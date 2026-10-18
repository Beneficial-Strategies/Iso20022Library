// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IClearingSystemMemberIdentification3Choice"/>
    [KnownType(typeof(ClearingSystemMemberIdentification3Choice.Identification))]
    [KnownType(typeof(ClearingSystemMemberIdentification3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentification3Choice.Identification),
        nameof(ClearingSystemMemberIdentification3Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentification3Choice.Proprietary),
        nameof(ClearingSystemMemberIdentification3Choice.Proprietary)
    )]
    [IsoId("_TMehGdp-Ed-ak6NoX_4Aeg_-1564562098")]
    [DisplayName("Clearing System Member Identification 3 Choice")]
    public abstract partial record ClearingSystemMemberIdentification3Choice_ { }
}
