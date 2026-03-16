// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies messages related to a key exchange process.
/// ISO 8583 MTI.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gNRF4FWWEeeiG_nL4vgKnQ")]
[Description(@"Identifies messages related to a key exchange process.|ISO 8583 MTI.")]
[DerivedFrom(typeof(MessageFunctionCode))]
public enum MessageFunction25Code
{
    /// <summary>
    /// Message function is a request.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_KsoZoemuEemNVKPwszFC-A")]
    [Description(@"Message function is a request.")]
    Request = MessageFunctionCode.Request, // same ordinal as derivation source for type conversions
}
