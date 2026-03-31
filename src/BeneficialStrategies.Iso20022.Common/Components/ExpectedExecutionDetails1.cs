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
[IsoId("_VGhL7tp-Ed-ak6NoX_4Aeg_-1557006265")]
[DisplayName("Expected Execution Details")]
public record ExpectedExecutionDetails1
{
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("_VGhL79p-Ed-ak6NoX_4Aeg_-1370456351")]
    [DisplayName("Expected Trade Date Time")]
    [IsoXmlTag("XpctdTradDtTm")]
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; }

    /// <summary>
    /// Expected date at which the financial instruments will be exchanged against cash.
    /// </summary>
    [IsoId("_VGq84Np-Ed-ak6NoX_4Aeg_-1060152455")]
    [DisplayName("Expected Settlement Date")]
    [IsoXmlTag("XpctdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedSettlementDate { get; init; }
}
