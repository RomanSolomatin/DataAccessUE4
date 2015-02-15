// Copyright 2014 afuzzyllama. All Rights Reserved.
using System.IO;

namespace UnrealBuildTool.Rules
{
	public class DataAccess : ModuleRules
	{
		public DataAccess(TargetInfo Target)
		{
			PrivateIncludePaths.AddRange(
				new string[] {
					"DataAccess/Private"
				}
            );

			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"Core",
                    "CoreUObject",
                    "SQLiteSupport"
				}
			);
		}
	}
}