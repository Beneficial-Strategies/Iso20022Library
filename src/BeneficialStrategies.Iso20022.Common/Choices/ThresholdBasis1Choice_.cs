// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a threshold basis defined as a predefined code or as a proprietary value.
    /// </summary>
    [KnownType(typeof(ThresholdBasis1Choice.Code))]
    [KnownType(typeof(ThresholdBasis1Choice.Proprietary))]
    [JsonDerivedType(typeof(ThresholdBasis1Choice.Code), nameof(ThresholdBasis1Choice.Code))]
    [JsonDerivedType(
        typeof(ThresholdBasis1Choice.Proprietary),
        nameof(ThresholdBasis1Choice.Proprietary)
    )]
    [IsoId("_wlX_cBuMEeyhRdHRjakS2w")]
    [DisplayName("Threshold Basis 1 Choice")]
    public abstract record ThresholdBasis1Choice_ { }
}
