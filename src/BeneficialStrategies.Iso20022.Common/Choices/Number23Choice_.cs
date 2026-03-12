// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number23Choice.Short))]
    [KnownType(typeof(Number23Choice.Long))]
    [JsonDerivedType(typeof(Number23Choice.Short),nameof(Number23Choice.Short))]
    [JsonDerivedType(typeof(Number23Choice.Long),nameof(Number23Choice.Long))]
    [IsoId("_5NbJo5NLEeWGlc8L7oPDIg")]
    [DisplayName("Number 23 Choice")]
    public abstract partial record Number23Choice_
    {
    }
}
