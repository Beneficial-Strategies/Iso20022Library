// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5lMfIIKTEeeCI5iKR7LsYQ")]
[Description(@"Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalCashAccountType1Code))]
public enum ExternalCashAccountTypeCode
{
    /// <summary>
    /// Account used to post debits and credits when no specific account has been nominated.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_uLQ32fRYEeuLhpyIdtJzwg")]
    [Description(@"Account used to post debits and credits when no specific account has been nominated.")]
    Current,
    
    /// <summary>
    /// Account used for credit card payments.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_uLQ33PRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for credit card payments.")]
    CardAccount,
    
    /// <summary>
    /// Account used for the payment of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uLao0PRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for the payment of cash.")]
    CashPayment,
    
    /// <summary>
    /// Account used for charges if different from the account for|payment.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_uLao0_RYEeuLhpyIdtJzwg")]
    [Description(@"Account used for charges if different from the account for|payment.")]
    Charges,
    
    /// <summary>
    /// Account used for payment of income if different from the current cash account
    /// Encoded/decoded by serializers as &quot;CISH&quot;.
    /// </summary>
    [EnumMember(Value = "CISH")]
    [IsoId("_uLao1vRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for payment of income if different from the current cash account")]
    CashIncome,
    
    /// <summary>
    /// Account used for commission if different from the account|for payment.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uLao2fRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for commission if different from the account|for payment.")]
    Commission,
    
    /// <summary>
    /// Account used to post settlement debit and credit entries on behalf of a designated Clearing Participant.
    /// Encoded/decoded by serializers as &quot;CPAC&quot;.
    /// </summary>
    [EnumMember(Value = "CPAC")]
    [IsoId("_uLjywPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used to post settlement debit and credit entries on behalf of a designated Clearing Participant.")]
    ClearingParticipantSettlementAccount,
    
    /// <summary>
    /// Account used for savings with special interest and withdrawal terms.  
    /// Encoded/decoded by serializers as &quot;LLSV&quot;.
    /// </summary>
    [EnumMember(Value = "LLSV")]
    [IsoId("_uLjyw_RYEeuLhpyIdtJzwg")]
    [Description(@"Account used for savings with special interest and withdrawal terms.  ")]
    LimitedLiquiditySavingsAccount,
    
    /// <summary>
    /// Account used for loans.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_uLjyxvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for loans.")]
    Loan,
    
    /// <summary>
    /// Account used for a marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_uLjyyfRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for a marginal lending facility.")]
    MarginalLending,
    
    /// <summary>
    /// Account used for money markets if different from the cash|account.
    /// Encoded/decoded by serializers as &quot;MOMA&quot;.
    /// </summary>
    [EnumMember(Value = "MOMA")]
    [IsoId("_uLjyzPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for money markets if different from the cash|account.")]
    MoneyMarket,
    
    /// <summary>
    /// Account used for non-resident external.
    /// Encoded/decoded by serializers as &quot;NREX&quot;.
    /// </summary>
    [EnumMember(Value = "NREX")]
    [IsoId("_uLtjwPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for non-resident external.")]
    NonResidentExternal,
    
    /// <summary>
    /// Account is used for overdrafts.
    /// Encoded/decoded by serializers as &quot;ODFT&quot;.
    /// </summary>
    [EnumMember(Value = "ODFT")]
    [IsoId("_uLtjw_RYEeuLhpyIdtJzwg")]
    [Description(@"Account is used for overdrafts.")]
    Overdraft,
    
    /// <summary>
    /// Account used for overnight deposits.
    /// Encoded/decoded by serializers as &quot;ONDP&quot;.
    /// </summary>
    [EnumMember(Value = "ONDP")]
    [IsoId("_uLtjxvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for overnight deposits.")]
    OverNightDeposit,
    
    /// <summary>
    /// Account not otherwise specified. 
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uLtjyfRYEeuLhpyIdtJzwg")]
    [Description(@"Account not otherwise specified. ")]
    OtherAccount,
    
    /// <summary>
    /// Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.
    /// Encoded/decoded by serializers as &quot;SACC&quot;.
    /// </summary>
    [EnumMember(Value = "SACC")]
    [IsoId("_uLtjzPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used to post debit and credit entries, as a result of transactions cleared and settled through a specific clearing and settlement system.")]
    Settlement,
    
    /// <summary>
    /// Accounts used for salary payments.
    /// Encoded/decoded by serializers as &quot;SLRY&quot;.
    /// </summary>
    [EnumMember(Value = "SLRY")]
    [IsoId("_uL2tsPRYEeuLhpyIdtJzwg")]
    [Description(@"Accounts used for salary payments.")]
    Salary,
    
    /// <summary>
    /// Account used for savings.
    /// Encoded/decoded by serializers as &quot;SVGS&quot;.
    /// </summary>
    [EnumMember(Value = "SVGS")]
    [IsoId("_uL2ts_RYEeuLhpyIdtJzwg")]
    [Description(@"Account used for savings.")]
    Savings,
    
    /// <summary>
    /// Account used for taxes if different from the account for|payment.
    /// Encoded/decoded by serializers as &quot;TAXE&quot;.
    /// </summary>
    [EnumMember(Value = "TAXE")]
    [IsoId("_uL2ttvRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for taxes if different from the account for|payment.")]
    Tax,
    
    /// <summary>
    /// A transacting account is the most basic type of bank account that you can get. The main difference between transaction and cheque accounts is that you usually do not get a cheque book with your transacting account and neither are you offered an overdraft facility.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_uL2tufRYEeuLhpyIdtJzwg")]
    [Description(@"A transacting account is the most basic type of bank account that you can get. The main difference between transaction and cheque accounts is that you usually do not get a cheque book with your transacting account and neither are you offered an overdraft facility.")]
    TransactingAccount,
    
    /// <summary>
    /// Account used for trading if different from the current cash|account.
    /// Encoded/decoded by serializers as &quot;TRAS&quot;.
    /// </summary>
    [EnumMember(Value = "TRAS")]
    [IsoId("_uL2tvPRYEeuLhpyIdtJzwg")]
    [Description(@"Account used for trading if different from the current cash|account.")]
    CashTrading,
    
    /// <summary>
    /// Account created virtually to facilitate collection and reconciliation.
    /// Encoded/decoded by serializers as &quot;VACC&quot;.
    /// </summary>
    [EnumMember(Value = "VACC")]
    [IsoId("_UtIU8I5FEeyANo-d7JlQ1A")]
    [Description(@"Account created virtually to facilitate collection and reconciliation.")]
    VirtualAccount,
    
    /// <summary>
    /// Non-Resident Individual / Entity Foreign Current held domestically.
    /// Encoded/decoded by serializers as &quot;NFCA&quot;.
    /// </summary>
    [EnumMember(Value = "NFCA")]
    [IsoId("_YbOMAGvbEe2F6NrIyOmXcA")]
    [Description(@"Non-Resident Individual / Entity Foreign Current held domestically.")]
    NonResidentForeignCurrencyAccount,
    
}
