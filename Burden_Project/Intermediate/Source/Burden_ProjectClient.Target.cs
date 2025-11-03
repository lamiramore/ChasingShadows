using UnrealBuildTool;

public class Burden_ProjectClientTarget : TargetRules
{
	public Burden_ProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Burden_Project");
	}
}
