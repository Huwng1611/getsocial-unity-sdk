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

using UnityEngine;

public static class GSStyles
{
    public static readonly GUIStyle BigLabelText;
    public static readonly GUIStyle NormalLabelText;
    public static readonly GUIStyle NormalLabelTextRed;

    public static readonly GUIStyle TextField;
    public static readonly GUIStyle Toggle;
    public static readonly GUIStyle Button;
    public static readonly GUIStyle ConsoleBg;
    public static readonly GUIStyle ConsoleText;

    static GSStyles()
    {
        BigLabelText = new GUIStyle
        {
            margin = new RectOffset(4, 4, 4, 4),
            fontSize = 65,
            alignment = TextAnchor.MiddleCenter,
            wordWrap = true,
            richText = false
        };

        NormalLabelText = new GUIStyle
        {
            margin = new RectOffset(4, 4, 4, 4),
            fontSize = 28,
            alignment = TextAnchor.UpperLeft,
            wordWrap = true,
            richText = false,
            stretchWidth = true
        };

        NormalLabelTextRed = new GUIStyle(NormalLabelText) {normal = {textColor = Color.red}};

        TextField = new GUIStyle(GUI.skin.textField)
        {
            name = "textfield",
            fontSize = 28,
            fixedHeight = 65,
            stretchWidth = true,
            wordWrap = true,
            richText = false
        };

        Toggle = new GUIStyle(GUI.skin.toggle)
        {
            name = "toggle",
            margin = new RectOffset(10, 4, -20, 4),
            padding = new RectOffset(80, 0, 80, 0),
            border = new RectOffset(0, 0, 0, 0),
            fontSize = 28,
            clipping = TextClipping.Overflow,
            imagePosition = ImagePosition.ImageOnly,
            stretchWidth = false,
            stretchHeight = false,
            alignment = TextAnchor.MiddleLeft
        };

        Button = new GUIStyle(GUI.skin.button)
        {
            fontSize = 28,
            fixedHeight = 72,
            stretchWidth = true,
            richText = false,
            alignment = TextAnchor.MiddleCenter
        };

        ConsoleBg = new GUIStyle
        {
            stretchWidth = true,
            fixedWidth = 0,
            fixedHeight = 0,
            normal = {background = (Texture2D) Resources.Load("GUI/black-square")}
        };

        ConsoleText = new GUIStyle
        {
            fontSize = 26,
            wordWrap = true,
            stretchWidth = true,
            richText = true,
            padding = new RectOffset(8, 8, 0, 0),
            normal = {textColor = Color.green},
            font = (Font) Resources.Load("Fonts/courier-new")
        };
    }
}