using System.Collections.Generic;
using UnityEngine;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace GetSocialSdk.Core
{
    public class GetSocialSettings : ScriptableObject
    {
        public const string UnityDemoAppAppId = "LuDPp7W0J4";
        
        const string SettingsAssetName = "GetSocialSettings";
        const string SettingsAssetPath = "Assets/GetSocial/Resources/";

        static GetSocialSettings _instance;

        [SerializeField]
        string _appId = string.Empty;

        [SerializeField]
        bool _isAutoRegisrationForPushesEnabled = true;

        [SerializeField]
        bool _useGetSocialUi = true;

        [SerializeField]
        string _getSocialDefaultConfigurationFilePath = string.Empty;

        [SerializeField] 
        string _iosPushEnvironment = string.Empty;

        [SerializeField] 
        List<string> _deeplinkingDomains = new List<string>();

        [SerializeField] 
        bool _isAndroidEnabled = false;
        
        [SerializeField] 
        bool _isIosEnabled = false;

        [SerializeField] 
        bool _isIosPushEnabled = false;
        
        [SerializeField] 
        bool _isAndroidPushEnabled = false;
        
        [SerializeField] 
        bool _isAppIdValid = true;


        #region initialization

        public static GetSocialSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Resources.Load(SettingsAssetName) as GetSocialSettings;
                    if (_instance == null)
                    {
                        _instance = CreateInstance<GetSocialSettings>();
                        AppId = UnityDemoAppAppId;
                        SaveAsset(SettingsAssetPath, SettingsAssetName);
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region public methods

        public static string AppId
        {
            get { return Instance._appId; }
            set
            {
                Instance._appId = value;
                MarkAssetDirty();
            }
        }

        public static bool UseGetSocialUi
        {
            get { return Instance._useGetSocialUi; }
            set
            {
                Instance._useGetSocialUi = value;
                MarkAssetDirty();
            }
        }

        public static bool IsAutoRegisrationForPushesEnabled
        {
            get { return Instance._isAutoRegisrationForPushesEnabled; }
            set
            {
                Instance._isAutoRegisrationForPushesEnabled = value;
                MarkAssetDirty();
            }
        }

        public static string IosPushEnvironment
        {
            get { return Instance._iosPushEnvironment; }
            set
            {
                Instance._iosPushEnvironment= value;
                MarkAssetDirty();
            }
        }
        
        public static List<string> DeeplinkingDomains
        {
            get { return Instance._deeplinkingDomains; }
            set
            {
                Instance._deeplinkingDomains = value;
                MarkAssetDirty();
            }
        }

        public static bool IsAdroidEnabled
        {
            get { return Instance._isAndroidEnabled; }
            set
            {
                Instance._isAndroidEnabled = value;
                MarkAssetDirty();
            }
        }
        
        public static bool IsIosEnabled
        {
            get { return Instance._isIosEnabled; }
            set
            {
                Instance._isIosEnabled = value;
                MarkAssetDirty();
            }
        }
        
        public static string UiConfigurationDefaultFilePath
        {
            get { return Instance._getSocialDefaultConfigurationFilePath; }
            set
            {
                Instance._getSocialDefaultConfigurationFilePath = value;
                MarkAssetDirty();
            }
        }
        
        public static bool IsIosPushEnabled
        {
            get { return Instance._isIosPushEnabled; }
            set
            {
                Instance._isIosPushEnabled = value;
                MarkAssetDirty();
            }
        }
        
        public static bool IsAndroidPushEnabled
        {
            get { return Instance._isAndroidPushEnabled; }
            set
            {
                Instance._isAndroidPushEnabled = value;
                MarkAssetDirty();
            }
        }
        
        public static bool IsAppIdValidated
        {
            get { return Instance._isAppIdValid; }
            set
            {
                Instance._isAppIdValid = value;
                MarkAssetDirty();
            }
        }

        #endregion

        #region private methods

        static void SaveAsset(string directory, string name)
        {
#if UNITY_EDITOR
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            AssetDatabase.CreateAsset(Instance, directory + name + ".asset");
            AssetDatabase.Refresh();
#endif
        }

        static void MarkAssetDirty()
        {
#if UNITY_EDITOR
            EditorUtility.SetDirty(Instance);
#endif
        }

        #endregion
    }
}