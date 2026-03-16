// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code as to the nature of the dispute about the collateral amount.
    /// </summary>
    [KnownType(typeof(DisputeResolutionType2Choice.Code))]
    [KnownType(typeof(DisputeResolutionType2Choice.ProprietaryIdentification))]
    [JsonDerivedType(
        typeof(DisputeResolutionType2Choice.Code),
        nameof(DisputeResolutionType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DisputeResolutionType2Choice.ProprietaryIdentification),
        nameof(DisputeResolutionType2Choice.ProprietaryIdentification)
    )]
    [IsoId("_UnrTydp-Ed-ak6NoX_4Aeg_-116466273")]
    [DisplayName("Dispute Resolution Type 2 Choice")]
    public abstract record DisputeResolutionType2Choice_ { }
}
