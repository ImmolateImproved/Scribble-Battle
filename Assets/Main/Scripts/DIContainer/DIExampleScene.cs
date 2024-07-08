using UnityEngine;

namespace DI
{
    public class DIExampleScene : MonoBehaviour
    {
        public void Init(DIContainer projectContainer)
        {
            //var serviceWithoutTag = projectContainer.Resolve<MyAwesomeProjectService>();
            //var serviceTag1 = projectContainer.Resolve<MyAwesomeProjectService>("op1");
            //var serviceTag2 = projectContainer.Resolve<MyAwesomeProjectService>("op2");

            var sceneContainer = new DIContainer(projectContainer);
            sceneContainer.RegisterSingleton(c => new MySceneService(c.Resolve<MyAwesomeProjectService>()));
            sceneContainer.RegisterSingleton(c => new MyFactory());
            sceneContainer.RegisterInstance(new MyObject("test", 5));
        }
    }
}