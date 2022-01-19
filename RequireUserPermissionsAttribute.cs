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

namespace Unifiedban.Next.Common.Telegram
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class RequireUserPermissionsAttribute : CheckPermissionBaseAttribute
    {
        public Enums.TelegramPermissions Permission;

        public RequireUserPermissionsAttribute(Enums.TelegramPermissions permission)
        {
            Permission = permission;
        }

        public override bool ExecuteCheck(UserPrivileges userPrivileges)
        {
            return Permission switch
            {
                Enums.TelegramPermissions.CanManageChat => userPrivileges.CanManageChat,
                Enums.TelegramPermissions.CanPostMessages => userPrivileges.CanPostMessages,
                Enums.TelegramPermissions.CanEditMessages => userPrivileges.CanEditMessages,
                Enums.TelegramPermissions.CanDeleteMessages => userPrivileges.CanDeleteMessages,
                Enums.TelegramPermissions.CanManageVoiceChats => userPrivileges.CanManageVoiceChats,
                Enums.TelegramPermissions.CanRestrictMembers => userPrivileges.CanRestrictMembers,
                Enums.TelegramPermissions.CanPromoteMembers => userPrivileges.CanPromoteMembers,
                Enums.TelegramPermissions.CanChangeInfo => userPrivileges.CanChangeInfo,
                Enums.TelegramPermissions.CanInviteUsers => userPrivileges.CanInviteUsers,
                Enums.TelegramPermissions.CanPinMessages => userPrivileges.CanPinMessages,
                _ => false
            };
        }
    }
}