// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further information on the reason for the unable to apply investigation.
/// </summary>
[IsoId("_7MMxcdjKEeq5MfBBxQig1Q")]
[DisplayName("Missing Or Incorrect Data")]
public partial record MissingOrIncorrectData1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the request is related to an AML (Anti Money Laundering) investigation or not.
    /// </summary>
    [IsoId("_7O3D4djKEeq5MfBBxQig1Q")]
    [DisplayName("Anti Money Laundering Request")]
    [IsoXmlTag("AMLReq")]
    [IsoSimpleType(IsoSimpleType.AMLIndicator)]
    public IsoAMLIndicator? AntiMoneyLaunderingRequest { get; init; } 
    
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    [IsoId("_7O3D49jKEeq5MfBBxQig1Q")]
    [DisplayName("Missing Information")]
    [IsoXmlTag("MssngInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<UnableToApplyMissing2> MissingInformation { get; init; } = new ValueList<UnableToApplyMissing2>(){};
    
    /// <summary>
    /// Indicates, in a coded form, the incorrect information.
    /// </summary>
    [IsoId("_7O3D5djKEeq5MfBBxQig1Q")]
    [DisplayName("Incorrect Information")]
    [IsoXmlTag("IncrrctInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<UnableToApplyIncorrect2> IncorrectInformation { get; init; } = new ValueList<UnableToApplyIncorrect2>(){};
    
    
    #nullable disable
    
}
