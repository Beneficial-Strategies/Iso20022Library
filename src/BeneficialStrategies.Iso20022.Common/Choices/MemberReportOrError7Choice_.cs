// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide information on transactions and booked entries held at the transaction administrator.
    /// </summary>
    [KnownType(typeof(MemberReportOrError7Choice.Report))]
    [KnownType(typeof(MemberReportOrError7Choice.OperationalError))]
    [JsonDerivedType(
        typeof(MemberReportOrError7Choice.Report),
        nameof(MemberReportOrError7Choice.Report)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError7Choice.OperationalError),
        nameof(MemberReportOrError7Choice.OperationalError)
    )]
    [IsoId("_fMY0YdcZEeqRFcf2R4bPBw")]
    [DisplayName("Member Report Or Error 7 Choice")]
    public abstract record MemberReportOrError7Choice_ { }
}
