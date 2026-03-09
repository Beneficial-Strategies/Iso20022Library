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
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QDA1y9p-Ed-ak6NoX_4Aeg_-1355433292")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualPerson13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualPerson13( System.String reqBirthName,AttendanceCard1 reqAttendanceCardDetails )
    {
        BirthName = reqBirthName;
        AttendanceCardDetails = reqAttendanceCardDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name received at birth, eg, maiden name.
    /// </summary>
    [IsoId("_QDKmwNp-Ed-ak6NoX_4Aeg_-1355433290")]
    [DisplayName("Birth Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthNm")]
    #endif
    [IsoXmlTag("BirthNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BirthName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BirthName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BirthName { get; init; } 
    #else
    public System.String BirthName { get; set; } 
    #endif
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QDKmwdp-Ed-ak6NoX_4Aeg_-1355433275")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GivenName { get; init; } 
    #else
    public System.String? GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a person, eg passport.
    /// </summary>
    [IsoId("_QDKmwtp-Ed-ak6NoX_4Aeg_-1355433179")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification2? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification2? Identification { get; init; } 
    #else
    public PersonIdentification2? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QDKmw9p-Ed-ak6NoX_4Aeg_-1355433136")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LongPostalAddress2Choice_? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LongPostalAddress2Choice_? Address { get; init; } 
    #else
    public LongPostalAddress2Choice_? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Organisation represented by a person, or for which a person works.
    /// </summary>
    [IsoId("_QDKmxNp-Ed-ak6NoX_4Aeg_2100880565")]
    [DisplayName("Employing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmplngPty")]
    #endif
    [IsoXmlTag("EmplngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification9Choice_? EmployingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_? EmployingParty { get; init; } 
    #else
    public PartyIdentification9Choice_? EmployingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies details related to the attendance card.
    /// </summary>
    [IsoId("_QDKmxdp-Ed-ak6NoX_4Aeg_-1159001390")]
    [DisplayName("Attendance Card Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncCardDtls")]
    #endif
    [IsoXmlTag("AttndncCardDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AttendanceCard1 AttendanceCardDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AttendanceCard1 AttendanceCardDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttendanceCard1 AttendanceCardDetails { get; init; } 
    #else
    public AttendanceCard1 AttendanceCardDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
