// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund transaction that results in a cash movement out of a fund.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ViYohNp-Ed-ak6NoX_4Aeg_1123962465")]
[Description(
    @"Specifies the type of investment fund transaction that results in a cash movement out of a fund."
)]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentFundTransactionOutType4Code>))]
#endif
public enum InvestmentFundTransactionOutType4Code
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_ViYohdp-Ed-ak6NoX_4Aeg_-1882035565")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption = InvestmentFundTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_ViYohtp-Ed-ak6NoX_4Aeg_-1812771225")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut = InvestmentFundTransactionTypeCode.SwitchOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_ViYoh9p-Ed-ak6NoX_4Aeg_1824710762")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie = InvestmentFundTransactionTypeCode.InSpecie, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a cross out.
    /// Encoded/decoded by serializers as &quot;CROO&quot;.
    /// </summary>
    [EnumMember(Value = "CROO")]
    [IsoId("_ViYoiNp-Ed-ak6NoX_4Aeg_1843184237")]
    [Description(@"Transaction is a cross out.")]
    CrossOut = InvestmentFundTransactionTypeCode.CrossOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_ViYoidp-Ed-ak6NoX_4Aeg_1864425612")]
    [Description(@"Transaction is a dividend.")]
    Dividend = InvestmentFundTransactionTypeCode.Dividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ViiZgNp-Ed-ak6NoX_4Aeg_1870890259")]
    [Description(@"Transaction is another type of transaction.")]
    Other = InvestmentFundTransactionTypeCode.Other, // same ordinal as derivation source for type conversions
}
