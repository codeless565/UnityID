using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface SkillBase{

    void SkillCall();
    float GetManaCost();
    float GetDamage();

    int GetLevel();
    int GetRankupCost();

    Sprite GetSkillImage();
    string GetName();
    string GetDescription();

    void RankUp();

}
