using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUIHandler : MonoBehaviour
{
    public SpriteRenderer current_health_tens;
    public SpriteRenderer current_health_ones;
    public SpriteRenderer max_health_tens;
    public SpriteRenderer max_health_ones;
    public SpriteRenderer current_stamina_tens;
    public SpriteRenderer current_stamina_ones;
    public SpriteRenderer max_stamina_tens;
    public SpriteRenderer max_stamina_ones;

    public Sprite[] num_sprites = new Sprite[10];


    private void UpdateUI(SpriteRenderer tens_place, SpriteRenderer ones_place, int stat_number)
    {
        if(stat_number/10 == 0)
        {
            tens_place.sprite = null;
        }

        else
        {
            tens_place.sprite = num_sprites[stat_number / 10];
        }
        ones_place.sprite = num_sprites[stat_number % 10];
    }

    public void UpdateCurrentHealth(int current_health)
    {
        UpdateUI(current_health_tens, current_health_ones, current_health);
    }

    public void UpdateMaxHealth(int max_health)
    {
        UpdateUI(max_health_tens, max_health_ones, max_health);
    }

    public void UpdateCurrentStamina(int current_stamina)
    {
        UpdateUI(current_stamina_tens, current_stamina_ones, current_stamina);
    }

    public void UpdateMaxStamina(int max_stamina)
    {
        UpdateUI(max_stamina_tens, max_stamina_ones, max_stamina);
    }
}
