using System;

public static class EventBus
{
    public static event Action Idle;
    public static event Action Move;
    public static event Action Dash;

    public static event Action UseItem;
    public static event Action Attack;
}
