// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat5Choice.Code))]
    [KnownType(typeof(DividendTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(DividendTypeFormat5Choice.Code),nameof(DividendTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat5Choice.Proprietary),nameof(DividendTypeFormat5Choice.Proprietary))]
    [IsoId("_dHrasSXfEeO4bIO_HtGo9Q")]
    [DisplayName("Dividend Type Format 5 Choice")]
    public abstract partial record DividendTypeFormat5Choice_
    {
    }
}
