using PurchaseMS.Domain.Models.States.Interfaces;
using System.Reflection;

namespace PurchaseMS.Data.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return a instance of purchase state classname
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public static IPurchaseState GetState(this string className)
        {
            Assembly assembly = Assembly.Load("PurchaseMS.Domain");
            string fullClassName = $"PurchaseMS.Domain.Models.States.{className}";
            Type type = assembly.GetType(fullClassName);
            IPurchaseState state = (IPurchaseState)Activator.CreateInstance(type);
            return state;
        }
    }
}