// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number of crystallised units.
/// </summary>
[IsoId("_PzGf8E3gEeidB49bWZiS0g")]
[DisplayName("Crystallisation")]
public partial record Crystallisation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the tranche.
    /// </summary>
    [IsoId("_XvKXkE3gEeidB49bWZiS0g")]
    [DisplayName("Tranche Identification")]
    [IsoXmlTag("TrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TrancheIdentification { get; init; } 
    
    /// <summary>
    /// Number of units crystallised.
    /// </summary>
    [IsoId("_erZw8E3gEeidB49bWZiS0g")]
    [DisplayName("Crystallised Units Number")]
    [IsoXmlTag("CrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? CrystallisedUnitsNumber { get; init; } 
    
    /// <summary>
    /// Number of units uncrystallised.
    /// </summary>
    [IsoId("_iUO40E3gEeidB49bWZiS0g")]
    [DisplayName("Uncrystallised Units Number")]
    [IsoXmlTag("UcrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? UncrystallisedUnitsNumber { get; init; } 
    
    /// <summary>
    /// Additional information about the crystallisation.
    /// </summary>
    [IsoId("_tmFnkE3gEeidB49bWZiS0g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
