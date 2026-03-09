// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of administrative service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l0Ao8Hu8EeSLmfFG0DG7zQ")]
[Description(@"Type of administrative service.")]
[Derivations(typeof(CardServiceType2Code),typeof(CardServiceType4Code),typeof(CardServiceType3Code),typeof(CardServiceType1Code),typeof(CardServiceType5Code))]
public enum CardServiceTypeCode
{
    /// <summary>
    /// Partial reconciliation of the day.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_pMYS8Hu8EeSLmfFG0DG7zQ")]
    [Description(@"Partial reconciliation of the day.")]
    CheckPoint,
    
    /// <summary>
    /// Final reconciliation.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_szGiAHu8EeSLmfFG0DG7zQ")]
    [Description(@"Final reconciliation.")]
    Final,
    
    /// <summary>
    /// Request for totals of a previous reconciliation.
    /// Encoded/decoded by serializers as &quot;PRVS&quot;.
    /// </summary>
    [EnumMember(Value = "PRVS")]
    [IsoId("_vCKakHu8EeSLmfFG0DG7zQ")]
    [Description(@"Request for totals of a previous reconciliation.")]
    TotalInquiry,
    
    /// <summary>
    /// Close communication at application level to stop store and forward process.
    /// Encoded/decoded by serializers as &quot;SFDS&quot;.
    /// </summary>
    [EnumMember(Value = "SFDS")]
    [IsoId("_E_NcgHvEEeSKFIcWw3l4Yw")]
    [Description(@"Close communication at application level to stop store and forward process.")]
    DisableStoreForward,
    
    /// <summary>
    /// Detection whether communication at application level is still active.
    /// Encoded/decoded by serializers as &quot;ECHO&quot;.
    /// </summary>
    [EnumMember(Value = "ECHO")]
    [IsoId("_IFZKUHvEEeSKFIcWw3l4Yw")]
    [Description(@"Detection whether communication at application level is still active.")]
    EchoTest,
    
    /// <summary>
    /// Establish communication at application level to start store and forward process.
    /// Encoded/decoded by serializers as &quot;SFEN&quot;.
    /// </summary>
    [EnumMember(Value = "SFEN")]
    [IsoId("_Kdr3YHvEEeSKFIcWw3l4Yw")]
    [Description(@"Establish communication at application level to start store and forward process.")]
    EnableStoreForward,
    
    /// <summary>
    /// Establish communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNN&quot;.
    /// </summary>
    [EnumMember(Value = "SGNN")]
    [IsoId("_NhMEoHvEEeSKFIcWw3l4Yw")]
    [Description(@"Establish communication at application level.")]
    SignOn,
    
    /// <summary>
    /// Terminate communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNF&quot;.
    /// </summary>
    [EnumMember(Value = "SGNF")]
    [IsoId("_RF1QEHvEEeSKFIcWw3l4Yw")]
    [Description(@"Terminate communication at application level.")]
    SignOff,
    
    /// <summary>
    /// Request the keys that the receiver must send in the response.
    /// Encoded/decoded by serializers as &quot;KYCG&quot;.
    /// </summary>
    [EnumMember(Value = "KYCG")]
    [IsoId("_I-HzAHvNEeSCJdwgzb6SFw")]
    [Description(@"Request the keys that the receiver must send in the response.")]
    KeyChange,
    
    /// <summary>
    /// Convey the key to the receiver.
    /// Encoded/decoded by serializers as &quot;KYDL&quot;.
    /// </summary>
    [EnumMember(Value = "KYDL")]
    [IsoId("_Lt9dYHvNEeSCJdwgzb6SFw")]
    [Description(@"Convey the key to the receiver.")]
    DeliverKey,
    
    /// <summary>
    /// Request the receiver to verify the key check value.
    /// Encoded/decoded by serializers as &quot;KYVF&quot;.
    /// </summary>
    [EnumMember(Value = "KYVF")]
    [IsoId("_OOzCcHvNEeSCJdwgzb6SFw")]
    [Description(@"Request the receiver to verify the key check value.")]
    KeyVerification,
    
    /// <summary>
    /// Initiate cutover
    /// Encoded/decoded by serializers as &quot;INCU&quot;.
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_embX5Hx8EemHsOqJOzMVfg")]
    [Description(@"Initiate cutover")]
    InitiateCutover,
    
    /// <summary>
    /// National defined code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_embX5Xx8EemHsOqJOzMVfg")]
    [Description(@"National defined code.")]
    OtherNational,
    
    /// <summary>
    /// Private defined code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_embX5nx8EemHsOqJOzMVfg")]
    [Description(@"Private defined code.")]
    OtherPrivate,
    
    /// <summary>
    /// Response received
    /// Encoded/decoded by serializers as &quot;RERE&quot;.
    /// </summary>
    [EnumMember(Value = "RERE")]
    [IsoId("_embX53x8EemHsOqJOzMVfg")]
    [Description(@"Response received")]
    ResponseReceived,
    
    /// <summary>
    /// Deactivate the specified key.
    /// Encoded/decoded by serializers as &quot;DEKY&quot;.
    /// </summary>
    [EnumMember(Value = "DEKY")]
    [IsoId("_D-IpcJJbEemtzI0l4QED6w")]
    [Description(@"Deactivate the specified key.")]
    DeactivateKey,
    
    /// <summary>
    /// Request new key to be generated and conveyed.
    /// Encoded/decoded by serializers as &quot;RQKY&quot;.
    /// </summary>
    [EnumMember(Value = "RQKY")]
    [IsoId("_gFYaYK4aEemYtqDpusmLsQ")]
    [Description(@"Request new key to be generated and conveyed.")]
    RequestKey,
    
}
