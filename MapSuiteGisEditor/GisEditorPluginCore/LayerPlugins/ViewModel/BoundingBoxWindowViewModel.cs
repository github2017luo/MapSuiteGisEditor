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


using GalaSoft.MvvmLight;

namespace ThinkGeo.MapSuite.GisEditor.Plugins
{
    [System.Serializable]
    public class BoundingBoxWindowViewModel : ViewModelBase
    {
        private double left, right, top, bottom;
        private int width, height;

        public BoundingBoxWindowViewModel()
            : base()
        {
            Left = -180d;
            Right = 180d;
            Top = 90d;
            Bottom = -90d;
            Width = 45;
            Height = 45;
        }

        public double Bottom
        {
            get { return bottom; }
            set
            {
                bottom = value;
                RaisePropertyChanged(()=>Bottom);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public double Top
        {
            get { return top; }
            set
            {
                top = value;
                RaisePropertyChanged(()=>Top);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public double Right
        {
            get { return right; }
            set
            {
                right = value;
                RaisePropertyChanged(()=>Right);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public double Left
        {
            get { return left; }
            set
            {
                left = value;
                RaisePropertyChanged(()=>Left);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                RaisePropertyChanged(()=>Height);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                RaisePropertyChanged(()=>Width);
                RaisePropertyChanged(()=>IsValid);
            }
        }

        public bool IsValid
        {
            get
            {
                return Left < Right && Top > Bottom && Width > 0 && Height > 0;
            }
        }
    }
}