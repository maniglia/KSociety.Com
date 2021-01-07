﻿using System;
using KSociety.Base.App.Shared;
using KSociety.Base.InfraSub.Shared.Interface;
using ProtoBuf;

namespace KSociety.Com.App.Dto.Res.Update.Logix
{
    [ProtoContract]
    public class LogixTag : IResponse, IIdObject
    {
        [ProtoMember(1), CompatibilityLevel(CompatibilityLevel.Level200)]
        public Guid Id { get; set; }

        public LogixTag() { }
        public LogixTag(Guid tagId)
        {
            Id = tagId;
        }
    }
}
