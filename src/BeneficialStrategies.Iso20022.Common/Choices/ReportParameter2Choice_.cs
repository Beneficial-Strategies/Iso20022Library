// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between types of reporting parameter.
    /// </summary>
    [KnownType(typeof(ReportParameter2Choice.Party))]
    [KnownType(typeof(ReportParameter2Choice.Country))]
    [KnownType(typeof(ReportParameter2Choice.Currency))]
    [KnownType(typeof(ReportParameter2Choice.UserDefined))]
    [JsonDerivedType(typeof(ReportParameter2Choice.Party), nameof(ReportParameter2Choice.Party))]
    [JsonDerivedType(
        typeof(ReportParameter2Choice.Country),
        nameof(ReportParameter2Choice.Country)
    )]
    [JsonDerivedType(
        typeof(ReportParameter2Choice.Currency),
        nameof(ReportParameter2Choice.Currency)
    )]
    [JsonDerivedType(
        typeof(ReportParameter2Choice.UserDefined),
        nameof(ReportParameter2Choice.UserDefined)
    )]
    [IsoId("_U11EiNp-Ed-ak6NoX_4Aeg_-922147524")]
    [DisplayName("Report Parameter 2 Choice")]
    public abstract record ReportParameter2Choice_ { }
}
