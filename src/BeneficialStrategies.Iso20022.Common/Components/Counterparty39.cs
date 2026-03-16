// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information specific to the counterparties of the reported transaction.
/// </summary>
[IsoId("_5CDkdcgoEeuGrNSsxk3B0A")]
[DisplayName("Counterparty")]
public record Counterparty39
{
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_5DZoMcgoEeuGrNSsxk3B0A")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_5DZoM8goEeuGrNSsxk3B0A")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public required PartyIdentification236Choice_ OtherCounterparty { get; init; }

    /// <summary>
    /// Identification of the entity in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_5DZoNcgoEeuGrNSsxk3B0A")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; }

    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_5DZoN8goEeuGrNSsxk3B0A")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public OrganisationIdentification15Choice_? ReportSubmittingEntity { get; init; }
}
