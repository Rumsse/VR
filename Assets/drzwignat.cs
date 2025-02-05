using UnityEngine;

public class drzwignat : MonoBehaviour
{
    public GameObject door;
    public Transform spawnPosition;

    private void SpawnDoor()
    {
        if (door != null && spawnPosition != null)
        {
            // Tworzy drzwi w danej pozycji
            Instantiate(door, spawnPosition.position, spawnPosition.rotation);
        }
        else
        {
            Debug.LogWarning("Brak przypisanego prefabrykatu drzwi lub pozycji spawn!");
        }
    }

}