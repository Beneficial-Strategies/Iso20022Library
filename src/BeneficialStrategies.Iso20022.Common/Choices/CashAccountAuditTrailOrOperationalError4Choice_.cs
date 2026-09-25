// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Used to report between the cash account reference data or an operational error.
    /// </summary>
    [KnownType(typeof(CashAccountAuditTrailOrOperationalError4Choice.CashAccountAuditTrailReport))]
    [KnownType(typeof(CashAccountAuditTrailOrOperationalError4Choice.OperationalError))]
    [JsonDerivedType(
        typeof(CashAccountAuditTrailOrOperationalError4Choice.CashAccountAuditTrailReport),
        nameof(CashAccountAuditTrailOrOperationalError4Choice.CashAccountAuditTrailReport)
    )]
    [JsonDerivedType(
        typeof(CashAccountAuditTrailOrOperationalError4Choice.OperationalError),
        nameof(CashAccountAuditTrailOrOperationalError4Choice.OperationalError)
    )]
    [IsoId("_9qh9YeVaEfC90e_m8fMznQ")]
    [DisplayName("Cash Account Audit Trail Or Operational Error 4 Choice")]
    public abstract record CashAccountAuditTrailOrOperationalError4Choice_ { }
}
