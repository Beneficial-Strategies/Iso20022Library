// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for cash account audit trail query.
/// </summary>
[IsoId("_mgXTYeTXEfC01pKpYIyMTA")]
[DisplayName("Cash Account Audit Trail Search Criteria4")]
public record CashAccountAuditTrailSearchCriteria4
{
    /// <summary>
    /// Describes cash account to be queried.
    /// </summary>
    [IsoId("_mjjxUeTXEfC01pKpYIyMTA")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccount40? CashAccountIdentification { get; init; }

    /// <summary>
    /// Describes date period for querying information.
    /// </summary>
    [IsoId("_mjjxU-TXEfC01pKpYIyMTA")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriodSearch1Choice_? DatePeriod { get; init; }
}
