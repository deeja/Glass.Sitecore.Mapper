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
using System.Linq.Expressions;

namespace Glass.Sitecore.Mapper.Configuration.Fluent
{
    /// <summary>
    /// Indicates that the property should pull from the item links list.
    /// </summary>
    public class SitecoreLinked<T> : AbstractSitecoreAttributeBuilder<T>
    {
        Configuration.Attributes.SitecoreLinkedAttribute _att;

        public SitecoreLinked(Expression<Func<T, object>> ex)
            : base(ex)
        {
            _att = new Configuration.Attributes.SitecoreLinkedAttribute(); 
        }

        internal override Attributes.AbstractSitecorePropertyAttribute Attribute
        {
            get { return _att; }
        }
        /// <summary>
        /// Indicates if linked items should not be  loaded lazily. Default value is true. If set linked items will be loaded when the contain object is created.
        /// </summary>
        public SitecoreLinked<T> IsNotLazy()
        {
            _att.IsLazy = false;
            return this;
        }
        /// <summary>
        /// Indicates the type should be inferred from the item template
        /// </summary>
        public SitecoreLinked<T> InferType()
        {
            _att.InferType = false;
            return this;
        }
        /// <summary>
        /// Indicate weather All, References or Referred should be loaded
        /// </summary>
        public SitecoreLinked<T> Option(SitecoreLinkedOptions option)
        {
            _att.Option = option;
            return this;
        }

    }
}
