using UnityEngine;

namespace SCP_Universal_Cheat
{
    public class Loader
    {
        public static void Init()
        {
            Loader.Load = new GameObject();
            Loader.Load.AddComponent<SUC>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }
 
        private static GameObject Load;
    }

    public class SUC : MonoBehaviour
    {
    }
}