// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the reporting type.
    /// </summary>
    [KnownType(typeof(Reporting2Choice.Code))]
    [KnownType(typeof(Reporting2Choice.Proprietary))]
    [JsonDerivedType(typeof(Reporting2Choice.Code), nameof(Reporting2Choice.Code))]
    [JsonDerivedType(typeof(Reporting2Choice.Proprietary), nameof(Reporting2Choice.Proprietary))]
    [IsoId("_Qs45Mtp-Ed-ak6NoX_4Aeg_-349062494")]
    [DisplayName("Reporting 2 Choice")]
    public abstract record Reporting2Choice_ { }
}
