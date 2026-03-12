// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code or free text.
    /// </summary>
    [KnownType(typeof(AdjustmentType1Choice.Type))]
    [KnownType(typeof(AdjustmentType1Choice.OtherAdjustmentType))]
    [JsonDerivedType(typeof(AdjustmentType1Choice.Type),nameof(AdjustmentType1Choice.Type))]
    [JsonDerivedType(typeof(AdjustmentType1Choice.OtherAdjustmentType),nameof(AdjustmentType1Choice.OtherAdjustmentType))]
    [IsoId("_HQHgwBrXEeOVR9VN6fAMUg")]
    [DisplayName("Adjustment Type 1 Choice")]
    public abstract partial record AdjustmentType1Choice_
    {
    }
}
