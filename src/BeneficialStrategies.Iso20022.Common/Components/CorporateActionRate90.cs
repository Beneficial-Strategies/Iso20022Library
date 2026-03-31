// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rate details.
/// </summary>
[IsoId("_BdK6YZcAEee8S7xwGG7Veg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate90
{
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_Br5595cAEee8S7xwGG7Veg")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat20Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_Br55_5cAEee8S7xwGG7Veg")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat20Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_Br56B5cAEee8S7xwGG7Veg")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat19Choice_? NewToOld { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_Br56D5cAEee8S7xwGG7Veg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat39Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_Br56EZcAEee8S7xwGG7Veg")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? FiscalStamp { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_Br56E5cAEee8S7xwGG7Veg")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ApplicableRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_Br56FZcAEee8S7xwGG7Veg")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat22Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Rate of financial transaction tax.
    /// </summary>
    [IsoId("_Br56F5cAEee8S7xwGG7Veg")]
    [DisplayName("Financial Transaction Tax Rate")]
    [IsoXmlTag("FinTxTaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? FinancialTransactionTaxRate { get; init; }
}
