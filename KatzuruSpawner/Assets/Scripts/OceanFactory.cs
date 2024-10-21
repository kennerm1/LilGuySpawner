using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFactory : ICharFactory
{
    public IChar Create(CharRequirements requirements)
    {
        if (requirements.season == 0) //winter
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MalFruh();
                }
                else //female
                {
                    return new FemFruh();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MalWinn();
                }
                else //female
                {
                    return new FemWinn();
                }
            }
        }
        else if (requirements.season == 2) //spring
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MalSomm();
                }
                else //female
                {
                    return new FemSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MalFruh();
                }
                else //female
                {
                    return new FemFruh();
                }
            }
        }
        else if (requirements.season == 3) //summer
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MalSomm();
                }
                else //female
                {
                    return new FemSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MalHerbst();
                }
                else //female
                {
                    return new FemHerbst();
                }
            }
        }
        else //fall
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MalHerbst();
                }
                else //female
                {
                    return new FemHerbst();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MalWinn();
                }
                else //female
                {
                    return new FemWinn();
                }
            }
        }
    }
}
