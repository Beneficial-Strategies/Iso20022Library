// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of lottery.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afolodp-Ed-ak6NoX_4Aeg_-1740647870")]
[Description(@"Specifies the type of lottery.")]
[DerivedFrom(typeof(LotteryTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LotteryType1Code>))]
#endif
public enum LotteryType1Code
{
    /// <summary>
    /// Original lottery that has been announced for a specific amount and date.
    /// Encoded/decoded by serializers as &quot;ORIG&quot;.
    /// </summary>
    [EnumMember(Value = "ORIG")]
    [IsoId("_afolotp-Ed-ak6NoX_4Aeg_-1740647868")]
    [Description(@"Original lottery that has been announced for a specific amount and date.")]
    OriginalLotteryNotification = LotteryTypeCode.OriginalLotteryNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplemental or additional quantity called on a previously announced original lottery.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_afolo9p-Ed-ak6NoX_4Aeg_-1740647840")]
    [Description(
        @"Supplemental or additional quantity called on a previously announced original lottery."
    )]
    SupplementalLotteryNotification = LotteryTypeCode.SupplementalLotteryNotification, // same ordinal as derivation source for type conversions
}
