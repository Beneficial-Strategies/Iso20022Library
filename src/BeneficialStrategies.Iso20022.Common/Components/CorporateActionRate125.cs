// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Rate125.
/// </summary>
[IsoId("_3LzgLYV4Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Rate125")]
public partial record CorporateActionRate125
{
    #nullable enable

    /// <summary>
    /// Additional Quantity For Existing Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat20Choice_? AdditionalQuantityForExistingSecurities { get; init; } 

    /// <summary>
    /// Additional Quantity For Subscribed Resultant Securities.
    /// </summary>
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat20Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; } 

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
    public RateAndAmountFormat59Choice_? ChargesFees { get; init; } 

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
    public RatioFormat19Choice_? NewToOld { get; init; } 

    /// <summary>
    /// Second Level Tax.
    /// </summary>
    [DisplayName("Second Level Tax")]
    [IsoXmlTag("ScndLvlTax")]
    public ValueList<RateAndAmountFormat55Choice_> SecondLevelTax { get; init; } = [];

    /// <summary>
    /// Tax Credit Rate.
    /// </summary>
    [DisplayName("Tax Credit Rate")]
    [IsoXmlTag("TaxCdtRate")]
    public RateFormat27Choice_? TaxCreditRate { get; init; } 

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat55Choice_> WithholdingTaxRate { get; init; } = [];

    
    #nullable disable
    
}
