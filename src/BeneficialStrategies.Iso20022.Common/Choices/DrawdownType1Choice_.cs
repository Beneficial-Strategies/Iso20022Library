// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of drawdown.
    /// </summary>
    [KnownType(typeof(DrawdownType1Choice.Code))]
    [KnownType(typeof(DrawdownType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DrawdownType1Choice.Code),nameof(DrawdownType1Choice.Code))]
    [JsonDerivedType(typeof(DrawdownType1Choice.Proprietary),nameof(DrawdownType1Choice.Proprietary))]
    [IsoId("_NHMP4FNdEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Type 1 Choice")]
    public abstract partial record DrawdownType1Choice_
    {
    }
}
