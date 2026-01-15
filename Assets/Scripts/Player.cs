using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        HandleMovement();
        HandlePlanting();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0f).normalized;
        _playerTransform.Translate(direction * _speed * Time.deltaTime);
    }
    private void HandlePlanting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }
    public void PlantSeed ()
    {
        if (_numSeedsLeft <= 0)
        {
            return;
        }
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

        _numSeedsLeft--;
        _numSeedsPlanted++;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
