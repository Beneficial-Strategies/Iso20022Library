// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order11.
/// </summary>
[IsoId("_z6GJJTEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order11")]
public record StandingOrder11
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; }

    /// <summary>
    /// Associated Pool Account.
    /// </summary>
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification8? Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification8? Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Execution Type.
    /// </summary>
    [DisplayName("Execution Type")]
    [IsoXmlTag("ExctnTp")]
    public ExecutionType1Choice_? ExecutionType { get; init; }

    /// <summary>
    /// Frequency.
    /// </summary>
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public Frequency2Code? Frequency { get; init; }

    /// <summary>
    /// Link Set Identification.
    /// </summary>
    [DisplayName("Link Set Identification")]
    [IsoXmlTag("LkSetId")]
    public IsoMax35Text? LinkSetIdentification { get; init; }

    /// <summary>
    /// Link Set Order Identification.
    /// </summary>
    [DisplayName("Link Set Order Identification")]
    [IsoXmlTag("LkSetOrdrId")]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; }

    /// <summary>
    /// Link Set Order Sequence.
    /// </summary>
    [DisplayName("Link Set Order Sequence")]
    [IsoXmlTag("LkSetOrdrSeq")]
    public IsoNumber? LinkSetOrderSequence { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Responsible Party.
    /// </summary>
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public BranchAndFinancialInstitutionIdentification8? ResponsibleParty { get; init; }

    /// <summary>
    /// System Member.
    /// </summary>
    [DisplayName("System Member")]
    [IsoXmlTag("SysMmb")]
    public BranchAndFinancialInstitutionIdentification8? SystemMember { get; init; }

    /// <summary>
    /// Totals Per Standing Order.
    /// </summary>
    [DisplayName("Totals Per Standing Order")]
    [IsoXmlTag("TtlsPerStgOrdr")]
    public StandingOrderTotalAmount1? TotalsPerStandingOrder { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public StandingOrderType1Choice_? Type { get; init; }

    /// <summary>
    /// Validity Period.
    /// </summary>
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod3? ValidityPeriod { get; init; }

    /// <summary>
    /// Zero Sweep Indicator.
    /// </summary>
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
