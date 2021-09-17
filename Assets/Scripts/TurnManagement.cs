using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManagement : MonoBehaviour
{
    public string active_unit;
    public List<CombatUnit> Combatants;

    public static TurnManagement instance;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    static int SortByScore(CombatUnit p1, CombatUnit p2)
    {
        return p1.turn_placement.CompareTo(p2.turn_placement);
    }

    private void Start()
    {
        Combatants.Sort(SortByScore);
        //print(SortByScore(Combatants[0].GetComponent<CombatUnit>(), Combatants[1].GetComponent<CombatUnit>()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
