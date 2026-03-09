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
/// Details of the issuer, as required by ASX.
/// </summary>
[IsoId("_uvhcJ299EeKuY41pq1-dog")]
[DisplayName("Issuer Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IssuerAttributesSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IssuerAttributesSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IssuerAttributesSD1( System.String reqName,System.String reqRegistrationNumber,System.String reqIssuerIdentification )
    {
        Name = reqName;
        RegistrationNumber = reqRegistrationNumber;
        IssuerIdentification = reqIssuerIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. ||In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_uvhcL299EeKuY41pq1-dog")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_uvhcRW99EeKuY41pq1-dog")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINXMax140Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Registered number type of the entity.
    /// </summary>
    [IsoId("_uvhcKm99EeKuY41pq1-dog")]
    [DisplayName("Registered Number Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdNbTp")]
    #endif
    [IsoXmlTag("RegdNbTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegisteredNumberType1Code? RegisteredNumberType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegisteredNumberType1Code? RegisteredNumberType { get; init; } 
    #else
    public RegisteredNumberType1Code? RegisteredNumberType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of Registered Number.
    /// </summary>
    [IsoId("_uvhcPm99EeKuY41pq1-dog")]
    [DisplayName("Other Registered Number Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRegdNbTp")]
    #endif
    [IsoXmlTag("OthrRegdNbTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherRegisteredNumberType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherRegisteredNumberType { get; init; } 
    #else
    public System.String? OtherRegisteredNumberType { get; set; } 
    #endif
    
    /// <summary>
    /// Equivalent, unique number of the entity for the Registered Number Type.
    /// </summary>
    [IsoId("_uvhcOW99EeKuY41pq1-dog")]
    [DisplayName("Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnNb")]
    #endif
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text RegistrationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegistrationNumber { get; init; } 
    #else
    public System.String RegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// ASX Issuer Code.
    /// </summary>
    [IsoId("_uvhcNG99EeKuY41pq1-dog")]
    [DisplayName("Issuer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrId")]
    #endif
    [IsoXmlTag("IssrId")]
    [IsoSimpleType(IsoSimpleType.Exact3UpperCaseAlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3UpperCaseAlphaNumericText IssuerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerIdentification { get; init; } 
    #else
    public System.String IssuerIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
