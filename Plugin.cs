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
    public abstract class Plugin : PluginBase
    {
        protected Plugin(int priority) : base(priority)
        {
        }

        protected Plugin(int priority, string @group = "") : base(priority, @group)
        {
        }

        protected Plugin(int priority, string @group = "",
            ResultValueAttribute.ResultType resultType = ResultValueAttribute.ResultType.Mandatory) : base(priority,
            @group, resultType)
        {
        }

        protected Plugin(int priority, string @group = "",
            ResultValueAttribute.ResultType resultType = ResultValueAttribute.ResultType.Mandatory,
            ResultValueAttribute.ResultAction resultAction = ResultValueAttribute.ResultAction.Delete) : base(priority,
            @group, resultType, resultAction)
        {
        }

        public abstract bool Execute<C,T>(QueueMessage<C, UserPrivileges, UserPrivileges, T> message);
    }
}