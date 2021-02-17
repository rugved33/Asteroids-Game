using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpawnerInterface<T>
{   
    void Start();
    void SpawnAtPosition(T type, Vector3 position);
    void Stop();
}