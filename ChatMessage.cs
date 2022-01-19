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
using System.Collections.Generic;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Unifiedban.Next.Common.Telegram
{
    public sealed class ActionData
    {
        public enum PostSentActions
        {
            None = 0,
            Pin = 1,
            Destroy = 2
        }
        
#region " Base "
        public Chat Chat { get; set; }
        public string Text { get; set; }
        public ParseMode ParseMode { get; set; } = ParseMode.Markdown;
        public bool DisableWebPagePreview { get; set; }
        public bool DisableNotification { get; set; }
        public Chat FromChat { get; set; }
        public int? ReferenceMessageId { get; set; }
        public bool AllowSendingWithoutReply { get; set; }
        public IEnumerable<MessageEntity>? Entities { get; set; }
#endregion

#region " Media #
        public IReplyMarkup? ReplyMarkup { get; set; }
        public InputOnlineFile? InputFile { get; set; }
        public int? Duration { get; set; }
        public int? Performer { get; set; }
        public int? Title { get; set; }
        public InputMedia? Thumbnail { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool? SupportsStreaming { get; set; }
#endregion

#region " User Management "

        public long? ReferenceUserId { get; set; }
        public DateTime? BanExpiration { get; set; }
        public bool RevokeMessages { get; set; }
        public ChatPermissions? ChatPermissions { get; set; }
        public string? InviteName { get; set; }
        public DateTime? InviteExpiration { get; set; }
        public int? InviteMembersLimit { get; set; }
        public bool? InviteCreatesJoinRequest { get; set; }
        public string? InviteLink { get; set; }
        
#endregion

#region " Internal Management "
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public PostSentActions PostSentAction { get; set; } = PostSentActions.None;
        public ushort AutoDestroyTimeInSeconds { get; set; } = 10;
        public long ControlChatId { get; set; }
#endregion

        public ActionData(){}
        public ActionData(Chat chat)
        {
            Chat = chat;
        }
        public ActionData(
            Chat chat,
            string text)
        {
            Chat = chat;
            Text = text;
        }
    }
}