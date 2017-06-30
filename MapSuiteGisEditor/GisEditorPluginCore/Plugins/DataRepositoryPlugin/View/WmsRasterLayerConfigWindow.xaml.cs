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


using System.Windows;
using GalaSoft.MvvmLight.Messaging;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    /// <summary>
    /// Interaction logic for AddWmsDialog.xaml
    /// </summary>
    public partial class WmsRasterLayerConfigWindow : Window
    {
        private WmsRasterLayerConfigViewModel viewModel;

        public WmsRasterLayerConfigWindow(bool getWmsSourceFromDataRepsitory = false)
        {
            InitializeComponent();
            viewModel = new WmsRasterLayerConfigViewModel(getWmsSourceFromDataRepsitory);
            DataContext = viewModel;

            Messenger.Default.Register<DialogMessage>(this, viewModel, (message) =>
            {
                System.Windows.Forms.MessageBox.Show(message.Content, message.Caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            });

            Messenger.Default.Register<bool>(this, viewModel, (message) =>
            {
                DialogResult = message;
            });

            Closing += (s, e) =>
            {
                Messenger.Default.Unregister(this);
            };
        }

        public WmsRasterLayerConfigViewModel ViewModel { get { return viewModel; } }
    }
}
