// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat1Choice.Code))]
    [KnownType(typeof(DividendTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(DividendTypeFormat1Choice.Code),nameof(DividendTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat1Choice.Proprietary),nameof(DividendTypeFormat1Choice.Proprietary))]
    [IsoId("_Q36dctp-Ed-ak6NoX_4Aeg_-2059778608")]
    [DisplayName("Dividend Type Format 1 Choice")]
    public abstract partial record DividendTypeFormat1Choice_
    {
    }
}
