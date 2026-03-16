// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide information on transactions and booked entries held at the transaction administrator.
    /// </summary>
    [KnownType(typeof(MemberReportOrError3Choice.Report))]
    [KnownType(typeof(MemberReportOrError3Choice.OperationalError))]
    [JsonDerivedType(
        typeof(MemberReportOrError3Choice.Report),
        nameof(MemberReportOrError3Choice.Report)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError3Choice.OperationalError),
        nameof(MemberReportOrError3Choice.OperationalError)
    )]
    [IsoId("_isPSsZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Report Or Error 3 Choice")]
    public abstract record MemberReportOrError3Choice_ { }
}
