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
[IsoId("_T-i_sERSEeeb1MmUPTrSMw")]
[DisplayName("Tax")]
public partial record Tax33
{
    #nullable enable
    
    /// <summary>
    /// Type of tax.
    /// </summary>
    [IsoId("_RkBeBkRSEeeb1MmUPTrSMw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AddendumTaxType1Code Type { get; init; } 
    
    /// <summary>
    /// Other type of tax. Describes the type of tax when Other, Other National, Other Private or Other Taxes Type is selected. 
    /// </summary>
    [IsoId("_suAC8PJ5EeiJn9rM2Znz2w")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Description of the tax.
    /// </summary>
    [IsoId("_RkBeCERSEeeb1MmUPTrSMw")]
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
    [IsoId("_0R7ngERSEeeb1MmUPTrSMw")]
    [DisplayName("Tax Exemption")]
    [IsoXmlTag("TaxXmptn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TaxExemption { get; init; } 
    
    /// <summary>
    /// Reason for tax exemption.
    /// </summary>
    [IsoId("_K-F9UfJ6EeiJn9rM2Znz2w")]
    [DisplayName("Tax Exempt Reason")]
    [IsoXmlTag("TaxXmptRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxExemptReason { get; init; } 
    
    /// <summary>
    /// Tax amount.
    /// </summary>
    [IsoId("_RkBeCkRSEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Tax rate applied on original amount.
    /// </summary>
    [IsoId("_RkKn8ERSEeeb1MmUPTrSMw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    
    #nullable disable
    
}
