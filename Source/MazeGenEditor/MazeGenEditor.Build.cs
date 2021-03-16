// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MazeGenEditor : ModuleRules
{
	public MazeGenEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
        
        PublicDependencyModuleNames.AddRange(new string[] { "UE4_BP_MazeGen_MIT" });

		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore", "ContentBrowser", "AssetRegistry" });

        PublicIncludePaths.AddRange(
            new string[]
            {
                "MazeGenEditor/Public"
            });

        PrivateIncludePaths.AddRange(
            new string[]
            {
                "MazeGenEditor/Private"
            });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
