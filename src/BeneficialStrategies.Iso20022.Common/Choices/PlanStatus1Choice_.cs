// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the status of a plan.
    /// </summary>
    [KnownType(typeof(PlanStatus1Choice.Code))]
    [KnownType(typeof(PlanStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(PlanStatus1Choice.Code), nameof(PlanStatus1Choice.Code))]
    [JsonDerivedType(typeof(PlanStatus1Choice.Proprietary), nameof(PlanStatus1Choice.Proprietary))]
    [IsoId("_x_mUgQjbEeS5F6qHcKOrew")]
    [DisplayName("Plan Status 1 Choice")]
    public abstract record PlanStatus1Choice_ { }
}
