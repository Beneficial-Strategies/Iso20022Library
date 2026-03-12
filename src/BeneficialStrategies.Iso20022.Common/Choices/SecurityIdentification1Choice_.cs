// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification1Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification1Choice.AlternateIdentification))]
    [KnownType(typeof(SecurityIdentification1Choice.RIC))]
    [KnownType(typeof(SecurityIdentification1Choice.TickerSymbol))]
    [KnownType(typeof(SecurityIdentification1Choice.Bloomberg))]
    [KnownType(typeof(SecurityIdentification1Choice.CTA))]
    [KnownType(typeof(SecurityIdentification1Choice.Common))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.ISIN),nameof(SecurityIdentification1Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.AlternateIdentification),nameof(SecurityIdentification1Choice.AlternateIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.RIC),nameof(SecurityIdentification1Choice.RIC))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.TickerSymbol),nameof(SecurityIdentification1Choice.TickerSymbol))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.Bloomberg),nameof(SecurityIdentification1Choice.Bloomberg))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.CTA),nameof(SecurityIdentification1Choice.CTA))]
    [JsonDerivedType(typeof(SecurityIdentification1Choice.Common),nameof(SecurityIdentification1Choice.Common))]
    [IsoId("_Vb-ekNp-Ed-ak6NoX_4Aeg_-1748201317")]
    [DisplayName("Security Identification 1 Choice")]
    public abstract partial record SecurityIdentification1Choice_
    {
    }
}
