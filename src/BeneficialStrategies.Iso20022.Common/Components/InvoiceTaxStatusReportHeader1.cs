// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the Invoice tax status report header details.
/// </summary>
[IsoId("_I_Tr4U52Eeaine-lsNAGsA")]
[DisplayName("Invoice Tax Status Report Header")]
public record InvoiceTaxStatusReportHeader1
{
    /// <summary>
    /// Party to which the TaxReport is delivered. This message block contains party details for a specific tax authority.
    /// </summary>
    [IsoId("_6iFdwGqXEea_XZixF5unWQ")]
    [DisplayName("Tax Authority")]
    [IsoXmlTag("TaxAuthrty")]
    public TaxOrganisationIdentification1? TaxAuthority { get; init; }

    /// <summary>
    /// Identifies the InvoiceTaxReportStatusAdvice message.
    /// </summary>
    [IsoId("_bLfvgE52Eeaine-lsNAGsA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to the identification of the InvoiceTaxReport message.
    /// </summary>
    [IsoId("_W1dt8E53Eeaine-lsNAGsA")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required MessageIdentification1 OriginalMessageIdentification { get; init; }

    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_JIHClU52Eeaine-lsNAGsA")]
    [DisplayName("Report Status")]
    [IsoXmlTag("RptSts")]
    public required TaxReportingStatus1Code ReportStatus { get; init; }

    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_JIHCl052Eeaine-lsNAGsA")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public ValueList<GenericValidationRuleIdentification1> ValidationRule { get; init; } = [];
}
