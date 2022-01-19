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

namespace Unifiedban.Next.Common.Telegram
{
    public struct ActionRequest
    {
        public enum Actions
        {
            LeaveChat = -1,
            SendText = 0,
            SendImage = 1,
            SendVideo = 2,
            SendGif = 3,
            SendAudio = 4,
            DeleteMessage = 5,
            EditMessage = 6,
            EditMessageCaption = 7,
            KickUser = 8,
            BanUser = 9,
            ApplyUserPermissions = 10,
            ApplyChatPermissions = 11,
            ExportChatInvite = 12,
            CreateChatInvite = 13,
            RevokeChatInvite = 14,
            ApproveChatJoinRequest = 15,
            DeclineChatJoinRequest = 16,
            PinMessage = 17,
            UnpinMessage = 18,
            UnpinAllMessages = 19
        }
    
        public Actions Action { get; set; }
        public ActionData Message { get; set; }
    }
}