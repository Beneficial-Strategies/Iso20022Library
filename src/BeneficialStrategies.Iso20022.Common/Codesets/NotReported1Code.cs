// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a not reported value code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UzChQNGfEeaQk737TH1Fzw")]
[Description(@"Specifies a not reported value code.")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum NotReported1Code
{
    /// <summary>
    /// Value not reported by the party.
    /// Encoded/decoded by serializers as &quot;NORP&quot;.
    /// </summary>
    [EnumMember(Value = "NORP")]
    [IsoId("_WhKP8dGfEeaQk737TH1Fzw")]
    [Description(@"Value not reported by the party.")]
    NotReported = SpecialPurposeCode.NotReported, // same ordinal as derivation source for type conversions
    
}
