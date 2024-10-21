using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFactory : ICharFactory
{
    public IChar Create(CharRequirements requirements)
    {
        if (requirements.season == 0) //winter
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaFruh();
                }
                else //female
                {
                    return new FeFruh();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaWinn();
                }
                else //female
                {
                    return new FeWinn();
                }
            }
        }
        else if (requirements.season == 2) //spring
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaSomm();
                }
                else //female
                {
                    return new FeSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaFruh();
                }
                else //female
                {
                    return new FeFruh();
                }
            }
        }
        else if (requirements.season == 3) //summer
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaSomm();
                }
                else //female
                {
                    return new FeSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaHerbst();
                }
                else //female
                {
                    return new FeHerbst();
                }
            }
        }
        else //fall
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaHerbst();
                }
                else //female
                {
                    return new FeHerbst();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaWinn();
                }
                else //female
                {
                    return new FeWinn();
                }
            }
        }
    }
}
