using Newtonsoft.Json;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateStacks : MonoBehaviour
{
    private int blocksix = 0;
    private int floorsix = 0;
    private int blockseven = 0;
    private int floorseven = 0;
    private int blockeight = 0;
    private int flooreight = 0;
    private int i = 0;
    
    public class JengaBlock
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string grade { get; set; }
        public int mastery { get; set; }
        public string domainid { get; set; }
        public string domain { get; set; }
        public string cluster { get; set; }
        public string standardid { get; set; }
        public string standarddescription { get; set; }
    }

    public GameObject jengaPrefab;
    public Material[] material;
    Renderer rend;
    private float dpm = .7f;
    private string url = "https://ga1vqcu3o1.execute-api.us-east-1.amazonaws.com/Assessment/stack";

    // Start is called before the first frame update
    void Start()
    {
        GetData();        
    }

    public void GetData()
    {
        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string url){


        
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(request.error);
            }
            else
            {
                List<JengaBlock> blocksinitial = JsonConvert.DeserializeObject<List<JengaBlock>>(request.downloadHandler.text);
                List<JengaBlock> blocks = blocksinitial.OrderBy(x => x.grade).ThenBy(x => x.domain).ThenBy(x => x.cluster).ThenBy(x => x.standardid).ToList();
                foreach(var block in blocks){
                    if(block.grade == "6th Grade"){
                        i = blocksix % 3;
                        if(floorsix % 2 == 0){
                            GameObject bk = Instantiate(jengaPrefab, new Vector3((-4.3f + i * dpm), 0.2f + floorsix * 0.4f, .5F), Quaternion.identity);
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }   
                        else{
                            GameObject bk = Instantiate(jengaPrefab, new Vector3(-3.6f, 0.2f + floorsix * 0.4f, (-0.2f + i * dpm)), Quaternion.Euler(new Vector3(0, 90, 0)));
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }
                        blocksix++;
                        if(blocksix % 3 == 0)
                            floorsix++;
                    }
                    else if(block.grade == "7th Grade"){
                        i = blockseven % 3;
                        if(floorseven % 2 == 0){
                            GameObject bk = Instantiate(jengaPrefab, new Vector3((-0.3f + i * dpm), 0.2f + floorseven * 0.4f, .5F), Quaternion.identity);
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }   
                        else{
                            GameObject bk = Instantiate(jengaPrefab, new Vector3(0.4f, 0.2f + floorseven * 0.4f, (-0.2f + i * dpm)), Quaternion.Euler(new Vector3(0, 90, 0)));
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }
                        blockseven++;
                        if(blockseven % 3 == 0)
                            floorseven++;
                    }
                    else if(block.grade == "8th Grade"){
                        i = blockeight % 3;
                        if(flooreight % 2 == 0){
                            GameObject bk = Instantiate(jengaPrefab, new Vector3((3.6f + i * dpm), 0.2f + flooreight * 0.4f, .5F), Quaternion.identity);
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }   
                        else{
                            GameObject bk = Instantiate(jengaPrefab, new Vector3(4.3f, 0.2f + flooreight * 0.4f, (-0.2f + i * dpm)), Quaternion.Euler(new Vector3(0, 90, 0)));
                            bk.name = "Block" + block.id;
                            rend = bk.GetComponent<Renderer>();
                            rend.enabled = true;
                            rend.sharedMaterial = material[block.mastery];
                            BlockData b = bk.GetComponent("BlockData") as BlockData;
                            b.grade = block.grade;
                            b.domain = block.domain;
                            b.cluster = block.cluster;
                            b.standardid = block.standardid;
                            b.standarddescription = block.standarddescription;
                        }
                        blockeight++;
                        if(blockeight % 3 == 0)
                            flooreight++;
                    }
                    
                }
            }

        }
    }
}
