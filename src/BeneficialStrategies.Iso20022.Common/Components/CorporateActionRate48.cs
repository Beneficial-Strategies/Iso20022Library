// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
[IsoId("_CmbWMSnoEeOFFarFEDwxng")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate48
{
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_C-0oFynoEeOFFarFEDwxng")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_C-0oHynoEeOFFarFEDwxng")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_C-0oJynoEeOFFarFEDwxng")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat12Choice_? NewToOld { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_C-0oLynoEeOFFarFEDwxng")]
    [DisplayName("Transformation Rate")]
    [IsoXmlTag("TrfrmatnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TransformationRate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_C-0oMSnoEeOFFarFEDwxng")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat14Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_C-0oMynoEeOFFarFEDwxng")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat3Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_C-0oNSnoEeOFFarFEDwxng")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat3Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_C-0oNynoEeOFFarFEDwxng")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public TaxCreditRateFormat5Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Rate of financial transaction tax.
    /// </summary>
    [IsoId("_TtasUCnoEeOFFarFEDwxng")]
    [DisplayName("Financial Transaction Tax Rate")]
    [IsoXmlTag("FinTxTaxRate")]
    public RateFormat3Choice_? FinancialTransactionTaxRate { get; init; }
}
