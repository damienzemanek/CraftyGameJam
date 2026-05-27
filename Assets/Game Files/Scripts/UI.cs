using UnityEngine;

public class UI : Singleton<UI>
{
    public GameObject deathScreen;

    protected override void Awake()
    {
        base.Awake();
        deathScreen.SetActive(false);
    }
}
