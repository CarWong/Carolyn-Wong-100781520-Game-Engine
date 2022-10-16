using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class SpikeBall : Observer
{
    GameObject spikeObject;
    SpikeEditorEvents spikeEvent;

    public SpikeBall(GameObject spikeObject, SpikeEditorEvents spikeEvent)
    {
        this.spikeObject = spikeObject;
        this.spikeEvent = spikeEvent;
    }

    public override void OnNotify()
    {
        SpikeColor(spikeEvent.SpikeEditorColor());
    }

    void SpikeColor(Color mat)
    {
        if(spikeObject)
        {
            spikeObject.GetComponent<Renderer>().materials[0].color = mat;
        }
    }
}
