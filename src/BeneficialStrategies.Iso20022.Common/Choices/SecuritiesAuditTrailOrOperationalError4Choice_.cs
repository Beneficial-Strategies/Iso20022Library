// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Used to report between the securities reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport))]
    [KnownType(typeof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport),
        nameof(SecuritiesAuditTrailOrOperationalError4Choice.SecuritiesAuditTrailReport)
    )]
    [JsonDerivedType(
        typeof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError),
        nameof(SecuritiesAuditTrailOrOperationalError4Choice.OperationalError)
    )]
    [IsoId("_PrBR8ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Securities Audit Trail Or Operational Error 4 Choice")]
    public abstract record SecuritiesAuditTrailOrOperationalError4Choice_ { }
}
