// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to specify the type margin.
    /// </summary>
    [KnownType(typeof(MarginType1Choice.Code))]
    [KnownType(typeof(MarginType1Choice.Proprietary))]
    [JsonDerivedType(typeof(MarginType1Choice.Code),nameof(MarginType1Choice.Code))]
    [JsonDerivedType(typeof(MarginType1Choice.Proprietary),nameof(MarginType1Choice.Proprietary))]
    [IsoId("_-axnkKMOEeCojJW5vEuTEQ_533219719")]
    [DisplayName("Margin Type 1 Choice")]
    public abstract partial record MarginType1Choice_
    {
    }
}
