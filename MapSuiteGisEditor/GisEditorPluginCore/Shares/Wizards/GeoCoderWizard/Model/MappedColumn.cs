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


using System.ComponentModel;
using System.Data;
using System;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    public class MappedColumn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string columnKey;
        [NonSerialized]
        private DataColumn selectedColumn;

        public string ColumnKey
        {
            get { return columnKey; }
            set
            {
                columnKey = value;
                OnPropertyChanged("ColumnKey");
            }
        }

        public DataColumn SelectedColumn
        {
            get { return selectedColumn; }
            set
            {
                selectedColumn = value;
                OnPropertyChanged("SelectedColumn");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
