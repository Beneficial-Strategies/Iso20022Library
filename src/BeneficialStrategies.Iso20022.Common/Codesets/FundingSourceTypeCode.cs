// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of funding source used for a financial service
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LeQrPNwoEeeiWo5KG3eipw")]
[Description(@"Type of funding source used for a financial service")]
[Derivations(typeof(FundingSourceType2Code))]
public enum FundingSourceTypeCode
{
    /// <summary>
    /// Default account.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_LeQrP9woEeeiWo5KG3eipw")]
    [Description(@"Default account.")]
    Default,

    /// <summary>
    /// Savings account.
    /// Encoded/decoded by serializers as &quot;SVNG&quot;.
    /// </summary>
    [EnumMember(Value = "SVNG")]
    [IsoId("_LeQrPtwoEeeiWo5KG3eipw")]
    [Description(@"Savings account.")]
    Savings,

    /// <summary>
    /// Checking account.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_LeQrTdwoEeeiWo5KG3eipw")]
    [Description(@"Checking account.")]
    Checking,

    /// <summary>
    /// Credit card account.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_LeQrU9woEeeiWo5KG3eipw")]
    [Description(@"Credit card account.")]
    CreditCard,

    /// <summary>
    /// Universal account.
    /// Encoded/decoded by serializers as &quot;UVRL&quot;.
    /// </summary>
    [EnumMember(Value = "UVRL")]
    [IsoId("_LeQrT9woEeeiWo5KG3eipw")]
    [Description(@"Universal account.")]
    Universal,

    /// <summary>
    /// Investment account.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_LeQrSdwoEeeiWo5KG3eipw")]
    [Description(@"Investment account.")]
    Investment,

    /// <summary>
    /// Electronic purse card account.
    /// Encoded/decoded by serializers as &quot;EPRS&quot;.
    /// </summary>
    [EnumMember(Value = "EPRS")]
    [IsoId("_LeQrRdwoEeeiWo5KG3eipw")]
    [Description(@"Electronic purse card account.")]
    EpurseCard,

    /// <summary>
    /// Certificate of deposit saving account.
    /// Encoded/decoded by serializers as &quot;CTDP&quot;.
    /// </summary>
    [EnumMember(Value = "CTDP")]
    [IsoId("_LeQrSNwoEeeiWo5KG3eipw")]
    [Description(@"Certificate of deposit saving account.")]
    CertificateOfDeposit,

    /// <summary>
    /// Current account.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_LeQrVtwoEeeiWo5KG3eipw")]
    [Description(@"Current account.")]
    Current,

    /// <summary>
    /// Debit card account.
    /// Encoded/decoded by serializers as &quot;CDBT&quot;.
    /// </summary>
    [EnumMember(Value = "CDBT")]
    [IsoId("_LeQrUtwoEeeiWo5KG3eipw")]
    [Description(@"Debit card account.")]
    DebitCard,

    /// <summary>
    /// Home equity loan credit account.
    /// Encoded/decoded by serializers as &quot;HEQL&quot;.
    /// </summary>
    [EnumMember(Value = "HEQL")]
    [IsoId("_LeQrV9woEeeiWo5KG3eipw")]
    [Description(@"Home equity loan credit account.")]
    HomeEquityLoan,

    /// <summary>
    /// Instalment loan credit account.
    /// Encoded/decoded by serializers as &quot;ISTL&quot;.
    /// </summary>
    [EnumMember(Value = "ISTL")]
    [IsoId("_LeQrUNwoEeeiWo5KG3eipw")]
    [Description(@"Instalment loan credit account.")]
    InstalmentLoan,

    /// <summary>
    /// Line of credit account.
    /// Encoded/decoded by serializers as &quot;LCDT&quot;.
    /// </summary>
    [EnumMember(Value = "LCDT")]
    [IsoId("_LeQrS9woEeeiWo5KG3eipw")]
    [Description(@"Line of credit account.")]
    LineOfCredit,

    /// <summary>
    /// Mobile Station Integrated Services Digital Network Number (MSISDN).
    /// Encoded/decoded by serializers as &quot;MBNW&quot;.
    /// </summary>
    [EnumMember(Value = "MBNW")]
    [IsoId("_LeQrQtwoEeeiWo5KG3eipw")]
    [Description(@"Mobile Station Integrated Services Digital Network Number (MSISDN).")]
    MobilePhoneAccount,

    /// <summary>
    /// Money market saving account.
    /// Encoded/decoded by serializers as &quot;MNMK&quot;.
    /// </summary>
    [EnumMember(Value = "MNMK")]
    [IsoId("_LeQrRNwoEeeiWo5KG3eipw")]
    [Description(@"Money market saving account.")]
    MoneyMarket,

    /// <summary>
    /// Money market checking account.
    /// Encoded/decoded by serializers as &quot;MNMC&quot;.
    /// </summary>
    [EnumMember(Value = "MNMC")]
    [IsoId("_LeQrQdwoEeeiWo5KG3eipw")]
    [Description(@"Money market checking account.")]
    MoneyMarketChecking,

    /// <summary>
    /// Mortgage loan credit account.
    /// Encoded/decoded by serializers as &quot;MTGL&quot;.
    /// </summary>
    [EnumMember(Value = "MTGL")]
    [IsoId("_LeQrR9woEeeiWo5KG3eipw")]
    [Description(@"Mortgage loan credit account.")]
    MortgageLoan,

    /// <summary>
    /// Retirement account.
    /// Encoded/decoded by serializers as &quot;RTRM&quot;.
    /// </summary>
    [EnumMember(Value = "RTRM")]
    [IsoId("_LeQrVdwoEeeiWo5KG3eipw")]
    [Description(@"Retirement account.")]
    RetirementAccount,

    /// <summary>
    /// Revolving loan account.
    /// Encoded/decoded by serializers as &quot;RVLV&quot;.
    /// </summary>
    [EnumMember(Value = "RVLV")]
    [IsoId("_LeQrTtwoEeeiWo5KG3eipw")]
    [Description(@"Revolving loan account.")]
    RevolvingLoanAccount,

    /// <summary>
    /// Stock or bond investment account.
    /// Encoded/decoded by serializers as &quot;STBD&quot;.
    /// </summary>
    [EnumMember(Value = "STBD")]
    [IsoId("_LeQrVNwoEeeiWo5KG3eipw")]
    [Description(@"Stock or bond investment account.")]
    StockOrBond,

    /// <summary>
    /// Pre-paid account.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_LeQrPdwoEeeiWo5KG3eipw")]
    [Description(@"Pre-paid account.")]
    PrePaid,

    /// <summary>
    /// Fleet card account.
    /// Encoded/decoded by serializers as &quot;FLTC&quot;.
    /// </summary>
    [EnumMember(Value = "FLTC")]
    [IsoId("_LeQrStwoEeeiWo5KG3eipw")]
    [Description(@"Fleet card account.")]
    FleetCard,

    /// <summary>
    /// Cash as a source type  to perform the transaction.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_LeQrRtwoEeeiWo5KG3eipw")]
    [Description(@"Cash as a source type  to perform the transaction.")]
    Cash,

    /// <summary>
    /// Account for debiting funds.
    /// Encoded/decoded by serializers as &quot;DBAC&quot;.
    /// </summary>
    [EnumMember(Value = "DBAC")]
    [IsoId("_LeQrTNwoEeeiWo5KG3eipw")]
    [Description(@"Account for debiting funds.")]
    DebitAccount,

    /// <summary>
    /// Account for crediting funds.
    /// Encoded/decoded by serializers as &quot;CRAC&quot;.
    /// </summary>
    [EnumMember(Value = "CRAC")]
    [IsoId("_LeQrQNwoEeeiWo5KG3eipw")]
    [Description(@"Account for crediting funds.")]
    CreditAccount,

    /// <summary>
    /// Other type of account defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_LeQrUdwoEeeiWo5KG3eipw")]
    [Description(@"Other type of account defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of account defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_LeQrQ9woEeeiWo5KG3eipw")]
    [Description(@"Other type of account defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as &quot;CHQE&quot;.
    /// </summary>
    [EnumMember(Value = "CHQE")]
    [IsoId("_hsPJMNwoEeeiWo5KG3eipw")]
    [Description(@"Cheque")]
    Cheque,

    /// <summary>
    /// Loyalty points converted into cash
    /// Encoded/decoded by serializers as &quot;LOYL&quot;.
    /// </summary>
    [EnumMember(Value = "LOYL")]
    [IsoId("_odBggNwoEeeiWo5KG3eipw")]
    [Description(@"Loyalty points converted into cash")]
    Loyaly,
}
