// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate129.
/// </summary>
[IsoId("_g81uUYV5Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Rate129")]
public record CorporateActionRate129
{
    /// <summary>
    /// Additional Quantity For Existing Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat17Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Additional Quantity For Subscribed Resultant Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat17Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Applicable Rate.
    /// </summary>
    [DisplayName("Applicable Rate")]
    [IsoXmlTag("AplblRate")]
    public RateFormat24Choice_? ApplicableRate { get; init; }

    /// <summary>
    /// Charges Fees.
    /// </summary>
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public RateAndAmountFormat57Choice_? ChargesFees { get; init; }

    /// <summary>
    /// Estimated Rate Indicator.
    /// </summary>
    [DisplayName("Estimated Rate Indicator")]
    [IsoXmlTag("EstmtdRateInd")]
    public IsoYesNoIndicator? EstimatedRateIndicator { get; init; }

    /// <summary>
    /// Financial Transaction Tax Rate.
    /// </summary>
    [DisplayName("Financial Transaction Tax Rate")]
    [IsoXmlTag("FinTxTaxRate")]
    public RateFormat24Choice_? FinancialTransactionTaxRate { get; init; }

    /// <summary>
    /// Fiscal Stamp.
    /// </summary>
    [DisplayName("Fiscal Stamp")]
    [IsoXmlTag("FsclStmp")]
    public RateFormat24Choice_? FiscalStamp { get; init; }

    /// <summary>
    /// New To Old.
    /// </summary>
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat18Choice_? NewToOld { get; init; }

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat56Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Tax Credit Rate.
    /// </summary>
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat26Choice_? TaxCreditRate { get; init; }

    /// <summary>
    /// Transformation Rate.
    /// </summary>
    [DisplayName("Transformation Rate")]
    [IsoXmlTag("TrfrmatnRate")]
    public IsoPercentage14Rate? TransformationRate { get; init; }

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat56Choice_> WithholdingTaxRate { get; init; } = [];
}
