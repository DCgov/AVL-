using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LocalEnv
/// </summary>
public static class LocalEnv
{
    //static public string AVLDBConnString = "Server=(local);Database=AVL;User Id=tirs;Password=keepsafe;";
    static public string tirsConnString = "Server=(local);Database=tirs;User Id=tirs;Password=keepsafe;";

    static public string AVLDBConnString = "Server=10.40.16.106;Database=DCVehiclelog2011;User Id=sa;Password=cadds111!;";
    //static public string tirsConnString = "Server=10.40.62.167;Database=tirs;User Id=tirs;Password=keepsafe;";
    static public string speedConnString = "Server=10.40.62.167;Database=speed;User Id=tirs;Password=keepsafe;";
    static public string microwaveConnString = "Server=10.40.63.52;Database=RTMSData;User Id=tirs;Password=keepsafe;";
    static public string tirs_lookupConnString = "Server=10.40.62.167;Database=tirs_lookup;User Id=tirs;Password=keepsafe;";
    
}