using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Shared;

public partial class main : System.Web.UI.Page
{
    const string ConnectionString = "mongodb://localhost";
    MongoServer server;
    MongoClient client;
    MongoDatabase database;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a MongoClient object by using the connection string
        client = new MongoClient(ConnectionString);

        //Use the MongoClient to access the server
        server = client.GetServer();

        // Use the server to access the 'test' database
        database = server.GetDatabase("test");
    }
}