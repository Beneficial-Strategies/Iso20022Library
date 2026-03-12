// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for calculation type.
    /// </summary>
    [KnownType(typeof(CalculationType3Choice.Code))]
    [KnownType(typeof(CalculationType3Choice.Proprietary))]
    [JsonDerivedType(typeof(CalculationType3Choice.Code),nameof(CalculationType3Choice.Code))]
    [JsonDerivedType(typeof(CalculationType3Choice.Proprietary),nameof(CalculationType3Choice.Proprietary))]
    [IsoId("_MpzBp-LaEeWFtOV72FbX9w")]
    [DisplayName("Calculation Type 3 Choice")]
    public abstract partial record CalculationType3Choice_
    {
    }
}
