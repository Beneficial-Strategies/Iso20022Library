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
[IsoId("_N2Aj4LToEeiWMOV-LTfmAw")]
[DisplayName("Benefit Crystallisation Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BenefitCrystallisationEvent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of crystallisation event.
    /// </summary>
    [IsoId("_UiBv9LToEeiWMOV-LTfmAw")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrawdownEventType1Choice_? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownEventType1Choice_? EventType { get; init; } 
    #else
    public DrawdownEventType1Choice_? EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the crystallisation event.
    /// </summary>
    [IsoId("_UiBv87ToEeiWMOV-LTfmAw")]
    [DisplayName("Event Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtNb")]
    #endif
    [IsoXmlTag("EvtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EventNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventNumber { get; init; } 
    #else
    public System.String? EventNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the crystallisation event was triggered. 
    /// </summary>
    [IsoId("_UiBv8LToEeiWMOV-LTfmAw")]
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
    [IsoId("_UiBv8bToEeiWMOV-LTfmAw")]
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
    [IsoId("_UiBv8rToEeiWMOV-LTfmAw")]
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
    /// Additional information about the benefit crystallisation event.
    /// </summary>
    [IsoId("_UiBv9bToEeiWMOV-LTfmAw")]
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
