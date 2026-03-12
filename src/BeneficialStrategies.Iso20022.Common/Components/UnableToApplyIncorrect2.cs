// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of incorrect information.
/// </summary>
[IsoId("_-C21gdjKEeq5MfBBxQig1Q")]
[DisplayName("Unable To Apply Incorrect")]
public partial record UnableToApplyIncorrect2
{
    #nullable enable
    
    /// <summary>
    /// Specifies which data type is incorrect in the transaction.
    /// </summary>
    [IsoId("_-FWv49jKEeq5MfBBxQig1Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IncorrectData1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Further details about the incorrect information.
    /// </summary>
    [IsoId("_-FWv5djKEeq5MfBBxQig1Q")]
    [DisplayName("Additional Incorrect Information")]
    [IsoXmlTag("AddtlIncrrctInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalIncorrectInformation { get; init; } 
    
    
    #nullable disable
    
}
