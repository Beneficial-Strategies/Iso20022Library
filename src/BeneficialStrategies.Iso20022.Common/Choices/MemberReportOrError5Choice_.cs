// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide information on transactions and booked entries held at the transaction administrator.
    /// </summary>
    [KnownType(typeof(MemberReportOrError5Choice.Report))]
    [KnownType(typeof(MemberReportOrError5Choice.OperationalError))]
    [JsonDerivedType(
        typeof(MemberReportOrError5Choice.Report),
        nameof(MemberReportOrError5Choice.Report)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError5Choice.OperationalError),
        nameof(MemberReportOrError5Choice.OperationalError)
    )]
    [IsoId("_jUbLIXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Report Or Error 5 Choice")]
    public abstract record MemberReportOrError5Choice_ { }
}
