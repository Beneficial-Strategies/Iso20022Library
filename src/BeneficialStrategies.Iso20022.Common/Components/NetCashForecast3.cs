// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net cash movement to a fund as a result of investment funds transactions.
/// </summary>
[IsoId("_Si5_pdp-Ed-ak6NoX_4Aeg_1538517625")]
[DisplayName("Net Cash Forecast")]
public record NetCashForecast3
{
    /// <summary>
    /// Net amount of the cash flow, expressed as an amount of money.
    /// </summary>
    [IsoId("_Si5_ptp-Ed-ak6NoX_4Aeg_1538517912")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Net amount, expressed as a number of units.
    /// </summary>
    [IsoId("_Si5_p9p-Ed-ak6NoX_4Aeg_1538517937")]
    [DisplayName("Net Units Number")]
    [IsoXmlTag("NetUnitsNb")]
    public FinancialInstrumentQuantity1? NetUnitsNumber { get; init; }

    /// <summary>
    /// Specifies the direction of the cash flow from the perspective of the fund.
    /// </summary>
    [IsoId("_Si5_qNp-Ed-ak6NoX_4Aeg_1538517972")]
    [DisplayName("Flow Direction")]
    [IsoXmlTag("FlowDrctn")]
    public required FlowDirectionType1Code FlowDirection { get; init; }
}
