 
 // Unity Player Fire method
 private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject laser = Instantiate
                (
                laserPrefab, 
                transform.position, 
                Quaternion.identity
                ) as GameObject ;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
        }
    }