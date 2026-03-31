// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [KnownType(typeof(MemberReportOrError6Choice.Member))]
    [KnownType(typeof(MemberReportOrError6Choice.BusinessError))]
    [JsonDerivedType(
        typeof(MemberReportOrError6Choice.Member),
        nameof(MemberReportOrError6Choice.Member)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError6Choice.BusinessError),
        nameof(MemberReportOrError6Choice.BusinessError)
    )]
    [IsoId("_j3hRJXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Report Or Error 6 Choice")]
    public abstract record MemberReportOrError6Choice_ { }
}
