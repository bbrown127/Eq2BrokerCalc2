
// <summary>Implements the non public setter class</summary>

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Eq2BrokerCalc2LibTests.Mocks
{
    /// <summary>   A non public setter. </summary>
    static class NonPublicSetter
    {
        /// <summary>   A TObject extension method that call non public setter. 
        ///             <para>
        ///                   URL: https://coding.abel.nu/2013/05/calling-non-public-setters/ 
        ///             </para>
        ///             <para>
        ///                   Example: new Order { OrderId = 983427 }.CallNonPublicSetter(o => o.StatusId, OrderStatus.Confirmed) 
        ///             </para>
        ///             </summary>
        /// <typeparam name="TObject">      Type of the object. </typeparam>
        /// <typeparam name="TProperty">    Type of the property. </typeparam>
        /// <param name="obj">      The obj to act on. </param>
        /// <param name="property"> The property. </param>
        /// <param name="value">    The value. </param>
        /// <returns>   A TObject. </returns>
        public static TObject CallNonPublicSetter<TObject, TProperty>(this TObject obj,
            Expression<Func<TObject, TProperty>> property, TProperty value)
        {
            var memberExp = (MemberExpression)property.Body;

            ((PropertyInfo)memberExp.Member).SetValue(obj, value);

            return obj;
        }
    }
}
