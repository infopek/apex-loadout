﻿using System;

namespace ApexLoadout.Weapons
{
	class CarePackage
	{
		static string[] weapons = { "Alti", "Scut", "Spitticus", "Krab" };

		public string GetWeapon(int index)
		{
			return weapons[index];
		}

		public CarePackage()
		{

		}
	}
}