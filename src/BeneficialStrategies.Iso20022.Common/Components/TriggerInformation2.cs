// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element containing all information needed to identify who triggered the request.
/// </summary>
[IsoId("_Bn_c4RBcEeqgJK7e3n_EXA")]
[DisplayName("Trigger Information")]
public partial record TriggerInformation2
{
    #nullable enable
    
    /// <summary>
    /// Actor who trigger the request.
    /// </summary>
    [IsoId("_By5FURBcEeqgJK7e3n_EXA")]
    [DisplayName("Trigger Source")]
    [IsoXmlTag("TrggrSrc")]
    public required PartyType5Code TriggerSource { get; init; } 
    
    /// <summary>
    /// Identification of the trigger source.
    /// </summary>
    [IsoId("_By5FUxBcEeqgJK7e3n_EXA")]
    [DisplayName("Source Identification")]
    [IsoXmlTag("SrcId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text SourceIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the type of the call.
    /// </summary>
    [IsoId("_By5FVRBcEeqgJK7e3n_EXA")]
    [DisplayName("Trigger Type")]
    [IsoXmlTag("TrggrTp")]
    public required ExchangePolicy2Code TriggerType { get; init; } 
    
    /// <summary>
    /// Additional information related to request.
    /// </summary>
    [IsoId("_By5FVxBcEeqgJK7e3n_EXA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
