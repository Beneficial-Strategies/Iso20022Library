// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to identify a financial institution.
    /// </summary>
    [KnownType(typeof(MemberIdentification3Choice.BICFI))]
    [KnownType(typeof(MemberIdentification3Choice.ClearingSystemMemberIdentification))]
    [KnownType(typeof(MemberIdentification3Choice.Other))]
    [JsonDerivedType(typeof(MemberIdentification3Choice.BICFI),nameof(MemberIdentification3Choice.BICFI))]
    [JsonDerivedType(typeof(MemberIdentification3Choice.ClearingSystemMemberIdentification),nameof(MemberIdentification3Choice.ClearingSystemMemberIdentification))]
    [JsonDerivedType(typeof(MemberIdentification3Choice.Other),nameof(MemberIdentification3Choice.Other))]
    [IsoId("_h_8rhXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Member Identification 3 Choice")]
    public abstract partial record MemberIdentification3Choice_
    {
    }
}
