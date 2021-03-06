using HMCon;
using HMCon.Export;
using HMCon.Formats;
using HMCon.Import;
using HMCon.Util;
using System;
using System.Collections.Generic;

namespace HMConMC {

	[ModuleInfo("MinecraftModule", "Minecraft World Generator / Importer v0.9.6")]
	public class HMConMCModule : HMConModule {

		public override HMConCommandHandler GetCommandHandler() {
			return new MCCommandHandler();
		}

		public override void RegisterFormats(List<FileFormat> registry)
		{
			registry.Add(new MCRegionFormat());
			registry.Add(new MCBetaRegionFormat());
			registry.Add(new MCRawRegionFormat());
			registry.Add(new MCWorldFormat());
		}
	}
}
