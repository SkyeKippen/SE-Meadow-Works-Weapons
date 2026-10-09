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
SKC_01_Mk1 "Common Name"\
S - Small (Size)\
K - Kinetic (Damage Type (Kinetic/Energy/Hybrid))\
C - Cannon (Cannon, Laser, Repeater, Missile, Gatling, Point-Defence, Dumb, EWAR)\
01 - 01, 02, 03... - Iterates with each new weapon design regardless of prefix\
Mk1 - Mk1, Mk2, Mk3 - Specifically for the same style/design of weapon, each Mk# up is generally a straight upgrade

### Size Guidelines (LG)
T - Tiny (up to 2x2x2)\
S - Small (Up to 3x3x3)\
M - Medium (Up to 5x5x5)\
L - Large (Up to 7x7x7)\
X - X-Large (Up to 9x9x9)\
C - Capital (Anything larger)\
W - Super Weapon (Special)

### Tallies (Existing Weapons Only)
LG: 7\
SG: 1

Kinetic: 5\
Energy: 3\
EWAR: 0

Cannon: 4\
Laser: 2\
Repeater/Autocannon: 1\
Gatling/PDC: 0\
Missile: 1

Tiny: 5\
Small: 2\
Medium: 1\
Large: 0\
X-Large: 0\
Capital: 0\
Super Weapon: 0

### Full Weapon List
- `TEC_01_Mk1 ""`
- `SKC_02_Mk1 ""`
- `TEL_03_Mk1 ""`
- `MEL_04_Mk1 ""`
- `CEE_05_Mk1 ""`
- `TKM_06_Mk1 ""`
- `TKC_07_Mk1 ""`
- `SKR_08_Mk1_S ""`
- `TKC_09_Mk1 ""`


#### Finished


#### Working
- `TEC_01_Mk1 ""`
- `SKC_02_Mk1 ""`
- `TEL_03_Mk1 ""`
- `MEL_04_Mk1 ""`
- `TKM_06_Mk1 ""`
- `TKC_07_Mk1 ""`
- `SKR_08_Mk1_S ""`


#### Non-Functional


#### Not Started
- `CEE_05_Mk1 ""`



### Weapons & Descriptions
- `TEC_01_Mk1 ""` - Tiny Energy Cannon Mk1 - Turret - A basic energy cannon that doesn't do much on its own, but can be lined up for devastating broadsides.
- `SKC_02_Mk1 ""` - Small Kinetic Cannon Mk1 - Turret - A double-barreled turret, resembling a cruder version of old naval warship turrets.
- `TEL_03_Mk1 ""` - Tiny Energy Laser Mk1 - Turret - A Laser turret with long firing length, but relatively low damage.
- `MEL_04_Mk1 ""` - Medium Energy Laser Mk1 - Turret - Triple-barreled laser turret with long range but relatively low damage.
- `CEE_05_Mk1 ""` - Capital Energy EWAR-EMP Mk1 - Fixed - Single-Shot Ion Cannon capable of temporarily disabling small ships or sections of larger ships.
- `TKM_06_Mk1 ""` - Tiny Kinetic Missile Mk1 - Fixed - 8 Micro Missile burst designed for targeting SG. Individual low damage. Reduced damage to LG.
- `TKC_07_Mk1 ""` - Tiny Kinetic Cannon Mk1 - Turret - TEC-01, but a physical projectile instead of energy.
- `SKB_08_Mk1_S ""` - Small Kinetic Repeater Mk1 Small (SG) - Fixed - Similar to vanilla autocannon, but fires a 5-shot burst with a short reload.
- `TKC_09_Mk1 ""` - Tiny Kinetic Cannon Mk1 - Fixed - Broadside-style fixed cannon, very heavy cannon but unable to rotate or elevate. Low speed, very high damage, very long reload.