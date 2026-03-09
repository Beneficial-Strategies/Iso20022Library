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
/// Information about the date and location(s) of a general meeting.
/// </summary>
[IsoId("_l-Zlq609EemDtrWpq90Ckg")]
[DisplayName("Meeting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Meeting5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Meeting5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Meeting5( DateFormat58Choice_ reqDateAndTime,System.String reqQuorumRequired )
    {
        DateAndTime = reqDateAndTime;
        QuorumRequired = reqQuorumRequired;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the meeting will take place.
    /// </summary>
    [IsoId("_mThhFa09EemDtrWpq90Ckg")]
    [DisplayName("Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTm")]
    #endif
    [IsoXmlTag("DtAndTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat58Choice_ DateAndTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat58Choice_ DateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_ DateAndTime { get; init; } 
    #else
    public DateFormat58Choice_ DateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the meeting date.
    /// </summary>
    [IsoId("_mThhF609EemDtrWpq90Ckg")]
    [DisplayName("Date Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtSts")]
    #endif
    [IsoXmlTag("DtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingDateStatus2Code? DateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingDateStatus2Code? DateStatus { get; init; } 
    #else
    public MeetingDateStatus2Code? DateStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a minimum number of security representation is required to hold a meeting.
    /// </summary>
    [IsoId("_mThhGa09EemDtrWpq90Ckg")]
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
    /// Location at which the meeting will take place.
    /// </summary>
    [IsoId("_mThhG609EemDtrWpq90Ckg")]
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
    [IsoId("_mThhHa09EemDtrWpq90Ckg")]
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
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_Hp_Wga0-EemDtrWpq90Ckg")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
