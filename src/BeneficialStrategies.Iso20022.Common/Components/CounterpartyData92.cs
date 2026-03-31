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
[IsoId("_oDWwUT3tEe2eko1JI07Zbw")]
[DisplayName("Counterparty Data")]
public record CounterpartyData92
{
    /// <summary>
    /// Identification of the reporting counterparty.
    /// </summary>
    [IsoId("_oGHwcT3tEe2eko1JI07Zbw")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public OrganisationIdentification15Choice_? ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_oGHwdT3tEe2eko1JI07Zbw")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public OrganisationIdentification15Choice_? ReportSubmittingEntity { get; init; }

    /// <summary>
    /// Unique code identifying that counterparty in the case where a financial counterparty is responsible for reporting on behalf of the other counterparty.
    /// </summary>
    [IsoId("_oGHwdz3tEe2eko1JI07Zbw")]
    [DisplayName("Entity Responsible For Report")]
    [IsoXmlTag("NttyRspnsblForRpt")]
    public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; }
}
