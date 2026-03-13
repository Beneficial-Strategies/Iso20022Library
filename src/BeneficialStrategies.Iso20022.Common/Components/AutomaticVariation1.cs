// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variation parameters and triggers.
/// </summary>
[IsoId("_9yyli3ltEeG7BsjMvd1mEw_-1016607830")]
[DisplayName("Automatic Variation")]
public partial record AutomaticVariation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the automatic variation.
    /// </summary>
    [IsoId("_9yyljHltEeG7BsjMvd1mEw_-276845926")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Type of variation.
    /// </summary>
    [IsoId("_9yyljXltEeG7BsjMvd1mEw_-770869744")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required VariationType1Code Type { get; init; } 
    
    /// <summary>
    /// Details related to the variation amount and its trigger.
    /// </summary>
    [IsoId("_9y7vcHltEeG7BsjMvd1mEw_-1036746610")]
    [DisplayName("Amount And Trigger")]
    [IsoXmlTag("AmtAndTrggr")]
    public ValueList<AmountAndTrigger1> AmountAndTrigger { get; init; } = [];
    // ID for the above is _9y7vcHltEeG7BsjMvd1mEw_-1036746610
    
    /// <summary>
    /// Additional information related to the variation.
    /// </summary>
    [IsoId("_9y7vcXltEeG7BsjMvd1mEw_-469370329")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
