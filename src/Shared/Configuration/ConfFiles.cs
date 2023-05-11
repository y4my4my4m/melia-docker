﻿using Melia.Shared.Configuration.Files;

namespace Melia.Shared.Configuration
{
	/// <summary>
	/// Wrapper around all conf files for easy access.
	/// </summary>
	public class ConfFiles
	{
		/// <summary>
		/// commands.conf
		/// </summary>
		public CommandsConfFile Commands { get; } = new CommandsConfFile();

		/// <summary>
		/// database.conf
		/// </summary>
		public DatabaseConfFile Database { get; } = new DatabaseConfFile();

		/// <summary>
		/// localization.conf
		/// </summary>
		public LocalizationConf Localization { get; } = new LocalizationConf();

		/// <summary>
		/// login.conf
		/// </summary>
		public LoginConfFile Login { get; } = new LoginConfFile();

		/// <summary>
		/// web.conf
		/// </summary>
		public WebConfFile Web { get; } = new WebConfFile();

		/// <summary>
		/// world.conf
		/// </summary>
		public WorldConfFile World { get; } = new WorldConfFile();

		/// <summary>
		/// Loads all conf files.
		/// </summary>
		public virtual void Load()
		{
			this.Login.Load("system/conf/login.conf");

			this.Commands.Load("system/conf/commands.conf");
			this.Database.Load("system/conf/database.conf");
			this.Localization.Load("system/conf/localization.conf");
			this.Web.Load("system/conf/web.conf");
			this.World.Load("system/conf/world.conf");
		}
	}
}
