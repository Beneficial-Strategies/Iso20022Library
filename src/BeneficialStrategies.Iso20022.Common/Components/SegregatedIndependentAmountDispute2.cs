// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for the segregated independent amount, the dispute details like the dispute amount or the dispute date and the resolution type details.
/// </summary>
[IsoId("_dCiJ4StOEeyOa655cLd-DQ")]
[DisplayName("Segregated Independent Amount Dispute")]
public record SegregatedIndependentAmountDispute2
{
    /// <summary>
    /// Details of the disputed instruction.
    /// </summary>
    [IsoId("_da94AStOEeyOa655cLd-DQ")]
    [DisplayName("Dispute Details")]
    [IsoXmlTag("DsptDtls")]
    public required Dispute1 DisputeDetails { get; init; }

    /// <summary>
    /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    [IsoId("_da94AytOEeyOa655cLd-DQ")]
    [DisplayName("Dispute Resolution Type 1 Choice")]
    [IsoXmlTag("DsptRsltnTp1Chc")]
    public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; }
}
