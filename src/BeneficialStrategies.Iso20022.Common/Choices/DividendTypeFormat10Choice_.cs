// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat10Choice.Code))]
    [KnownType(typeof(DividendTypeFormat10Choice.Proprietary))]
    [JsonDerivedType(typeof(DividendTypeFormat10Choice.Code),nameof(DividendTypeFormat10Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat10Choice.Proprietary),nameof(DividendTypeFormat10Choice.Proprietary))]
    [IsoId("_c5VTV5KQEeWHWpTQn1FFVg")]
    [DisplayName("Dividend Type Format 10 Choice")]
    public abstract partial record DividendTypeFormat10Choice_
    {
    }
}
