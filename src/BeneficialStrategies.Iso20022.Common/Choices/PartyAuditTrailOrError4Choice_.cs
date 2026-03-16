// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Audit Trail Or Error4Choice.
    /// </summary>
    [KnownType(typeof(PartyAuditTrailOrError4Choice.AuditTrail))]
    [KnownType(typeof(PartyAuditTrailOrError4Choice.BusinessError))]
    [JsonDerivedType(
        typeof(PartyAuditTrailOrError4Choice.AuditTrail),
        nameof(PartyAuditTrailOrError4Choice.AuditTrail)
    )]
    [JsonDerivedType(
        typeof(PartyAuditTrailOrError4Choice.BusinessError),
        nameof(PartyAuditTrailOrError4Choice.BusinessError)
    )]
    [IsoId("_Yqq3gTE_Ee62xuUQ2zyZww")]
    [DisplayName("Party Audit Trail Or Error4Choice")]
    public abstract record PartyAuditTrailOrError4Choice_ { }
}
