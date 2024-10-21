using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladeFactory : ICharFactory
{
    public IChar Create(CharRequirements requirements)
    {
        if (requirements.season == 0) //winter
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MFruh();
                }
                else //female
                {
                    return new FFruh();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MWinn();
                }
                else //female
                {
                    return new FWinn();
                }
            }
        }
        else if (requirements.season == 2) //spring
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MSomm();
                }
                else //female
                {
                    return new FSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MFruh();
                }
                else //female
                {
                    return new FFruh();
                }
            }
        }
        else if (requirements.season == 3) //summer
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MSomm();
                }
                else //female
                {
                    return new FSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MHerbst();
                }
                else //female
                {
                    return new FHerbst();
                }
            }
        }
        else //fall
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MHerbst();
                }
                else //female
                {
                    return new FHerbst();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MWinn();
                }
                else //female
                {
                    return new FWinn();
                }
            }
        }
    }
}
