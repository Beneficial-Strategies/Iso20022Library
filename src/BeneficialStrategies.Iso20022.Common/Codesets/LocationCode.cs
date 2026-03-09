// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a location.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_s14uMKHnEeagRbKvRt3LnA")]
[Description(@"Specifies a location.")]
[Derivations(typeof(Location1Code))]
public enum LocationCode
{
    /// <summary>
    /// At my institution.
    /// Encoded/decoded by serializers as &quot;MYIN&quot;.
    /// </summary>
    [EnumMember(Value = "MYIN")]
    [IsoId("_wrAloKHnEeagRbKvRt3LnA")]
    [Description(@"At my institution.")]
    AtMyInstitution,
    
    /// <summary>
    /// At another institution
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-A-hMKHnEeagRbKvRt3LnA")]
    [Description(@"At another institution")]
    AtAnotherInstitution,
    
}
