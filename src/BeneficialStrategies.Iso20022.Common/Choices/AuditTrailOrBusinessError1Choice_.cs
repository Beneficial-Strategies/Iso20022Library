// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Report between the static data audit trail or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError1Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError1Choice.BusinessError))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError1Choice.AuditTrail),nameof(AuditTrailOrBusinessError1Choice.AuditTrail))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError1Choice.BusinessError),nameof(AuditTrailOrBusinessError1Choice.BusinessError))]
    [IsoId("_kzKJFO5NEeCisYr99QEiWA_1431906360")]
    [DisplayName("Audit Trail Or Business Error 1 Choice")]
    public abstract partial record AuditTrailOrBusinessError1Choice_
    {
    }
}
