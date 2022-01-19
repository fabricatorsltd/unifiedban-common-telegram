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
    [Serializable]
    public struct UserPrivileges
    {
        public long ChatId { get; set; }
        public long UserId { get; set; }
        public bool CanManageChat { get; set; }
        public bool CanPostMessages { get; set; }
        public bool CanEditMessages { get; set; }
        public bool CanDeleteMessages { get; set; }
        public bool CanManageVoiceChats { get; set; }
        public bool CanRestrictMembers { get; set; }
        public bool CanPromoteMembers { get; set; }
        public bool CanChangeInfo { get; set; }
        public bool CanInviteUsers { get; set; }
        public bool CanPinMessages { get; set; }
    }
}