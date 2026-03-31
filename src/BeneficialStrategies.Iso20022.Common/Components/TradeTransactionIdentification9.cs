// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_mdZxga7MEemZxoEFHjN-AQ")]
[DisplayName("Trade Transaction Identification")]
public record TradeTransactionIdentification9
{
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_mhuQ0a7MEemZxoEFHjN-AQ")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; }

    /// <summary>
    /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
    /// </summary>
    [IsoId("_wIaeQa7MEemZxoEFHjN-AQ")]
    [DisplayName("Report Submitting Entity")]
    [IsoXmlTag("RptSubmitgNtty")]
    public required OrganisationIdentification9Choice_ ReportSubmittingEntity { get; init; }
}
