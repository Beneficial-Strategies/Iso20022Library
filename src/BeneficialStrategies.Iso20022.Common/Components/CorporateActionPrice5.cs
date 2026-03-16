// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
[IsoId("_TWKoldp-Ed-ak6NoX_4Aeg_678070102")]
[DisplayName("Corporate Action Price")]
public record CorporateActionPrice5
{
    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or a number of points above an index.
    /// </summary>
    [IsoId("_TWKoltp-Ed-ak6NoX_4Aeg_678070194")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public PriceFormat6Choice_? ExercisePrice { get; init; }

    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    [IsoId("_TWKol9p-Ed-ak6NoX_4Aeg_678070564")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat7Choice_? GenericCashPriceReceivedPerProduct { get; init; }

    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    [IsoId("_TWKomNp-Ed-ak6NoX_4Aeg_678070626")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat5Choice_? GenericCashPricePaidPerProduct { get; init; }

    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments within the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_TWTygNp-Ed-ak6NoX_4Aeg_678070656")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public AmountPrice3? TaxableIncomePerDividendShare { get; init; }

    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_TWTygdp-Ed-ak6NoX_4Aeg_678070163")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat5Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_TWTygtp-Ed-ak6NoX_4Aeg_678070595")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat5Choice_? OverSubscriptionDepositPrice { get; init; }
}
