// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
[IsoId("_Ski-Ztp-Ed-ak6NoX_4Aeg_1757732027")]
[DisplayName("Cash Out Forecast")]
public record CashOutForecast4
{
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_Ski-Z9p-Ed-ak6NoX_4Aeg_1757732045")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate CashSettlementDate { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    [IsoId("_Ski-aNp-Ed-ak6NoX_4Aeg_1757732335")]
    [DisplayName("Sub Total Amount")]
    [IsoXmlTag("SubTtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; }

    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    [IsoId("_Ski-adp-Ed-ak6NoX_4Aeg_1757732352")]
    [DisplayName("Sub Total Units Number")]
    [IsoXmlTag("SubTtlUnitsNb")]
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; }

    /// <summary>
    /// Indicates whether the cash flow out is exceptional.
    /// </summary>
    [IsoId("_Ski-atp-Ed-ak6NoX_4Aeg_1757732387")]
    [DisplayName("Exceptional Cash Flow Indicator")]
    [IsoXmlTag("XcptnlCshFlowInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; }
}
