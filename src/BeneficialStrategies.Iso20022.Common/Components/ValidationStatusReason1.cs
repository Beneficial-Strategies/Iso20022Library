// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information on the status reason of the record.
/// </summary>
[IsoId("_Nx3NEQtPEeWkxvNyFrBT8Q")]
[DisplayName("Validation Status Reason")]
public partial record ValidationStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_N71BZQtPEeWkxvNyFrBT8Q")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification77? Originator { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status.
    /// </summary>
    [IsoId("_N71BZwtPEeWkxvNyFrBT8Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public StatusReason6Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Provides details about the rule which could not be validated.
    /// </summary>
    [IsoId("_T2qoIQtPEeWkxvNyFrBT8Q")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_N71BaQtPEeWkxvNyFrBT8Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
