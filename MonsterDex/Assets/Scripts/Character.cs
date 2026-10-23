using System;

// 배열 안의 { } 하나에 대응하는 클래스
[Serializable]
public class Skill
{
    public string name;
    public int damage;
    public float cooldown;
}

// 맨 바깥 { }에 대응하는 클래스. 이 클래스가 곧 바깥 상자라서 따로 감쌀 필요가 없다
[Serializable]
public class Character
{
    public int id;
    public string name;
    public int level;
    public int hp;
    public Skill[] skills;   // JSON의 "skills" 배열과 이름이 같다
}