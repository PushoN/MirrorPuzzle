﻿using UnityEngine;

namespace Assets.Prototype.Scripts
{
    public class Util
    {
        // http://scienceprimer.com/javascript-code-convert-light-wavelength-color
        public static Color GetColor(float wavelength)
        {
            float r, g, b, a;
            float wl = wavelength;


            if (wl >= 380 && wl < 440)
            {
                r = -1 * (wl - 440) / (440 - 380);
                g = 0;
                b = 1;
            }
            else if (wl >= 440 && wl < 490)
            {
                r = 0;
                g = (wl - 440) / (490 - 440);
                b = 1;
            }
            else if (wl >= 490 && wl < 510)
            {
                r = 0;
                g = 1;
                b = -1 * (wl - 510) / (510 - 490);
            }
            else if (wl >= 510 && wl < 580)
            {
                r = (wl - 510) / (580 - 510);
                g = 1;
                b = 0;
            }
            else if (wl >= 580 && wl < 645)
            {
                r = 1;
                g = -1 * (wl - 645) / (645 - 580);
                b = 0;
            }
            else if (wl >= 645 && wl <= 780)
            {
                r = 1;
                g = 0;
                b = 0;
            }
            else
            {
                r = 0;
                g = 0;
                b = 0;
            }

            // intensty is lower at the edges of the visible spectrum.
            if (wl > 780 || wl < 380)
            {
                a = 0;
            }
            else if (wl > 700)
            {
                a = (780 - wl) / (780 - 700);
            }
            else if (wl < 420)
            {
                a = (wl - 380) / (420 - 380);
            }
            else
            {
                a = 1;
            }

            return new Color(r, g, b, a);
        }
    }
}

