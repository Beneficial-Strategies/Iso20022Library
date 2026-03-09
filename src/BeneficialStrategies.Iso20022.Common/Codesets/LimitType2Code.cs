// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aecS19p-Ed-ak6NoX_4Aeg_-1945298768")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum LimitType2Code
{
    /// <summary>
    /// Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_aecS2Np-Ed-ak6NoX_4Aeg_-1945298749")]
    [Description(@"Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.")]
    Multilateral = LimitTypeCode.Multilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;BILI&quot;.
    /// </summary>
    [EnumMember(Value = "BILI")]
    [IsoId("_aelcwNp-Ed-ak6NoX_4Aeg_-1945298725")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    Bilateral = LimitTypeCode.Bilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_aelcwdp-Ed-ak6NoX_4Aeg_643064875")]
    [Description(@"Mandatory part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    MandatoryBilateral = LimitTypeCode.MandatoryBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Discretionary part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aelcwtp-Ed-ak6NoX_4Aeg_669847845")]
    [Description(@"Discretionary part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    DiscretionaryBilateral = LimitTypeCode.DiscretionaryBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_aelcw9p-Ed-ak6NoX_4Aeg_-1945298708")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.")]
    NetBilateral = LimitTypeCode.NetBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.
    /// Encoded/decoded by serializers as &quot;INBI&quot;.
    /// </summary>
    [EnumMember(Value = "INBI")]
    [IsoId("_aelcxNp-Ed-ak6NoX_4Aeg_-1945298707")]
    [Description(@"Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.")]
    IndirectBilateral = LimitTypeCode.IndirectBilateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_aelcxdp-Ed-ak6NoX_4Aeg_-1945298690")]
    [Description(@"Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.")]
    Global = LimitTypeCode.Global, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Limit not to be exceeded for direct debit operations.
    /// Encoded/decoded by serializers as &quot;DIDB&quot;.
    /// </summary>
    [EnumMember(Value = "DIDB")]
    [IsoId("_aelcxtp-Ed-ak6NoX_4Aeg_-1357778967")]
    [Description(@"Limit not to be exceeded for direct debit operations.")]
    DirectDebit = LimitTypeCode.DirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single direct debit payment limit not to be exceeded by any single direct debit transaction by a customer.
    /// Encoded/decoded by serializers as &quot;SPLC&quot;.
    /// </summary>
    [EnumMember(Value = "SPLC")]
    [IsoId("_aelcx9p-Ed-ak6NoX_4Aeg_1042026748")]
    [Description(@"Single direct debit payment limit not to be exceeded by any single direct debit transaction by a customer.")]
    SingleCustomerDirectDebit = LimitTypeCode.SingleCustomerDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single direct debit payment limit not to be exceeded by any single direct debit transaction initiated by a financial institution.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_aelcyNp-Ed-ak6NoX_4Aeg_1061422207")]
    [Description(@"Single direct debit payment limit not to be exceeded by any single direct debit transaction initiated by a financial institution.")]
    SingleFinancialInstitutionDirectDebit = LimitTypeCode.SingleFinancialInstitutionDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total daily payments limit for customer direct debits not to be exceeded by the total of all direct debit transactions initiated by customers.
    /// Encoded/decoded by serializers as &quot;TDLC&quot;.
    /// </summary>
    [EnumMember(Value = "TDLC")]
    [IsoId("_aelcydp-Ed-ak6NoX_4Aeg_1089126865")]
    [Description(@"Total daily payments limit for customer direct debits not to be exceeded by the total of all direct debit transactions initiated by customers.")]
    TotalDailyCustomerDirectDebit = LimitTypeCode.TotalDailyCustomerDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Total daily payments limit for financial institutions direct debits not to be exceeded by the total of all direct debit transactions initiated by financial institutions.
    /// Encoded/decoded by serializers as &quot;TDLF&quot;.
    /// </summary>
    [EnumMember(Value = "TDLF")]
    [IsoId("_aelcytp-Ed-ak6NoX_4Aeg_1090974824")]
    [Description(@"Total daily payments limit for financial institutions direct debits not to be exceeded by the total of all direct debit transactions initiated by financial institutions.")]
    TotalDailyFinancialInstitutionDirectDebit = LimitTypeCode.TotalDailyFinancialInstitutionDirectDebit, // same ordinal as derivation source for type conversions
    
}
