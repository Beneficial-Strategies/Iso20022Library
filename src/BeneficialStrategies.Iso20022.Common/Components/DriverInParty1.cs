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
/// Driver in a car rental party
/// </summary>
[IsoId("_dUOokFyvEeeve7Je9cXtkQ")]
[DisplayName("Driver In Party")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DriverInParty1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of vehicle rental driver.
    /// </summary>
    [IsoId("_njIFgFyvEeeve7Je9cXtkQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Address of driver in party.
    /// </summary>
    [IsoId("_oB86EFywEeeve7Je9cXtkQ")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? Address { get; init; } 
    #else
    public Address1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact details of driver in party.
    /// </summary>
    [IsoId("_shr0wFywEeeve7Je9cXtkQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact6? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact6? Contact { get; init; } 
    #else
    public Contact6? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of vehicle rental driver.
    /// </summary>
    [IsoId("_fjFQUFywEeeve7Je9cXtkQ")]
    [DisplayName("Date Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfBirth")]
    #endif
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfBirth { get; init; } 
    #else
    public System.DateOnly? DateOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Age of driver.
    /// </summary>
    [IsoId("_xM6LwFzGEeeDqe2giKl0eQ")]
    [DisplayName("Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Age")]
    #endif
    [IsoXmlTag("Age")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? Age { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Age { get; init; } 
    #else
    public System.String? Age { get; set; } 
    #endif
    
    /// <summary>
    /// Credential used by the driver for identification.
    /// </summary>
    [IsoId("_K7dFAFywEeeve7Je9cXtkQ")]
    [DisplayName("Driver Credential")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrCrdntl")]
    #endif
    [IsoXmlTag("DrvrCrdntl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TravelDocument1? DriverCredential { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TravelDocument1? DriverCredential { get; init; } 
    #else
    public TravelDocument1? DriverCredential { get; set; } 
    #endif
    
    /// <summary>
    /// Driving license details.
    /// </summary>
    [IsoId("_S-g8gFywEeeve7Je9cXtkQ")]
    [DisplayName("Driving License")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvgLic")]
    #endif
    [IsoXmlTag("DrvgLic")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrivingLicense1? DrivingLicense { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrivingLicense1? DrivingLicense { get; init; } 
    #else
    public DrivingLicense1? DrivingLicense { get; set; } 
    #endif
    
    
    #nullable disable
    
}
