/* unified/ban - Management and protection systems

© fabricators SRL, https://fabricators.ltd , https://unifiedban.solutions

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License with our addition
to Section 7 as published in unified/ban's the GitHub repository.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License and the
additional terms along with this program. 
If not, see <https://docs.fabricators.ltd/docs/licenses/unifiedban>.

For more information, see Licensing FAQ: 

https://docs.fabricators.ltd/docs/licenses/faq */

using System;
using Unifiedban.Next.Common.Telegram;

namespace Unifiedban.Next.Common
{
    /// <summary>
    /// Represents a base for all command pre-execution check attributes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class CheckPermissionBaseAttribute : Attribute
    {
        /// <summary>
        /// Asynchronously checks whether this command can be executed within given context.
        /// </summary>
        /// <returns>Whether the command can be executed in given context.</returns>
        public abstract bool ExecuteCheck(UserPrivileges userPrivileges);
    }
}