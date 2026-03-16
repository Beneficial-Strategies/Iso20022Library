// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the currency control group status details.
/// </summary>
[IsoId("_Zza3u-FQEeSvv6t4Ka7B7A")]
[DisplayName("Currency Control Group Status")]
public record CurrencyControlGroupStatus1
{
    /// <summary>
    /// Original underlying message references for which the status advice is provided.
    /// </summary>
    [IsoId("_4acEUeFQEeSvv6t4Ka7B7A")]
    [DisplayName("Original References")]
    [IsoXmlTag("OrgnlRefs")]
    public required OriginalMessage3 OriginalReferences { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_Zza3vuFQEeSvv6t4Ka7B7A")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty2 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_twd08eFQEeSvv6t4Ka7B7A")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; }

    /// <summary>
    /// For daily reporting this is the day to which the transaction data in the status message refers to.
    /// For periodic reporting this is the first and the last day to which the transaction data in the status message refers.
    /// </summary>
    [IsoId("_Zza3v-FQEeSvv6t4Ka7B7A")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; }

    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_Zza3vOFQEeSvv6t4Ka7B7A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public StatisticalReportingStatus1Code? Status { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_rtNosTnBEeWDb47rJ6ki4Q")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValidationStatusReason1? StatusReason { get; init; }

    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_PdkrMG5bEeW1GNjYvtuLyQ")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; }
}
