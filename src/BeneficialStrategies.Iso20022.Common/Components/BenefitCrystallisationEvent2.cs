// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the realisation of benefits taken from a pension.
/// </summary>
[IsoId("_bWw_QZN4EembCsVG-3f_AA")]
[DisplayName("Benefit Crystallisation Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BenefitCrystallisationEvent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the crystallisation event. In the UK market this could be, for example, BCE5, BE5A or BCE5B.
    /// </summary>
    [IsoId("_brJT05N4EembCsVG-3f_AA")]
    [DisplayName("Event Type Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTpNb")]
    #endif
    [IsoXmlTag("EvtTpNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EventTypeNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventTypeNumber { get; init; } 
    #else
    public System.String? EventTypeNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the crystallisation event. In the UK market this could be, for example, ‘entitlement to scheme pension’.
    /// </summary>
    [IsoId("_brJT0ZN4EembCsVG-3f_AA")]
    [DisplayName("Event Type Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTpNm")]
    #endif
    [IsoXmlTag("EvtTpNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EventTypeName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventTypeName { get; init; } 
    #else
    public System.String? EventTypeName { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the crystallisation event was triggered. 
    /// </summary>
    [IsoId("_brJT1ZN4EembCsVG-3f_AA")]
    [DisplayName("Event Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDt")]
    #endif
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EventDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EventDate { get; init; } 
    #else
    public System.DateOnly? EventDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the crystallisation event.
    /// </summary>
    [IsoId("_brJT15N4EembCsVG-3f_AA")]
    [DisplayName("Crystallisation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrstllstnAmt")]
    #endif
    [IsoXmlTag("CrstllstnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? CrystallisationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of allowance used for the benefit crystallisation event.
    /// </summary>
    [IsoId("_brJT2ZN4EembCsVG-3f_AA")]
    [DisplayName("Percentage Of Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfAllwnc")]
    #endif
    [IsoXmlTag("PctgOfAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfAllowance { get; init; } 
    #else
    public System.Decimal? PercentageOfAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether lifetime allowance protection impacts the benefit crystallisation event.
    /// </summary>
    [IsoId("_O21eYJN5EembCsVG-3f_AA")]
    [DisplayName("Lifetime Allowance Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LftmAllwncPrtcn")]
    #endif
    [IsoXmlTag("LftmAllwncPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LifetimeAllowanceProtection { get; init; } 
    #else
    public System.String? LifetimeAllowanceProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    [IsoId("_brJT25N4EembCsVG-3f_AA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
