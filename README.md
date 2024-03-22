# Information Machines - Factory 4.0

Information Machines is a Unity project designed for connecting to the Festo factory machine using OPC UA communication. This project aims to enable seamless integration with the Festo factory machine, providing a bridge between Unity applications and the industrial environment.

## Key Features

- **TCP Client-Server Communication:** Utilizes TCP client-server communication to establish a connection between Unity applications and the Festo factory machine.
- **OPC UA Integration:** Leverages OPC UA interfaces to communicate with the industrial machines, allowing for real-time data exchange.
- **Monitoring and Control:** Monitors and controls various aspects of the factory machine, including reading data from OPC UA nodes and sending orders.

## Unity Version

This project is developed and tested on Unity version 2022.3.18. Ensure that you are using a compatible Unity version for optimal functionality.

## Getting Started

To get started with Information Machines, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Unity 2022.3.18 or a compatible version.
3. Obtain a realvirtual license for Unity to enable the necessary functionalities.

## Scripts Overview

### SendOrder Script

The `SendOrder` script facilitates TCP client-server communication and includes functionality for sending orders to the Festo factory machine. This script establishes a connection, listens for incoming data, and sends orders based on specified part numbers and quantities.

### UIUpdateManager Script

The `UIUpdateManager` script manages the user interface elements, updating connection images, displaying data from OPC UA nodes, and facilitating the sending of orders to the machine. This script ensures a smooth user experience and real-time monitoring.

### NodeReader Script

The `NodeReader` script is responsible for reading data from OPC UA nodes and updating the UI elements accordingly. It subscribes to OPC UA events, monitors node changes, and provides feedback on the connection status of the factory machine.


## Acknowledgments

Special thanks to realvirtual for providing the Unity license to enable OPC UA communication in this project.

---
