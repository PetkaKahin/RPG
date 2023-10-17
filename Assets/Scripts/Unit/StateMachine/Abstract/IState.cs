using System.Xml.Serialization;

namespace Unit
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}
