// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xYEPwJf8EeSfnc-VXAEapg")]
[Description(@"Specifies the type of product or financial instrument.")]
[DerivedFrom(typeof(FinancialInstrumentProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancialInstrumentProductType1Code>))]
#endif
public enum FinancialInstrumentProductType1Code
{
    /// <summary>
    /// Certificate issued by a bank or thrift that indicates a specified sum of money deposited. The certificate has a maturity date and a specified interest rate.
    /// Encoded/decoded by serializers as &quot;CEOD&quot;.
    /// </summary>
    [EnumMember(Value = "CEOD")]
    [IsoId("_9dV_gZf8EeSfnc-VXAEapg")]
    [Description(
        @"Certificate issued by a bank or thrift that indicates a specified sum of money deposited. The certificate has a maturity date and a specified interest rate."
    )]
    CertificateOfDeposit = FinancialInstrumentProductTypeCode.CertificateOfDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Short-term, unsecured promissory note issued by a corporation. The maturity is typically less than 270 days, with a most common maturity range of 30 to 50 days or less. Commercial paper is usually issued at a discount, though some are interest-bearing.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_C8DD4Zf9EeSfnc-VXAEapg")]
    [Description(
        @"Short-term, unsecured promissory note issued by a corporation. The maturity is typically less than 270 days, with a most common maturity range of 30 to 50 days or less. Commercial paper is usually issued at a discount, though some are interest-bearing."
    )]
    CommercialPaper = FinancialInstrumentProductTypeCode.CommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other short term debt securities issued.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9l4EUbw2EeSv87Gr1rLbvg")]
    [Description(@"Other short term debt securities issued.")]
    OtherShortTermDebtSecurities = FinancialInstrumentProductTypeCode.OtherShortTermDebtSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt instrument issued by a financial institution which has a maturity of no more than one year, is either interest-bearing or discounted and is backed by some form of collateral.
    /// Encoded/decoded by serializers as &quot;ABCP&quot;.
    /// </summary>
    [EnumMember(Value = "ABCP")]
    [IsoId("_-8w-wbw2EeSv87Gr1rLbvg")]
    [Description(
        @"Debt instrument issued by a financial institution which has a maturity of no more than one year, is either interest-bearing or discounted and is backed by some form of collateral."
    )]
    AssetBackedCommercialPaper = FinancialInstrumentProductTypeCode.AssetBackedCommercialPaper, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt instrument in which the periodic interest payments are calculated on the basis of the value (fixing of an underlying reference rate such as the Euribor) on predefined dates (fixing dates) and which has a maturity of no more tha one year.
    /// Encoded/decoded by serializers as &quot;FRNT&quot;.
    /// </summary>
    [EnumMember(Value = "FRNT")]
    [IsoId("_AK3wobw3EeSv87Gr1rLbvg")]
    [Description(
        @"Debt instrument in which the periodic interest payments are calculated on the basis of the value (fixing of an underlying reference rate such as the Euribor) on predefined dates (fixing dates) and which has a maturity of no more tha one year."
    )]
    FloatingRateNote = FinancialInstrumentProductTypeCode.FloatingRateNote, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash account with a notice period to withdraw money and that gives rise to interest payments or calculations at regular intervals, and daily change of the applicable rate.
    /// Encoded/decoded by serializers as &quot;CACM&quot;.
    /// </summary>
    [EnumMember(Value = "CACM")]
    [IsoId("_BoAdAbw3EeSv87Gr1rLbvg")]
    [Description(
        @"Cash account with a notice period to withdraw money and that gives rise to interest payments or calculations at regular intervals, and daily change of the applicable rate."
    )]
    CallAccountCallMoney = FinancialInstrumentProductTypeCode.CallAccountCallMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unsecured interest-bearing deposit that is either redeemable at notice or has a maturity of no more than one year, that is 397 days after the settlement date, and which is either taken (borrowing) or placed (lending) by the agent.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_Wrmtofl3EeSaUu1MjG4T0Q")]
    [Description(
        @"Unsecured interest-bearing deposit that is either redeemable at notice or has a maturity of no more than one year, that is 397 days after the settlement date, and which is either taken (borrowing) or placed (lending) by the agent."
    )]
    Deposit = FinancialInstrumentProductTypeCode.Deposit, // same ordinal as derivation source for type conversions
}
