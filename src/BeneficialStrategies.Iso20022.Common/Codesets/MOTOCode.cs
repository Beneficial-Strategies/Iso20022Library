// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code that identifies the type of MOTO transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CPEMoDHLEeyTT91yHXSlSQ")]
[Description(@"A code that identifies the type of MOTO transaction.")]
[Derivations(typeof(MOTO1Code))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum MOTOCode
{
    /// <summary>
    /// Mail order.
    /// Encoded/decoded by serializers as &quot;MAOR&quot;.
    /// </summary>
    [EnumMember(Value = "MAOR")]
    [IsoId("_QZrRMDHLEeyTT91yHXSlSQ")]
    [Description(@"Mail order.")]
    MailOrder,
    
    /// <summary>
    /// Telephone order
    /// Encoded/decoded by serializers as &quot;TPOR&quot;.
    /// </summary>
    [EnumMember(Value = "TPOR")]
    [IsoId("_byF68DHLEeyTT91yHXSlSQ")]
    [Description(@"Telephone order")]
    TelephoneOrder,
    
    /// <summary>
    /// Mail order or telephone order.
    /// Encoded/decoded by serializers as &quot;MOTO&quot;.
    /// </summary>
    [EnumMember(Value = "MOTO")]
    [IsoId("_gi3iUDHLEeyTT91yHXSlSQ")]
    [Description(@"Mail order or telephone order.|")]
    MailOrderOrTelephoneOrder,
    
}
