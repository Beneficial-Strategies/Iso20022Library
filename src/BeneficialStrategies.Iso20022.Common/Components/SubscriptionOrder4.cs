// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor&apos;s principal in an investment fund.
/// </summary>
[IsoId("_VToa1tp-Ed-ak6NoX_4Aeg_-610302907")]
[DisplayName("Subscription Order")]
public record SubscriptionOrder4
{
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_VToa19p-Ed-ak6NoX_4Aeg_-610302905")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; }

    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    [IsoId("_VToa2Np-Ed-ak6NoX_4Aeg_-610302717")]
    [DisplayName("Order Type")]
    [IsoXmlTag("OrdrTp")]
    public ValueList<FundOrderType1> OrderType { get; init; } = [];

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VToa2dp-Ed-ak6NoX_4Aeg_-610302344")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VToa2tp-Ed-ak6NoX_4Aeg_-610302872")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_VToa29p-Ed-ak6NoX_4Aeg_-610302847")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public required ActiveOrHistoricCurrencyAndAmount NetAmount { get; init; }

    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_VToa3Np-Ed-ak6NoX_4Aeg_-335526969")]
    [DisplayName("Rounding")]
    [IsoXmlTag("Rndg")]
    public RoundingDirection2Code? Rounding { get; init; }

    /// <summary>
    /// Amount of money used to determine the quantity of investment fund units to be subscribed, including all charges, commissions, and tax.
    /// </summary>
    [IsoId("_VTyL0Np-Ed-ak6NoX_4Aeg_-610302830")]
    [DisplayName("Gross Amount")]
    [IsoXmlTag("GrssAmt")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_VTyL0dp-Ed-ak6NoX_4Aeg_-289035538")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VTyL0tp-Ed-ak6NoX_4Aeg_-610302812")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer&apos;s actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [IsoId("_VTyL09p-Ed-ak6NoX_4Aeg_-610302787")]
    [DisplayName("Letter Intent Reference")]
    [IsoXmlTag("LttrInttRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LetterIntentReference { get; init; }

    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer&apos;s present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [IsoId("_VTyL1Np-Ed-ak6NoX_4Aeg_-610302770")]
    [DisplayName("Accumulation Right Reference")]
    [IsoXmlTag("AcmltnRghtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccumulationRightReference { get; init; }

    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    [IsoId("_VTyL1dp-Ed-ak6NoX_4Aeg_-610302414")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge8> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VTyL1tp-Ed-ak6NoX_4Aeg_-610302379")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission6> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_VTyL19p-Ed-ak6NoX_4Aeg_-610302457")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax6> TaxDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VTyL2Np-Ed-ak6NoX_4Aeg_-610302011")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VT7VwNp-Ed-ak6NoX_4Aeg_-610302475")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VT7Vwdp-Ed-ak6NoX_4Aeg_-610302301")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VT7Vwtp-Ed-ak6NoX_4Aeg_-610302752")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VT7Vw9p-Ed-ak6NoX_4Aeg_-610302735")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VT7VxNp-Ed-ak6NoX_4Aeg_-610301976")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction19? CashSettlementDetails { get; init; }
}
