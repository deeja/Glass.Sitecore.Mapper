﻿/*
   Copyright 2011 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Data.Items;

namespace Glass.Sitecore.Mapper
{
    public interface ISitecoreService
    {
        IEnumerable<T> Query<T>(string query) where T: class;
        IEnumerable<T> Query<T>(string query, bool isLazy) where T : class;
        T QuerySingle<T>(string query) where T : class;

        T GetItem<T>(string path) where T : class;
        T GetItem<T>(Guid id) where T : class;
        
        void Save<T>(T item) where T : class;
        T Create<T>(object parent, string name) where T : class;
        
        void Delete<T>(T item) where T : class;
    }
}