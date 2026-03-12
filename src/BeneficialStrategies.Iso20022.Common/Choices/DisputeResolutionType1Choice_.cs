// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code as to the nature of the dispute about the collateral amount.
    /// </summary>
    [KnownType(typeof(DisputeResolutionType1Choice.Code))]
    [KnownType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(DisputeResolutionType1Choice.Code),nameof(DisputeResolutionType1Choice.Code))]
    [JsonDerivedType(typeof(DisputeResolutionType1Choice.ProprietaryIdentification),nameof(DisputeResolutionType1Choice.ProprietaryIdentification))]
    [IsoId("_QmogNdp-Ed-ak6NoX_4Aeg_1282948020")]
    [DisplayName("Dispute Resolution Type 1 Choice")]
    public abstract partial record DisputeResolutionType1Choice_
    {
    }
}
