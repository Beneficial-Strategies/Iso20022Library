// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of different FX amount types.
    /// </summary>
    [KnownType(typeof(FXAmountType1Choice.Code))]
    [KnownType(typeof(FXAmountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(FXAmountType1Choice.Code), nameof(FXAmountType1Choice.Code))]
    [JsonDerivedType(
        typeof(FXAmountType1Choice.Proprietary),
        nameof(FXAmountType1Choice.Proprietary)
    )]
    [IsoId("_Z-9lgwN2Ee2-vqzwMUAewg")]
    [DisplayName("FX Amount Type 1 Choice")]
    public abstract record FXAmountType1Choice_ { }
}
