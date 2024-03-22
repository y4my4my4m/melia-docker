//--- Melia Script -----------------------------------------------------------
// Verkti Square Spawns
//--- Description -----------------------------------------------------------
// Sets up monster spawners for 'f_flash_59'.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Game.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash59MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_flash_59", MonsterId.Jukopus_Gray, Properties("MHP", 272618, "MINPATK", 4007, "MAXPATK", 4826, "MINMATK", 4007, "MAXMATK", 4826, "DEF", 16229, "MDEF", 16229));
		AddPropertyOverrides("f_flash_59", MonsterId.Rambear, Properties("MHP", 272936, "MINPATK", 4011, "MAXPATK", 4831, "MINMATK", 4011, "MAXMATK", 4831, "DEF", 16288, "MDEF", 16288));
		AddPropertyOverrides("f_flash_59", MonsterId.Goblin2_Wand1, Properties("MHP", 273518, "MINPATK", 4019, "MAXPATK", 4840, "MINMATK", 4019, "MAXMATK", 4840, "DEF", 16396, "MDEF", 16396));

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_59.Id1", MonsterId.Jukopus_Gray, min: 23, max: 30);
		AddSpawner("f_flash_59.Id2", MonsterId.Rambear, min: 12, max: 15);
		AddSpawner("f_flash_59.Id3", MonsterId.Rootcrystal_01, min: 12, max: 15, respawn: TimeSpan.FromMilliseconds(20000));
		AddSpawner("f_flash_59.Id4", MonsterId.Rambear, min: 9, max: 12);
		AddSpawner("f_flash_59.Id5", MonsterId.Goblin2_Wand1, min: 8, max: 10);
		AddSpawner("f_flash_59.Id6", MonsterId.Jukopus_Gray, min: 57, max: 75);
		AddSpawner("f_flash_59.Id7", MonsterId.Rambear, min: 4, max: 5);
		AddSpawner("f_flash_59.Id8", MonsterId.Jukopus_Gray, min: 6, max: 8);

		// Monster Spawn Points -----------------------------

		// 'Jukopus_Gray' GenType 7 Spawn Points
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(86, 207, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(612, -182, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(760, -289, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(823, -87, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-99, -338, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-327, -342, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(712, 100, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(82, -313, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(919, 538, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(965, 765, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1042, 640, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1133, 483, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1151, 668, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(317, 231, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(131, 450, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(249, 457, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1107, -228, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1090, -29, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1183, 100, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1269, -240, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1344, -82, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1195, -78, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(575, -614, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(791, -595, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-797, 382, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-913, 481, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-827, -1201, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-999, -980, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-643, -1039, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-808, -849, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-815, -1011, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-1459, -380, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-1087, -347, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-1291, -374, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(921, 654, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1066, 754, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1166, 560, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1004, 502, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(814, 565, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(1221, 502, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(853, 451, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(872, 770, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-950, -1140, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-955, -1022, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-910, -917, 30));
		AddSpawnPoint("f_flash_59.Id1", "f_flash_59", Rectangle(-765, -946, 30));

		// 'Rambear' GenType 8 Spawn Points
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1459, -416, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1716, -351, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1392, -270, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1147, -415, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1316, -401, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1584, -319, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-1103, -269, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-907, -1062, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-908, -892, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-721, -1096, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-664, -868, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-789, -985, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-910, -1213, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-686, -1216, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-498, -345, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-381, -265, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-381, -366, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-172, -298, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-19, -412, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-4, -300, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(929, 535, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(1113, 768, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(1168, 578, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-904, 370, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-686, 441, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-721, 298, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-884, 481, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-777, 374, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-76, 141, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(10, 142, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(52, 81, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(74, 48, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(1, 40, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-56, 65, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-76, 102, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(49, 141, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(92, 121, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(48, 114, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(139, 124, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(210, 139, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(223, 175, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(269, 142, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(336, 126, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(347, 175, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(385, 221, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(298, 205, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(260, 231, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(192, 225, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(254, 202, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(157, 175, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(126, 217, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(96, 169, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(21, 184, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-37, 184, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-36, 132, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-89, 194, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(0, 255, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-79, 253, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-123, 328, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-136, 385, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-19, 363, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-50, 456, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(90, 502, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(104, 426, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(120, 551, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(171, 531, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(251, 509, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(140, 501, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-57, 534, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(4, 460, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-103, 415, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-135, 518, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-95, 574, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(65, 576, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-59, 361, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-18, 239, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(138, 376, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(271, 396, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-716, 349, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-671, 341, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-713, 406, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-792, 453, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-780, 326, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-823, 336, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-858, 337, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-918, 310, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-962, 307, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-989, 358, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-973, 394, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-931, 441, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-854, 425, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-854, 382, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-835, 470, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-754, 490, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-755, 417, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-906, 417, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-959, 365, 30));
		AddSpawnPoint("f_flash_59.Id2", "f_flash_59", Rectangle(-647, 394, 30));

		// 'Rootcrystal_01' GenType 28 Spawn Points
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-39, 509, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(1037, 746, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(1157, 555, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(875, 492, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(568, -69, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(621, -255, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(413, -266, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(727, 92, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(1224, -58, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(1162, -157, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(763, -581, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(540, -574, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-109, -264, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-387, -351, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-909, -1064, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-744, -957, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-1457, -338, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-1147, -322, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-796, 352, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-712, 441, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-840, -31, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(-436, 427, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(360, 266, 100));
		AddSpawnPoint("f_flash_59.Id3", "f_flash_59", Rectangle(299, 492, 100));

		// 'Rambear' GenType 30 Spawn Points
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(-13, 92, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(-54, 299, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(295, 169, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(308, 504, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(343, 348, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(172, 463, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(24, 509, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(171, 310, 30));
		AddSpawnPoint("f_flash_59.Id4", "f_flash_59", Rectangle(55, 216, 30));

		// 'Goblin2_Wand1' GenType 31 Spawn Points
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(642, -250, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(751, -73, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(603, -674, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(832, -592, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1224, 94, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1179, -201, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-792, -1166, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-904, -963, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(508, -507, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1047, -49, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1332, -62, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(723, 102, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(969, 600, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1130, 645, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(982, 767, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(864, 539, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(1101, 524, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(888, 706, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-1346, -381, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-722, -356, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-677, -196, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-272, -348, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-35, -76, 25));
		AddSpawnPoint("f_flash_59.Id5", "f_flash_59", Rectangle(-2, -314, 25));

		// 'Jukopus_Gray' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-719, -1173, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-812, -1179, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-889, -1071, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-960, -935, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-854, -896, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-707, -910, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-633, -900, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-627, -1020, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-732, -1007, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-813, -1035, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1322, -186, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1358, -205, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1303, -287, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1326, -239, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1215, -275, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1144, -265, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1214, -230, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1390, -145, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1336, -126, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1280, -158, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1237, -199, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1159, -147, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1090, -165, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1042, -111, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1102, -88, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1182, -2, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1262, -7, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1282, -76, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1237, -51, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1224, -131, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1130, -39, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1324, 19, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1236, 46, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1152, 51, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1102, 114, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1233, 148, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1169, 150, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1106, 42, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1059, 19, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1118, 3, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(836, -21, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(769, -37, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(737, 42, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(824, 75, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(814, 173, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(745, 186, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(687, 219, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(615, 181, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(563, 133, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(491, 59, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(439, 73, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(444, 31, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(496, 143, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(686, 40, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(630, 56, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(562, -38, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(435, -10, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(382, -133, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(396, -221, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(383, -265, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(469, -243, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(514, -284, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(611, -294, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(474, -307, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(592, -235, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(713, -274, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(738, -208, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(698, -127, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(627, -92, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(710, -78, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(470, -569, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(562, -509, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(528, -659, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(680, -741, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(670, -703, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(704, -633, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(752, -674, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(780, -626, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(859, -637, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(748, -581, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(711, -545, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(629, -523, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(769, -494, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(752, -454, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(748, -552, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(875, -537, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(900, -599, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(821, -624, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(619, -611, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(668, -656, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(430, -94, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(462, -158, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(561, -160, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(551, -101, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(487, -60, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(529, -196, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(814, -139, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(664, -14, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(636, 130, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(571, 50, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(1, -212, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(114, -283, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(46, -283, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1, -154, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-17, -238, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(33, -361, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-40, -356, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-62, -302, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-120, -299, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-141, -360, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-211, -364, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-270, -301, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-218, -310, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-346, -284, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-412, -320, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-452, -386, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-500, -309, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-561, -313, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-643, -310, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-709, -265, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-649, -370, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-579, -426, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-571, -347, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-530, -382, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-611, -272, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-622, -427, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-703, -315, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-460, -308, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-319, -386, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-227, -393, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-894, -1168, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-806, -1110, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-660, -1132, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-676, -1088, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-730, -1129, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-648, -959, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-743, -892, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-857, -977, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-963, -881, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-863, -842, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1095, -397, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1136, -334, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1043, -248, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1043, -299, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1161, -286, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1208, -379, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1259, -312, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1200, -314, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1302, -321, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1259, -398, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1348, -268, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1385, -356, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1291, -261, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1403, -392, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1468, -312, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1413, -306, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1504, -354, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1532, -288, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1557, -341, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1643, -317, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1658, -364, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1661, -401, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1693, -303, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1636, -254, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1599, -275, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1609, -355, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1562, -371, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1538, -258, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1451, -265, 50));
		AddSpawnPoint("f_flash_59.Id6", "f_flash_59", Rectangle(-1430, -350, 50));

		// 'Rambear' GenType 33 Spawn Points
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-799, -1240, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-987, -1087, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-950, -984, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-857, -922, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-664, -881, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-572, -920, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-618, -1091, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-681, -1191, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-970, -1220, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-848, -1145, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-701, -1024, 40));
		AddSpawnPoint("f_flash_59.Id7", "f_flash_59", Rectangle(-822, -1058, 40));

		// 'Jukopus_Gray' GenType 34 Spawn Points
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(572, -645, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(526, -555, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(599, -484, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(685, -507, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(665, -558, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(862, -574, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(811, -656, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(713, -695, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(620, -721, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(732, -621, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(511, -624, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(653, -447, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(772, -530, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(794, -600, 30));
		AddSpawnPoint("f_flash_59.Id8", "f_flash_59", Rectangle(902, -569, 30));
	}
}
