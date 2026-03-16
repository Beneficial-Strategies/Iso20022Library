// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionTypeFormat1Choice.Code))]
    [KnownType(typeof(ConversionTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConversionTypeFormat1Choice.Code),
        nameof(ConversionTypeFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConversionTypeFormat1Choice.Proprietary),
        nameof(ConversionTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3wscNp-Ed-ak6NoX_4Aeg_759734385")]
    [DisplayName("Conversion Type Format 1 Choice")]
    public abstract record ConversionTypeFormat1Choice_ { }
}
