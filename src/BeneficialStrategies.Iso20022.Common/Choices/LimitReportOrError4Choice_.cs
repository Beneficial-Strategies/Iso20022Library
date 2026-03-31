// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitReportOrError4Choice.BusinessReport))]
    [KnownType(typeof(LimitReportOrError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(LimitReportOrError4Choice.BusinessReport),
        nameof(LimitReportOrError4Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(LimitReportOrError4Choice.OperationalError),
        nameof(LimitReportOrError4Choice.OperationalError)
    )]
    [IsoId("_CtV4dW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Report Or Error 4 Choice")]
    public abstract record LimitReportOrError4Choice_ { }
}
