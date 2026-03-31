// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the item is eligible or not eligible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cJMIICC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is eligible or not eligible.")]
[Derivations(typeof(Eligible1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EligibleCode>))]
#endif
public enum EligibleCode
{
    /// <summary>
    /// Item is eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_iJlkUCC9EeWPMvNwVtiMsA")]
    [Description(@"Item is eligible.")]
    Eligible,

    /// <summary>
    /// Item is not eligible.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_lRvoECC9EeWPMvNwVtiMsA")]
    [Description(@"Item is not eligible.")]
    NotEligible,
}
