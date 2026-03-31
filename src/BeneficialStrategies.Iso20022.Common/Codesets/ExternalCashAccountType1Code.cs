// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t7bogVkyEeGeoaLUQk__nA_-2034002224")]
[Description(
    @"Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCashAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCashAccountType1Code>))]
#endif
public enum ExternalCashAccountType1Code
{
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_uLQ32_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Account used to post debits and credits when no specific account has been nominated."
    )]
    Current = ExternalCashAccountTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for credit card payments.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_uLQ33vRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for credit card payments.")]
    CardAccount = ExternalCashAccountTypeCode.CardAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uLao0vRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment = ExternalCashAccountTypeCode.CashPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for charges if different from the account for|payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_uLao1fRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for charges if different from the account for|payment.")]
    Charges = ExternalCashAccountTypeCode.Charges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for payment of income if different from the current cash account
    /// Encoded/decoded by serializers as &quot;CISH&quot;.
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_uLao2PRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for payment of income if different from the current cash account")]
    CashIncome = ExternalCashAccountTypeCode.CashIncome, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for commission if different from the account|for payment.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uLao2_RYEeuLhpyIdtJzwg")]
    [Description(@"Account used for commission if different from the account|for payment.")]
    Commission = ExternalCashAccountTypeCode.Commission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post settlement debit and credit entries on behalf of a designated Clearing Participant.
    /// Encoded/decoded by serializers as &quot;CPAC&quot;.
    /// </summary>
    [EnumMember(Value = "CPAC")]
    [IsoId("_uLjywvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Account used to post settlement debit and credit entries on behalf of a designated Clearing Participant."
    )]
    ClearingParticipantSettlementAccount =
        ExternalCashAccountTypeCode.ClearingParticipantSettlementAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for savings with special interest and withdrawal terms.
    /// Encoded/decoded by serializers as &quot;LLSV&quot;.
    /// </summary>
    [EnumMember(Value = "LLSV")]
    [IsoId("_uLjyxfRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for savings with special interest and withdrawal terms.  ")]
    LimitedLiquiditySavingsAccount = ExternalCashAccountTypeCode.LimitedLiquiditySavingsAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_uLjyyPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for loans.")]
    Loan = ExternalCashAccountTypeCode.Loan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_uLjyy_RYEeuLhpyIdtJzwg")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending = ExternalCashAccountTypeCode.MarginalLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for money markets if different from the cash|account.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_uLjyzvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for money markets if different from the cash|account.")]
    MoneyMarket = ExternalCashAccountTypeCode.MoneyMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for non-resident external.
    /// Encoded/decoded by serializers as &quot;NREX&quot;.
    /// </summary>
    [EnumMember(Value = "NREX")]
    [IsoId("_uLtjwvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for non-resident external.")]
    NonResidentExternal = ExternalCashAccountTypeCode.NonResidentExternal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is used for overdrafts.
    /// Encoded/decoded by serializers as &quot;ODFT&quot;.
    /// </summary>
    [EnumMember(Value = "ODFT")]
    [IsoId("_uLtjxfRYEeuLhpyIdtJzwg")]
    [Description(@"Account is used for overdrafts.")]
    Overdraft = ExternalCashAccountTypeCode.Overdraft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as &quot;ONDP&quot;.
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_uLtjyPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit = ExternalCashAccountTypeCode.OverNightDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account not otherwise specified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uLtjy_RYEeuLhpyIdtJzwg")]
    [Description(@"Account not otherwise specified. ")]
    OtherAccount = ExternalCashAccountTypeCode.OtherAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_uLtjzvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system."
    )]
    Settlement = ExternalCashAccountTypeCode.Settlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accounts used for salary payments.
    /// Encoded/decoded by serializers as &quot;SLRY&quot;.
    /// </summary>
    [EnumMember(Value = "SLRY")]
    [IsoId("_uL2tsvRYEeuLhpyIdtJzwg")]
    [Description(@"Accounts used for salary payments.")]
    Salary = ExternalCashAccountTypeCode.Salary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_uL2ttfRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for savings.")]
    Savings = ExternalCashAccountTypeCode.Savings, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for taxes if different from the account for|payment.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_uL2tuPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for taxes if different from the account for|payment.")]
    Tax = ExternalCashAccountTypeCode.Tax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A transacting account is the most basic type of bank account that you can get. The main difference between transaction and cheque accounts is that you usually do not get a cheque book with your transacting account and neither are you offered an overdraft facility.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_uL2tu_RYEeuLhpyIdtJzwg")]
    [Description(
        @"A transacting account is the most basic type of bank account that you can get. The main difference between transaction and cheque accounts is that you usually do not get a cheque book with your transacting account and neither are you offered an overdraft facility."
    )]
    TransactingAccount = ExternalCashAccountTypeCode.TransactingAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account used for trading if different from the current cash|account.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_uL2tvvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for trading if different from the current cash|account.")]
    CashTrading = ExternalCashAccountTypeCode.CashTrading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account created virtually to facilitate collection and reconciliation.
    /// Encoded/decoded by serializers as &quot;VACC&quot;.
    /// </summary>
    [EnumMember(Value = "VACC")]
    [IsoId("_n1HScY5FEeyANo-d7JlQ1A")]
    [Description(@"Account created virtually to facilitate collection and reconciliation.")]
    VirtualAccount = ExternalCashAccountTypeCode.VirtualAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non-Resident Individual / Entity Foreign Current held domestically.
    /// Encoded/decoded by serializers as &quot;NFCA&quot;.
    /// </summary>
    [EnumMember(Value = "NFCA")]
    [IsoId("_YbOMAmvbEe2F6NrIyOmXcA")]
    [Description(@"Non-Resident Individual / Entity Foreign Current held domestically.")]
    NonResidentForeignCurrencyAccount =
        ExternalCashAccountTypeCode.NonResidentForeignCurrencyAccount, // same ordinal as derivation source for type conversions
}
