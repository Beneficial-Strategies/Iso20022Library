// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Expected trade date and expected settlement date of the order execution.
/// </summary>
[IsoId("_6azDQUgXEea9YuSvQGoi-w")]
[DisplayName("Expected Execution Details")]
public record ExpectedExecutionDetails4
{
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("_60PeA0gXEea9YuSvQGoi-w")]
    [DisplayName("Expected Trade Date Time")]
    [IsoXmlTag("XpctdTradDtTm")]
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; }

    /// <summary>
    /// Date of a payment, for example, a prepayment date.
    /// </summary>
    [IsoId("_60PeBUgXEea9YuSvQGoi-w")]
    [DisplayName("Expected Cash Settlement Date")]
    [IsoXmlTag("XpctdCshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedCashSettlementDate { get; init; }
}
