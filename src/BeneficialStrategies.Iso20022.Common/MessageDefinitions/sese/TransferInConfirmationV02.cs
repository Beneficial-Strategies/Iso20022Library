// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a transfer agent, sends the TransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.
/// This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// Usage
/// The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.
/// The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(
    @"Scope|An executing party, eg, a transfer agent, sends the TransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.|This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|Usage|The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.|The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference."
)]
[IsoId("_JuZN4tE6Ed-BzquC8wXy7w_13196644")]
[DisplayName("Transfer In Confirmation V")]
public record TransferInConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.007.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInConfV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_JuZN49E6Ed-BzquC8wXy7w_872070214")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_JuZN5NE6Ed-BzquC8wXy7w_13197035")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_JuZN5dE6Ed-BzquC8wXy7w_13197000")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_JuZN5tE6Ed-BzquC8wXy7w_13197077")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_JuZN59E6Ed-BzquC8wXy7w_13196663")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer7 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_JuZN6NE6Ed-BzquC8wXy7w_13196688")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_Jui-4NE6Ed-BzquC8wXy7w_13196940")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_Jui-4dE6Ed-BzquC8wXy7w_13196975")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required DeliverInformation4 SettlementDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Jui-4tE6Ed-BzquC8wXy7w_104786759")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Jui-49E6Ed-BzquC8wXy7w_13197112")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferInConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInConfirmationV02.
