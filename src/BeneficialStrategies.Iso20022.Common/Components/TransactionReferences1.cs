// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that identify the underlying transaction.
/// </summary>
[IsoId("_PyLkc9p-Ed-ak6NoX_4Aeg_-1495574784")]
[DisplayName("Transaction References")]
public record TransactionReferences1
{
    /// <summary>
    /// Point to point reference assigned by the instructing party of the underlying message.
    /// </summary>
    [IsoId("_PyLkdNp-Ed-ak6NoX_4Aeg_865909121")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// The account servicing institution&apos;s reference for the transaction.
    /// </summary>
    [IsoId("_PyLkddp-Ed-ak6NoX_4Aeg_-1495574208")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the instruction.||Usage: the instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_PyLkdtp-Ed-ak6NoX_4Aeg_-718892673")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the initiating party to unumbiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to carry on multiple references, the end-to-end identification must be carried on throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_PyLkd9p-Ed-ak6NoX_4Aeg_-718892648")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the first instructing agent to unambiguously identify the transaction and passed on, unchanged, throughout the entire interbank chain. ||Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. |Usage: The instructing agent has to make sure the transaction identification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_PyLkeNp-Ed-ak6NoX_4Aeg_-718892631")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Reference of the direct debit mandate that has been signed between by the debtor and the creditor.
    /// </summary>
    [IsoId("_PyUuYNp-Ed-ak6NoX_4Aeg_-676413030")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateIdentification { get; init; }

    /// <summary>
    /// Identifies the cheque number.
    /// </summary>
    [IsoId("_PyUuYdp-Ed-ak6NoX_4Aeg_-605299049")]
    [DisplayName("Cheque Number")]
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ChequeNumber { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, assigned by the clearing system.
    /// </summary>
    [IsoId("_PyUuYtp-Ed-ak6NoX_4Aeg_-503714579")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <summary>
    /// Proprietary reference of an underlying transaction.
    /// </summary>
    [IsoId("_PyUuY9p-Ed-ak6NoX_4Aeg_267426407")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryReference1? Proprietary { get; init; }
}
