using UnrealBuildTool;

public class Burden_ProjectServerTarget : TargetRules
{
	public Burden_ProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Burden_Project");
	}
}
