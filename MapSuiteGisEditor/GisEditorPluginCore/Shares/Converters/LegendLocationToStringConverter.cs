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
using System.Windows.Data;
using ThinkGeo.MapSuite.Layers;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    public class LegendLocationToStringConverter : ValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is AdornmentLocation)
            {
                switch ((AdornmentLocation)value)
                {
                    case AdornmentLocation.UseOffsets:
                        return "Fixed Location";
                    case AdornmentLocation.Center:
                        return "Center";
                    case AdornmentLocation.CenterLeft:
                    case AdornmentLocation.CenterRight:
                    case AdornmentLocation.LowerCenter:
                    case AdornmentLocation.LowerLeft:
                    case AdornmentLocation.LowerRight:
                    case AdornmentLocation.UpperCenter:
                    case AdornmentLocation.UpperLeft:
                    case AdornmentLocation.UpperRight:
                        return LegendHelper.AddSpaceToLastUpperChar(value.ToString());
                    default: return Binding.DoNothing;
                }
            }
            else
            {
                return Binding.DoNothing;
            }
        }
    }
}