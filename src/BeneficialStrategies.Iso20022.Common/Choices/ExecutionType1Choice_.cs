// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of execution to be performed in the request.
    /// </summary>
    [KnownType(typeof(ExecutionType1Choice.Time))]
    [KnownType(typeof(ExecutionType1Choice.Event))]
    [JsonDerivedType(typeof(ExecutionType1Choice.Time), nameof(ExecutionType1Choice.Time))]
    [JsonDerivedType(typeof(ExecutionType1Choice.Event), nameof(ExecutionType1Choice.Event))]
    [IsoId("_75qQhqMgEeCJ6YNENx4h-w_354040007")]
    [DisplayName("Execution Type 1 Choice")]
    public abstract record ExecutionType1Choice_ { }
}
