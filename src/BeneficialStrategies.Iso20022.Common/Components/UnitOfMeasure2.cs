// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_OO8ZwZF_EeukDPgU2BMkjQ")]
[DisplayName("Unit Of Measure")]
public partial record UnitOfMeasure2
{
    #nullable enable
    
    /// <summary>
    /// Unit of measure of the item being shipped.
    /// </summary>
    [IsoId("_OU5QwZF_EeukDPgU2BMkjQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_OU5Qw5F_EeukDPgU2BMkjQ")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Number of units.
    /// </summary>
    [IsoId("_OU5QxZF_EeukDPgU2BMkjQ")]
    [DisplayName("Number Of Units")]
    [IsoXmlTag("NbOfUnits")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NumberOfUnits { get; init; } 
    
    
    #nullable disable
    
}
