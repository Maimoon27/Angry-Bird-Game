// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class LevelManager : MonoBehaviour
// {
//     public string Scene_Name;
//     public MonScript[] No_OfMonsters;
//     void onEnable()
//     {   
//         No_OfMonsters = FindObjectsOfType<MonScript>();
//     }
//     void Update()
//     {   
//             foreach (MonScript monsters in No_OfMonsters)
//             {
//                 if (monsters != null)
//                 {
//                     return;
//                 }
//             }

//             SceneManager.LoadScene("Level2");
//     }
// }
