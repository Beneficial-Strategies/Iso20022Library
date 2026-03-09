// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of communication network.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oE24kGpVEeSR-ZWLvO-1dg")]
[Description(@"Type of communication network.")]
[DerivedFrom(typeof(NetworkTypeCode))]
public enum NetworkType1Code
{
    /// <summary>
    /// Protocol of an IP network.
    /// Encoded/decoded by serializers as &quot;IPNW&quot;.
    /// </summary>
    [EnumMember(Value = "IPNW")]
    [IsoId("_pr02YWpVEeSR-ZWLvO-1dg")]
    [Description(@"Protocol of an IP network.")]
    InternetProtocol = NetworkTypeCode.InternetProtocol, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protocol of a Public Switched Telephone Network (PSTN).
    /// Encoded/decoded by serializers as &quot;PSTN&quot;.
    /// </summary>
    [EnumMember(Value = "PSTN")]
    [IsoId("_pyrsUWpVEeSR-ZWLvO-1dg")]
    [Description(@"Protocol of a Public Switched Telephone Network (PSTN).")]
    PublicTelephone = NetworkTypeCode.PublicTelephone, // same ordinal as derivation source for type conversions
    
}
