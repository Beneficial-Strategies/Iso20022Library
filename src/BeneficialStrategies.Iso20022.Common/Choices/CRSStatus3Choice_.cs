// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the Common Reporting Standard (CRS) status.
    /// </summary>
    [KnownType(typeof(CRSStatus3Choice.Code))]
    [KnownType(typeof(CRSStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(CRSStatus3Choice.Code), nameof(CRSStatus3Choice.Code))]
    [JsonDerivedType(typeof(CRSStatus3Choice.Proprietary), nameof(CRSStatus3Choice.Proprietary))]
    [IsoId("_--TuEUNeEeamLdeYEZm56w")]
    [DisplayName("CRS Status 3 Choice")]
    public abstract record CRSStatus3Choice_ { }
}
