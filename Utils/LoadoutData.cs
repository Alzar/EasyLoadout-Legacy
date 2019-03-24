/*
 *	Developed By: Alzar
 *	Name: Easy Loadout - Legacy
 *	Dependent: Rage Plugin Hook & LSPDFR
 *	Released On: GitHub & LSPDFR
*/

namespace EasyLoadout.Utils {
	class LoadoutData {
		public string LoadoutNumber { get; set; }
		public string LoadoutConfig { get; set; }

		public LoadoutData(string num, string config) {
			LoadoutNumber = num;
			LoadoutConfig = config;
		}
	}
}
