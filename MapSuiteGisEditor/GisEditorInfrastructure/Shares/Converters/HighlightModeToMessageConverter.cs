/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/


using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Data;
using ThinkGeo.MapSuite.WpfDesktop.Extension;

namespace ThinkGeo.MapSuite.GisEditor
{
    [Serializable]
    [Obfuscation]
    internal class HighlightModeToMessageConverter : IValueConverter
    {
        private static readonly string createNew = GisEditor.LanguageManager.GetStringResource("FindFeaturesWindowAdvancedQueryCreateNewSelection");
        private static readonly string addToCurrent = GisEditor.LanguageManager.GetStringResource("FindFeaturesWindowAdvancedQueryAddResult");
        private static readonly string searchInCurrent = GisEditor.LanguageManager.GetStringResource("FindFeaturesWindowAdvancedQuerySearchOnly").ToString();

        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            if (value is AddHighlightFeaturesMode)
            {
                AddHighlightFeaturesMode mode = (AddHighlightFeaturesMode)value;
                switch (mode)
                {
                    case AddHighlightFeaturesMode.Add:
                        return addToCurrent;
                    case AddHighlightFeaturesMode.FilterExisting:
                        return searchInCurrent;
                    case AddHighlightFeaturesMode.Reset:
                    default:
                        return createNew;
                }
            }
            else return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}