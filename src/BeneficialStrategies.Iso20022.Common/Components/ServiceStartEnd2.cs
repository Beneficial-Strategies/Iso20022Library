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
/// Start or end of service.
/// </summary>
[IsoId("_QOD4UcW1EeuhguwJmlgagQ")]
[DisplayName("Service Start End")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ServiceStartEnd2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Location of service (for example, Paris CDG, Paris Gare du Nord, etc.). 
    /// </summary>
    [IsoId("_QStHwcW1EeuhguwJmlgagQ")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Location { get; init; } 
    #else
    public System.String? Location { get; set; } 
    #endif
    
    /// <summary>
    /// Location code assigned to an airport or to a service location (for example, CDG, YUL, etc.).
    /// </summary>
    [IsoId("_QStHw8W1EeuhguwJmlgagQ")]
    [DisplayName("Location Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCd")]
    #endif
    [IsoXmlTag("LctnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LocationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocationCode { get; init; } 
    #else
    public System.String? LocationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Address of service.
    /// </summary>
    [IsoId("_QStHxcW1EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact details at location.
    /// </summary>
    [IsoId("_QStHx8W1EeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact2? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact2? Contact { get; init; } 
    #else
    public Contact2? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of service.
    /// </summary>
    [IsoId("_QStHycW1EeuhguwJmlgagQ")]
    [DisplayName("Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTm")]
    #endif
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DateAndTime { get; init; } 
    #else
    public System.DateTime? DateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Period of day pertaining to the service location.
    /// </summary>
    [IsoId("_QStHy8W1EeuhguwJmlgagQ")]
    [DisplayName("Time Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmSgmt")]
    #endif
    [IsoXmlTag("TmSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeSegment1Code? TimeSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeSegment1Code? TimeSegment { get; init; } 
    #else
    public TimeSegment1Code? TimeSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Journey information related to the vehicle rental.
    /// </summary>
    [IsoId("_QStHzcW1EeuhguwJmlgagQ")]
    [DisplayName("Journey Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JrnyInf")]
    #endif
    [IsoXmlTag("JrnyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public JourneyInformation1? JourneyInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public JourneyInformation1? JourneyInformation { get; init; } 
    #else
    public JourneyInformation1? JourneyInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
