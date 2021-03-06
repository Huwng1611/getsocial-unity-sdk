﻿using System;
using System.Collections;
using System.Collections.Generic;
using GetSocialSdk.MiniJSON;
using UnityEngine;

namespace GetSocialSdk.Editor
{
    public class RemoteConfigRequest
    {
        private const string ConfigRequestUrlPattern = "https://hades.getsocial.im/plugin/?app={0}";
        
        public string AppId { get; private set; }
        public bool IsInProgress { get; private set; }
        
        private EditorCoroutine _requestCoroutine;
        private Request _request;

        public static RemoteConfigRequest ForAppId(string appId)
        { 
            return new RemoteConfigRequest(appId);
        }
        
        private RemoteConfigRequest(string appId)
        {
            AppId = appId;
            IsInProgress = false;
        }

        public void Start(Action<RemoteConfig> onSuccess, Action<string> onFailure)
        {
            IsInProgress = true;
            _requestCoroutine = EditorCoroutine.Start(StartRequest(onSuccess, onFailure));
        }

        IEnumerator StartRequest(Action<RemoteConfig> onSuccess, Action<string> onFailure)
        {
            _request = RequestHelper.CreateDownloadRequest(string.Format(ConfigRequestUrlPattern, AppId));

            while (!_request.IsDone())
            {
                yield return null;
            }
            
            if(_request.GetErrorMessage() != null)
            {
                IsInProgress = false;
                onFailure(GetErrorMessage(_request.GetErrorMessage()));
            }
            else
            {
                try
                {
                    var remoteConfig = RemoteConfig.FromDict(
                        GSJson.Deserialize(_request.GetString()) as Dictionary<string, object>);

                    IsInProgress = false;
                    onSuccess(remoteConfig);                        
                }
                catch (Exception e)
                {
                    IsInProgress = false;
                    onFailure(e.Message);
                }
            }
        }

        public void Cancel()
        {
            if (_requestCoroutine != null)
            {
                _requestCoroutine.Stop();
            }
        }
        
        private string GetErrorMessage(string originalErrorMessage)
        {
            var errorMessage = originalErrorMessage;
            
            if (originalErrorMessage.Contains("400"))
            {
                errorMessage = "Invalid App Id.";
            } 
            else if (originalErrorMessage.Contains("500"))
            {
                errorMessage = "API failed to respond.";
            }
            return errorMessage;
        }
    }
}