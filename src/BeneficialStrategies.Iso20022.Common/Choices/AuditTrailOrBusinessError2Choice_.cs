// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the static data audit trail or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError2Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError2Choice.BusinessError))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError2Choice.AuditTrail),nameof(AuditTrailOrBusinessError2Choice.AuditTrail))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError2Choice.BusinessError),nameof(AuditTrailOrBusinessError2Choice.BusinessError))]
    [IsoId("_BaOI8fAzEeWPfa2xBhBfLQ")]
    [DisplayName("Audit Trail Or Business Error 2 Choice")]
    public abstract partial record AuditTrailOrBusinessError2Choice_
    {
    }
}
