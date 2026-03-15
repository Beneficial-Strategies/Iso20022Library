// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aevNwNp-Ed-ak6NoX_4Aeg_-1698330264")]
[Description(@"Specifies the type of risk management limit.")]
[Derivations(typeof(LimitType4Code),typeof(LimitType3Code),typeof(LimitType2Code))]
public enum LimitTypeCode
{
    /// <summary>
    /// Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_aevNwdp-Ed-ak6NoX_4Aeg_-1698330263")]
    [Description(@"Limit is a maximum amount value applied to, or by, a participant to a set of counterparties. The multilateral limit is taken into account by the transaction administrator to contain the risk in the system. With the help of the multilateral limit, the direct participant restricts the use of liquidity when clearing payments with all other direct participants for which no bilateral limit is set.")]
    Multilateral,
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;BILI&quot;.
    /// </summary>
    [EnumMember(Value = "BILI")]
    [IsoId("_aevNwtp-Ed-ak6NoX_4Aeg_-1698330255")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    Bilateral,
    
    /// <summary>
    /// Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.
    /// Encoded/decoded by serializers as &quot;NELI&quot;.
    /// </summary>
    [EnumMember(Value = "NELI")]
    [IsoId("_aevNw9p-Ed-ak6NoX_4Aeg_-1698330254")]
    [Description(@"Limit is applied by one party to a specific counterparty, and corresponds to the maximum net balance acceptable by the party that is setting the limit. The limit is calculated as an arithmetic sum in value of the bilateral flows exchanged between the two parties. The net bilateral limit can be expressed as a debit or a credit balance.")]
    NetBilateral,
    
    /// <summary>
    /// Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.
    /// Encoded/decoded by serializers as &quot;INBI&quot;.
    /// </summary>
    [EnumMember(Value = "INBI")]
    [IsoId("_aevNxNp-Ed-ak6NoX_4Aeg_-1698330253")]
    [Description(@"Limit is a maximum value set by a direct participant with respect to its indirect participant. The limit represents the maximum amount the indirect participant can use to settle its operations.")]
    IndirectBilateral,
    
    /// <summary>
    /// Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.
    /// Encoded/decoded by serializers as &quot;GLBL&quot;.
    /// </summary>
    [EnumMember(Value = "GLBL")]
    [IsoId("_aevNxdp-Ed-ak6NoX_4Aeg_-418005556")]
    [Description(@"Maximum value set by either the transaction administrator or by a member for the participation of a member in the system. The global limit may be expressed as a credit or debit maximum value and is taken into account by the transaction administrator when processing transaction inside the system. With the help of the global limit, the direct participant may limit the use of liquidity when clearing specific type of payments.")]
    Global,
    
    /// <summary>
    /// Mandatory part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_aevNxtp-Ed-ak6NoX_4Aeg_-1004098496")]
    [Description(@"Mandatory part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    MandatoryBilateral,
    
    /// <summary>
    /// Discretionary part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ae4XsNp-Ed-ak6NoX_4Aeg_-1004098454")]
    [Description(@"Discretionary part of the bilateral limit applied by one party to a specific counterparty, and corresponds to the maximum amount of traffic party setting the limit can send to that counterparty. The limit can be expressed as a debit or a credit limit. With the help of a bilateral limit, the direct participant restricts the use of liquidity when clearing payments with another direct participant.")]
    DiscretionaryBilateral,
    
    /// <summary>
    /// Limit not to be exceeded for direct debit operations.
    /// Encoded/decoded by serializers as &quot;DIDB&quot;.
    /// </summary>
    [EnumMember(Value = "DIDB")]
    [IsoId("_ae4Xsdp-Ed-ak6NoX_4Aeg_-956999426")]
    [Description(@"Limit not to be exceeded for direct debit operations.")]
    DirectDebit,
    
    /// <summary>
    /// Single direct debit payment limit not to be exceeded by any single direct debit transaction by a customer.
    /// Encoded/decoded by serializers as &quot;SPLC&quot;.
    /// </summary>
    [EnumMember(Value = "SPLC")]
    [IsoId("_ae4Xstp-Ed-ak6NoX_4Aeg_-956999409")]
    [Description(@"Single direct debit payment limit not to be exceeded by any single direct debit transaction by a customer.")]
    SingleCustomerDirectDebit,
    
    /// <summary>
    /// Single direct debit payment limit not to be exceeded by any single direct debit transaction initiated by a financial institution.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_ae4Xs9p-Ed-ak6NoX_4Aeg_-956999366")]
    [Description(@"Single direct debit payment limit not to be exceeded by any single direct debit transaction initiated by a financial institution.")]
    SingleFinancialInstitutionDirectDebit,
    
    /// <summary>
    /// Total daily payments limit for customer direct debits not to be exceeded by the total of all direct debit transactions initiated by customers.
    /// Encoded/decoded by serializers as &quot;TDLC&quot;.
    /// </summary>
    [EnumMember(Value = "TDLC")]
    [IsoId("_ae4XtNp-Ed-ak6NoX_4Aeg_-956999331")]
    [Description(@"Total daily payments limit for customer direct debits not to be exceeded by the total of all direct debit transactions initiated by customers.")]
    TotalDailyCustomerDirectDebit,
    
    /// <summary>
    /// Total daily payments limit for financial institutions direct debits not to be exceeded by the total of all direct debit transactions initiated by financial institutions.
    /// Encoded/decoded by serializers as &quot;TDLF&quot;.
    /// </summary>
    [EnumMember(Value = "TDLF")]
    [IsoId("_ae4Xtdp-Ed-ak6NoX_4Aeg_-956999289")]
    [Description(@"Total daily payments limit for financial institutions direct debits not to be exceeded by the total of all direct debit transactions initiated by financial institutions.")]
    TotalDailyFinancialInstitutionDirectDebit,
    
    /// <summary>
    /// Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”).
    /// Encoded/decoded by serializers as &quot;ACOL&quot;.
    /// </summary>
    [EnumMember(Value = "ACOL")]
    [IsoId("_g6qO0mliEeGaMcKyqKNRfQ_1114973959")]
    [Description(@"Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”).")]
    AutoCollateralisation,
    
    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure.
    /// Encoded/decoded by serializers as &quot;UCDT&quot;.
    /// </summary>
    [EnumMember(Value = "UCDT")]
    [IsoId("_g6qO0GliEeGaMcKyqKNRfQ_1316540946")]
    [Description(@"Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure.")]
    UnsecuredCredit,
    
    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank.
    /// Encoded/decoded by serializers as &quot;EXGT&quot;.
    /// </summary>
    [EnumMember(Value = "EXGT")]
    [IsoId("_g6qO0WliEeGaMcKyqKNRfQ_-1032190019")]
    [Description(@"Limit is related to a cap amount granted by a national central bank or a settlement bank.")]
    ExternalGuarantee,
    
}
