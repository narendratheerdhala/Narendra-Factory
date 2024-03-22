using UnityEngine;
using realvirtual;
using TMPro;

public class NodeWriter : MonoBehaviour
{
    [Header("Factory Machine")]
    public int factoryMachineID;
    public OPCUA_Interface oPCUAinterface;

    //[Header("OPCUA Reader")]
    //public string nodeBeingMonitored;
    //public string nodeID;
    //public string dataFromOPCUANode;

    // Start is called before the first frame update

    public string startNode;
    public string stopNode;

    private bool _machineStopped;

    public TextMeshProUGUI buttonText;

    void Start()
    {
        oPCUAinterface.EventOnConnected.AddListener(OnInterfaceConnected);
        oPCUAinterface.EventOnDisconnected.AddListener(OnInterfaceDisconnected);

        _machineStopped = true;
    }

    private void OnInterfaceConnected()
    {
        Debug.Log("Node Writer connected to Factory Machine " + factoryMachineID);
    }

    private void OnInterfaceDisconnected()
    {
        Debug.LogWarning("Node Writer for Factory Machine " + factoryMachineID + " has disconnected");
    }
    
    public void WriteNodeToFalse(string nodeID)
    {
        oPCUAinterface.WriteNodeValue(nodeID, false);
    }

    public void WriteNodeToTrue(string nodeID)
    {
        oPCUAinterface.WriteNodeValue(nodeID, true);
    }

    public void ToggleStartStop()
    {
      

        if(_machineStopped)
        {
            oPCUAinterface.WriteNodeValue(stopNode, false);

            oPCUAinterface.WriteNodeValue(startNode, true);

            _machineStopped = false;

            buttonText.text = "Stop";
        }
        else
        {
            oPCUAinterface.WriteNodeValue(stopNode, true);

            oPCUAinterface.WriteNodeValue(startNode, false);


            _machineStopped = true;

            buttonText.text = "Start";


        }
    }

    //ns=3;s="dbVar"."Hmi"."Btn"."Stop"."xBit"
    //ns=3;s="dbVar"."Hmi"."Btn"."Start"."xBit"

}
