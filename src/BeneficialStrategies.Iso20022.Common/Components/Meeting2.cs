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
/// Specifies the physical parameters of a shareholders meeting. Several dates and places can be defined for a meeting.
/// </summary>
[IsoId("_TKY2Y9p-Ed-ak6NoX_4Aeg_795834246")]
[DisplayName("Meeting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Meeting2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Meeting2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Meeting2( DateFormat2Choice_ reqDateAndTime,System.String reqQuorumRequired )
    {
        DateAndTime = reqDateAndTime;
        QuorumRequired = reqQuorumRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TKY2ZNp-Ed-ak6NoX_4Aeg_795834504")]
    [DisplayName("Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTm")]
    #endif
    [IsoXmlTag("DtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat2Choice_ DateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat2Choice_ DateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_ DateAndTime { get; init; } 
    #else
    public DateFormat2Choice_ DateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the status of a meeting date.
    /// </summary>
    [IsoId("_TKY2Zdp-Ed-ak6NoX_4Aeg_795834512")]
    [DisplayName("Date Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtSts")]
    #endif
    [IsoXmlTag("DtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingDateStatus1Code? DateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingDateStatus1Code? DateStatus { get; init; } 
    #else
    public MeetingDateStatus1Code? DateStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2Ztp-Ed-ak6NoX_4Aeg_795834537")]
    [DisplayName("Quorum Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QrmReqrd")]
    #endif
    [IsoXmlTag("QrmReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator QuorumRequired { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QuorumRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QuorumRequired { get; init; } 
    #else
    public System.String QuorumRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies location where meeting will take place.
    /// </summary>
    [IsoId("_TKY2Z9p-Ed-ak6NoX_4Aeg_205631143")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<LocationFormat1Choice_> Location { get; init; } = new ValueList<LocationFormat1Choice_>(){};
    
    /// <summary>
    /// Minimum quantity of securities required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2aNp-Ed-ak6NoX_4Aeg_795834554")]
    [DisplayName("Quorum Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QrmQty")]
    #endif
    [IsoXmlTag("QrmQty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QuorumQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QuorumQuantity { get; init; } 
    #else
    public System.String? QuorumQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as a percentage, required to hold a meeting.
    /// </summary>
    [IsoId("_TKY2adp-Ed-ak6NoX_4Aeg_795834597")]
    [DisplayName("Quorum Quantity Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QrmQtyPctg")]
    #endif
    [IsoXmlTag("QrmQtyPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? QuorumQuantityPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? QuorumQuantityPercentage { get; init; } 
    #else
    public System.Decimal? QuorumQuantityPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
