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

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.044.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_fr3pcYZHEe-6cOl7zMpJaA")]
[DisplayName("Securities Trade Confirmation Status Advice V04")]
public record SecuritiesTradeConfirmationStatusAdviceV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.044.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.044.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Affirmation Status.
    /// </summary>
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public AffirmationStatus11Choice_? AffirmationStatus { get; init; }

    /// <summary>
    /// Cancellation Processing Status.
    /// </summary>
    [DisplayName("Cancellation Processing Status")]
    [IsoXmlTag("CxlPrcgSts")]
    public CancellationProcessingStatus10Choice_? CancellationProcessingStatus { get; init; }

    /// <summary>
    /// Confirmation Parties.
    /// </summary>
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public ValueList<ConfirmationParties9> ConfirmationParties { get; init; } = [];

    /// <summary>
    /// Counterparty Trading Details.
    /// </summary>
    [DisplayName("Counterparty Trading Details")]
    [IsoXmlTag("CtrPtyTradgDtls")]
    public Order23? CounterpartyTradingDetails { get; init; }

    /// <summary>
    /// Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties121? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; }

    /// <summary>
    /// Matching Status.
    /// </summary>
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus35Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Party Trading Details.
    /// </summary>
    [DisplayName("Party Trading Details")]
    [IsoXmlTag("PtyTradgDtls")]
    public Order23? PartyTradingDetails { get; init; }

    /// <summary>
    /// Processing Status.
    /// </summary>
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus98Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties121? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public ValueList<Linkages77> References { get; init; } = [];

    /// <summary>
    /// Replacement Processing Status.
    /// </summary>
    [DisplayName("Replacement Processing Status")]
    [IsoXmlTag("RplcmntPrcgSts")]
    public ReplacementProcessingStatus10Choice_? ReplacementProcessingStatus { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since SecuritiesTradeConfirmationStatusAdviceV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationStatusAdviceV04.
