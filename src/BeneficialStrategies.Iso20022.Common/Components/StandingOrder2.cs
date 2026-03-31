// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the detailed attributes of a standing order.
/// </summary>
[IsoId("_7-RqxKMgEeCJ6YNENx4h-w_-305246324")]
[DisplayName("Standing Order")]
public record StandingOrder2
{
    /// <summary>
    /// Amount of money and currency to be transferred when a payment instruction is created as a result of a standing order.
    /// </summary>
    [IsoId("_7-RqxaMgEeCJ6YNENx4h-w_-1986263654")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; }

    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [IsoId("_7-RqxqMgEeCJ6YNENx4h-w_740803250")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_7-Rqx6MgEeCJ6YNENx4h-w_-347646741")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Type of the standing order.
    /// </summary>
    [IsoId("_7-bbwKMgEeCJ6YNENx4h-w_-1880922960")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public StandingOrderType1Choice_? Type { get; init; }

    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_7-bbwaMgEeCJ6YNENx4h-w_-1558653346")]
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_7-bbwqMgEeCJ6YNENx4h-w_-1545122205")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Regularity with which payment instructions are to be created and processed as a result of the standing order, such as daily, weekly, or monthly.
    /// </summary>
    [IsoId("_7-bbw6MgEeCJ6YNENx4h-w_1622282302")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency2Code? Frequency { get; init; }

    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_7-bbxKMgEeCJ6YNENx4h-w_-51000641")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriodDetails1? ValidityPeriod { get; init; }

    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [IsoId("_7-bbxaMgEeCJ6YNENx4h-w_649425612")]
    [DisplayName("System Member")]
    [IsoXmlTag("SysMmb")]
    public BranchAndFinancialInstitutionIdentification5? SystemMember { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_7-bbxqMgEeCJ6YNENx4h-w_-1344719094")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public BranchAndFinancialInstitutionIdentification5? ResponsibleParty { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
    /// </summary>
    [IsoId("_7-bbx6MgEeCJ6YNENx4h-w_1953175849")]
    [DisplayName("Link Set Identification")]
    [IsoXmlTag("LkSetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkSetIdentification { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
    /// </summary>
    [IsoId("_7-lMwKMgEeCJ6YNENx4h-w_414157345")]
    [DisplayName("Link Set Order Identification")]
    [IsoXmlTag("LkSetOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; }

    /// <summary>
    /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
    /// </summary>
    [IsoId("_7-lMwaMgEeCJ6YNENx4h-w_46283719")]
    [DisplayName("Link Set Order Sequence")]
    [IsoXmlTag("LkSetOrdrSeq")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LinkSetOrderSequence { get; init; }

    /// <summary>
    /// Defines whether the standing order is executed through a time-based or an event-based trigger.
    /// </summary>
    [IsoId("_7-lMwqMgEeCJ6YNENx4h-w_9714746")]
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public ExecutionType1Choice_? ExecutionType { get; init; }

    /// <summary>
    /// Cash account credited from a standing order mechanism.
    /// </summary>
    [IsoId("_7-lMw6MgEeCJ6YNENx4h-w_1006787099")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <summary>
    /// Cash account debited from a standing order mechanism.
    /// </summary>
    [IsoId("_7-lMxKMgEeCJ6YNENx4h-w_-987357607")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <summary>
    /// Overall amount of &quot;not yet executed&quot; predefined liquidity transfer orders or &quot;defined&quot; by a system participant in its sphere of responsibility within the system.
    /// </summary>
    [IsoId("_7-lMxaMgEeCJ6YNENx4h-w_722379147")]
    [DisplayName("Totals Per Standing Order")]
    [IsoXmlTag("TtlsPerStgOrdr")]
    public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; }

    /// <summary>
    /// Indicates whether the liquidity transfer standing order is defined as a zero sweeping order. When true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_7-lMxqMgEeCJ6YNENx4h-w_1380829379")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
