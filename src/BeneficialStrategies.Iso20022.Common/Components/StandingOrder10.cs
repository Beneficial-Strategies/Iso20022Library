// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order10.
/// </summary>
[IsoId("_yhhMoTEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order10")]
public record StandingOrder10
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount2Choice_? Amount { get; init; }

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
    /// Validity Period.
    /// </summary>
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; }

    /// <summary>
    /// Zero Sweep Indicator.
    /// </summary>
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
