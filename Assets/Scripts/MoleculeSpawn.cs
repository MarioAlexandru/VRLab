using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeSpawn : MonoBehaviour
{
    
   
    public GameObject empty;
    public GameObject H2O;
    public GameObject NaCl;
    public GameObject propan;
    public GameObject metanol;
    public GameObject metan;
    public GameObject HCl;
    public GameObject etanol;
    public GameObject NH3;
    //-9,2.5,1.5
    //GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    //bullet.GetComponent<BulletScript>().shooter = gameObject;\
    private void Start()
    {
       
    }
    public void spawnH2O()
    {
        GameObject Molecule=Instantiate(H2O, empty.transform.position, Quaternion.identity);
        
        

    }
    public void spawnNaCl()
    {
        GameObject Molecule = Instantiate(NaCl, empty.transform.position, Quaternion.identity);
        
    }
    public void spawnpropan()
    {
        GameObject Molecule = Instantiate(propan, empty.transform.position, Quaternion.identity);
       
    }
    public void spawnmetanol()
    {
        GameObject Molecule = Instantiate(metanol, empty.transform.position, Quaternion.identity);
        
    }
    public void spawnmetan()
    {
        GameObject Molecule = Instantiate(metan, empty.transform.position, Quaternion.identity);
        //Molecule.GetComponent<VerticalBillboard>().target = Xrcamera.transform;
    }
    public void spawnHCl()
    {
        GameObject Molecule = Instantiate(HCl, empty.transform.position, Quaternion.identity);
        
    }
    public void spawnetanol()
    {
        GameObject Molecule = Instantiate(etanol, empty.transform.position, Quaternion.identity);
       
    }
    public void spawnNH3()
    {
        GameObject Molecule = Instantiate(NH3, empty.transform.position, Quaternion.identity);

       
    }
}
