// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the interest request is new or updated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbT9cdp-Ed-ak6NoX_4Aeg_133291981")]
[Description(@"Indicates whether the interest request is new or updated.")]
[Derivations(typeof(InterestRequestSequence1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterestRequestSequenceCode>))]
#endif
public enum InterestRequestSequenceCode
{
    /// <summary>
    /// Indicates this is a new interest payment request.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YbT9ctp-Ed-ak6NoX_4Aeg_1628760532")]
    [Description(@"Indicates this is a new interest payment request.")]
    Initial,

    /// <summary>
    /// Indicates this is an updated interest payement request.
    /// Encoded/decoded by serializers as &quot;UPDA&quot;.
    /// </summary>
    [EnumMember(Value = "UPDA")]
    [IsoId("_YbT9c9p-Ed-ak6NoX_4Aeg_-1309702625")]
    [Description(@"Indicates this is an updated interest payement request.")]
    Updated,
}
