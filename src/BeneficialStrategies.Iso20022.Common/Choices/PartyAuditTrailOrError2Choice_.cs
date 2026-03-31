// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the static data audit trail or a business error.
    /// </summary>
    [KnownType(typeof(PartyAuditTrailOrError2Choice.AuditTrail))]
    [KnownType(typeof(PartyAuditTrailOrError2Choice.BusinessError))]
    [JsonDerivedType(
        typeof(PartyAuditTrailOrError2Choice.AuditTrail),
        nameof(PartyAuditTrailOrError2Choice.AuditTrail)
    )]
    [JsonDerivedType(
        typeof(PartyAuditTrailOrError2Choice.BusinessError),
        nameof(PartyAuditTrailOrError2Choice.BusinessError)
    )]
    [IsoId("_G7GHAWjHEeiCUdTMLdZoIg")]
    [DisplayName("Party Audit Trail Or Error 2 Choice")]
    public abstract record PartyAuditTrailOrError2Choice_ { }
}
