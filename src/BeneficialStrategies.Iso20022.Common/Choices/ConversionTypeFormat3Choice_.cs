// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of conversion.
    /// </summary>
    [KnownType(typeof(ConversionTypeFormat3Choice.Code))]
    [KnownType(typeof(ConversionTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ConversionTypeFormat3Choice.Code),
        nameof(ConversionTypeFormat3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ConversionTypeFormat3Choice.Proprietary),
        nameof(ConversionTypeFormat3Choice.Proprietary)
    )]
    [IsoId("_1ms0IUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Conversion Type Format 3 Choice")]
    public abstract record ConversionTypeFormat3Choice_ { }
}
