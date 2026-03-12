// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of dividend.
    /// </summary>
    [KnownType(typeof(DividendTypeFormat3Choice.Code))]
    [KnownType(typeof(DividendTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(DividendTypeFormat3Choice.Code),nameof(DividendTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(DividendTypeFormat3Choice.Proprietary),nameof(DividendTypeFormat3Choice.Proprietary))]
    [IsoId("_KsR2Md3iEd-KAqAOGQOnnw")]
    [DisplayName("Dividend Type Format 3 Choice")]
    public abstract partial record DividendTypeFormat3Choice_
    {
    }
}
