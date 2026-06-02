// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extract of trade data for an investment fund order.
/// </summary>
[IsoId("9cf2189a-e314-43bf-b99a-ebb69310d6d8")]
[DisplayName("Fund Order Data7")]
public record FundOrderData7
{
    /// <summary>
    /// Account information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("cc936d92-5131-414e-8e50-9e94f0e2fd80")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount81? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Financial instrument information of the individual order instruction for which the status is given.
    /// </summary>
    [IsoId("b1df57d0-1baf-4242-a414-cf10b1fef39b")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument107? FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Number of investment fund units subscribed or redeemed.
    /// </summary>
    [IsoId("7a196d0d-4b05-4849-9ea6-7b1fee14e879")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public IsoDecimalNumber? UnitsNumber { get; init; }

    /// <summary>
    /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
    /// </summary>
    [IsoId("e8d01b5a-6510-4624-b785-52be658214b0")]
    [DisplayName("Digital Token Unit")]
    [IsoXmlTag("DgtlTknUnit")]
    public IsoMax30DecimalNumber? DigitalTokenUnit { get; init; }

    /// <summary>
    /// Amount of money to be invested in or received from the fund.
    /// </summary>
    [IsoId("1443c26b-8155-4b93-8561-8f34c11a214b")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Amount of money to be paid by the investor or redeemed from the fund.
    /// </summary>
    [IsoId("12b81252-de0d-4c1f-bd07-c4926bdf3c71")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Portion of the investor's holdings, in a specific investment fund/fund class, that is redeemed.
    /// </summary>
    [IsoId("8a6682a7-79d2-44dc-b89c-06a69e1b9abb")]
    [DisplayName("Holdings Redemption Rate")]
    [IsoXmlTag("HldgsRedRate")]
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; }

    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("aaa5891a-78a5-4998-b386-6ace179921c4")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; }

    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// </summary>
    [IsoId("bf436cd1-2518-446e-922e-afd72869f052")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; }

    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// </summary>
    [IsoId("157d014c-0472-46b2-bb17-8c6f354baff3")]
    [DisplayName("Quoted Currency")]
    [IsoXmlTag("QtdCcy")]
    public ActiveCurrencyCode? QuotedCurrency { get; init; }
}
