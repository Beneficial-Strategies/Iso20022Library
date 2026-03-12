// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services either in a structured or unstructured way.
    /// </summary>
    [KnownType(typeof(LongPostalAddress2Choice.Unstructured))]
    [KnownType(typeof(LongPostalAddress2Choice.Structured))]
    [JsonDerivedType(typeof(LongPostalAddress2Choice.Unstructured),nameof(LongPostalAddress2Choice.Unstructured))]
    [JsonDerivedType(typeof(LongPostalAddress2Choice.Structured),nameof(LongPostalAddress2Choice.Structured))]
    [IsoId("_RVRH19p-Ed-ak6NoX_4Aeg_-1296060125")]
    [DisplayName("Long Postal Address 2 Choice")]
    public abstract partial record LongPostalAddress2Choice_
    {
    }
}
