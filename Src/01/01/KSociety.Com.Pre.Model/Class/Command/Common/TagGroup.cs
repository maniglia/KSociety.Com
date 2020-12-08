﻿using System.Threading;
using System.Threading.Tasks;
using KSociety.Com.Pre.Model.Interface.Command.Common;
using KSociety.Com.Srv.Agent;
using Microsoft.Extensions.Logging;

namespace KSociety.Com.Pre.Model.Class.Command.Common
{
    public class TagGroup : ITagGroup
    {
        private readonly Srv.Agent.Command.Common.TagGroup _tagGroup;

        public TagGroup(IComAgentConfiguration agentConfiguration, ILoggerFactory loggerFactory)
        {
            _tagGroup = new Srv.Agent.Command.Common.TagGroup(agentConfiguration, loggerFactory);
        }

        public bool Remove(App.Dto.Req.Remove.Common.TagGroup removeItem, CancellationToken cancellationToken = default)
        {
            return _tagGroup.Remove(removeItem);
        }

        public async ValueTask<bool> RemoveAsync(App.Dto.Req.Remove.Common.TagGroup removeCommonTagGroup, CancellationToken cancellationToken = default)
        {
            return await _tagGroup.RemoveAsync(removeCommonTagGroup);
        }

        public App.Dto.Res.Add.Common.TagGroup Add(App.Dto.Req.Add.Common.TagGroup addCommonTagGroup, CancellationToken cancellationToken = default)
        {
            return _tagGroup.Add(addCommonTagGroup);
        }

        public App.Dto.Res.Update.Common.TagGroup Update(App.Dto.Req.Update.Common.TagGroup updateItem, CancellationToken cancellationToken = default)
        {
            return _tagGroup.Update(updateItem);
        }

        public async ValueTask<App.Dto.Res.Update.Common.TagGroup> UpdateAsync(App.Dto.Req.Update.Common.TagGroup updateCommonTagGroup, CancellationToken cancellationToken = default)
        {
            return await _tagGroup.UpdateAsync(updateCommonTagGroup);
        }

        public App.Dto.Res.Copy.Common.TagGroup Copy(App.Dto.Req.Copy.Common.TagGroup copyItem, CancellationToken cancellationToken = default)
        {
            return _tagGroup.Copy(copyItem);
        }

        public async ValueTask<App.Dto.Res.Add.Common.TagGroup> AddAsync(App.Dto.Req.Add.Common.TagGroup addCommonTagGroup, CancellationToken cancellationToken = default)
        {
            return await _tagGroup.AddAsync(addCommonTagGroup);
        }

        public async ValueTask<App.Dto.Res.Copy.Common.TagGroup> CopyAsync(App.Dto.Req.Copy.Common.TagGroup copyCommonTagGroup, CancellationToken cancellationToken = default)
        {
            return await _tagGroup.CopyAsync(copyCommonTagGroup);
        }

        public bool ModifyField(App.Dto.Req.ModifyField.Common.TagGroup modifyCommonTagGroupField, CancellationToken cancellationToken = default)
        {
            return _tagGroup.ModifyField(modifyCommonTagGroupField);
        }

        public async ValueTask<bool> ModifyFieldAsync(App.Dto.Req.ModifyField.Common.TagGroup modifyCommonTagGroupField, CancellationToken cancellationToken = default)
        {
            return await _tagGroup.ModifyFieldAsync(modifyCommonTagGroupField);
        }
    }
}
