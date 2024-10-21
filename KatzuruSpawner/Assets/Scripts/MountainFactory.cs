using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainFactory : ICharFactory
{
    public IChar Create(CharRequirements requirements)
    {
        if (requirements.season == 0) //winter
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleFruh();
                }
                else //female
                {
                    return new FemaleFruh();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleWinn();
                }
                else //female
                {
                    return new FemaleWinn();
                }
            }
        }
        else if (requirements.season == 2) //spring
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleSomm();
                }
                else //female
                {
                    return new FemaleSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleFruh();
                }
                else //female
                {
                    return new FemaleFruh();
                }
            }
        }
        else if (requirements.season == 3) //summer
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleSomm();
                }
                else //female
                {
                    return new FemaleSomm();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleHerbst();
                }
                else //female
                {
                    return new FemaleHerbst();
                }
            }
        }
        else //fall
        {
            if (requirements.temp == 0) //warm
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleHerbst();
                }
                else //female
                {
                    return new FemaleHerbst();
                }
            }
            else //cold
            {
                if (requirements.gender == 0) //male
                {
                    return new MaleWinn();
                }
                else //female
                {
                    return new FemaleWinn();
                }
            }
        }
    }
}
