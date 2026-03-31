// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a drawdown event type.
    /// </summary>
    [KnownType(typeof(DrawdownEventType1Choice.Code))]
    [KnownType(typeof(DrawdownEventType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DrawdownEventType1Choice.Code), nameof(DrawdownEventType1Choice.Code))]
    [JsonDerivedType(
        typeof(DrawdownEventType1Choice.Proprietary),
        nameof(DrawdownEventType1Choice.Proprietary)
    )]
    [IsoId("_DvIiEFNiEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Event Type 1 Choice")]
    public abstract record DrawdownEventType1Choice_ { }
}
