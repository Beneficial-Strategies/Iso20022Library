// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account information or an error report.
    /// </summary>
    [KnownType(typeof(AccountReportOrError4Choice.Error))]
    [KnownType(typeof(AccountReportOrError4Choice.AccountReport))]
    [JsonDerivedType(
        typeof(AccountReportOrError4Choice.Error),
        nameof(AccountReportOrError4Choice.Error)
    )]
    [JsonDerivedType(
        typeof(AccountReportOrError4Choice.AccountReport),
        nameof(AccountReportOrError4Choice.AccountReport)
    )]
    [IsoId("_1NV5sTEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Report Or Error 4 Choice")]
    public abstract record AccountReportOrError4Choice_ { }
}
