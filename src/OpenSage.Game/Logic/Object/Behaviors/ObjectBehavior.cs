﻿using System;
using System.Collections.Generic;
using OpenSage.Data.Ini.Parser;

namespace OpenSage.Logic.Object
{
    public abstract class ObjectBehavior : ObjectModule
    {
        internal static ObjectBehavior ParseBehavior(IniParser parser) => ParseModule(parser, BehaviorParseTable);

        private static readonly Dictionary<string, Func<IniParser, ObjectBehavior>> BehaviorParseTable = new Dictionary<string, Func<IniParser, ObjectBehavior>>
        {
            { "AIUpdateInterface", AIUpdateInterfaceBehavior.Parse },
            { "AutoDepositUpdate", AutoDepositUpdateBehavior.Parse },
            { "AutoHealBehavior", AutoHealBehavior.Parse },
            { "BaikonurLaunchPower", BaikonurLaunchPowerBehavior.Parse },
            { "BaseRegenerateUpdate", BaseRegenerateUpdateBehavior.Parse },
            { "BoneFXDamage", BoneFXDamageBehavior.Parse },
            { "BoneFXUpdate", BoneFXUpdateBehavior.Parse },
            { "BridgeBehavior", BridgeBehavior.Parse },
            { "BridgeTowerBehavior", BridgeTowerBehavior.Parse },
            { "CostModifierUpgrade", CostModifierUpgradeBehavior.Parse },
            { "CreateCrateDie", CreateCrateDieBehavior.Parse },
            { "CreateObjectDie", CreateObjectDieBehavior.Parse },
            { "CrushDie", CrushDieBehavior.Parse },
            { "DamDie", DamDieBehavior.Parse },
            { "DefaultProductionExitUpdate", DefaultProductionExitUpdateBehavior.Parse },
            { "DeletionUpdate", DeletionUpdateBehavior.Parse },
            { "DestroyDie", DestroyDieBehavior.Parse },
            { "FireWeaponWhenDeadBehavior", FireWeaponWhenDeadBehavior.Parse },
            { "FireWeaponWhenDamagedBehavior", FireWeaponWhenDamagedBehavior.Parse },
            { "FlammableUpdate", FlammableUpdateBehavior.Parse },
            { "FloatUpdate", FloatUpdateBehavior.Parse },
            { "FXListDie", FXListDieBehavior.Parse },
            { "GarrisonContain", GarrisonContainBehavior.Parse },
            { "GrantUpgradeCreate", GrantUpgradeCreateBehavior.Parse },
            { "InstantDeathBehavior", InstantDeathBehavior.Parse },
            { "KeepObjectDie", KeepObjectDieBehavior.Parse },
            { "LifetimeUpdate", LifetimeUpdateBehavior.Parse },
            { "MoneyCrateCollide", MoneyCrateCollideBehavior.Parse },
            { "OCLSpecialPower", OCLSpecialPowerBehavior.Parse },
            { "PhysicsBehavior", PhysicsBehavior.Parse },
            { "PoisonedBehavior", PoisonedBehavior.Parse },
            { "PreorderCreate", PreorderCreateBehavior.Parse },
            { "ProductionUpdate", ProductionUpdateBehavior.Parse },
            { "RadarUpdate", RadarUpdateBehavior.Parse },
            { "RadarUpgrade", RadarUpgradeBehavior.Parse },
            { "RailedTransportContain", RailedTransportContainBehavior.Parse },
            { "RailedTransportDockUpdate", RailedTransportDockUpdateBehavior.Parse },
            { "RailedTransportAIUpdate", RailedTransportAIUpdateBehavior.Parse },
            { "RailroadBehavior", RailroadBehavior.Parse },
            { "RebuildHoleBehavior", RebuildHoleBehavior.Parse },
            { "SalvageCrateCollide", SalvageCrateCollideBehavior.Parse },
            { "SlowDeathBehavior", SlowDeathBehavior.Parse },
            { "SquishCollide", SquishCollideBehavior.Parse },
            { "StructureCollapseUpdate", StructureCollapseUpdateBehavior.Parse },
            { "StructureToppleUpdate", StructureToppleUpdateBehavior.Parse },
            { "SupplyWarehouseCreate", SupplyWarehouseCreateBehavior.Parse },
            { "SupplyWarehouseCripplingBehavior", SupplyWarehouseCripplingBehavior.Parse },
            { "SupplyWarehouseDockUpdate", SupplyWarehouseDockUpdateBehavior.Parse },
            { "TechBuildingBehavior", TechBuildingBehavior.Parse },
            { "TensileFormationUpdate", TensileFormationUpdateBehavior.Parse },
            { "ToppleUpdate", ToppleUpdateBehavior.Parse },
            { "TransitionDamageFX", TransitionDamageFXBehavior.Parse },
            { "TransportAIUpdate", TransportAIUpdateBehavior.Parse },
            { "TransportContain", TransportContainBehavior.Parse },
            { "UnitCrateCollide", UnitCrateCollideBehavior.Parse },
            { "VeterancyCrateCollide", VeterancyCrateCollideBehavior.Parse },
        };
    }
}
