/**
 *     Copyright 2015-2016 GetSocial B.V.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using GetSocialSdk.Core;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace GetSocialSdk.Editor
{
    public static class GetSocialPostprocess
    {
        [PostProcessBuild(256)]
        public static void OnPostProcessBuild(BuildTarget target, string path)
        {
            if (!GetSocialSettings.IsAppIdValidated)
            {
                Debug.LogError(string.Format("GetSocial: provided App Id {0} was not validated. Please check if App Id is correct and you're connected to the internet.", GetSocialSettings.AppId));
            }
            
            if (BuildTarget.iOS == target)
            {
                GetSocialPostprocessIOS.UpdateXcodeProject(path);
            }

            if (BuildTarget.Android == target)
            {
                var androidManifestHelper = new AndroidManifestHelper();
                if (!androidManifestHelper.IsConfigurationCorrect())
                {
                    Debug.LogWarning("GetSocial: AndroidManifest.xml configuration is not complete. Summary: \n\n" + androidManifestHelper.ConfigurationSummary());
                }
                
                if (PlayerSettingsCompat.bundleIdentifier == "com.Company.ProductName")
                {
                    Debug.LogError("GetSocial: Please change the default Unity Bundle Identifier (com.Company.ProductName) to your package.");
                }
            }
        }
    }
}

