using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUnit : MonoBehaviour
{
    public int turn_placement = 0;

    public int level;
    public int current_health;
    public int max_health;
    public int current_stamina;
    public int max_stamina;
    public int current_fire;
    public int max_fire;
    public int current_air;
    public int max_air;
    public int current_water;
    public int max_water;
    public int current_ice;
    public int max_ice;
    public int current_bio;
    public int max_bio;
    public int current_electric;
    public int max_electric;
    public int current_mech;
    public int max_mech;

    // Start is called before the first frame update
    void Start()
    {
        TurnManagement.instance.Combatants.Add(this);
        current_health = max_health; // For the ENEMIES ONLY
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void register_influence(int action_influence)
    {
        current_health += action_influence;
    }

    void Attack()
    {

    }
}
