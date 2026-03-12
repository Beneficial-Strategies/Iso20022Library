// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Percentage of ownership or of beneficial ownership of the shares/units in the account.
/// </summary>
[IsoId("_5pdeAEzaEea8fovz_9xSTQ")]
[DisplayName("Ownership Beneficiary Rate")]
public partial record OwnershipBeneficiaryRate1
{
    #nullable enable
    
    /// <summary>
    /// Ownership or beneficial ownership expressed as a percentage.
    /// </summary>
    [IsoId("_Inb5MEzbEea8fovz_9xSTQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Ownership or beneficial ownership expressed as a fraction or another form.
    /// </summary>
    [IsoId("_LmBxQEzbEea8fovz_9xSTQ")]
    [DisplayName("Fraction")]
    [IsoXmlTag("Frctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Fraction { get; init; } 
    
    
    #nullable disable
    
}
