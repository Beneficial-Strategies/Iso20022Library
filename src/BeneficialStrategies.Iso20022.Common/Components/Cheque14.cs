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
[IsoId("_cRHMkbtuEeq_cfXrH83Rcw")]
[DisplayName("Cheque")]
public record Cheque14
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_35u6gCmwEeutWNGMV2XKIQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_B1s0YSmxEeutWNGMV2XKIQ")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_cSN_0btuEeq_cfXrH83Rcw")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ChequeNumber { get; init; }

    /// <summary>
    /// Date when the cheque has been issued by the payer.
    /// </summary>
    [IsoId("_cSN_07tuEeq_cfXrH83Rcw")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }

    /// <summary>
    /// Date after which a cheque is no longer valid. The validity period of a cheque is calculated from the issue date on the face of the cheque.  The period may be indicated on the face of the cheque itself such as &quot;Valid for 90 days” or may be determined in accordance with domestic banking practice.
    /// Not all countries will have a validity period.
    /// </summary>
    [IsoId("_Nfnd0SmxEeutWNGMV2XKIQ")]
    [DisplayName("Stale Date")]
    [IsoXmlTag("StlDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StaleDate { get; init; }

    /// <summary>
    /// Specifies the amount of the cheque to be paid to the payee.
    /// </summary>
    [IsoId("_cSN_1btuEeq_cfXrH83Rcw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Date and time at which the cheque amount becomes available on the payee account.
    /// </summary>
    [IsoId("_cSN_17tuEeq_cfXrH83Rcw")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public DateAndDateTime2Choice_? EffectiveDate { get; init; }

    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [IsoId("_cSN_3btuEeq_cfXrH83Rcw")]
    [DisplayName("Drawer Agent")]
    [IsoXmlTag("DrwrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; }

    /// <summary>
    /// Specifies the cash account of the drawer agent.
    /// </summary>
    [IsoId("_cSN_37tuEeq_cfXrH83Rcw")]
    [DisplayName("Drawer Agent Account")]
    [IsoXmlTag("DrwrAgtAcct")]
    public CashAccount40? DrawerAgentAccount { get; init; }

    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    [IsoId("_cSN_4btuEeq_cfXrH83Rcw")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification135? Payee { get; init; }

    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    [IsoId("_cSN_47tuEeq_cfXrH83Rcw")]
    [DisplayName("Payee Account")]
    [IsoXmlTag("PyeeAcct")]
    public CashAccount40? PayeeAccount { get; init; }

    /// <summary>
    /// Specifies the status of the cancellation or stop request.
    /// </summary>
    [IsoId("_7ilW4Sm4EeutWNGMV2XKIQ")]
    [DisplayName("Cheque Cancellation Or Stop Status")]
    [IsoXmlTag("ChqCxlOrStopSts")]
    public required ChequeCancellationStatus1 ChequeCancellationOrStopStatus { get; init; }
}
