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
[IsoId("_18oYYTOOEeqjy7_SkdcoGg")]
[DisplayName("Crystallisation")]
public partial record Crystallisation2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the tranche.
    /// </summary>
    [IsoId("_2USDYTOOEeqjy7_SkdcoGg")]
    [DisplayName("Tranche Identification")]
    [IsoXmlTag("TrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TrancheIdentification { get; init; } 
    
    /// <summary>
    /// Number of units crystallised.
    /// </summary>
    [IsoId("_2USDYzOOEeqjy7_SkdcoGg")]
    [DisplayName("Crystallised Units Number")]
    [IsoXmlTag("CrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? CrystallisedUnitsNumber { get; init; } 
    
    /// <summary>
    /// Number of units uncrystallised.
    /// </summary>
    [IsoId("_2USDZTOOEeqjy7_SkdcoGg")]
    [DisplayName("Uncrystallised Units Number")]
    [IsoXmlTag("UcrstllsdUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? UncrystallisedUnitsNumber { get; init; } 
    
    /// <summary>
    /// Sum representing the crystallised amount.
    /// </summary>
    [IsoId("_9dUioDOOEeqjy7_SkdcoGg")]
    [DisplayName("Crystallised Amount")]
    [IsoXmlTag("CrstllsdAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CrystallisedAmount { get; init; } 
    
    /// <summary>
    /// Sum representing the uncrystallised amount.
    /// </summary>
    [IsoId("_C-z1QDOPEeqjy7_SkdcoGg")]
    [DisplayName("Uncrystallised Amount")]
    [IsoXmlTag("UcrstllsdAmt")]
    public ActiveCurrencyAnd13DecimalAmount? UncrystallisedAmount { get; init; } 
    
    /// <summary>
    /// Additional information about the crystallisation.
    /// </summary>
    [IsoId("_2USDZzOOEeqjy7_SkdcoGg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
