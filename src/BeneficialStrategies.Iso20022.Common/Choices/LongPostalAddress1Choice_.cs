// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [KnownType(typeof(LongPostalAddress1Choice.Unstructured))]
    [KnownType(typeof(LongPostalAddress1Choice.Structured))]
    [JsonDerivedType(
        typeof(LongPostalAddress1Choice.Unstructured),
        nameof(LongPostalAddress1Choice.Unstructured)
    )]
    [JsonDerivedType(
        typeof(LongPostalAddress1Choice.Structured),
        nameof(LongPostalAddress1Choice.Structured)
    )]
    [IsoId("_QG4pJdp-Ed-ak6NoX_4Aeg_-1972571676")]
    [DisplayName("Long Postal Address 1 Choice")]
    public abstract record LongPostalAddress1Choice_ { }
}
