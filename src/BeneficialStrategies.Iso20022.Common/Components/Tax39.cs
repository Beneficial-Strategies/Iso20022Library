// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of tax.
/// </summary>
[IsoId("_75ERgSB_Eey8XKHwKquEQw")]
[DisplayName("Tax")]
public partial record Tax39
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_7_qowSB_Eey8XKHwKquEQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AddendumTaxType2Code Type { get; init; } 
    
    /// <summary>
    /// Other type of tax. Describes the type of tax when Other, Other National, Other Private or Other Taxes Type is selected. 
    /// </summary>
    [IsoId("_7_qowyB_Eey8XKHwKquEQw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Description of the tax.
    /// </summary>
    [IsoId("_7_qoxSB_Eey8XKHwKquEQw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Description { get; init; } 
    
    /// <summary>
    /// Exemption for this type of tax.
    /// True: Exemption of tax
    /// False: No exemption of tax
    /// </summary>
    [IsoId("_7_qoxyB_Eey8XKHwKquEQw")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TaxExemption { get; init; } 
    
    /// <summary>
    /// Reason for tax exemption.
    /// </summary>
    [IsoId("_7_qoySB_Eey8XKHwKquEQw")]
    [DisplayName("Tax Exempt Reason")]
    [IsoXmlTag("TaxXmptRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxExemptReason { get; init; } 
    
    /// <summary>
    /// Tax amount.
    /// </summary>
    [IsoId("_7_qoyyB_Eey8XKHwKquEQw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Tax rate applied on original amount.
    /// </summary>
    [IsoId("_7_qozSB_Eey8XKHwKquEQw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Indicate whether the Tax amount is included in total transaction amount
    /// </summary>
    [IsoId("_PQL3MCCAEey8XKHwKquEQw")]
    [DisplayName("Included In Total Indicator")]
    [IsoXmlTag("InclInTtlInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? IncludedInTotalIndicator { get; init; } 
    
    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_ZJllQCCAEey8XKHwKquEQw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    
    #nullable disable
    
}
