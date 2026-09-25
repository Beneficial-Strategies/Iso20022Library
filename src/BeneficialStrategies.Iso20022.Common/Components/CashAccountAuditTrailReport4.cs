// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report information about cash account reference data.
/// </summary>
[IsoId("_9t1JBeVaEfC90e_m8fMznQ")]
[DisplayName("Cash Account Audit Trail Report")]
public record CashAccountAuditTrailReport4
{
    /// <summary>
    /// Identifies the returned cash account reference data or error information.
    /// </summary>
    [IsoId("_9wOVseVaEfC90e_m8fMznQ")]
    [DisplayName("Cash Account Audit Trail Or Error")]
    [IsoXmlTag("CshAcctAudtTrlOrErr")]
    public required AuditTrailOrBusinessError6Choice_ CashAccountAuditTrailOrError { get; init; }

    /// <summary>
    /// Period in dates for which the audit trail is provided.
    /// </summary>
    [IsoId("_9wOVs-VaEfC90e_m8fMznQ")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriodSearch1Choice_? DatePeriod { get; init; }

    /// <summary>
    /// Identifies the cash account for which the audit trail is provided.
    /// </summary>
    [IsoId("_9wOVteVaEfC90e_m8fMznQ")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public required CashAccount40 CashAccountIdentification { get; init; }
}
