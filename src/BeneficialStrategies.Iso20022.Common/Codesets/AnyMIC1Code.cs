// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a market identification code (MIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PWEXMB3ZEeWNp95x0ENf8w")]
[Description(@"Specifies a market identification code (MIC).")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum AnyMIC1Code
{
    /// <summary>
    /// Any MIC code.
    /// Encoded/decoded by serializers as &quot;ANYM&quot;.
    /// </summary>
    [EnumMember(Value = "ANYM")]
    [IsoId("_SW4c0R3ZEeWNp95x0ENf8w")]
    [Description(@"Any MIC code.")]
    AnyMIC = SpecialPurposeCode.AnyMIC, // same ordinal as derivation source for type conversions
}
