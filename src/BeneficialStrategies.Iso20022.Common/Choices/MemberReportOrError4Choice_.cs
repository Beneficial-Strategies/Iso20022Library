// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on a member or a business error.
    /// </summary>
    [KnownType(typeof(MemberReportOrError4Choice.Member))]
    [KnownType(typeof(MemberReportOrError4Choice.BusinessError))]
    [JsonDerivedType(
        typeof(MemberReportOrError4Choice.Member),
        nameof(MemberReportOrError4Choice.Member)
    )]
    [JsonDerivedType(
        typeof(MemberReportOrError4Choice.BusinessError),
        nameof(MemberReportOrError4Choice.BusinessError)
    )]
    [IsoId("_i8mp9ZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Report Or Error 4 Choice")]
    public abstract record MemberReportOrError4Choice_ { }
}
