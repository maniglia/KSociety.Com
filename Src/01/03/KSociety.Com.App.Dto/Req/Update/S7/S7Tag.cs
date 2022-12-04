﻿using System;
using KSociety.Base.App.Shared;
using ProtoBuf;

namespace KSociety.Com.App.Dto.Req.Update.S7
{
    [ProtoContract]
    public class S7Tag : IRequest
    {
        [ProtoMember(1), CompatibilityLevel(CompatibilityLevel.Level200)]
        public Guid Id { get; set; }

        [ProtoMember(2)] public int AutomationTypeId { get; set; }

        [ProtoMember(3)] public string Name { get; set; }

        [ProtoMember(4), CompatibilityLevel(CompatibilityLevel.Level200)]
        public Guid ConnectionId { get; set; }

        [ProtoMember(5)] public bool Enable { get; set; }

        [ProtoMember(6)] public string InputOutput { get; set; }

        [ProtoMember(7)] public string AnalogDigitalSignal { get; set; }

        [ProtoMember(8)] public string MemoryAddress { get; set; }

        [ProtoMember(9)] public bool Invoke { get; private set; }

        [ProtoMember(10), CompatibilityLevel(CompatibilityLevel.Level200)]
        public Guid TagGroupId { get; set; }

        [ProtoMember(11)] public int? DataBlock { get; set; }

        [ProtoMember(12)] public int? Offset { get; set; }

        [ProtoMember(13)] public byte? BitOfByte { get; set; }

        [ProtoMember(14)] public int? WordLenId { get; set; }

        [ProtoMember(15)] public int? AreaId { get; set; }

        [ProtoMember(16)] public int? StringLength { get; set; }

        public S7Tag() { }

        public S7Tag
        (
            Guid id,
            int automationTypeId,
            string name,
            Guid connectionId,
            bool enable,
            string inputOutput,
            string analogDigitalSignal,
            string memoryAddress,
            bool invoke,
            Guid tagGroupId,
            int? dataBlock, int? offset,
            byte? bitOfByte,
            int? wordLenId, int? areaId,
            int? stringLength
        )
        {
            Id = id;
            AutomationTypeId = 1; //automationTypeId;
            Name = name;
            ConnectionId = connectionId;
            Enable = enable;
            InputOutput = inputOutput;
            AnalogDigitalSignal = analogDigitalSignal;
            MemoryAddress = memoryAddress;
            Invoke = invoke;
            TagGroupId = tagGroupId; //
            DataBlock = dataBlock;
            Offset = offset;
            BitOfByte = bitOfByte;
            WordLenId = wordLenId;
            AreaId = areaId;
            StringLength = stringLength;
        }
    }
}