using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharFactory
{
    IChar Create(CharRequirements requirements);
}
