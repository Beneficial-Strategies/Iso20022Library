// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data specific to counterparties and related fields.
/// </summary>
[IsoId("_IKxnMc2HEeqFGLkKbAvCGg")]
[DisplayName("Counterparty Data")]
public record CounterpartyData78
{
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_ILv3kc2HEeqFGLkKbAvCGg")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification10Choice_ ReportSubmittingEntity { get; init; }

    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_ILv3k82HEeqFGLkKbAvCGg")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification10Choice_ ReportingCounterparty { get; init; }
}
