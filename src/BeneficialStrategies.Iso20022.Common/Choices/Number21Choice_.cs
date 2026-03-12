// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number21Choice.NumberIdentification))]
    [KnownType(typeof(Number21Choice.Proprietary))]
    [JsonDerivedType(typeof(Number21Choice.NumberIdentification),nameof(Number21Choice.NumberIdentification))]
    [JsonDerivedType(typeof(Number21Choice.Proprietary),nameof(Number21Choice.Proprietary))]
    [IsoId("_AeehM9okEeC60axPepSq7g_363304581")]
    [DisplayName("Number 21 Choice")]
    public abstract partial record Number21Choice_
    {
    }
}
