using Game.Scripts;
// "using System.Collections;" removed.
using UnityEngine;
// "using System.Collections.Generic;" removed.

// Should we add a namespace? Game.Scripts?
// Should we add regions?

public class FixStylesErrors : MonoBehaviour
{

    public DataClass myCustomData; // "customData" renamed to "myCustomData" / See "new DataClass()" in Start().
    internal string customName = "fixStylesErrors";
    protected SampleScript mySampleScript; // "sampleScript" renamed to "mySampleScript" / See GetComponent() in LateUpdate().
    private Collider _myCustomCollider; // "myCustomCollider" renamed to "_myCustomCollider" / It's private!

    private void Start()
    {
        myCustomData = new DataClass(); // Should we move this line to an Awake method?
        myCustomData.sample = 2;
    }

    private void FixedUpdate() // Remove?
    {

    }

    private void Update()
    {
        _myCustomCollider = GetComponent<Collider>(); // Should we move this line to an Awake method?
    }

    private void LateUpdate()
    {
        mySampleScript = GetComponent<SampleScript>(); // Should we move this line to an Awake method?
    }

    public string SampleParamsFunction(string value)
    {
        return $"Hello, {value}";
    }

    private void SimpleFunction() // "simpleFunction" renamed to "SimpleFunction" / Method names always in PascalCase!
    {

    }

}

public class DataClass
{
    public int sample;
}
