using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float _currenttimer = 0.5f;
    private bool _canShoot = true;
    

    private void Update()
    {
        TimerMethod();

        Shoot();

      
    }

    private void TimerMethod()
    {
       if (!_canShoot)
        {
          _currenttimer -= Time.deltaTime;
   
            if (_currenttimer <= 0)
           {
               _canShoot = true;
                _currenttimer = Timer;
            }
        }
    }


    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }

}
