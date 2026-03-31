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
[IsoId("_S5InHW49EeiU9cctagi5ow")]
[DisplayName("Currency Control Group Status")]
public record CurrencyControlGroupStatus2
{
    /// <summary>
    /// Original underlying message references for which the status advice is provided.
    /// </summary>
    [IsoId("_TC94gW49EeiU9cctagi5ow")]
    [DisplayName("Original References")]
    [IsoXmlTag("OrgnlRefs")]
    public required OriginalMessage5 OriginalReferences { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_TC94g249EeiU9cctagi5ow")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty5 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_TC94hW49EeiU9cctagi5ow")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; }

    /// <summary>
    /// For daily reporting this is the day to which the transaction data in the status message refers to.
    /// For periodic reporting this is the first and the last day to which the transaction data in the status message refers.
    /// </summary>
    [IsoId("_TC94h249EeiU9cctagi5ow")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; }

    /// <summary>
    /// Provides the status for the full report.
    /// </summary>
    [IsoId("_TC94iW49EeiU9cctagi5ow")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public StatisticalReportingStatus1Code? Status { get; init; }

    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_TC94i249EeiU9cctagi5ow")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<ValidationStatusReason2> StatusReason { get; init; } = [];

    /// <summary>
    /// Provides the date and time when the status was issued.
    /// </summary>
    [IsoId("_TC94jW49EeiU9cctagi5ow")]
    [DisplayName("Status Date Time")]
    [IsoXmlTag("StsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusDateTime { get; init; }
}
