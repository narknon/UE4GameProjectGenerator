// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjectGeneratorTarget : TargetRules
{
	public ProjectGeneratorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		BuildEnvironment = TargetBuildEnvironment.Shared;
		ExtraModuleNames.AddRange(new[] {"ProjectGenerator"});
	}
}