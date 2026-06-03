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
[IsoId("c93ca819-6af0-415f-baab-fc1c90cfdbc8")]
[DisplayName("Expected Execution Details5")]
public record ExpectedExecutionDetails5
{
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("7b2e5310-54a0-4406-bfec-07f6ff34030d")]
    [DisplayName("Expected Trade Date Time")]
    [IsoXmlTag("XpctdTradDtTm")]
    public DateAndDateTime2Choice_? ExpectedTradeDateTime { get; init; }

    /// <summary>
    /// Date of a payment, for example, a prepayment date.
    /// </summary>
    [IsoId("1deacae2-46a2-49c9-91ea-04e5f33075c8")]
    [DisplayName("Expected Cash Settlement Date")]
    [IsoXmlTag("XpctdCshSttlmDt")]
    public IsoISODate? ExpectedCashSettlementDate { get; init; }
}
