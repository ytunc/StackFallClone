using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public LevelSpawn LevelSpawn;
    public int obstacleCount;
    public Slider slider;
    public int value;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ConfigSlider()
    {
        obstacleCount = LevelSpawn.rndCountObstacle;
        slider.maxValue = obstacleCount;
    }

    public void SliderUp()
    {
        value++;
        slider.value = value;
    }

}
