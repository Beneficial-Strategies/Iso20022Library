// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement capacity information.
    /// </summary>
    [KnownType(typeof(SettlingCapacity3Choice.Code))]
    [KnownType(typeof(SettlingCapacity3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlingCapacity3Choice.Code),nameof(SettlingCapacity3Choice.Code))]
    [JsonDerivedType(typeof(SettlingCapacity3Choice.Proprietary),nameof(SettlingCapacity3Choice.Proprietary))]
    [IsoId("_AZQqBNokEeC60axPepSq7g_550780639")]
    [DisplayName("Settling Capacity 3 Choice")]
    public abstract partial record SettlingCapacity3Choice_
    {
    }
}
