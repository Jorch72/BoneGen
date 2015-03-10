# BoneGen
Herringbone Wang Tile dungeon generators

The original work done by Sean T. Barrett on [Herringbone Wang Tile dungeon generation](http://nothings.org/gamedev/herringbone/) produces some very high-quality dungeons, but the [C library](https://github.com/nothings/stb/blob/master/stb_herringbone_wang_tile.h) he graciously made available is hard to integrate into non-C/C++ applications.
Here, I modified the STB source to output JSON instead of a bitmap, and used that JSON in a C# loader.
The plan is to keep porting, using the JSON in similar ways in different languages.

# License
Released into the public domain with the Unlicense (see LICENSE file in this directory).

## Sample output
Using the TilesetType `ROUND_ROOMS_DIAGONAL_CORRIDORS`:
```
################################################################################
########..............############......############....############...........#
########...............##########.......############.....############..........#
########...............#########..........##########.....###########...........#
########...............########.............#########.....#########............#
#######.................######...............########.....#########............#
#.####.....##....#......#####.....#####.......########....#########.....#....#.#
#........##########.......#.....#######........#######.....#######......########
#.......#############..........#######..........######........#.......##########
#.......##############........########.....##....######..............###########
##......##############.......#########....####.....####............#############
###....###############......#########.....#####.....##.............#############
###.....##############.....#########.....######...................##############
####....##############....##########....########...................#############
#####....############....##########....##########..................#############
######....##########.....#########....############.................#############
#######....#######.........#####.....##############................###########.#
########....#####...........###.......##############...................######..#
########......##.............#.........#############......................##...#
#####..........#.............#.........#############.............###.......#...#
###....................................#############............#####..........#
##.....................................############......#....##########.......#
#...........##..........................##########......##################.....#
#............##...............#..........##....#.......####################....#
#............##...............##......................#####################....#
#............###.............########.................######################...#
#............###.............#########...............############.....######...#
##..........#####...........###########.............###########.........#####..#
##..........######.........###########..............##########...........#####.#
###........#########.....#############..............#########.............######
#####....############....#############..............#########.............######
######################....############..............########...............#####
######################.....############.............########...............#####
########.....#########.....###########..............########...............#####
######........#########.....#########................#######...............###.#
#####..........########.....#########................#######...............###.#
#####...........########....#########.....#....#......#####.................#..#
#####......#.....#######.....#######......########.....##......................#
#.##.......###....######........#.......###########..........#...........#.....#
#.........#####....######..............#############........###.........###....#
#......#########.....####............###############.......######......#####...#
#......##########.....##.............################.....########.....######..#
#.....###########...................#################....#########....##########
#......###########...................###############....##########....##########
#......############..................##############....##########....###########
#......#############.................#############....#########.....############
#......##############..................##########....########.........##########
#.....################....................#######...########...........#########
#.....################......................####....#######.............########
#......###############.......................###....#######.............########
#......###############............####..............######................######
#.#......############......#....##########...........#####.................#####
#####......#########......##################..........####..................##.#
######.....##....#.......###########...######.........####.....................#
#######.................##########.......#####........####...............#.....#
########................#########.........####........#####.............###....#
########...............#########...........####......######.............####...#
#########.............##########...........#####....########...........######..#
########..............#########.............#####....########.........########.#
########..............#########.............######....#########.....############
########..............#########.............#######....#########....############
########................########...........#########....#########....###########
#####....................#######...........##########...#########.....##########
####.......................######...........#########....#######......##########
##..........................######..........######.......######........#########
#..................####......#####.....##....###.........####...........########
#..................#####......###....#####....#...........##............########
#....###............######..........#######...............#.............########
#..#####............########........########............................########
########............#########......##########................#..........########
########............##########.....##########...............##..........########
#########..........############......########..............####........#########
#########..........#############......#######..............#####......##########
######...............#############....########............########....##########
#####....###....##....#############....#######............#######....###########
####....###########....#############....#######..........#######....############
###.....############....#...#########....#######........#######....#############
###....#############..........#######....#########....########........##########
##.....##############..........######....####################.............######
################################################################################
```

Using the TilesetType `DEFAULT_DUNGEON`:
```
################################################################################
#....########......##.......######..#####.......####.......###############.....#
#.....######................######......#........###..........############.....#
#......####............##...#..............#......##...........#####...#####...#
#.......##....###......##..................#..#...##...........####.....####...#
#.##....##....####.....##.......#####......#.....###............##.......###...#
#.##....##....#####....##.......#................###.....................###...#
####...####...###########..##...#............#..####.......##............###...#
####...####...#########.....#####......##......#####.......##........##........#
####..######..#########.....########...###.....#####..#########.....###........#
####..######..############..########...#####..######..#########.....############
#..#.....##..................#######...#####.....##......######......###########
#..#......#.......................##...#####...............###.............#####
#..#......#..#########..###.......######.#####.............###....#........#...#
#..####...#..##..........##..###..######..####.......##.....#.....##..###..#...#
#.....#......##..........##..###..##.......###........###.........##..#........#
#.....#......###..#########..###...........###..........##........###.#........#
#..####......................###......##...###...........##......######........#
#........##..................#######..###........###.....####....######........#
#........#####..######..############..###........###.....#####..#########.....##
############.....#####......########..################..######......#####.....##
###########........###.............#..#############........###..............####
#........##........###.............#.........######........#................#..#
#.........#........###.........#...#.........#....#..####..#......###########..#
######....####.....###....######...#..#####..#....#.....#..#..##...............#
#............##....###....#....#####..###...............#..#..##...............#
#.............###.........#....#......###...............#.........##############
#.........#...............#...........###.........#.....#......................#
#........##........#####..#...........###........############..................#
######..######.....#####..######......#####.....################..#####..#######
######..##############.....#####..#########.....###........##......#####......##
######..###........##........###................###........###.....#####......##
#....#.............##......................................####..##########...##
#....#......##..#...#..##..........##..####..................##..#...#....#....#
#.#..#..##..##..#...#..###........##......#########..............#...#....#....#
#.......##......#......####......##..........######..............#...#....####.#
#.#.....##......#......#####....##............#####.......................####.#
#....#..###.##..###.#########...#....##........####...........#................#
#....#..#####.....###.......#####....#####......###........####..#######.......#
##..#########.....###........###.....#####......########..#####......###.....###
##......#####.....####..##...###.....#####..#########.....#####......#####..####
##......#.........###....##..###.......##...........#.....#########..##........#
##......#................##..#####.....##...........#..........####..##........#
##......#..####...........#..#...##....####..########..#.......####...#..####..#
###....##..####...........#..#....##...##.....#........#....#...###...#..#..#..#
####..###..####...........#........##..##.....#........#....#...###......#..#..#
#..........#.............##.........#......#..#....#........##..###......#..#..#
#..........#.......##....##..#......#......#..#....#......####........####..#..#
####..######..########..##...###....#..#####..#....#......####.......##.....####
####..######..############..#####......###....######......########..###........#
##.....#####.....#######....#####......###.....#####......#####.....###..#.....#
#......####........#.........###....#..##........##.......#..##.....###..#.....#
#......#..#........#................#..##.........#...#####..#...........#...###
#......#..#........................##..##.........#...#......#...........#...#.#
#####..#...........................##..#######....#..........#..##...#...#...#.#
#..........................###....##.........#....#..........#..#...##...#####.#
#............................#...###.........#........#......#.....###.........#
#####...........#....#.......######....##.............####...#....#####........#
###########.....#....#.......######....##........###.....#...#...######.......##
#############...######.....#########..##############.....#####..#########.....##
#..#########.....#####..#########.....################..######......#####.....##
#...##########..######..#....#..#.....################.....##...........##.....#
#....########....#####..#....#..#...........##########.....##...........###....#
#.......#####....#####..#....#..#...........##.....######..##....#####..###....#
#.......######..######..#....#..#......#....##......##.....##....#####..###....#
#....#..........######..###..#..#......#....##.......#.....##....###....###....#
#....#.......................#..#####..#.....#.......#..#........###....###....#
#....#..#####................#.........##...............#........###....##.....#
#....#..########..####.......#.........##........##.....#####.....#######......#
######..#####......###.....#####..#########.....###.....######.....#####......##
####....#####......#####..######......#####.....################...#####..######
#........####......#####..#####.......#..##.....###........#####.....###..#...##
#...........#......#####..#...#...#####..#.................######.....##..#...##
#...........############..#...#...#......#.................#######....##..#...##
#.................######..#...#..........#..##...###..###..#######....##..#...##
#......###.............#..#...#..........#..#...####..###......###....##..#...##
#........#..#..........#..#.......#......#.....####....##.......##.............#
##.......####....####..#..#.......####...#....#####.....#####...##.............#
##.......####....####..#..#..###.....#...#...######......#####...#...#####..####
################################################################################
```
