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
/// This record is an implementation of the auth.034.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions.
/// </summary>
[Description(
    @"The InvoiceTaxReport message is sent by tax responsible to tax authority. Tax authorities require corporates to report their sales based value added tax (VAT). This message is targeted to this reporting based on information in sales invoices and card transactions."
)]
[IsoId("_B5eQoFmrEeOQYsoJizpkVw")]
[DisplayName("Invoice Tax Report V")]
public record InvoiceTaxReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.034.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InvcTaxRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.034.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Defines message level identification, number of individual tax reports and tax authority.
    /// </summary>
    [IsoId("_riLtAGn0Eea5EcY2TpG1mw")]
    [DisplayName("Invoice Tax Report Header")]
    [IsoXmlTag("InvcTaxRptHdr")]
    public required TaxReportHeader1 InvoiceTaxReportHeader { get; init; }

    /// <summary>
    /// Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.
    /// </summary>
    [IsoId("_DiX4YFm8EeOQYsoJizpkVw")]
    [DisplayName("Tax Report")]
    [IsoXmlTag("TaxRpt")]
    public required TaxReport1 TaxReport { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YqO7oEjvEeaOe8w0NJ11wQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since InvoiceTaxReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InvoiceTaxReportV01.
