// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fees not included in the transaction.
/// </summary>
[IsoId("_mFHMkESLEeeb1MmUPTrSMw")]
[DisplayName("Additional Fee")]
public partial record AdditionalFee1
{
    #nullable enable
    
    /// <summary>
    /// Type or class of fee.
    /// </summary>
    [IsoId("_1pF31ESLEeeb1MmUPTrSMw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount10Code Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of amount of fee.
    /// </summary>
    [IsoId("_1pF31USLEeeb1MmUPTrSMw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Identification of fee program.
    /// </summary>
    [IsoId("_7lgj8WqBEemXfKijhrqa-Q")]
    [DisplayName("Fee Program")]
    [IsoXmlTag("FeePrgm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FeeProgram { get; init; } 
    
    /// <summary>
    /// Identification of specific fee.
    /// </summary>
    [IsoId("_8a_acWqBEemXfKijhrqa-Q")]
    [DisplayName("Fee Descriptor")]
    [IsoXmlTag("FeeDscrptr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FeeDescriptor { get; init; } 
    
    /// <summary>
    /// Amount of one occurrence of the fee amount.
    /// </summary>
    [IsoId("_1pF31kSLEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required FeeAmount2 Amount { get; init; } 
    
    /// <summary>
    /// Short description of the fee amount.
    /// </summary>
    [IsoId("_wsUqAZmJEee_M7tURHTZTQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; } 
    
    
    #nullable disable
    
}
