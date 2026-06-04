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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.062.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_sYMvWWtdEeCY4-KZ9JEyUQ_-571581596")]
[DisplayName("Pay In Schedule V02")]
public record PayInScheduleV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.062.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PayInSchdl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.062.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification19Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// Pay In Factors.
    /// </summary>
    [DisplayName("Pay In Factors")]
    [IsoXmlTag("PayInFctrs")]
    public PayInFactors1? PayInFactors { get; init; }

    /// <summary>
    /// Pay In Schedule Balance.
    /// </summary>
    [DisplayName("Pay In Schedule Balance")]
    [IsoXmlTag("PayInSchdlBal")]
    public ValueList<BalanceStatus2> PayInScheduleBalance { get; init; } = [];

    /// <summary>
    /// Pay In Schedule Item.
    /// </summary>
    [DisplayName("Pay In Schedule Item")]
    [IsoXmlTag("PayInSchdlItm")]
    public ValueList<PayInScheduleItems> PayInScheduleItem { get; init; } = [];

    /// <summary>
    /// Report Data.
    /// </summary>
    [DisplayName("Report Data")]
    [IsoXmlTag("RptData")]
    public required ReportData3 ReportData { get; init; }
}

// Since PayInScheduleV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PayInScheduleV02.
