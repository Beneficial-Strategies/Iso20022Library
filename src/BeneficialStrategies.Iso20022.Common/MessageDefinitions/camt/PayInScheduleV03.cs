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
/// This record is an implementation of the camt.062.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PayInSchedule message is sent by a central settlement system to the participant to provide notification of a series of timed payments scheduled for each currency at the time and date of the schedule generation. The central settlement system may send information about how the timed payments have been calculated.
/// </summary>
[Description(
    @"The PayInSchedule message is sent by a central settlement system to the participant to provide notification of a series of timed payments scheduled for each currency at the time and date of the schedule generation. The central settlement system may send information about how the timed payments have been calculated."
)]
[IsoId("_KfNcsS43EeK7-OZOLIksSw")]
[DisplayName("Pay In Schedule V")]
public record PayInScheduleV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.062.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PayInSchdl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.062.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Party for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_KfNctS43EeK7-OZOLIksSw")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification73Choice_ PartyIdentification { get; init; }

    /// <summary>
    /// General information applicable to the report.
    /// </summary>
    [IsoId("_KfNcuS43EeK7-OZOLIksSw")]
    [DisplayName("Report Data")]
    [IsoXmlTag("RptData")]
    public required ReportData4 ReportData { get; init; }

    /// <summary>
    /// Projected net position for all currencies, projected long for the value date.
    /// </summary>
    [IsoId("_KfNcvS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Schedule Long Balance")]
    [IsoXmlTag("PayInSchdlLngBal")]
    public BalanceStatus2? PayInScheduleLongBalance { get; init; }

    /// <summary>
    /// Currency and total amount to be paid in by the corresponding deadline.
    /// </summary>
    [IsoId("_KfNcwS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Schedule Item")]
    [IsoXmlTag("PayInSchdlItm")]
    public PayInScheduleItems1? PayInScheduleItem { get; init; }

    /// <summary>
    /// Factors used in the calculation of the pay-in schedule.
    /// </summary>
    [IsoId("_KfNcxS43EeK7-OZOLIksSw")]
    [DisplayName("Pay In Factors")]
    [IsoXmlTag("PayInFctrs")]
    public PayInFactors1? PayInFactors { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DTaJUS53EeKwTrPDLMbLxA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PayInScheduleV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PayInScheduleV03.
