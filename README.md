# MW Weapons

### Development Sections Per Weapon
1) Modeling
2) Materials & Texturing
3) Scripting (.cs files)
4) Supporting Files (.sbc)
5) Particles
6) Audio
7) Custom Animation

Sections 1 - 4 are required.
Section 7 is completely optional.

### Theme
Harder Sci-Fi, doesn't focus on any specific type of weapon.

### Naming Scheme
`<Family> <Size><Variant>`, e.g. `Anvil S2` (SubtypeId `MW_Anvil_S2`)\
Family - One word per weapon class (see below)\
Size - T/S/M/L/X/C/W (see Size Guidelines)\
Variant - 1, 2, 3... - Iterates per family and size; a higher number is generally a straight upgrade or a newer design\
Small grid weapons add `(SG)` to the name and `_SG` to the SubtypeId, e.g. `Rattler S1 (SG)` / `MW_Rattler_S1_SG`

### Families
Anvil - Kinetic cannon turret\
Hammer - Heavy fixed kinetic cannon / artillery\
Ember - Energy cannon\
Lumen - Laser\
Hornet - Missile\
Rattler - Repeater/Autocannon\
Lance - Railgun\
Vorpal - Ion / EMP (EWAR)

### Size Guidelines (LG)
T - Tiny (up to 2x2x2)\
S - Small (Up to 3x3x3)\
M - Medium (Up to 5x5x5)\
L - Large (Up to 7x7x7)\
X - X-Large (Up to 9x9x9)\
C - Capital (Anything larger)\
W - Super Weapon (Special)

### Tallies (Existing Weapons Only)
LG: 10\
SG: 1

Kinetic: 7\
Energy: 3\
Hybrid: 1\
EWAR: 0

Cannon: 6\
Laser: 2\
Repeater/Autocannon: 1\
Railgun: 1\
Gatling/PDC: 0\
Missile: 1

Tiny: 6\
Small: 4\
Medium: 1\
Large: 0\
X-Large: 0\
Capital: 0\
Super Weapon: 0

### Full Weapon List
Old ID in brackets.
- `Ember T1` (TEC_01_Mk1)
- `Anvil S1` (SKC_02_Mk1)
- `Anvil S2` (SKC_02_Mk2)
- `Lumen T1` (TEL_03_Mk1)
- `Lumen M1` (MEL_04_Mk1)
- `Vorpal C1` (CEE_05_Mk1)
- `Hornet T1` (TKM_06_Mk1)
- `Anvil T1` (TKC_07_Mk1)
- `Rattler S1 (SG)` (SKR_08_Mk1_S)
- `Hammer T1` (TKC_09_Mk1)
- `Anvil T2` (TKC_10_Mk1)
- `Lance S1` (SHR_11_Mk1)


#### Finished


#### Working
- `Ember T1`
- `Anvil S1`
- `Lumen T1`
- `Lumen M1`
- `Hornet T1`
- `Anvil T1`
- `Rattler S1 (SG)`


#### Non-Functional


#### Not Started
- `Vorpal C1`



### Weapons & Descriptions
- `Ember T1` - Tiny Energy Cannon - Turret - A basic energy cannon that doesn't do much on its own, but can be lined up for devastating broadsides.
- `Anvil S1` - Small Kinetic Cannon - Turret - A double-barreled turret, resembling a cruder version of old naval warship turrets.
- `Anvil S2` - Small Kinetic Cannon - Turret - Upgraded Anvil S1.
- `Lumen T1` - Tiny Energy Laser - Turret - A Laser turret with long firing length, but relatively low damage.
- `Lumen M1` - Medium Energy Laser - Turret - Triple-barreled laser turret with long range but relatively low damage.
- `Vorpal C1` - Capital Energy EWAR-EMP - Fixed - Single-Shot Ion Cannon capable of temporarily disabling small ships or sections of larger ships.
- `Hornet T1` - Tiny Kinetic Missile - Fixed - 8 Micro Missile burst designed for targeting SG. Individual low damage. Reduced damage to LG.
- `Anvil T1` - Tiny Kinetic Cannon - Turret - Ember T1, but a physical projectile instead of energy.
- `Rattler S1 (SG)` - Small Kinetic Repeater (SG) - Fixed - Similar to vanilla autocannon, but fires a 5-shot burst with a short reload.
- `Hammer T1` - Tiny Kinetic Cannon - Fixed - Broadside-style fixed cannon, very heavy cannon but unable to rotate or elevate. Low speed, very high damage, very long reload.
- `Anvil T2` - Tiny Kinetic Cannon - Turret - Light artillery turret.
- `Lance S1` - Small Hybrid Railgun - Turret - Charged railgun turret firing a heavy sabot round.
