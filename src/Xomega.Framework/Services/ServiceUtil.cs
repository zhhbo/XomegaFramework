﻿// Copyright (c) 2017 Xomega.Net. All rights reserved.

using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Reflection;

namespace Xomega.Framework.Services
{
    /// <summary>
    /// Static utility methods for working with services
    /// </summary>
    public static class ServiceUtil
    {
        #region Auto-mapping

        /// <summary>
        /// Copies the values of all properties from the source object to the
        /// corresponding properties in the destination object.
        /// </summary>
        /// <param name="src">The source object.</param>
        /// <param name="dest">The destination object.</param>
        public static void CopyProperties(object src, object dest)
        {
            if (src == null || dest == null) return;
            CopyProperties(src, dest, src.GetType().GetProperties());
        }

        /// <summary>
        /// Copies the values of the specified properties from the source object
        /// to the corresponding properties in the destination object.
        /// </summary>
        /// <param name="src">The source object.</param>
        /// <param name="dest">The destination object.</param>
        /// <param name="props">The list of fields to copy.</param>
        public static void CopyProperties(object src, object dest, IEnumerable<PropertyInfo> props)
        {
            if (src == null || dest == null) return;
            foreach (PropertyInfo srcProp in props)
            {
                object val = srcProp.GetValue(src, null);
                PropertyInfo destProp = dest.GetType().GetProperty(srcProp.Name, srcProp.PropertyType);
                if (destProp != null && !destProp.GetCustomAttributes(typeof(EdmScalarPropertyAttribute), false)
                        .Cast<EdmScalarPropertyAttribute>().Any(a => a.EntityKeyProperty))
                    destProp.SetValue(dest, val, null);
            }
        }

        #endregion
    }
}
