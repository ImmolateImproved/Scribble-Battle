using UnityEngine;

namespace DI
{
    public class MyAwesomeProjectService
    {

    }

    public class MySceneService
    {
        private readonly MyAwesomeProjectService projectService;

        public MySceneService(MyAwesomeProjectService projectService)
        {
            this.projectService = projectService;
        }
    }

    public class MyFactory
    {
        public MyObject CreateInstance(string id, int param)
        {
            return new MyObject(id, param);
        }
    }

    public class MyObject
    {
        private readonly string id;
        private readonly int param;

        public MyObject(string id, int param)
        {
            this.id = id;
            this.param = param;
        }
    }

    public class DIExample : MonoBehaviour
    {
        private void Awake()
        {
            var projectContainer = new DIContainer();

            projectContainer.RegisterSingleton(c => new MyAwesomeProjectService());
            projectContainer.RegisterSingleton("op1", c => new MyAwesomeProjectService());
            projectContainer.RegisterSingleton("op2", c => new MyAwesomeProjectService());

            var sceneRoot = FindAnyObjectByType<DIExampleScene>();
            sceneRoot.Init(projectContainer);
        }
    }
}