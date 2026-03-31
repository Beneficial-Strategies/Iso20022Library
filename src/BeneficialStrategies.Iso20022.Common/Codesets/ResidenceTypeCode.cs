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
[IsoId("_-WZTUGjMEeiRg5NzP0jkQg")]
[Description(
    @"Specifies the type of residence where the party has its permanent home or principal establishment."
)]
[Derivations(typeof(ResidenceType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResidenceTypeCode>))]
#endif
public enum ResidenceTypeCode
{
    /// <summary>
    /// Residence is domestic.
    /// Encoded/decoded by serializers as &quot;DMST&quot;.
    /// </summary>
    [EnumMember(Value = "DMST")]
    [IsoId("_AyErkGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is domestic.")]
    Domestic,

    /// <summary>
    /// Residence is foreign.
    /// Encoded/decoded by serializers as &quot;FRGN&quot;.
    /// </summary>
    [EnumMember(Value = "FRGN")]
    [IsoId("_CC7PcGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is foreign.")]
    Foreign,

    /// <summary>
    /// Residence is mixed
    /// Encoded/decoded by serializers as &quot;MXED&quot;.
    /// </summary>
    [EnumMember(Value = "MXED")]
    [IsoId("_DKcRIGjNEeiRg5NzP0jkQg")]
    [Description(@"Residence is mixed")]
    Mixed,
}
