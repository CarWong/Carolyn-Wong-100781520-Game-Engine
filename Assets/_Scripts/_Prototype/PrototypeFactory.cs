using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrototypeFactory : MonoBehaviour
{
    public List<CollectableData> allData;

    public GameObject buttonPanel;
    public GameObject buttonPrefab;

    private EditorManager editor;

    Coin coinPrototype;
    BlueGem bluePrototype;
    GreenGem greenPrototype;
    PinkGem pinkPrototype;
    FullHeart heartProtoype;

    private void Start()
    {
        editor = EditorManager.instance;

        coinPrototype = new Coin(allData[0]._prefab, allData[0]._score);
        bluePrototype = new BlueGem(allData[1]._prefab, allData[1]._score);
        greenPrototype = new GreenGem(allData[2]._prefab, allData[2]._score);
        pinkPrototype = new PinkGem(allData[3]._prefab, allData[3]._score);
        heartProtoype = new FullHeart(allData[4]._prefab, allData[4]._heal);

        for(int i = 0; i< allData.Count; i++)
        {
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonPanel.transform);
            button.gameObject.name = allData[i]._name + " Button";
            button.GetComponentInChildren<TextMeshProUGUI>().text = allData[i]._name;
            button.GetComponent<Button>().onClick.AddListener(delegate { Spawner(button); });
        }
    }

    void Spawner(GameObject button)
    {
        var btn = button.GetComponentInChildren<TextMeshProUGUI>();

        switch (btn.text)
        {
            case "Coin":
                editor.item = coinPrototype.Clone().Spawn();
                break;
            case "BlueGem":
                editor.item = bluePrototype.Clone().Spawn();
                break;
            case "GreenGem":
                editor.item = greenPrototype.Clone().Spawn();
                break;
            case "PinKGem":
                editor.item = pinkPrototype.Clone().Spawn();
                break;
            case "FullHeart":
                editor.item = heartProtoype.Clone().Spawn();
                break;
            default:
                break;
        }
        editor.instantiated = true;
    }
}
