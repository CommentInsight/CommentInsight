using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentCleanTool
{
    class FileHelper
    {
        internal static int[][] GBFreq = new int[94][];
        internal static int[][] GBKFreq = new int[126][];

        public FileHelper()
        {
            Initialize_Frequencies();
        }

        internal virtual void Initialize_Frequencies()
        {
            int i;
            if (GBFreq[0] == null)
            {
                for (i = 0; i < 94; i++)
                {
                    GBFreq[i] = new int[94];
                }

                #region GBFreq[20][35] = 599;

                GBFreq[49][26] = 598;
                GBFreq[41][38] = 597;
                GBFreq[17][26] = 596;
                GBFreq[32][42] = 595;
                GBFreq[39][42] = 594;
                GBFreq[45][49] = 593;
                GBFreq[51][57] = 592;
                GBFreq[50][47] = 591;
                GBFreq[42][90] = 590;
                GBFreq[52][65] = 589;
                GBFreq[53][47] = 588;
                GBFreq[19][82] = 587;
                GBFreq[31][19] = 586;
                GBFreq[40][46] = 585;
                GBFreq[24][89] = 584;
                GBFreq[23][85] = 583;
                GBFreq[20][28] = 582;
                GBFreq[42][20] = 581;
                GBFreq[34][38] = 580;
                GBFreq[45][9] = 579;
                GBFreq[54][50] = 578;
                GBFreq[25][44] = 577;
                GBFreq[35][66] = 576;
                GBFreq[20][55] = 575;
                GBFreq[18][85] = 574;
                GBFreq[20][31] = 573;
                GBFreq[49][17] = 572;
                GBFreq[41][16] = 571;
                GBFreq[35][73] = 570;
                GBFreq[20][34] = 569;
                GBFreq[29][44] = 568;
                GBFreq[35][38] = 567;
                GBFreq[49][9] = 566;
                GBFreq[46][33] = 565;
                GBFreq[49][51] = 564;
                GBFreq[40][89] = 563;
                GBFreq[26][64] = 562;
                GBFreq[54][51] = 561;
                GBFreq[54][36] = 560;
                GBFreq[39][4] = 559;
                GBFreq[53][13] = 558;
                GBFreq[24][92] = 557;
                GBFreq[27][49] = 556;
                GBFreq[48][6] = 555;
                GBFreq[21][51] = 554;
                GBFreq[30][40] = 553;
                GBFreq[42][92] = 552;
                GBFreq[31][78] = 551;
                GBFreq[25][82] = 550;
                GBFreq[47][0] = 549;
                GBFreq[34][19] = 548;
                GBFreq[47][35] = 547;
                GBFreq[21][63] = 546;
                GBFreq[43][75] = 545;
                GBFreq[21][87] = 544;
                GBFreq[35][59] = 543;
                GBFreq[25][34] = 542;
                GBFreq[21][27] = 541;
                GBFreq[39][26] = 540;
                GBFreq[34][26] = 539;
                GBFreq[39][52] = 538;
                GBFreq[50][57] = 537;
                GBFreq[37][79] = 536;
                GBFreq[26][24] = 535;
                GBFreq[22][1] = 534;
                GBFreq[18][40] = 533;
                GBFreq[41][33] = 532;
                GBFreq[53][26] = 531;
                GBFreq[54][86] = 530;
                GBFreq[20][16] = 529;
                GBFreq[46][74] = 528;
                GBFreq[30][19] = 527;
                GBFreq[45][35] = 526;
                GBFreq[45][61] = 525;
                GBFreq[30][9] = 524;
                GBFreq[41][53] = 523;
                GBFreq[41][13] = 522;
                GBFreq[50][34] = 521;
                GBFreq[53][86] = 520;
                GBFreq[47][47] = 519;
                GBFreq[22][28] = 518;
                GBFreq[50][53] = 517;
                GBFreq[39][70] = 516;
                GBFreq[38][15] = 515;
                GBFreq[42][88] = 514;
                GBFreq[16][29] = 513;
                GBFreq[27][90] = 512;
                GBFreq[29][12] = 511;
                GBFreq[44][22] = 510;
                GBFreq[34][69] = 509;
                GBFreq[24][10] = 508;
                GBFreq[44][11] = 507;
                GBFreq[39][92] = 506;
                GBFreq[49][48] = 505;
                GBFreq[31][46] = 504;
                GBFreq[19][50] = 503;
                GBFreq[21][14] = 502;
                GBFreq[32][28] = 501;
                GBFreq[18][3] = 500;
                GBFreq[53][9] = 499;
                GBFreq[34][80] = 498;
                GBFreq[48][88] = 497;
                GBFreq[46][53] = 496;
                GBFreq[22][53] = 495;
                GBFreq[28][10] = 494;
                GBFreq[44][65] = 493;
                GBFreq[20][10] = 492;
                GBFreq[40][76] = 491;
                GBFreq[47][8] = 490;
                GBFreq[50][74] = 489;
                GBFreq[23][62] = 488;
                GBFreq[49][65] = 487;
                GBFreq[28][87] = 486;
                GBFreq[15][48] = 485;
                GBFreq[22][7] = 484;
                GBFreq[19][42] = 483;
                GBFreq[41][20] = 482;
                GBFreq[26][55] = 481;
                GBFreq[21][93] = 480;
                GBFreq[31][76] = 479;
                GBFreq[34][31] = 478;
                GBFreq[20][66] = 477;
                GBFreq[51][33] = 476;
                GBFreq[34][86] = 475;
                GBFreq[37][67] = 474;
                GBFreq[53][53] = 473;
                GBFreq[40][88] = 472;
                GBFreq[39][10] = 471;
                GBFreq[24][3] = 470;
                GBFreq[27][25] = 469;
                GBFreq[26][15] = 468;
                GBFreq[21][88] = 467;
                GBFreq[52][62] = 466;
                GBFreq[46][81] = 465;
                GBFreq[38][72] = 464;
                GBFreq[17][30] = 463;
                GBFreq[52][92] = 462;
                GBFreq[34][90] = 461;
                GBFreq[21][7] = 460;
                GBFreq[36][13] = 459;
                GBFreq[45][41] = 458;
                GBFreq[32][5] = 457;
                GBFreq[26][89] = 456;
                GBFreq[23][87] = 455;
                GBFreq[20][39] = 454;
                GBFreq[27][23] = 453;
                GBFreq[25][59] = 452;
                GBFreq[49][20] = 451;
                GBFreq[54][77] = 450;
                GBFreq[27][67] = 449;
                GBFreq[47][33] = 448;
                GBFreq[41][17] = 447;
                GBFreq[19][81] = 446;
                GBFreq[16][66] = 445;
                GBFreq[45][26] = 444;
                GBFreq[49][81] = 443;
                GBFreq[53][55] = 442;
                GBFreq[16][26] = 441;
                GBFreq[54][62] = 440;
                GBFreq[20][70] = 439;
                GBFreq[42][35] = 438;
                GBFreq[20][57] = 437;
                GBFreq[34][36] = 436;
                GBFreq[46][63] = 435;
                GBFreq[19][45] = 434;
                GBFreq[21][10] = 433;
                GBFreq[52][93] = 432;
                GBFreq[25][2] = 431;
                GBFreq[30][57] = 430;
                GBFreq[41][24] = 429;
                GBFreq[28][43] = 428;
                GBFreq[45][86] = 427;
                GBFreq[51][56] = 426;
                GBFreq[37][28] = 425;
                GBFreq[52][69] = 424;
                GBFreq[43][92] = 423;
                GBFreq[41][31] = 422;
                GBFreq[37][87] = 421;
                GBFreq[47][36] = 420;
                GBFreq[16][16] = 419;
                GBFreq[40][56] = 418;
                GBFreq[24][55] = 417;
                GBFreq[17][1] = 416;
                GBFreq[35][57] = 415;
                GBFreq[27][50] = 414;
                GBFreq[26][14] = 413;
                GBFreq[50][40] = 412;
                GBFreq[39][19] = 411;
                GBFreq[19][89] = 410;
                GBFreq[29][91] = 409;
                GBFreq[17][89] = 408;
                GBFreq[39][74] = 407;
                GBFreq[46][39] = 406;
                GBFreq[40][28] = 405;
                GBFreq[45][68] = 404;
                GBFreq[43][10] = 403;
                GBFreq[42][13] = 402;
                GBFreq[44][81] = 401;
                GBFreq[41][47] = 400;
                GBFreq[48][58] = 399;
                GBFreq[43][68] = 398;
                GBFreq[16][79] = 397;
                GBFreq[19][5] = 396;
                GBFreq[54][59] = 395;
                GBFreq[17][36] = 394;
                GBFreq[18][0] = 393;
                GBFreq[41][5] = 392;
                GBFreq[41][72] = 391;
                GBFreq[16][39] = 390;
                GBFreq[54][0] = 389;
                GBFreq[51][16] = 388;
                GBFreq[29][36] = 387;
                GBFreq[47][5] = 386;
                GBFreq[47][51] = 385;
                GBFreq[44][7] = 384;
                GBFreq[35][30] = 383;
                GBFreq[26][9] = 382;
                GBFreq[16][7] = 381;
                GBFreq[32][1] = 380;
                GBFreq[33][76] = 379;
                GBFreq[34][91] = 378;
                GBFreq[52][36] = 377;
                GBFreq[26][77] = 376;
                GBFreq[35][48] = 375;
                GBFreq[40][80] = 374;
                GBFreq[41][92] = 373;
                GBFreq[27][93] = 372;
                GBFreq[15][17] = 371;
                GBFreq[16][76] = 370;
                GBFreq[51][12] = 369;
                GBFreq[18][20] = 368;
                GBFreq[15][54] = 367;
                GBFreq[50][5] = 366;
                GBFreq[33][22] = 365;
                GBFreq[37][57] = 364;
                GBFreq[28][47] = 363;
                GBFreq[42][31] = 362;
                GBFreq[18][2] = 361;
                GBFreq[43][64] = 360;
                GBFreq[23][47] = 359;
                GBFreq[28][79] = 358;
                GBFreq[25][45] = 357;
                GBFreq[23][91] = 356;
                GBFreq[22][19] = 355;
                GBFreq[25][46] = 354;
                GBFreq[22][36] = 353;
                GBFreq[54][85] = 352;
                GBFreq[46][20] = 351;
                GBFreq[27][37] = 350;
                GBFreq[26][81] = 349;
                GBFreq[42][29] = 348;
                GBFreq[31][90] = 347;
                GBFreq[41][59] = 346;
                GBFreq[24][65] = 345;
                GBFreq[44][84] = 344;
                GBFreq[24][90] = 343;
                GBFreq[38][54] = 342;
                GBFreq[28][70] = 341;
                GBFreq[27][15] = 340;
                GBFreq[28][80] = 339;
                GBFreq[29][8] = 338;
                GBFreq[45][80] = 337;
                GBFreq[53][37] = 336;
                GBFreq[28][65] = 335;
                GBFreq[23][86] = 334;
                GBFreq[39][45] = 333;
                GBFreq[53][32] = 332;
                GBFreq[38][68] = 331;
                GBFreq[45][78] = 330;
                GBFreq[43][7] = 329;
                GBFreq[46][82] = 328;
                GBFreq[27][38] = 327;
                GBFreq[16][62] = 326;
                GBFreq[24][17] = 325;
                GBFreq[22][70] = 324;
                GBFreq[52][28] = 323;
                GBFreq[23][40] = 322;
                GBFreq[28][50] = 321;
                GBFreq[42][91] = 320;
                GBFreq[47][76] = 319;
                GBFreq[15][42] = 318;
                GBFreq[43][55] = 317;
                GBFreq[29][84] = 316;
                GBFreq[44][90] = 315;
                GBFreq[53][16] = 314;
                GBFreq[22][93] = 313;
                GBFreq[34][10] = 312;
                GBFreq[32][53] = 311;
                GBFreq[43][65] = 310;
                GBFreq[28][7] = 309;
                GBFreq[35][46] = 308;
                GBFreq[21][39] = 307;
                GBFreq[44][18] = 306;
                GBFreq[40][10] = 305;
                GBFreq[54][53] = 304;
                GBFreq[38][74] = 303;
                GBFreq[28][26] = 302;
                GBFreq[15][13] = 301;
                GBFreq[39][34] = 300;
                GBFreq[39][46] = 299;
                GBFreq[42][66] = 298;
                GBFreq[33][58] = 297;
                GBFreq[15][56] = 296;
                GBFreq[18][51] = 295;
                GBFreq[49][68] = 294;
                GBFreq[30][37] = 293;
                GBFreq[51][84] = 292;
                GBFreq[51][9] = 291;
                GBFreq[40][70] = 290;
                GBFreq[41][84] = 289;
                GBFreq[28][64] = 288;
                GBFreq[32][88] = 287;
                GBFreq[24][5] = 286;
                GBFreq[53][23] = 285;
                GBFreq[42][27] = 284;
                GBFreq[22][38] = 283;
                GBFreq[32][86] = 282;
                GBFreq[34][30] = 281;
                GBFreq[38][63] = 280;
                GBFreq[24][59] = 279;
                GBFreq[22][81] = 278;
                GBFreq[32][11] = 277;
                GBFreq[51][21] = 276;
                GBFreq[54][41] = 275;
                GBFreq[21][50] = 274;
                GBFreq[23][89] = 273;
                GBFreq[19][87] = 272;
                GBFreq[26][7] = 271;
                GBFreq[30][75] = 270;
                GBFreq[43][84] = 269;
                GBFreq[51][25] = 268;
                GBFreq[16][67] = 267;
                GBFreq[32][9] = 266;
                GBFreq[48][51] = 265;
                GBFreq[39][7] = 264;
                GBFreq[44][88] = 263;
                GBFreq[52][24] = 262;
                GBFreq[23][34] = 261;
                GBFreq[32][75] = 260;
                GBFreq[19][10] = 259;
                GBFreq[28][91] = 258;
                GBFreq[32][83] = 257;
                GBFreq[25][75] = 256;
                GBFreq[53][45] = 255;
                GBFreq[29][85] = 254;
                GBFreq[53][59] = 253;
                GBFreq[16][2] = 252;
                GBFreq[19][78] = 251;
                GBFreq[15][75] = 250;
                GBFreq[51][42] = 249;
                GBFreq[45][67] = 248;
                GBFreq[15][74] = 247;
                GBFreq[25][81] = 246;
                GBFreq[37][62] = 245;
                GBFreq[16][55] = 244;
                GBFreq[18][38] = 243;
                GBFreq[23][23] = 242;

                GBFreq[38][30] = 241;
                GBFreq[17][28] = 240;
                GBFreq[44][73] = 239;
                GBFreq[23][78] = 238;
                GBFreq[40][77] = 237;
                GBFreq[38][87] = 236;
                GBFreq[27][19] = 235;
                GBFreq[38][82] = 234;
                GBFreq[37][22] = 233;
                GBFreq[41][30] = 232;
                GBFreq[54][9] = 231;
                GBFreq[32][30] = 230;
                GBFreq[30][52] = 229;
                GBFreq[40][84] = 228;
                GBFreq[53][57] = 227;
                GBFreq[27][27] = 226;
                GBFreq[38][64] = 225;
                GBFreq[18][43] = 224;
                GBFreq[23][69] = 223;
                GBFreq[28][12] = 222;
                GBFreq[50][78] = 221;
                GBFreq[50][1] = 220;
                GBFreq[26][88] = 219;
                GBFreq[36][40] = 218;
                GBFreq[33][89] = 217;
                GBFreq[41][28] = 216;
                GBFreq[31][77] = 215;
                GBFreq[46][1] = 214;
                GBFreq[47][19] = 213;
                GBFreq[35][55] = 212;
                GBFreq[41][21] = 211;
                GBFreq[27][10] = 210;
                GBFreq[32][77] = 209;
                GBFreq[26][37] = 208;
                GBFreq[20][33] = 207;
                GBFreq[41][52] = 206;
                GBFreq[32][18] = 205;
                GBFreq[38][13] = 204;
                GBFreq[20][18] = 203;
                GBFreq[20][24] = 202;
                GBFreq[45][19] = 201;
                GBFreq[18][53] = 200;

                #endregion
            }

            if (GBKFreq[0] == null)
            {
                for (i = 0; i < 126; i++)
                {
                    GBKFreq[i] = new int[191];
                }

                #region GBKFreq[52][132] = 600;

                GBKFreq[73][135] = 599;
                GBKFreq[49][123] = 598;
                GBKFreq[77][146] = 597;
                GBKFreq[81][123] = 596;
                GBKFreq[82][144] = 595;
                GBKFreq[51][179] = 594;
                GBKFreq[83][154] = 593;
                GBKFreq[71][139] = 592;
                GBKFreq[64][139] = 591;
                GBKFreq[85][144] = 590;
                GBKFreq[52][125] = 589;
                GBKFreq[88][25] = 588;
                GBKFreq[81][106] = 587;
                GBKFreq[81][148] = 586;
                GBKFreq[62][137] = 585;
                GBKFreq[94][0] = 584;
                GBKFreq[1][64] = 583;
                GBKFreq[67][163] = 582;
                GBKFreq[20][190] = 581;
                GBKFreq[57][131] = 580;
                GBKFreq[29][169] = 579;
                GBKFreq[72][143] = 578;
                GBKFreq[0][173] = 577;
                GBKFreq[11][23] = 576;
                GBKFreq[61][141] = 575;
                GBKFreq[60][123] = 574;
                GBKFreq[81][114] = 573;
                GBKFreq[82][131] = 572;
                GBKFreq[67][156] = 571;
                GBKFreq[71][167] = 570;
                GBKFreq[20][50] = 569;
                GBKFreq[77][132] = 568;
                GBKFreq[84][38] = 567;
                GBKFreq[26][29] = 566;
                GBKFreq[74][187] = 565;
                GBKFreq[62][116] = 564;
                GBKFreq[67][135] = 563;
                GBKFreq[5][86] = 562;
                GBKFreq[72][186] = 561;
                GBKFreq[75][161] = 560;
                GBKFreq[78][130] = 559;
                GBKFreq[94][30] = 558;
                GBKFreq[84][72] = 557;
                GBKFreq[1][67] = 556;
                GBKFreq[75][172] = 555;
                GBKFreq[74][185] = 554;
                GBKFreq[53][160] = 553;
                GBKFreq[123][14] = 552;
                GBKFreq[79][97] = 551;
                GBKFreq[85][110] = 550;
                GBKFreq[78][171] = 549;
                GBKFreq[52][131] = 548;
                GBKFreq[56][100] = 547;
                GBKFreq[50][182] = 546;
                GBKFreq[94][64] = 545;
                GBKFreq[106][74] = 544;
                GBKFreq[11][102] = 543;
                GBKFreq[53][124] = 542;
                GBKFreq[24][3] = 541;
                GBKFreq[86][148] = 540;
                GBKFreq[53][184] = 539;
                GBKFreq[86][147] = 538;
                GBKFreq[96][161] = 537;
                GBKFreq[82][77] = 536;
                GBKFreq[59][146] = 535;
                GBKFreq[84][126] = 534;
                GBKFreq[79][132] = 533;
                GBKFreq[85][123] = 532;
                GBKFreq[71][101] = 531;
                GBKFreq[85][106] = 530;
                GBKFreq[6][184] = 529;
                GBKFreq[57][156] = 528;
                GBKFreq[75][104] = 527;
                GBKFreq[50][137] = 526;
                GBKFreq[79][133] = 525;
                GBKFreq[76][108] = 524;
                GBKFreq[57][142] = 523;
                GBKFreq[84][130] = 522;
                GBKFreq[52][128] = 521;
                GBKFreq[47][44] = 520;
                GBKFreq[52][152] = 519;
                GBKFreq[54][104] = 518;
                GBKFreq[30][47] = 517;
                GBKFreq[71][123] = 516;
                GBKFreq[52][107] = 515;
                GBKFreq[45][84] = 514;
                GBKFreq[107][118] = 513;
                GBKFreq[5][161] = 512;
                GBKFreq[48][126] = 511;
                GBKFreq[67][170] = 510;
                GBKFreq[43][6] = 509;
                GBKFreq[70][112] = 508;
                GBKFreq[86][174] = 507;
                GBKFreq[84][166] = 506;
                GBKFreq[79][130] = 505;
                GBKFreq[57][141] = 504;
                GBKFreq[81][178] = 503;
                GBKFreq[56][187] = 502;
                GBKFreq[81][162] = 501;
                GBKFreq[53][104] = 500;
                GBKFreq[123][35] = 499;
                GBKFreq[70][169] = 498;
                GBKFreq[69][164] = 497;
                GBKFreq[109][61] = 496;
                GBKFreq[73][130] = 495;
                GBKFreq[62][134] = 494;
                GBKFreq[54][125] = 493;
                GBKFreq[79][105] = 492;
                GBKFreq[70][165] = 491;
                GBKFreq[71][189] = 490;
                GBKFreq[23][147] = 489;
                GBKFreq[51][139] = 488;
                GBKFreq[47][137] = 487;
                GBKFreq[77][123] = 486;
                GBKFreq[86][183] = 485;
                GBKFreq[63][173] = 484;
                GBKFreq[79][144] = 483;
                GBKFreq[84][159] = 482;
                GBKFreq[60][91] = 481;
                GBKFreq[66][187] = 480;
                GBKFreq[73][114] = 479;
                GBKFreq[85][56] = 478;
                GBKFreq[71][149] = 477;
                GBKFreq[84][189] = 476;
                GBKFreq[104][31] = 475;
                GBKFreq[83][82] = 474;
                GBKFreq[68][35] = 473;
                GBKFreq[11][77] = 472;
                GBKFreq[15][155] = 471;
                GBKFreq[83][153] = 470;
                GBKFreq[71][1] = 469;
                GBKFreq[53][190] = 468;
                GBKFreq[50][135] = 467;
                GBKFreq[3][147] = 466;
                GBKFreq[48][136] = 465;
                GBKFreq[66][166] = 464;
                GBKFreq[55][159] = 463;
                GBKFreq[82][150] = 462;
                GBKFreq[58][178] = 461;
                GBKFreq[64][102] = 460;
                GBKFreq[16][106] = 459;
                GBKFreq[68][110] = 458;
                GBKFreq[54][14] = 457;
                GBKFreq[60][140] = 456;
                GBKFreq[91][71] = 455;
                GBKFreq[54][150] = 454;
                GBKFreq[78][177] = 453;
                GBKFreq[78][117] = 452;
                GBKFreq[104][12] = 451;
                GBKFreq[73][150] = 450;
                GBKFreq[51][142] = 449;
                GBKFreq[81][145] = 448;
                GBKFreq[66][183] = 447;
                GBKFreq[51][178] = 446;
                GBKFreq[75][107] = 445;
                GBKFreq[65][119] = 444;
                GBKFreq[69][176] = 443;
                GBKFreq[59][122] = 442;
                GBKFreq[78][160] = 441;
                GBKFreq[85][183] = 440;
                GBKFreq[105][16] = 439;
                GBKFreq[73][110] = 438;
                GBKFreq[104][39] = 437;
                GBKFreq[119][16] = 436;
                GBKFreq[76][162] = 435;
                GBKFreq[67][152] = 434;
                GBKFreq[82][24] = 433;
                GBKFreq[73][121] = 432;
                GBKFreq[83][83] = 431;
                GBKFreq[82][145] = 430;
                GBKFreq[49][133] = 429;
                GBKFreq[94][13] = 428;
                GBKFreq[58][139] = 427;
                GBKFreq[74][189] = 426;
                GBKFreq[66][177] = 425;
                GBKFreq[85][184] = 424;

                GBKFreq[55][183] = 423;
                GBKFreq[71][107] = 422;
                GBKFreq[11][98] = 421;
                GBKFreq[72][153] = 420;
                GBKFreq[2][137] = 419;
                GBKFreq[59][147] = 418;
                GBKFreq[58][152] = 417;
                GBKFreq[55][144] = 416;
                GBKFreq[73][125] = 415;
                GBKFreq[52][154] = 414;
                GBKFreq[70][178] = 413;
                GBKFreq[79][148] = 412;
                GBKFreq[63][143] = 411;
                GBKFreq[50][140] = 410;
                GBKFreq[47][145] = 409;
                GBKFreq[48][123] = 408;
                GBKFreq[56][107] = 407;
                GBKFreq[84][83] = 406;
                GBKFreq[59][112] = 405;
                GBKFreq[124][72] = 404;
                GBKFreq[79][99] = 403;
                GBKFreq[3][37] = 402;
                GBKFreq[114][55] = 401;
                GBKFreq[85][152] = 400;
                GBKFreq[60][47] = 399;
                GBKFreq[65][96] = 398;
                GBKFreq[74][110] = 397;
                GBKFreq[86][182] = 396;
                GBKFreq[50][99] = 395;
                GBKFreq[67][186] = 394;
                GBKFreq[81][74] = 393;
                GBKFreq[80][37] = 392;
                GBKFreq[21][60] = 391;
                GBKFreq[110][12] = 390;
                GBKFreq[60][162] = 389;
                GBKFreq[29][115] = 388;
                GBKFreq[83][130] = 387;
                GBKFreq[52][136] = 386;
                GBKFreq[63][114] = 385;
                GBKFreq[49][127] = 384;
                GBKFreq[83][109] = 383;
                GBKFreq[66][128] = 382;
                GBKFreq[78][136] = 381;
                GBKFreq[81][180] = 380;
                GBKFreq[76][104] = 379;
                GBKFreq[56][156] = 378;
                GBKFreq[61][23] = 377;
                GBKFreq[4][30] = 376;
                GBKFreq[69][154] = 375;
                GBKFreq[100][37] = 374;
                GBKFreq[54][177] = 373;
                GBKFreq[23][119] = 372;
                GBKFreq[71][171] = 371;
                GBKFreq[84][146] = 370;
                GBKFreq[20][184] = 369;
                GBKFreq[86][76] = 368;
                GBKFreq[74][132] = 367;
                GBKFreq[47][97] = 366;
                GBKFreq[82][137] = 365;
                GBKFreq[94][56] = 364;
                GBKFreq[92][30] = 363;
                GBKFreq[19][117] = 362;
                GBKFreq[48][173] = 361;
                GBKFreq[2][136] = 360;
                GBKFreq[7][182] = 359;
                GBKFreq[74][188] = 358;
                GBKFreq[14][132] = 357;
                GBKFreq[62][172] = 356;
                GBKFreq[25][39] = 355;
                GBKFreq[85][129] = 354;
                GBKFreq[64][98] = 353;
                GBKFreq[67][127] = 352;
                GBKFreq[72][167] = 351;
                GBKFreq[57][143] = 350;
                GBKFreq[76][187] = 349;
                GBKFreq[83][181] = 348;
                GBKFreq[84][10] = 347;
                GBKFreq[55][166] = 346;
                GBKFreq[55][188] = 345;
                GBKFreq[13][151] = 344;
                GBKFreq[62][124] = 343;
                GBKFreq[53][136] = 342;
                GBKFreq[106][57] = 341;
                GBKFreq[47][166] = 340;
                GBKFreq[109][30] = 339;
                GBKFreq[78][114] = 338;
                GBKFreq[83][19] = 337;
                GBKFreq[56][162] = 336;
                GBKFreq[60][177] = 335;
                GBKFreq[88][9] = 334;
                GBKFreq[74][163] = 333;
                GBKFreq[52][156] = 332;
                GBKFreq[71][180] = 331;
                GBKFreq[60][57] = 330;
                GBKFreq[72][173] = 329;
                GBKFreq[82][91] = 328;
                GBKFreq[51][186] = 327;
                GBKFreq[75][86] = 326;
                GBKFreq[75][78] = 325;
                GBKFreq[76][170] = 324;
                GBKFreq[60][147] = 323;
                GBKFreq[82][75] = 322;
                GBKFreq[80][148] = 321;
                GBKFreq[86][150] = 320;
                GBKFreq[13][95] = 319;
                GBKFreq[0][11] = 318;
                GBKFreq[84][190] = 317;
                GBKFreq[76][166] = 316;
                GBKFreq[14][72] = 315;
                GBKFreq[67][144] = 314;
                GBKFreq[84][44] = 313;
                GBKFreq[72][125] = 312;
                GBKFreq[66][127] = 311;
                GBKFreq[60][25] = 310;
                GBKFreq[70][146] = 309;
                GBKFreq[79][135] = 308;
                GBKFreq[54][135] = 307;
                GBKFreq[60][104] = 306;
                GBKFreq[55][132] = 305;
                GBKFreq[94][2] = 304;
                GBKFreq[54][133] = 303;
                GBKFreq[56][190] = 302;
                GBKFreq[58][174] = 301;
                GBKFreq[80][144] = 300;
                GBKFreq[85][113] = 299;

                #endregion
            }
        }
        public static Encoding GetEncoding(string filename)
        {
            var encodingByBOM = GetEncodingByBOM(filename);
            if (encodingByBOM != null)
                return encodingByBOM;

            
            var encodingByParsingUTF8 = GetEncodingByParsing(filename, Encoding.UTF8);
            if (encodingByParsingUTF8 != null)
                return encodingByParsingUTF8;

            var encodingByParsingGBK = GetEncodingByParsing(filename, Encoding.GetEncoding("GBK"));
            if (encodingByParsingGBK != null)
                return encodingByParsingGBK;

            var encodingByParsingGB2312 = GetEncodingByParsing(filename, Encoding.GetEncoding("GB2312"));
            if (encodingByParsingGB2312 != null)
                return encodingByParsingGB2312;

            var encodingByParsingLatin1 = GetEncodingByParsing(filename, Encoding.GetEncoding("iso-8859-1"));
            if (encodingByParsingLatin1 != null)
                return encodingByParsingLatin1;

            var encodingByParsingUTF7 = GetEncodingByParsing(filename, Encoding.UTF7);
            if (encodingByParsingUTF7 != null)
                return encodingByParsingUTF7;


            return null;   
        }

        
        
        
        
        
        private static Encoding GetEncodingByBOM(string filename)
        {
            
            var byteOrderMark = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(byteOrderMark, 0, 4);
            }

            
            if (byteOrderMark[0] == 0x2b && byteOrderMark[1] == 0x2f && byteOrderMark[2] == 0x76) return Encoding.UTF7;
            if (byteOrderMark[0] == 0xef && byteOrderMark[1] == 0xbb && byteOrderMark[2] == 0xbf) return Encoding.UTF8;
            if (byteOrderMark[0] == 0xff && byteOrderMark[1] == 0xfe) return Encoding.Unicode; 
            if (byteOrderMark[0] == 0xfe && byteOrderMark[1] == 0xff) return Encoding.BigEndianUnicode; 
            if (byteOrderMark[0] == 0 && byteOrderMark[1] == 0 && byteOrderMark[2] == 0xfe && byteOrderMark[3] == 0xff) return Encoding.UTF32;

            return null;    
        }

        private static Encoding GetEncodingByParsing(string filename, Encoding encoding)
        {
            var encodingVerifier = Encoding.GetEncoding(encoding.BodyName, new EncoderExceptionFallback(), new DecoderExceptionFallback());

            try
            {
                using (var textReader = new StreamReader(filename, encodingVerifier, detectEncodingFromByteOrderMarks: true))
                {
                    while (!textReader.EndOfStream)
                    {
                        textReader.ReadLine();   
                    }

                    
                    return textReader.CurrentEncoding;
                }
            }
            catch (Exception ex) { }

            return null;    
        }

        public static long FileLength(System.IO.FileInfo file)
        {
            if (System.IO.Directory.Exists(file.FullName))
                return 0;
            else
                return file.Length;
        }


        
        
        
        
        
        public static long Identity(long literal)
        {
            return literal;
        }

        
        
        
        
        
        public static ulong Identity(ulong literal)
        {
            return literal;
        }

        
        
        
        
        
        public static float Identity(float literal)
        {
            return literal;
        }

        
        
        
        
        
        public static double Identity(double literal)
        {
            return literal;
        }

        internal virtual int GB2312Probability(sbyte[] rawtext)
        {
            int i, rawtextlen = 0;

            int dbchars = 1, gbchars = 1;
            long gbfreq = 0, totalfreq = 1;
            float rangeval = 0, freqval = 0;
            int row, column;

            

            rawtextlen = rawtext.Length;
            for (i = 0; i < rawtextlen - 1; i++)
            {
                if (rawtext[i] >= 0)
                {
                    
                }
                else
                {
                    dbchars++;
                    if ((sbyte)Identity(0xA1) <= rawtext[i] && rawtext[i] <= (sbyte)Identity(0xF7) && (sbyte)Identity(0xA1) <= rawtext[i + 1] && rawtext[i + 1] <= (sbyte)Identity(0xFE))
                    {
                        gbchars++;
                        totalfreq += 500;
                        row = rawtext[i] + 256 - 0xA1;
                        column = rawtext[i + 1] + 256 - 0xA1;
                        if (GBFreq[row][column] != 0)
                        {
                            gbfreq += GBFreq[row][column];
                        }
                        else if (15 <= row && row < 55)
                        {
                            gbfreq += 200;
                        }
                    }
                    i++;
                }
            }

            rangeval = 50 * ((float)gbchars / (float)dbchars);
            freqval = 50 * ((float)gbfreq / (float)totalfreq);


            return (int)(rangeval + freqval);
        }


        internal virtual int GBKProbability(sbyte[] rawtext)
        {
            int i, rawtextlen = 0;

            int dbchars = 1, gbchars = 1;
            long gbfreq = 0, totalfreq = 1;
            float rangeval = 0, freqval = 0;
            int row, column;

            
            rawtextlen = rawtext.Length;
            for (i = 0; i < rawtextlen - 1; i++)
            {
                if (rawtext[i] >= 0)
                {
                    
                }
                else
                {
                    dbchars++;
                    if ((sbyte)Identity(0xA1) <= rawtext[i] && rawtext[i] <= (sbyte)Identity(0xF7) && (sbyte)Identity(0xA1) <= rawtext[i + 1] && rawtext[i + 1] <= (sbyte)Identity(0xFE))
                    {
                        gbchars++;
                        totalfreq += 500;
                        row = rawtext[i] + 256 - 0xA1;
                        column = rawtext[i + 1] + 256 - 0xA1;

                        if (GBFreq[row][column] != 0)
                        {
                            gbfreq += GBFreq[row][column];
                        }
                        else if (15 <= row && row < 55)
                        {
                            gbfreq += 200;
                        }
                    }
                    else if ((sbyte)Identity(0x81) <= rawtext[i] && rawtext[i] <= (sbyte)Identity(0xFE) && (((sbyte)Identity(0x80) <= rawtext[i + 1] && rawtext[i + 1] <= (sbyte)Identity(0xFE)) || ((sbyte)0x40 <= rawtext[i + 1] && rawtext[i + 1] <= (sbyte)0x7E)))
                    {
                        gbchars++;
                        totalfreq += 500;
                        row = rawtext[i] + 256 - 0x81;
                        if (0x40 <= rawtext[i + 1] && rawtext[i + 1] <= 0x7E)
                        {
                            column = rawtext[i + 1] - 0x40;
                        }
                        else
                        {
                            column = rawtext[i + 1] + 256 - 0x80;
                        }

                        if (GBKFreq[row][column] != 0)
                        {
                            gbfreq += GBKFreq[row][column];
                        }
                    }
                    i++;
                }
            }

            rangeval = 50 * ((float)gbchars / (float)dbchars);
            freqval = 50 * ((float)gbfreq / (float)totalfreq);

            return (int)(rangeval + freqval) - 1;
        }
    }
}