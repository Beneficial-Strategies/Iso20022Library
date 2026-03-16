// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cheque18.
/// </summary>
[IsoId("_26nT0TEyEe6g-ffJsqGiSA")]
[DisplayName("Cheque18")]
public record Cheque18
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Cheque Cancellation Or Stop Status.
    /// </summary>
    [DisplayName("Cheque Cancellation Or Stop Status")]
    [IsoXmlTag("ChqCxlOrStopSts")]
    public required ChequeCancellationStatus1 ChequeCancellationOrStopStatus { get; init; }

    /// <summary>
    /// Cheque Number.
    /// </summary>
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    public required IsoMax35Text ChequeNumber { get; init; }

    /// <summary>
    /// Drawer Agent.
    /// </summary>
    [DisplayName("Drawer Agent")]
    [IsoXmlTag("DrwrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DrawerAgent { get; init; }

    /// <summary>
    /// Drawer Agent Account.
    /// </summary>
    [DisplayName("Drawer Agent Account")]
    [IsoXmlTag("DrwrAgtAcct")]
    public CashAccount40? DrawerAgentAccount { get; init; }

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTime2Choice_? EffectiveDate { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Issue Date.
    /// </summary>
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Original Instruction Identification.
    /// </summary>
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification272? Payee { get; init; }

    /// <summary>
    /// Payee Account.
    /// </summary>
    [DisplayName("Payee Account")]
    [IsoXmlTag("PyeeAcct")]
    public CashAccount40? PayeeAccount { get; init; }

    /// <summary>
    /// Stale Date.
    /// </summary>
    [DisplayName("Stale Date")]
    [IsoXmlTag("StlDt")]
    public IsoISODate? StaleDate { get; init; }
}
