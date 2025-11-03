using UnrealBuildTool;

public class Burden_ProjectEditorTarget : TargetRules
{
	public Burden_ProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Burden_Project");
	}
}
