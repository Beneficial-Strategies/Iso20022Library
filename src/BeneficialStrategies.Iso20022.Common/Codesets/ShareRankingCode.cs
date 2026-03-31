// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the shares are ranking for dividend or pari passu.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZOkmaNp-Ed-ak6NoX_4Aeg_1801695812")]
[Description(@"Specifies whether the shares are ranking for dividend or pari passu.")]
[Derivations(typeof(ShareRanking1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ShareRankingCode>))]
#endif
public enum ShareRankingCode
{
    /// <summary>
    /// Payable on the date specified.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_ZOtwUNp-Ed-ak6NoX_4Aeg_1834017233")]
    [Description(@"Payable on the date specified.")]
    Dividend,

    /// <summary>
    /// Pari Passu. With equal rights as other shares of the company.
    /// Encoded/decoded by serializers as &quot;PARI&quot;.
    /// </summary>
    [EnumMember(Value = "PARI")]
    [IsoId("_ZOtwUdp-Ed-ak6NoX_4Aeg_1889429406")]
    [Description(@"Pari Passu. With equal rights as other shares of the company.")]
    PariPassu,
}
