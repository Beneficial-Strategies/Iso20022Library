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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.042.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument.
/// </summary>
[Description(
    @"The FinancialInstrumentReportingInvalidReferenceDataReport message is sent by the trading venue to the national competent authority to report on all records that have become invalid based on updates that have been received or that have passed the termination date original set for the instrument."
)]
[IsoId("_4LK8W0RNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Invalid Reference Data Report V")]
public record FinancialInstrumentReportingInvalidReferenceDataReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.042.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgInvldRefDataRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.042.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Date period capturing when instruments in the report have been invalidated
    /// Usage:
    /// Within MiFIR, only the From Date To Date field will be used with the From Date corresponding to the date the first instrument was added to this report while the To Date is the date the last instrument was added to the file.
    /// </summary>
    [IsoId("_4LK8XURNEee7JdgA9zPESA")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public required Period4Choice_ DatePeriod { get; init; }

    /// <summary>
    /// Number of invalid records in this message.
    /// </summary>
    [IsoId("_4LK8X0RNEee7JdgA9zPESA")]
    [DisplayName("Number Of Records")]
    [IsoXmlTag("NbOfRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfRecords { get; init; }

    /// <summary>
    /// Provides the details of the financial instruments.
    /// </summary>
    [IsoId("_4LK8YURNEee7JdgA9zPESA")]
    [DisplayName("Financial Instruments")]
    [IsoXmlTag("FinInstrms")]
    public required SecuritiesInvalidReferenceDataReport3 FinancialInstruments { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8Y0RNEee7JdgA9zPESA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since FinancialInstrumentReportingInvalidReferenceDataReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingInvalidReferenceDataReportV01.
