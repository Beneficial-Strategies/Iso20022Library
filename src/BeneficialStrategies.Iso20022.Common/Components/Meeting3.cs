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
[IsoId("_TKPsc9p-Ed-ak6NoX_4Aeg_1339167407")]
[DisplayName("Meeting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Meeting3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Meeting3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Meeting3( DateFormat2Choice_ reqDateAndTime,System.String reqQuorumRequired )
    {
        DateAndTime = reqDateAndTime;
        QuorumRequired = reqQuorumRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_TKPsdNp-Ed-ak6NoX_4Aeg_1339167469")]
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
    [IsoId("_TKPsddp-Ed-ak6NoX_4Aeg_1339167530")]
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
    [IsoId("_TKPsdtp-Ed-ak6NoX_4Aeg_1339167561")]
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
    [IsoId("_TKPsd9p-Ed-ak6NoX_4Aeg_1339167932")]
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
    [IsoId("_TKPseNp-Ed-ak6NoX_4Aeg_1339167622")]
    [DisplayName("Quorum Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QrmQty")]
    #endif
    [IsoXmlTag("QrmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuorumQuantity1Choice_? QuorumQuantity { get; init; } 
    #else
    public QuorumQuantity1Choice_? QuorumQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
