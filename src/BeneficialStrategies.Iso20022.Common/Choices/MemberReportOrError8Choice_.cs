// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [KnownType(typeof(MemberReportOrError8Choice.Member))]
    [KnownType(typeof(MemberReportOrError8Choice.BusinessError))]
    [JsonDerivedType(
        typeof(MemberReportOrError8Choice.Member),
        nameof(MemberReportOrError8Choice.Member)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError8Choice.BusinessError),
        nameof(MemberReportOrError8Choice.BusinessError)
    )]
    [IsoId("_fQIE5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Member Report Or Error 8 Choice")]
    public abstract record MemberReportOrError8Choice_ { }
}
