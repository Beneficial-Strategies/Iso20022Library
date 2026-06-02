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
[IsoId("cc220cd8-d6a8-4541-a2a8-b868d95e74fc")]
[DisplayName("Expected Execution6")]
public record ExpectedExecution6
{
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("bbcb1ca5-82f2-4751-840e-ff1082ed3549")]
    [DisplayName("Expected Trade Date Time")]
    [IsoXmlTag("XpctdTradDtTm")]
    public DateAndDateTime2Choice? ExpectedTradeDateTime { get; init; }

    /// <summary>
    /// Expected date at which the financial instruments will be exchanged against cash.
    /// </summary>
    [IsoId("b6845b9e-a4ef-4f6a-94f7-767a429b10b7")]
    [DisplayName("Expected Cash Settlement Date")]
    [IsoXmlTag("XpctdCshSttlmDt")]
    public IsoISODate? ExpectedCashSettlementDate { get; init; }
}
