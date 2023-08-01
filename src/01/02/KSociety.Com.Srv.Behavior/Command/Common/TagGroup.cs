﻿using Autofac;
using KSociety.Base.Srv.Shared.Interface;
using KSociety.Com.Srv.Contract.Command.Common;
using Microsoft.Extensions.Logging;

namespace KSociety.Com.Srv.Behavior.Command.Common;
public class TagGroup : KSociety.Base.Srv.Behavior.CommandImportExport<
    KSociety.Com.App.Dto.Req.Add.Common.TagGroup, KSociety.Com.App.Dto.Res.Add.Common.TagGroup,
    KSociety.Com.App.Dto.Req.Update.Common.TagGroup, KSociety.Com.App.Dto.Res.Update.Common.TagGroup,
    KSociety.Com.App.Dto.Req.Copy.Common.TagGroup, KSociety.Com.App.Dto.Res.Copy.Common.TagGroup,
    KSociety.Com.App.Dto.Req.ModifyField.Common.TagGroup, KSociety.Com.App.Dto.Res.ModifyField.Common.TagGroup,
    KSociety.Com.App.Dto.Req.Remove.Common.TagGroup, KSociety.Com.App.Dto.Res.Remove.Common.TagGroup,
    KSociety.Com.App.Dto.Req.Import.Common.TagGroup, KSociety.Com.App.Dto.Res.Import.Common.TagGroup,
    KSociety.Com.App.Dto.Req.Export.Common.TagGroup, KSociety.Com.App.Dto.Res.Export.Common.TagGroup>, ITagGroup
{
    public TagGroup(
        ILoggerFactory loggerFactory,
        IComponentContext componentContext,
        ICommandHandler commandHandler
    ) : base(loggerFactory, componentContext, commandHandler)
    {

    }
}
