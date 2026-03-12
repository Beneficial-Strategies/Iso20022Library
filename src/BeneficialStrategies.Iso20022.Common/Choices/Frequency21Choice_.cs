// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency21Choice.Type))]
    [KnownType(typeof(Frequency21Choice.Period))]
    [JsonDerivedType(typeof(Frequency21Choice.Type),nameof(Frequency21Choice.Type))]
    [JsonDerivedType(typeof(Frequency21Choice.Period),nameof(Frequency21Choice.Period))]
    [IsoId("_51BdAR7yEeSxevWRRWxNAg")]
    [DisplayName("Frequency 21 Choice")]
    public abstract partial record Frequency21Choice_
    {
    }
}
