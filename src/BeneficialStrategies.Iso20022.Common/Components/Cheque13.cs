// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_2YR7EQF9EeuDW9bNZAE8VA")]
[DisplayName("Cheque")]
public record Cheque13
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_2mTI8AF9EeuDW9bNZAE8VA")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_2Z2oYQF9EeuDW9bNZAE8VA")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ChequeNumber { get; init; }

    /// <summary>
    /// Date when the cheque has been issued by the payer.
    /// </summary>
    [IsoId("_2Z2oYwF9EeuDW9bNZAE8VA")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Date after which a cheque is no longer valid. The validity period of a cheque is calculated from the issue date on the face of the cheque.  The period may be indicated on the face of the cheque itself such as &quot;Valid for 90 days” or may be determined in accordance with domestic banking practice.
    /// Not all countries will have a validity period.
    /// </summary>
    [IsoId("_AAEUsAF-EeuDW9bNZAE8VA")]
    [DisplayName("Stale Date")]
    [IsoXmlTag("StlDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StaleDate { get; init; }

    /// <summary>
    /// Specifies the amount of the cheque to be paid to the payee.
    /// </summary>
    [IsoId("_2Z2oZQF9EeuDW9bNZAE8VA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Date and time at which the cheque amount becomes available on the payee account.
    /// </summary>
    [IsoId("_2Z2oZwF9EeuDW9bNZAE8VA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [IsoId("_2Z2oaQF9EeuDW9bNZAE8VA")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification135? Payer { get; init; }

    /// <summary>
    /// Specifies the cash account of the payer.
    /// </summary>
    [IsoId("_2Z2oawF9EeuDW9bNZAE8VA")]
    [DisplayName("Payer Account")]
    [IsoXmlTag("PyerAcct")]
    public CashAccount40? PayerAccount { get; init; }

    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [IsoId("_2Z2obQF9EeuDW9bNZAE8VA")]
    [DisplayName("Drawer Agent")]
    [IsoXmlTag("DrwrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; }

    /// <summary>
    /// Specifies the cash account of the drawer agent.
    /// </summary>
    [IsoId("_2Z2obwF9EeuDW9bNZAE8VA")]
    [DisplayName("Drawer Agent Account")]
    [IsoXmlTag("DrwrAgtAcct")]
    public CashAccount40? DrawerAgentAccount { get; init; }

    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    [IsoId("_2Z2ocQF9EeuDW9bNZAE8VA")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public required PartyIdentification135 Payee { get; init; }

    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    [IsoId("_-6PAsSkfEeuBrrgCSpsocg")]
    [DisplayName("Payee Account")]
    [IsoXmlTag("PyeeAcct")]
    public CashAccount40? PayeeAccount { get; init; }

    /// <summary>
    /// Further information related to the processing of the cheque instruction that may need to be acted upon by the agent processing the cheque.
    /// </summary>
    [IsoId("_i4gX4Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Instruction For Cheque Agent")]
    [IsoXmlTag("InstrForChqAgt")]
    public ValueList<InstructionForChequeAgent1> InstructionForChequeAgent { get; init; } = [];
}
