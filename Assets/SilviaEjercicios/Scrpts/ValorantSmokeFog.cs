using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering; 

public class ValorantSmokeFog : VolumeComponent

{
    public ColorParameter color = new ColorParameter (Color.white);
    public FloatParameter fogStart = new FloatParameter (3);
    public FloatParameter fogEnd = new FloatParameter (5);

}
