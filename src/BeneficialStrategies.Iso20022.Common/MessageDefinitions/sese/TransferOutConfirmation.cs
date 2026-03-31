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
/// This record is an implementation of the sese.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party&apos;s designated agent.
/// This message is used to confirm the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to confirm the transfer of a financial instrument to an own account or to a third party.
/// Usage
/// The TransferOutConfirmation message is used by an executing party to confirm to the instructing party that the withdrawal of a financial instrument from the owner&apos;s account and its delivery to another own account, or to a third party, has taken place.
/// </summary>
[Description(
    @"Scope|The TransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent.|This message is used to confirm the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to confirm the transfer of a financial instrument to an own account or to a third party.|Usage|The TransferOutConfirmation message is used by an executing party to confirm to the instructing party that the withdrawal of a financial instrument from the owner's account and its delivery to another own account, or to a third party, has taken place."
)]
[IsoId("_K1n7vNE6Ed-BzquC8wXy7w_1755875491")]
[DisplayName("Transfer Out Confirmation")]
public record TransferOutConfirmation : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.003.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.003.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K1n7vdE6Ed-BzquC8wXy7w_-1238228154")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference2 RelatedReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K1n7vtE6Ed-BzquC8wXy7w_-549643126")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_K1n7v9E6Ed-BzquC8wXy7w_777565139")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_K1xFoNE6Ed-BzquC8wXy7w_-1311799696")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer2 TransferDetails { get; init; }

    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    [IsoId("_K1xFodE6Ed-BzquC8wXy7w_-1327435613")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_K1xFotE6Ed-BzquC8wXy7w_-1200250804")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; }

    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_K1xFo9E6Ed-BzquC8wXy7w_-767634572")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation2 SettlementDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_K1xFpNE6Ed-BzquC8wXy7w_1501522016")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferOutConfirmationDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutConfirmation.
