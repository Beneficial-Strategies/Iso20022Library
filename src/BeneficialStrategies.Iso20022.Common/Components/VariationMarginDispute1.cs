// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides for the variation margin, the dispute details like the dispute amount or the dispute date and the resolution type details.
/// </summary>
[IsoId("_UllpEdp-Ed-ak6NoX_4Aeg_-1732352034")]
[DisplayName("Variation Margin Dispute")]
public record VariationMarginDispute1
{
    /// <summary>
    /// Details of the disputed instruction.
    /// </summary>
    [IsoId("_UllpEtp-Ed-ak6NoX_4Aeg_1114938110")]
    [DisplayName("Dispute Details")]
    [IsoXmlTag("DsptDtls")]
    public required Dispute1 DisputeDetails { get; init; }

    /// <summary>
    /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    [IsoId("_UllpE9p-Ed-ak6NoX_4Aeg_2088365475")]
    [DisplayName("Resolution Type Details")]
    [IsoXmlTag("RsltnTpDtls")]
    public ValueList<DisputeResolutionType2Choice_> ResolutionTypeDetails { get; init; } = [];
}
