// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Detail of the response.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z3kk4I4YEeW6h7rGyYlyTg")]
[Description(@"Detail of the response.")]
[DerivedFrom(typeof(ResultDetailCode))]
public enum ResultDetail3Code
{
    /// <summary>
    /// The certificate is unknown.
    /// Encoded/decoded by serializers as &quot;CRTU&quot;.
    /// </summary>
    [EnumMember(Value = "CRTU")]
    [IsoId("_dRl0sY4YEeW6h7rGyYlyTg")]
    [Description(@"The certificate is unknown.")]
    UnknownCertificate = ResultDetailCode.UnknownCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as &quot;SVSU&quot;.
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_eBK3g44YEeW6h7rGyYlyTg")]
    [Description(@"Requested service not supported.")]
    UnsupportedService = ResultDetailCode.UnsupportedService, // same ordinal as derivation source for type conversions
    
}
