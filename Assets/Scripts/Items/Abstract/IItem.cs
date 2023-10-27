using System;

namespace Items
{
    public interface IItem
    {
        event Action UseCompleted;

        void Use();
    }
}