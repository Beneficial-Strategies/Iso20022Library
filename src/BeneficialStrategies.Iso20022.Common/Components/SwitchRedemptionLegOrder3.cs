// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Redemption leg, or switch-out, of a switch transaction.
/// </summary>
[IsoId("_SK6WYNp-Ed-ak6NoX_4Aeg_-1708950755")]
[DisplayName("Switch Redemption Leg Order")]
public record SwitchRedemptionLegOrder3
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_SK6WYdp-Ed-ak6NoX_4Aeg_-1708950730")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SK6WYtp-Ed-ak6NoX_4Aeg_-1708948739")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SK6WY9p-Ed-ak6NoX_4Aeg_-1708948894")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity5Choice_? FinancialInstrumentQuantityChoice { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_SK6WZNp-Ed-ak6NoX_4Aeg_-1177159675")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount21? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SK6WZdp-Ed-ak6NoX_4Aeg_-1708950713")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_SK6WZtp-Ed-ak6NoX_4Aeg_-1708950660")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SK6WZ9p-Ed-ak6NoX_4Aeg_-1708950418")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SK6WaNp-Ed-ak6NoX_4Aeg_-1708950288")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_SLEHYNp-Ed-ak6NoX_4Aeg_-1708949298")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge17> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_SLEHYdp-Ed-ak6NoX_4Aeg_-97949453")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SLEHYtp-Ed-ak6NoX_4Aeg_438991890")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax16> TaxDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SLEHY9p-Ed-ak6NoX_4Aeg_-1708949722")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SLEHZNp-Ed-ak6NoX_4Aeg_-1708949980")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SLEHZdp-Ed-ak6NoX_4Aeg_-1708949876")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SLEHZtp-Ed-ak6NoX_4Aeg_302899296")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SLEHZ9p-Ed-ak6NoX_4Aeg_725242136")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
