// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party Audit Trail Or Error3Choice.
    /// </summary>
    [KnownType(typeof(PartyAuditTrailOrError3Choice.OperationalError))]
    [KnownType(typeof(PartyAuditTrailOrError3Choice.PartyAuditTrailReport))]
    [JsonDerivedType(typeof(PartyAuditTrailOrError3Choice.OperationalError),nameof(PartyAuditTrailOrError3Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyAuditTrailOrError3Choice.PartyAuditTrailReport),nameof(PartyAuditTrailOrError3Choice.PartyAuditTrailReport))]
    [IsoId("_YlNvwTE_Ee62xuUQ2zyZww")]
    [DisplayName("Party Audit Trail Or Error3Choice")]
    public abstract partial record PartyAuditTrailOrError3Choice_
    {
    }
}
