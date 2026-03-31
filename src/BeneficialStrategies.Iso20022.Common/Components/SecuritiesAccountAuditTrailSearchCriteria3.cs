// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for securities account audit trail query.
/// </summary>
[IsoId("_0Ba1cTpzEemk2e6qGBk8IQ")]
[DisplayName("Securities Account Audit Trail Search Criteria")]
public record SecuritiesAccountAuditTrailSearchCriteria3
{
    /// <summary>
    /// Unique identification of the securities account to be queried.
    /// </summary>
    [IsoId("_0L2j0TpzEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    public SecuritiesAccount19? SecuritiesAccountIdentification { get; init; }

    /// <summary>
    /// Specifies the period for querying information.
    /// </summary>
    [IsoId("_0L2j0zpzEemk2e6qGBk8IQ")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriodSearch1Choice_? DatePeriod { get; init; }
}
