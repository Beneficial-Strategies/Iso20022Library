// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a24A9dp-Ed-ak6NoX_4Aeg_1132707295")]
[Description(@"Specifies the nature, or use, of the cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashAccountType2Code>))]
#endif
public enum CashAccountType2Code
{
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a24A9tp-Ed-ak6NoX_4Aeg_1132707296")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment = CashAccountTypeCode.CashPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for charges if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_a24A99p-Ed-ak6NoX_4Aeg_1132707297")]
    [Description(@"Account used for charges if different from the account for payment.")]
    Charges = CashAccountTypeCode.Charges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for commission if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_a24A-Np-Ed-ak6NoX_4Aeg_1132707523")]
    [Description(@"Account used for commission if different from the account for payment.")]
    Commission = CashAccountTypeCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for taxes if different from the account for payment.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_a24A-dp-Ed-ak6NoX_4Aeg_1132707524")]
    [Description(@"Account used for taxes if different from the account for payment.")]
    Tax = CashAccountTypeCode.Tax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for payment of income if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;CISH&quot;.
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_a3Bx8Np-Ed-ak6NoX_4Aeg_1132707525")]
    [Description(@"Account used for payment of income if different from the current cash account.")]
    CashIncome = CashAccountTypeCode.CashIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for trading if different from the current cash account.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_a3Bx8dp-Ed-ak6NoX_4Aeg_1132707526")]
    [Description(@"Account used for trading if different from the current cash account.")]
    CashTrading = CashAccountTypeCode.CashTrading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_a3Bx8tp-Ed-ak6NoX_4Aeg_1132707528")]
    [Description(
        @"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system."
    )]
    Settlement = CashAccountTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_a3Bx89p-Ed-ak6NoX_4Aeg_1132707529")]
    [Description(
        @"Account used to post debits and credits when no specific account has been nominated."
    )]
    Current = CashAccountTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_a3Bx9Np-Ed-ak6NoX_4Aeg_1132707530")]
    [Description(@"Account used for savings.")]
    Savings = CashAccountTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as &quot;ONDP&quot;.
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_a3Bx9dp-Ed-ak6NoX_4Aeg_1132707531")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit = CashAccountTypeCode.OverNightDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_a3Bx9tp-Ed-ak6NoX_4Aeg_1132707532")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending = CashAccountTypeCode.MarginalLending, // same ordinal as derivation source for type conversions
}
