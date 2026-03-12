// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the realisation of benefits taken from a pension.
/// </summary>
[IsoId("_bWw_QZN4EembCsVG-3f_AA")]
[DisplayName("Benefit Crystallisation Event")]
public partial record BenefitCrystallisationEvent2
{
    #nullable enable
    
    /// <summary>
    /// Number of the crystallisation event. In the UK market this could be, for example, BCE5, BE5A or BCE5B.
    /// </summary>
    [IsoId("_brJT05N4EembCsVG-3f_AA")]
    [DisplayName("Event Type Number")]
    [IsoXmlTag("EvtTpNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EventTypeNumber { get; init; } 
    
    /// <summary>
    /// Name of the crystallisation event. In the UK market this could be, for example, ‘entitlement to scheme pension’.
    /// </summary>
    [IsoId("_brJT0ZN4EembCsVG-3f_AA")]
    [DisplayName("Event Type Name")]
    [IsoXmlTag("EvtTpNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? EventTypeName { get; init; } 
    
    /// <summary>
    /// Date on which the crystallisation event was triggered. 
    /// </summary>
    [IsoId("_brJT1ZN4EembCsVG-3f_AA")]
    [DisplayName("Event Date")]
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EventDate { get; init; } 
    
    /// <summary>
    /// Amount of the crystallisation event.
    /// </summary>
    [IsoId("_brJT15N4EembCsVG-3f_AA")]
    [DisplayName("Crystallisation Amount")]
    [IsoXmlTag("CrstllstnAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; init; } 
    
    /// <summary>
    /// Percentage of allowance used for the benefit crystallisation event.
    /// </summary>
    [IsoId("_brJT2ZN4EembCsVG-3f_AA")]
    [DisplayName("Percentage Of Allowance")]
    [IsoXmlTag("PctgOfAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfAllowance { get; init; } 
    
    /// <summary>
    /// Indicates whether lifetime allowance protection impacts the benefit crystallisation event.
    /// </summary>
    [IsoId("_O21eYJN5EembCsVG-3f_AA")]
    [DisplayName("Lifetime Allowance Protection")]
    [IsoXmlTag("LftmAllwncPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    
    /// <summary>
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    [IsoId("_brJT25N4EembCsVG-3f_AA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
