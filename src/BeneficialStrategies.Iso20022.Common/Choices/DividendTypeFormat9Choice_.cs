// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat9Choice.Code))]
    [KnownType(typeof(DividendTypeFormat9Choice.Proprietary))]
    [JsonDerivedType(typeof(DividendTypeFormat9Choice.Code),nameof(DividendTypeFormat9Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat9Choice.Proprietary),nameof(DividendTypeFormat9Choice.Proprietary))]
    [IsoId("_x36OMUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Dividend Type Format 9 Choice")]
    public abstract partial record DividendTypeFormat9Choice_
    {
    }
}
