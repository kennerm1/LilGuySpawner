using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFactory : AbstractCharFactory
{
    private readonly ICharFactory _factory;
    private readonly CharRequirements _requirements;

    public CharFactory(CharRequirements requirements)
    {
        switch (requirements.season) //Choose season
        {
            case 1:
                _factory = new MountainFactory();
                break;
            case 2:
                _factory = new GladeFactory();
                break;
            case 3:
                _factory = new OceanFactory();
                break;
            case 4:
                _factory = new ForestFactory();
                break;
        }
        _requirements = requirements;
    }

    public override IChar Create()
    {
        return _factory.Create(_requirements);
    }
}
