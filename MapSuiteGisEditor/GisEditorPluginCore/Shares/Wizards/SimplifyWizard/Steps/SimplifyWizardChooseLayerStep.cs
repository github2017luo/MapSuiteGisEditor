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
namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [Serializable]
    public class SimplifyWizardChooseLayerStep : WizardStep<SimplifyWizardShareObject>
    {
        [NonSerialized]
        private SimplifyWizardChooseLayerUserControl content;

        public SimplifyWizardChooseLayerStep()
        {
            Title = GisEditor.LanguageManager.GetStringResource("GeneralStepOne");
            Header = GisEditor.LanguageManager.GetStringResource("ToolsSimplifyWizardStepOneHeader");
            Description = GisEditor.LanguageManager.GetStringResource("ToolsSimplifyWizardStepOneDescription");
            content = new SimplifyWizardChooseLayerUserControl();
            Content = content;
        }

        protected override void EnterCore(SimplifyWizardShareObject parameter)
        {
            content.DataContext = parameter;
        }

        protected override bool CanMoveToNextCore()
        {
            var entity = content.DataContext as SimplifyWizardShareObject;
            if (entity != null)
            {
                return entity.SelectedFeatureLayer != null;
            }

            return false;
        }
    }
}
