// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the securities account reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport))]
    [KnownType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError))]
    [JsonDerivedType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport),nameof(SecuritiesAccountAuditTrailOrOperationalError3Choice.SecuritiesAccountAuditTrailReport))]
    [JsonDerivedType(typeof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError),nameof(SecuritiesAccountAuditTrailOrOperationalError3Choice.OperationalError))]
    [IsoId("_AvnmYTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Audit Trail Or Operational Error 3 Choice")]
    public abstract partial record SecuritiesAccountAuditTrailOrOperationalError3Choice_
    {
    }
}
