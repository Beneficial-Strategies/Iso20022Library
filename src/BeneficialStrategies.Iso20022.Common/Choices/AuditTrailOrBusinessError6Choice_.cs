// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the audit trail static data or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError6Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError6Choice.BusinessError))]
    [JsonDerivedType(
        typeof(AuditTrailOrBusinessError6Choice.AuditTrail),
        nameof(AuditTrailOrBusinessError6Choice.AuditTrail)
    )]
    [JsonDerivedType(
        typeof(AuditTrailOrBusinessError6Choice.BusinessError),
        nameof(AuditTrailOrBusinessError6Choice.BusinessError)
    )]
    [IsoId("_bRP60Wc-EemvNLufWGIVOQ")]
    [DisplayName("Audit Trail Or Business Error 6 Choice")]
    public abstract record AuditTrailOrBusinessError6Choice_ { }
}
