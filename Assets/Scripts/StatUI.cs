using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatUI : MonoBehaviour
{
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

    public BattleUIHandler UIHandler;
  

    public void UpdateCurrentHealth(int delta_health)
    {
        current_health += delta_health;
        UIHandler.UpdateCurrentHealth(current_health);
    }

    public void UpdateMaxHealth(int delta_health)
    {
        max_health += delta_health;
        UIHandler.UpdateMaxHealth(current_health);
    }

    public void UpdateCurrentStamina(int delta_stamina)
    {
        current_stamina += delta_stamina;
        UIHandler.UpdateCurrentStamina(current_stamina);
    }

    public void UpdateMaxStamina(int delta_stamina)
    {
        max_stamina += delta_stamina;
        UIHandler.UpdateMaxStamina(max_stamina);
    }

    // Start is called before the first frame update
    void Start()
    {
        UIHandler.UpdateCurrentHealth(current_health);
        UIHandler.UpdateMaxHealth(max_health);
        UIHandler.UpdateCurrentStamina(current_stamina);
        UIHandler.UpdateMaxStamina(max_stamina);
    }
}
