using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;

namespace Scripts {
    partial class Parts {
        // Don't edit above this line
        private AnimationDef MW_SHR_11_Mk1_Animation => new AnimationDef
        {
            EventParticles = new Dictionary<PartAnimationSetDef.EventTriggers, EventParticle[]>
            {
                [PreFire] = new[] { // Starts with the DelayUntilFire warmup (90 ticks), so the effect's 1.5 s charge ends as the shot fires.
                    new EventParticle
                    {
                        EmptyNames = Names("muzzle_projectile_1"), // Dummy the effect is attached to.
                        MuzzleNames = Names("muzzle_projectile_1"), // Muzzle the effect is attached to.
                        StartDelay = 0, // Ticks before the particle starts (60 = 1 second).
                        LoopDelay = 0, // Ticks between loops (60 = 1 second).
                        ForceStop = false,
                        Particle = new ParticleDef
                        {
                            Name = "MW_SHR_11_Mk1_MuzzleFlash", // Particle SubtypeId.
                            Extras = new ParticleOptionDef
                            {
                                Loop = false, // Should match the particle definition.
                                Restart = false,
                                MaxDistance = 800, // Metres.
                                MaxDuration = 0, // Ticks (60 = 1 second).
                                Scale = 1, // Scale of effect.
                            }
                        }
                    },
                },
            },
        };
        // Don't edit below this line.
    }
}
