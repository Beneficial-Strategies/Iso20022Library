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
[IsoId("_aczUE9p-Ed-ak6NoX_4Aeg_1672602191")]
[Description(
    @"Specifies the type of investment fund transaction that results in a cash movement out of a fund."
)]
[DerivedFrom(typeof(InvestmentFundTransactionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestmentFundTransactionOutType1Code>))]
#endif
public enum InvestmentFundTransactionOutType1Code
{
    /// <summary>
    /// Transaction is a redemption of an investment fund.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_aczUFNp-Ed-ak6NoX_4Aeg_1717851866")]
    [Description(@"Transaction is a redemption of an investment fund.")]
    Redemption = InvestmentFundTransactionTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a subscription leg of a switch order execution.
    /// Encoded/decoded by serializers as &quot;SWIO&quot;.
    /// </summary>
    [EnumMember(Value = "SWIO")]
    [IsoId("_aczUFdp-Ed-ak6NoX_4Aeg_1717851883")]
    [Description(@"Transaction is a subscription leg of a switch order execution.")]
    SwitchOut = InvestmentFundTransactionTypeCode.SwitchOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an InSpecie.
    /// Encoded/decoded by serializers as &quot;INSP&quot;.
    /// </summary>
    [EnumMember(Value = "INSP")]
    [IsoId("_aczUFtp-Ed-ak6NoX_4Aeg_1717851901")]
    [Description(@"Transaction is an InSpecie.")]
    InSpecie = InvestmentFundTransactionTypeCode.InSpecie, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a cross out.
    /// Encoded/decoded by serializers as &quot;CROO&quot;.
    /// </summary>
    [EnumMember(Value = "CROO")]
    [IsoId("_aczUF9p-Ed-ak6NoX_4Aeg_1717851902")]
    [Description(@"Transaction is a cross out.")]
    CrossOut = InvestmentFundTransactionTypeCode.CrossOut, // same ordinal as derivation source for type conversions
}
