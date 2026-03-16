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
[IsoId("_pXMjD8inEeirauUYrbJQCw")]
[DisplayName("Counterparty Data")]
public record CounterpartyData46
{
    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_pglvkcinEeirauUYrbJQCw")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; }

    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_pglvk8inEeirauUYrbJQCw")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// In the case where a financial counterparty is responsible for reporting on behalf of the other counterparty, the unique code identifying that counterparty.
    /// </summary>
    [IsoId("_pglvlcinEeirauUYrbJQCw")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification9Choice_? EntityResponsibleForReport { get; init; }
}
