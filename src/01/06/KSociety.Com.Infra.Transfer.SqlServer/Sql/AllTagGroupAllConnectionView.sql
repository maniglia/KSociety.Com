﻿CREATE VIEW [AllTagGroupAllConnectionView]
	AS SELECT 
	[AllTagGroupConnectionView].[Id],
	[TagName],
	[AllConnectionView].[Id] AS [ConnectionId],
	[AllTagGroupConnectionView].[ConnectionName],
	[AllTagGroupConnectionView].[AutomationTypeId],
	[AllTagGroupConnectionView].[AutomationName],
	[AllTagGroupConnectionView].[Ip],
	[AllTagGroupConnectionView].[WriteEnable],
	[InputOutput], 
	[AnalogDigitalSignal],
	[MemoryAddress],
	[Invoke],
	[TagGroupId],
	[TagGroupName],
	[Clock],
	[Update],
	[DataBlock],	
	[Offset],
	[BitOfByte],
	[WordLenId],
	[WordLenName],
	[AreaId],
	[AreaName],
	[StringLength],
	[AllConnectionView].[ConnectionTypeId],
	[AllConnectionView].[ConnectionTypeName],
	[AllConnectionView].[CpuTypeId],
	[AllConnectionView].[CpuTypeName],
	[AllConnectionView].[Rack],
	[AllConnectionView].[Slot],
	[AllConnectionView].[Path]
	FROM [AllTagGroupConnectionView]
	INNER JOIN [AllConnectionView] ON [AllConnectionView].[Id] = [AllTagGroupConnectionView].[ConnectionId]	
