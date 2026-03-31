// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionTypeFormat4Choice.Code))]
    [KnownType(typeof(ConversionTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConversionTypeFormat4Choice.Code),
        nameof(ConversionTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConversionTypeFormat4Choice.Proprietary),
        nameof(ConversionTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_c5VTb5KQEeWHWpTQn1FFVg")]
    [DisplayName("Conversion Type Format 4 Choice")]
    public abstract record ConversionTypeFormat4Choice_ { }
}
