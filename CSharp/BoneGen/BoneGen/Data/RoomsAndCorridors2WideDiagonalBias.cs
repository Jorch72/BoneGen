namespace BoneGen.Data
{
    public class RoomsAndCorridors2WideDiagonalBias
    {
        public static readonly Tileset INSTANCE = new Tileset();
        static RoomsAndCorridors2WideDiagonalBias()
        {
            /* Initialize #INSTANCE */
            INSTANCE.config.is_corner = false;
            INSTANCE.config.num_x_variants = 1;
            INSTANCE.config.num_y_variants = 1;
            INSTANCE.config.short_side_length = 9;
            INSTANCE.config.num_colors[0] = 2;
            INSTANCE.config.num_colors[1] = 2;
            INSTANCE.config.num_colors[2] = 1;
            INSTANCE.config.num_colors[3] = 2;
            INSTANCE.max_tiles.h = 16;
            INSTANCE.max_tiles.v = 16;
            INSTANCE.h_tiles = new Tile[16];
            /* Build h_tiles #0 */
            INSTANCE.h_tiles[0] = new Tile(0, 0, 0, 0, 0, 0
            , "###########..#####"
            , "#######.......####"
            , "..............####"
            , ".................."
            , "#..####..........."
            , "#..####.......####"
            , "#..####.......####"
            , "#..###############"
            , "#..###############"
        );
            /* Build h_tiles #1 */
            INSTANCE.h_tiles[1] = new Tile(0, 0, 1, 0, 0, 0
            , "###########..#####"
            , "#............#####"
            , "#............#####"
            , "#................."
            , "#....###.........."
            , "...........#######"
            , "...........#######"
            , "#..........#######"
            , "#..###############"
        );
            /* Build h_tiles #2 */
            INSTANCE.h_tiles[2] = new Tile(0, 0, 0, 0, 1, 0
            , "###########..#####"
            , "#####........#####"
            , "...##........#####"
            , "...##............."
            , "#..##............."
            , "#..##........#####"
            , "#............#####"
            , "#............#####"
            , "#####..###########"
        );
            /* Build h_tiles #3 */
            INSTANCE.h_tiles[3] = new Tile(0, 0, 1, 0, 1, 0
            , "###########..#####"
            , "###########..#####"
            , "###########..#####"
            , "###########......."
            , "###########......."
            , ".......########..#"
            , ".................#"
            , "#####............#"
            , "#####..###########"
        );
            /* Build h_tiles #4 */
            INSTANCE.h_tiles[4] = new Tile(0, 0, 0, 1, 0, 0
            , "###########..#####"
            , "###########..#####"
            , ".............#####"
            , ".............#####"
            , "#..########..#####"
            , "#..########..#####"
            , "#..########......."
            , "#..########......."
            , "#..###############"
        );
            /* Build h_tiles #5 */
            INSTANCE.h_tiles[5] = new Tile(0, 0, 1, 1, 0, 0
            , "###########..#####"
            , "#.....##.....#####"
            , "#............#####"
            , "#............#####"
            , "#.....##.....#####"
            , "......##.....#####"
            , "......##.........."
            , "#.....##.........."
            , "#..###############"
        );
            /* Build h_tiles #6 */
            INSTANCE.h_tiles[6] = new Tile(0, 0, 0, 1, 1, 0
            , "####....###..#####"
            , "####.....##..#####"
            , ".............#####"
            , ".............#####"
            , "##..##......######"
            , "##..###......#####"
            , "##..####.........."
            , "##.....##........."
            , "##.....###.....###"
        );
            /* Build h_tiles #7 */
            INSTANCE.h_tiles[7] = new Tile(0, 0, 1, 1, 1, 0
            , "###########..#####"
            , "###########..#####"
            , "###########..#####"
            , "###########..#####"
            , "###########..#####"
            , ".................#"
            , ".................."
            , "###..............."
            , "#####..###########"
        );
            /* Build h_tiles #8 */
            INSTANCE.h_tiles[8] = new Tile(0, 1, 0, 0, 0, 0
            , "#########........."
            , "#########........."
            , "...######........."
            , "...######...###..."
            , "#...........###..."
            , "#...........###..."
            , "#..######........."
            , "#..######........."
            , "#..######........."
        );
            /* Build h_tiles #9 */
            INSTANCE.h_tiles[9] = new Tile(0, 1, 1, 0, 0, 0
            , "##############..##"
            , "#.........####..##"
            , "#.........####..##"
            , "#..#####..####...."
            , "#..#####..####...."
            , "...#####..####..##"
            , "...#####........##"
            , "#..#####........##"
            , "#..###############"
        );
            /* Build h_tiles #10 */
            INSTANCE.h_tiles[10] = new Tile(0, 1, 0, 0, 1, 0
            , "##############..##"
            , "#................."
            , ".................."
            , ".................."
            , "#................."
            , "#................."
            , "#................."
            , "#................."
            , "#................."
        );
            /* Build h_tiles #11 */
            INSTANCE.h_tiles[11] = new Tile(0, 1, 1, 0, 1, 0
            , "##############..##"
            , "#...............##"
            , "#...............##"
            , "#..###########...."
            , "#..###########...."
            , "...###############"
            , ".......###########"
            , "#......###########"
            , "#####..###########"
        );
            /* Build h_tiles #12 */
            INSTANCE.h_tiles[12] = new Tile(0, 1, 0, 1, 0, 0
            , "##############..##"
            , "#......####......#"
            , ".................#"
            , ".................#"
            , "#......####......#"
            , "#......####......#"
            , "#................."
            , "#................."
            , "#......####......#"
        );
            /* Build h_tiles #13 */
            INSTANCE.h_tiles[13] = new Tile(0, 1, 1, 1, 0, 0
            , "##############..##"
            , "#...............##"
            , "#...............##"
            , "#..###############"
            , "#..#.....#......##"
            , ".........#......##"
            , "......#.....##...."
            , "#..####.....##...."
            , "#..###############"
        );
            /* Build h_tiles #14 */
            INSTANCE.h_tiles[14] = new Tile(0, 1, 0, 1, 1, 0
            , "##############..##"
            , "####........##..##"
            , "...#........##..##"
            , "...#........##..##"
            , "#..#........##..##"
            , "#..#........##..##"
            , "#..####..#####...."
            , "#................."
            , "#...............##"
        );
            /* Build h_tiles #15 */
            INSTANCE.h_tiles[15] = new Tile(0, 1, 1, 1, 1, 0
            , "##############..##"
            , "###########.....##"
            , "##.....####.....##"
            , "##.....####.....##"
            , "#####...........##"
            , "................##"
            , ".................."
            , "#####............."
            , "#####..###########"
        );
            INSTANCE.v_tiles = new Tile[16];
            /* Build v_tiles #0 */
            INSTANCE.v_tiles[0] = new Tile(0, 0, 0, 0, 0, 0
            , "#..######"
            , "#..######"
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "...####.."
            , "...####.."
            , "#..####.."
            , "#..####.."
            , "#........"
            , "#........"
        );
            /* Build v_tiles #1 */
            INSTANCE.v_tiles[1] = new Tile(1, 0, 0, 0, 0, 0
            , "#####..##"
            , "####....#"
            , "##......."
            , "##......."
            , "##......#"
            , "##..#..##"
            , "##..#####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
            , "#....####"
            , "......###"
            , "......###"
            , "#....####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
        );
            /* Build v_tiles #2 */
            INSTANCE.v_tiles[2] = new Tile(0, 0, 1, 0, 0, 0
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#........"
            , "#........"
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "#..####.."
            , "........."
            , "........."
            , "##..#####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
        );
            /* Build v_tiles #3 */
            INSTANCE.v_tiles[3] = new Tile(1, 0, 1, 0, 0, 0
            , "#####..##"
            , "####....#"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#........"
            , "#........"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#..######"
            , "#..######"
            , "....#####"
            , "....#####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
            , "##..#####"
        );
            /* Build v_tiles #4 */
            INSTANCE.v_tiles[4] = new Tile(0, 0, 0, 1, 0, 0
            , "#..######"
            , "#..######"
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#....#..."
            , "#..###..."
            , "#..#....."
            , "#..#....."
            , "#..#....."
            , "#..#....."
            , "......###"
            , "......###"
            , "##..#####"
        );
            /* Build v_tiles #5 */
            INSTANCE.v_tiles[5] = new Tile(1, 0, 0, 1, 0, 0
            , "#####..##"
            , "#####..##"
            , "#........"
            , "#........"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#......##"
            , "#......##"
            , "##.....##"
            , "##.....##"
            , "##.....##"
            , "##.....##"
            , "##.....##"
            , "##.....##"
            , ".......##"
            , ".......##"
            , "##..#####"
        );
            /* Build v_tiles #6 */
            INSTANCE.v_tiles[6] = new Tile(0, 0, 1, 1, 0, 0
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#........"
            , "#........"
            , "#######.."
            , "#######.."
            , "#######.."
            , "#######.."
            , "#######.."
            , "#######.."
            , "#######.."
            , "#######.."
            , "........."
            , "........."
            , "##..#####"
        );
            /* Build v_tiles #7 */
            INSTANCE.v_tiles[7] = new Tile(1, 0, 1, 1, 0, 0
            , "#####..##"
            , "#####..##"
            , "#......##"
            , "#......##"
            , "#..##..##"
            , "#..##...."
            , "#........"
            , "#......##"
            , "#..##..##"
            , "#..##..##"
            , "#......##"
            , "#......##"
            , "#..##..##"
            , "#..##..##"
            , "#......##"
            , ".......##"
            , ".......##"
            , "##..#####"
        );
            /* Build v_tiles #8 */
            INSTANCE.v_tiles[8] = new Tile(0, 0, 0, 0, 0, 1
            , "#..######"
            , "#......##"
            , "#........"
            , "#####...."
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "####...##"
            , "###....##"
            , "##.....##"
            , ".......##"
            , "....#..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
        );
            /* Build v_tiles #9 */
            INSTANCE.v_tiles[9] = new Tile(1, 0, 0, 0, 0, 1
            , "#####..##"
            , "#####..##"
            , "#####...."
            , "#####...."
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#........"
            , "#........"
            , "#..####.."
            , "...####.."
            , "...####.."
            , "#..####.."
            , "#........"
            , "#........"
            , "#####..##"
        );
            /* Build v_tiles #10 */
            INSTANCE.v_tiles[10] = new Tile(0, 0, 1, 0, 0, 1
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#..######"
            , "#........"
            , "#........"
            , "#####..##"
            , "#####..##"
            , "####....#"
            , "###......"
            , "##...##.."
            , "....###.."
            , "....###.."
            , "##...##.."
            , "###......"
            , "####....#"
            , "#####..##"
        );
            /* Build v_tiles #11 */
            INSTANCE.v_tiles[11] = new Tile(1, 0, 1, 0, 0, 1
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####...."
            , "#####...."
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , ".......##"
            , ".......##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , "#####..##"
        );
            /* Build v_tiles #12 */
            INSTANCE.v_tiles[12] = new Tile(0, 0, 0, 1, 0, 1
            , "#..######"
            , "#..######"
            , "#..###..."
            , "#..###..."
            , "#..###..#"
            , "#..###..#"
            , "#..###..#"
            , "#..##...#"
            , "#.......#"
            , "#.......#"
            , "#..##...#"
            , "#..###..#"
            , "#..###..#"
            , "#..###..#"
            , "#..###..#"
            , "...###..#"
            , "...###..#"
            , "#####...#"
        );
            /* Build v_tiles #13 */
            INSTANCE.v_tiles[13] = new Tile(1, 0, 0, 1, 0, 1
            , "#####..##"
            , "####....#"
            , "##......."
            , "##......."
            , "##..#####"
            , "#......##"
            , "#........"
            , "#........"
            , "#........"
            , "#........"
            , "#........"
            , "####....."
            , "#####..##"
            , "#####..##"
            , "#####..##"
            , ".......##"
            , ".......##"
            , "#####..##"
        );
            /* Build v_tiles #14 */
            INSTANCE.v_tiles[14] = new Tile(0, 0, 1, 1, 0, 1
            , "#..######"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#........"
            , "#........"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "#..##..##"
            , "#..##..##"
            , "#..##..##"
            , "#..##..##"
            , "...##..##"
            , "...##..##"
            , "#####..##"
        );
            /* Build v_tiles #15 */
            INSTANCE.v_tiles[15] = new Tile(1, 0, 1, 1, 0, 1
            , "####....#"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "###..####"
            , "#........"
            , "#........"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "###..####"
            , "###..####"
            , "#.......#"
            , "#.......#"
            , "#.......#"
            , "........#"
            , "...##..##"
            , "#####..##"
        );
        }

    }
}