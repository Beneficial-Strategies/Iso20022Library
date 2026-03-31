// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to identify a financial institution.
    /// </summary>
    [KnownType(typeof(MemberIdentification2Choice.BICFI))]
    [KnownType(typeof(MemberIdentification2Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(MemberIdentification2Choice.Other))]
    [JsonDerivedType(
        typeof(MemberIdentification2Choice.BICFI),
        nameof(MemberIdentification2Choice.BICFI)
    )]
    [JsonDerivedType(
        typeof(MemberIdentification2Choice.ClearingSystemMemberIdentification),
        nameof(MemberIdentification2Choice.ClearingSystemMemberIdentification)
    )]
    [JsonDerivedType(
        typeof(MemberIdentification2Choice.Other),
        nameof(MemberIdentification2Choice.Other)
    )]
    [IsoId("_8Hq3VqMgEeCJ6YNENx4h-w_1599829601")]
    [DisplayName("Member Identification 2 Choice")]
    public abstract record MemberIdentification2Choice_ { }
}
