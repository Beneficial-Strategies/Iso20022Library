// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency22Choice.Code))]
    [KnownType(typeof(Frequency22Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency22Choice.Code),nameof(Frequency22Choice.Code))]
    [JsonDerivedType(typeof(Frequency22Choice.Proprietary),nameof(Frequency22Choice.Proprietary))]
    [IsoId("_Zg-Akf3-EeS5i-mwuUyZxw")]
    [DisplayName("Frequency 22 Choice")]
    public abstract partial record Frequency22Choice_
    {
    }
}
