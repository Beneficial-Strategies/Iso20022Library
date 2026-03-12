// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for time unit.
    /// </summary>
    [KnownType(typeof(TimeUnit3Choice.Code))]
    [KnownType(typeof(TimeUnit3Choice.Proprietary))]
    [JsonDerivedType(typeof(TimeUnit3Choice.Code),nameof(TimeUnit3Choice.Code))]
    [JsonDerivedType(typeof(TimeUnit3Choice.Proprietary),nameof(TimeUnit3Choice.Proprietary))]
    [IsoId("_oIB4MeLaEeWFtOV72FbX9w")]
    [DisplayName("Time Unit 3 Choice")]
    public abstract partial record TimeUnit3Choice_
    {
    }
}
