﻿using System;
using KSociety.Base.App.Shared;
using KSociety.Base.InfraSub.Shared.Interface;
using ProtoBuf;

namespace KSociety.Com.App.Dto.Res.Copy.Logix
{
    [ProtoContract]
    public class LogixTag : IResponse, IKbIdObject
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
