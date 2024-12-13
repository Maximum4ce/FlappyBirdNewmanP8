public class GameControl : MonoBehaviour
{
    public GameObject gameOverText;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BirdDied ()
    {
        gameOverText.setActive(true);
        gameOver = true;
    }
}
