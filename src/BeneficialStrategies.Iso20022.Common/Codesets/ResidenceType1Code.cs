// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JX1ngGjNEeiRg5NzP0jkQg")]
[Description(
    @"Specifies the type of residence where the party has its permanent home or principal establishment."
)]
[DerivedFrom(typeof(ResidenceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResidenceType1Code>))]
#endif
public enum ResidenceType1Code
{
    /// <summary>
    /// Residence is domestic.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_LFI20WjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is domestic.")]
    Domestic = ResidenceTypeCode.Domestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Residence is foreign.
    /// Encoded/decoded by serializers as &quot;FRGN&quot;.
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_LOpYIWjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is foreign.")]
    Foreign = ResidenceTypeCode.Foreign, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Residence is mixed
    /// Encoded/decoded by serializers as &quot;MXED&quot;.
    /// </summary>
    [EnumMember(Value = "MXED")]
    [IsoId("_LYfQoWjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is mixed")]
    Mixed = ResidenceTypeCode.Mixed, // same ordinal as derivation source for type conversions
}
