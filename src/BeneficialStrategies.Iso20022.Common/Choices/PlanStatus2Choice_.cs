// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the status of a plan.
    /// </summary>
    [KnownType(typeof(PlanStatus2Choice.Code))]
    [KnownType(typeof(PlanStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(PlanStatus2Choice.Code), nameof(PlanStatus2Choice.Code))]
    [JsonDerivedType(typeof(PlanStatus2Choice.Proprietary), nameof(PlanStatus2Choice.Proprietary))]
    [IsoId("_Y1MI4SFOEeWgV9SQSyaAog")]
    [DisplayName("Plan Status 2 Choice")]
    public abstract record PlanStatus2Choice_ { }
}
