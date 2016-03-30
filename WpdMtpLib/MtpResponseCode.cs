﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpdMtpLib
{
    public enum MtpResponseCode : ushort
    {
        Error                                       = 0x0000,   // MTP通信が行えなかった場合
        Undefined                                   = 0x2000,
        OK,
        GeneralError,
        Session_Not_Open,
        Invalid_TransactionID,
        Operation_Not_Supported,
        Parameter_Not_Supported,
        IncompleteTransfer,
        Invalid_StorageID,
        Invalid_ObjectHandle,
        DeviceProp_Not_Supported,
        Invalid_ObjectFormatCode,
        Store_Full,
        Object_WriteProtected,
        Store_Read_Only,
        Access_Denied,
        No_Thumbnail_Present,
        SelfTest_Failed,
        Partial_Delection,
        Store_Not_Available,
        Specification_By_Format_Unsupported,
        No_Valid_ObjectInfo,
        Invalid_Code_Format,
        Unknown_Vendor_Code,
        Capture_Already_Terminated,
        Device_Busy,
        Invalid_ParentObject,
        Invalid_DeviceProp_Format,
        Invalid_DeviceProp_Value,
        Invalid_Parameter,
        Session_Already_Open,
        Transaction_Cancelled,
        Specification_of_Destination_Unsupported,
        Invalid_ObjectPropCode                  = 0xA801,
        Invalid_ObjectProp_Format,
        Invalid_ObjectProp_Value,
        Invalid_ObjectReference,
        Group_Not_Supported,
        Invalid_Dataset,
        Specification_By_GroupUnsupported,
        Specification_By_DepthUnsupported,
        Object_Too_Large,
        ObjectProp_Not_Supported
    }
}
