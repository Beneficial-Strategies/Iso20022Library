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
[IsoId("_Ulb4E9p-Ed-ak6NoX_4Aeg_1239056055")]
[DisplayName("Segregated Independent Amount Dispute")]
public record SegregatedIndependentAmountDispute1
{
    /// <summary>
    /// Details of the disputed instruction.
    /// </summary>
    [IsoId("_Ulb4FNp-Ed-ak6NoX_4Aeg_-2146942224")]
    [DisplayName("Dispute Details")]
    [IsoXmlTag("DsptDtls")]
    public required Dispute1 DisputeDetails { get; init; }

    /// <summary>
    /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    [IsoId("_Ulb4Fdp-Ed-ak6NoX_4Aeg_-432473842")]
    [DisplayName("Dispute Resolution Type 1 Choice")]
    [IsoXmlTag("DsptRsltnTp1Chc")]
    public ValueList<DisputeResolutionType1Choice_> DisputeResolutionType1Choice { get; init; } =
        [];
}
