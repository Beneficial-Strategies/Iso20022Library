// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cardholder account used for the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TV8F7AEcEeCQm6a_G2yO_w_398677392")]
[Description(@"Type of cardholder account used for the transaction.")]
[Derivations(
    typeof(CardAccountType1Code),
    typeof(CardAccountType2Code),
    typeof(CardAccountType3Code)
)]
public enum CardAccountTypeCode
{
    /// <summary>
    /// Default account.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_TV8F7QEcEeCQm6a_G2yO_w_-1096315740")]
    [Description(@"Default account.")]
    Default,

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_TV8F7gEcEeCQm6a_G2yO_w_1937282486")]
    [Description(@"Savings account.")]
    Savings,

    /// <summary>
    /// Checking account.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_TV8F7wEcEeCQm6a_G2yO_w_537868193")]
    [Description(@"Checking account.")]
    Checking,

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TV8F8AEcEeCQm6a_G2yO_w_-2037318629")]
    [Description(@"Credit card account.")]
    CreditCard,

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_TV8F8QEcEeCQm6a_G2yO_w_2127793109")]
    [Description(@"Universal account.")]
    Universal,

    /// <summary>
    /// Investment account.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_TV8F8gEcEeCQm6a_G2yO_w_-1003979586")]
    [Description(@"Investment account.")]
    Investment,

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_TWF24AEcEeCQm6a_G2yO_w_1085728270")]
    [Description(@"Electronic purse card account.")]
    EpurseCard,

    /// <summary>
    /// Certificate of deposit saving account.
    /// Encoded/decoded by serializers as &quot;CTDP&quot;.
    /// </summary>
    [EnumMember(Value = "CTDP")]
    [IsoId("_96VSMGkEEeS7zPBpvm732w")]
    [Description(@"Certificate of deposit saving account.")]
    CertificateOfDeposit,

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_C4t3wGkFEeS7zPBpvm732w")]
    [Description(@"Current account.")]
    Current,

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_GI6dMGkFEeS7zPBpvm732w")]
    [Description(@"Debit card account.")]
    DebitCard,

    /// <summary>
    /// Home equity loan credit account.
    /// Encoded/decoded by serializers as &quot;HEQL&quot;.
    /// </summary>
    [EnumMember(Value = "HEQL")]
    [IsoId("_KfeNwGkFEeS7zPBpvm732w")]
    [Description(@"Home equity loan credit account.")]
    HomeEquityLoan,

    /// <summary>
    /// Instalment loan credit account.
    /// Encoded/decoded by serializers as &quot;ISTL&quot;.
    /// </summary>
    [EnumMember(Value = "ISTL")]
    [IsoId("_NXQ6QGkFEeS7zPBpvm732w")]
    [Description(@"Instalment loan credit account.")]
    InstalmentLoan,

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_RIuZsGkFEeS7zPBpvm732w")]
    [Description(@"Line of credit account.")]
    LineOfCredit,

    /// <summary>
    /// Mobile Station Integrated Services Digital Network Number (MSISDN).
    /// Encoded/decoded by serializers as &quot;MBNW&quot;.
    /// </summary>
    [EnumMember(Value = "MBNW")]
    [IsoId("_TvgOsGkFEeS7zPBpvm732w")]
    [Description(@"Mobile Station Integrated Services Digital Network Number (MSISDN).")]
    MobilePhoneAccount,

    /// <summary>
    /// Money market saving account.
    /// Encoded/decoded by serializers as &quot;MNMK&quot;.
    /// </summary>
    [EnumMember(Value = "MNMK")]
    [IsoId("_dNvDsGkFEeS7zPBpvm732w")]
    [Description(@"Money market saving account.")]
    MoneyMarket,

    /// <summary>
    /// Money market checking account.
    /// Encoded/decoded by serializers as &quot;MNMC&quot;.
    /// </summary>
    [EnumMember(Value = "MNMC")]
    [IsoId("_fpJ9QGkFEeS7zPBpvm732w")]
    [Description(@"Money market checking account.")]
    MoneyMarketChecking,

    /// <summary>
    /// Mortgage loan credit account.
    /// Encoded/decoded by serializers as &quot;MTGL&quot;.
    /// </summary>
    [EnumMember(Value = "MTGL")]
    [IsoId("_i_iDMGkFEeS7zPBpvm732w")]
    [Description(@"Mortgage loan credit account.")]
    MortgageLoan,

    /// <summary>
    /// Retirement account.
    /// Encoded/decoded by serializers as &quot;RTRM&quot;.
    /// </summary>
    [EnumMember(Value = "RTRM")]
    [IsoId("_lVJPsGkFEeS7zPBpvm732w")]
    [Description(@"Retirement account.")]
    RetirementAccount,

    /// <summary>
    /// Revolving loan account.
    /// Encoded/decoded by serializers as &quot;RVLV&quot;.
    /// </summary>
    [EnumMember(Value = "RVLV")]
    [IsoId("_pdRisGkFEeS7zPBpvm732w")]
    [Description(@"Revolving loan account.")]
    RevolvingLoanAccount,

    /// <summary>
    /// Stock or bond investment account.
    /// Encoded/decoded by serializers as &quot;STBD&quot;.
    /// </summary>
    [EnumMember(Value = "STBD")]
    [IsoId("_sR8CsGkFEeS7zPBpvm732w")]
    [Description(@"Stock or bond investment account.")]
    StockOrBond,

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_Eu6J8I0kEeWzoK7sd7oTyw")]
    [Description(@"Pre-paid account.")]
    PrePaid,

    /// <summary>
    /// Fleet card account.
    /// Encoded/decoded by serializers as &quot;FLTC&quot;.
    /// </summary>
    [EnumMember(Value = "FLTC")]
    [IsoId("_chVI8JKYEeWRcecbKhfKuQ")]
    [Description(@"Fleet card account.")]
    FleetCard,

    /// <summary>
    /// Cash as a source type  to perform the transaction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_mQXYcE9OEeeg87n1YQSQ_A")]
    [Description(@"Cash as a source type  to perform the transaction.")]
    Cash,

    /// <summary>
    /// Account for debiting funds.
    /// Encoded/decoded by serializers as &quot;DBAC&quot;.
    /// </summary>
    [EnumMember(Value = "DBAC")]
    [IsoId("_0wUa4E9OEeeg87n1YQSQ_A")]
    [Description(@"Account for debiting funds.")]
    DebitAccount,

    /// <summary>
    /// Account for crediting funds.
    /// Encoded/decoded by serializers as &quot;CRAC&quot;.
    /// </summary>
    [EnumMember(Value = "CRAC")]
    [IsoId("_78z2wE9OEeeg87n1YQSQ_A")]
    [Description(@"Account for crediting funds.")]
    CreditAccount,

    /// <summary>
    /// Other type of account defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EGR4QE9PEeeg87n1YQSQ_A")]
    [Description(@"Other type of account defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of account defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Irz48E9PEeeg87n1YQSQ_A")]
    [Description(@"Other type of account defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Benefit account type
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_Ivr2EBeyEeicUaFCgptJRQ")]
    [Description(@"Benefit account type")]
    Benefit,
}
