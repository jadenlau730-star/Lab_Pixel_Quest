using UnityEngine;

public class HW2PlayerShoot1 : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpawn;


    private const float STimer = 2f;
    private float _Scurrenttimer = 2f;
    private bool _ScanShoot = true;

    private void SUpdate()
    {
    
        STimerMethod();

        SShoot();
    }

    private void STimerMethod()
    {
       if (!_ScanShoot)
        {
          _Scurrenttimer -= Time.deltaTime;
   
            if (_Scurrenttimer <= 0)
           {
               _ScanShoot = true;
                _Scurrenttimer = STimer;
            }
        }
    }


    private void SShoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _ScanShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _ScanShoot = false;
        }
    }

}
