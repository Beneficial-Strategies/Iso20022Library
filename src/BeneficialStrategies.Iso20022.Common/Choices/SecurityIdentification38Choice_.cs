// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Security Identification38Choice.
    /// </summary>
    [KnownType(typeof(SecurityIdentification38Choice.AlternateIdentification))]
    [KnownType(typeof(SecurityIdentification38Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification38Choice.Common))]
    [KnownType(typeof(SecurityIdentification38Choice.CTA))]
    [KnownType(typeof(SecurityIdentification38Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification38Choice.RIC))]
    [KnownType(typeof(SecurityIdentification38Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.AlternateIdentification),nameof(SecurityIdentification38Choice.AlternateIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.Bloomberg),nameof(SecurityIdentification38Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.Common),nameof(SecurityIdentification38Choice.Common))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.CTA),nameof(SecurityIdentification38Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.ISIN),nameof(SecurityIdentification38Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.RIC),nameof(SecurityIdentification38Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification38Choice.TickerSymbol),nameof(SecurityIdentification38Choice.TickerSymbol))]
    [IsoId("_i4YBAZqPEe6okLaLQ4oCqQ")]
    [DisplayName("Security Identification38Choice")]
    public abstract partial record SecurityIdentification38Choice_
    {
    }
}
