// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between details of one or more limits set by the member (or on behalf of the member) and managed by the transaction administrator or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitReportOrError3Choice.BusinessReport))]
    [KnownType(typeof(LimitReportOrError3Choice.OperationalError))]
    [JsonDerivedType(typeof(LimitReportOrError3Choice.BusinessReport),nameof(LimitReportOrError3Choice.BusinessReport))]
    [JsonDerivedType(typeof(LimitReportOrError3Choice.OperationalError),nameof(LimitReportOrError3Choice.OperationalError))]
    [IsoId("_Qm5s4ZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Report Or Error 3 Choice")]
    public abstract partial record LimitReportOrError3Choice_
    {
    }
}
