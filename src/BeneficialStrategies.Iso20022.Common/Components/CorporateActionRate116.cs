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
[IsoId("_YXgYFV99Ee262vCSVgjImg")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate116
{
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_YXgYGV99Ee262vCSVgjImg")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat23Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_YXgYIV99Ee262vCSVgjImg")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat23Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_YXgYKV99Ee262vCSVgjImg")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat24Choice_? NewToOld { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_YXgYMV99Ee262vCSVgjImg")]
    [DisplayName("Transformation Rate")]
    [IsoXmlTag("TrfrmatnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TransformationRate { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charges/fees that cannot be categorised.
    /// </summary>
    [IsoId("_YXgYM199Ee262vCSVgjImg")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat46Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Percentage of fiscal tax to apply.
    /// </summary>
    [IsoId("_YXgYNV99Ee262vCSVgjImg")]
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat3Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// Rate applicable to the event announced, for example, redemption rate for a redemption event.
    /// </summary>
    [IsoId("_YXgYN199Ee262vCSVgjImg")]
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat3Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Amount of money per equity allocated as the result of a tax credit.
    /// </summary>
    [IsoId("_YXgYOV99Ee262vCSVgjImg")]
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat21Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Rate of financial transaction tax.
    /// </summary>
    [IsoId("_YXgYO199Ee262vCSVgjImg")]
    [DisplayName("Financial Transaction Tax Rate")]
    [IsoXmlTag("FinTxTaxRate")]
    public RateFormat3Choice_? FinancialTransactionTaxRate { get; init; }

    /// <summary>
    /// Percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_YXgYPV99Ee262vCSVgjImg")]
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat47Choice_> WithholdingTaxRate { get; init; } = [];

    /// <summary>
    /// Rate at which the income will be withheld by a jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible. It is levied in complement or offset of the withholding tax rate (TAXR) levied by the jurisdiction of the issuer’s tax domicile.
    /// </summary>
    [IsoId("_YXgYP199Ee262vCSVgjImg")]
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat47Choice_> SecondLevelTax { get; init; } = [];
}
