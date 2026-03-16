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
[IsoId("_VS4z9Np-Ed-ak6NoX_4Aeg_1801928799")]
[DisplayName("Switch Subscription Leg Order")]
public record SwitchSubscriptionLegOrder2
{
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [IsoId("_VS4z9dp-Ed-ak6NoX_4Aeg_1801930589")]
    [DisplayName("Leg Identification")]
    [IsoXmlTag("LegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LegIdentification { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VS4z9tp-Ed-ak6NoX_4Aeg_1801931092")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    [IsoId("_VS4z99p-Ed-ak6NoX_4Aeg_1801930797")]
    [DisplayName("Financial Instrument Quantity Choice")]
    [IsoXmlTag("FinInstrmQtyChc")]
    public FinancialInstrumentQuantity4Choice_? FinancialInstrumentQuantityChoice { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_VS4z-Np-Ed-ak6NoX_4Aeg_1801928841")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    [IsoId("_VS4z-dp-Ed-ak6NoX_4Aeg_82888763")]
    [DisplayName("Requested Settlement Currency")]
    [IsoXmlTag("ReqdSttlmCcy")]
    public CurrencyCode? RequestedSettlementCurrency { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_VS4z-tp-Ed-ak6NoX_4Aeg_82888848")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    [IsoId("_VS4z-9p-Ed-ak6NoX_4Aeg_1801931152")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public Charge8? ChargeDetails { get; init; }

    /// <summary>
    /// Commission linked to the execution of an investment fund order.
    /// </summary>
    [IsoId("_VS4z_Np-Ed-ak6NoX_4Aeg_1801931169")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission6? CommissionDetails { get; init; }

    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    [IsoId("_VTCk8Np-Ed-ak6NoX_4Aeg_1801931213")]
    [DisplayName("Tax Details")]
    [IsoXmlTag("TaxDtls")]
    public Tax6? TaxDetails { get; init; }

    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [IsoId("_VTCk8dp-Ed-ak6NoX_4Aeg_1801930626")]
    [DisplayName("Settlement And Custody Details")]
    [IsoXmlTag("SttlmAndCtdyDtls")]
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [IsoId("_VTCk8tp-Ed-ak6NoX_4Aeg_1801928859")]
    [DisplayName("Physical Delivery Indicator")]
    [IsoXmlTag("PhysDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; }

    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    [IsoId("_VTCk89p-Ed-ak6NoX_4Aeg_1801930642")]
    [DisplayName("Physical Delivery Details")]
    [IsoXmlTag("PhysDlvryDtls")]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; }
}
