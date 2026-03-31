// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cheque17.
/// </summary>
[IsoId("_09KvsTEyEe6g-ffJsqGiSA")]
[DisplayName("Cheque17")]
public record Cheque17
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

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
    /// Instruction For Cheque Agent.
    /// </summary>
    [DisplayName("Instruction For Cheque Agent")]
    [IsoXmlTag("InstrForChqAgt")]
    public ValueList<InstructionForChequeAgent1> InstructionForChequeAgent { get; init; } = [];

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
    /// Payee.
    /// </summary>
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public required PartyIdentification272 Payee { get; init; }

    /// <summary>
    /// Payee Account.
    /// </summary>
    [DisplayName("Payee Account")]
    [IsoXmlTag("PyeeAcct")]
    public CashAccount40? PayeeAccount { get; init; }

    /// <summary>
    /// Payer.
    /// </summary>
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification272? Payer { get; init; }

    /// <summary>
    /// Payer Account.
    /// </summary>
    [DisplayName("Payer Account")]
    [IsoXmlTag("PyerAcct")]
    public CashAccount40? PayerAccount { get; init; }

    /// <summary>
    /// Stale Date.
    /// </summary>
    [DisplayName("Stale Date")]
    [IsoXmlTag("StlDt")]
    public IsoISODate? StaleDate { get; init; }

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }
}
