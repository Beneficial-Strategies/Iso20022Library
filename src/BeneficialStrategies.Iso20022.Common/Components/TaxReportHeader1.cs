// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines message level identification, number of individual tax reports and tax authority.
/// </summary>
[IsoId("_xtcK0WnzEea5EcY2TpG1mw")]
[DisplayName("Tax Report Header")]
public record TaxReportHeader1
{
    /// <summary>
    /// Unique message identification.
    /// </summary>
    [IsoId("_FdwToGn0Eea5EcY2TpG1mw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Number of TaxReports in this message. Seller can send all TaxReports in the same file.
    /// </summary>
    [IsoId("_L3NwEGn0Eea5EcY2TpG1mw")]
    [DisplayName("Number Of Tax Reports")]
    [IsoXmlTag("NbOfTaxRpts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfTaxReports { get; init; }

    /// <summary>
    /// Party to which the TaxReport is delivered. This message block contains party details for a specific tax authority.
    /// </summary>
    [IsoId("_VbSuYGn0Eea5EcY2TpG1mw")]
    [DisplayName("Tax Authority")]
    [IsoXmlTag("TaxAuthrty")]
    public TaxOrganisationIdentification1? TaxAuthority { get; init; }
}
