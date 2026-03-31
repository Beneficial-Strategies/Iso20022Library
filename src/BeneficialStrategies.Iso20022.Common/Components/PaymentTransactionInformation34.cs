// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original transactions, to which the status report message refers.
/// </summary>
[IsoId("_URBuVdp-Ed-ak6NoX_4Aeg_1719157267")]
[DisplayName("Payment Transaction Information")]
public record PaymentTransactionInformation34
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    [IsoId("_URBuVtp-Ed-ak6NoX_4Aeg_1416100752")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_URBuV9p-Ed-ak6NoX_4Aeg_399594878")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_URBuWNp-Ed-ak6NoX_4Aeg_1854375869")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_URK4QNp-Ed-ak6NoX_4Aeg_-1389458355")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_URK4Qdp-Ed-ak6NoX_4Aeg_1239758624")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.|Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    [IsoId("_URK4Qtp-Ed-ak6NoX_4Aeg_1564876131")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<ChargesInformation7> ChargesInformation { get; init; } = [];

    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_URK4Q9p-Ed-ak6NoX_4Aeg_799513829")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_URK4RNp-Ed-ak6NoX_4Aeg_-239194899")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    [IsoId("_URK4Rdp-Ed-ak6NoX_4Aeg_-874226745")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_URK4Rtp-Ed-ak6NoX_4Aeg_1672973906")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference15? OriginalTransactionReference { get; init; }
}
