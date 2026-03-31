// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate132.
/// </summary>
[IsoId("_kv7M05t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Rate132")]
public record CorporateActionRate132
{
    /// <summary>
    /// Additional Quantity For Existing Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat21Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Additional Quantity For Subscribed Resultant Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat21Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Applicable Rate.
    /// </summary>
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public IsoPercentage14Rate? ApplicableRate { get; init; }

    /// <summary>
    /// Charges Fees.
    /// </summary>
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat67Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Financial Transaction Tax Rate.
    /// </summary>
    [DisplayName("Financial Transaction Tax Rate")]
    [IsoXmlTag("FinTxTaxRate")]
    public IsoPercentage14Rate? FinancialTransactionTaxRate { get; init; }

    /// <summary>
    /// Fiscal Stamp.
    /// </summary>
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public IsoPercentage14Rate? FiscalStamp { get; init; }

    /// <summary>
    /// New To Old.
    /// </summary>
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat22Choice_? NewToOld { get; init; }

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat66Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Tax Credit Rate.
    /// </summary>
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat28Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat66Choice_> WithholdingTaxRate { get; init; } = [];
}
