// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subscription leg, or switch-in, of a switch order.
/// </summary>
[IsoId("_SLXCVdp-Ed-ak6NoX_4Aeg_-708775222")]
[DisplayName("Switch Subscription Leg Order")]
public record SwitchSubscriptionLegOrder3
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_SLXCVtp-Ed-ak6NoX_4Aeg_-708775126")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SLXCV9p-Ed-ak6NoX_4Aeg_-708774230")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_SLXCWNp-Ed-ak6NoX_4Aeg_-707854105")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity6Choice_? FinancialInstrumentQuantityChoice { get; init; }

    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_SLXCWdp-Ed-ak6NoX_4Aeg_-1166997751")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount21? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_SLXCWtp-Ed-ak6NoX_4Aeg_-708775110")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_SLXCW9p-Ed-ak6NoX_4Aeg_-708774819")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_SLgzUNp-Ed-ak6NoX_4Aeg_-708774802")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_SLgzUdp-Ed-ak6NoX_4Aeg_-707854027")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge17> ChargeDetails { get; init; } = [];

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_SLgzUtp-Ed-ak6NoX_4Aeg_-108109082")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = [];

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_SLgzU9p-Ed-ak6NoX_4Aeg_-707853656")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_SLgzVNp-Ed-ak6NoX_4Aeg_-708774784")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    [IsoId("_SLgzVdp-Ed-ak6NoX_4Aeg_895209820")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public ValueList<Tax16> TaxDetails { get; init; } = [];

    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [IsoId("_SLgzVtp-Ed-ak6NoX_4Aeg_386939737")]
    [DisplayName("Non Standard Settlement Information")]
    [IsoXmlTag("NonStdSttlmInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_SLgzV9p-Ed-ak6NoX_4Aeg_-707853620")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }

    /// <summary>
    /// Part of an investor&apos;s subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    [IsoId("_SLgzWNp-Ed-ak6NoX_4Aeg_892400273")]
    [DisplayName("Equalisation")]
    [IsoXmlTag("Equlstn")]
    public Equalisation1? Equalisation { get; init; }
}
