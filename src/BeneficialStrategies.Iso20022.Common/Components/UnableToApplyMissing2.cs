// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of missing information.
/// </summary>
[IsoId("_7O3D59jKEeq5MfBBxQig1Q")]
[DisplayName("Unable To Apply Missing")]
public partial record UnableToApplyMissing2
{
    #nullable enable
    
    /// <summary>
    /// Specifies which data type is mising in the transaction.
    /// </summary>
    [IsoId("_7RUiAdjKEeq5MfBBxQig1Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required MissingData1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Further details about the missing information.
    /// </summary>
    [IsoId("_7RUiA9jKEeq5MfBBxQig1Q")]
    [DisplayName("Additional Missing Information")]
    [IsoXmlTag("AddtlMssngInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalMissingInformation { get; init; } 
    
    
    #nullable disable
    
}
