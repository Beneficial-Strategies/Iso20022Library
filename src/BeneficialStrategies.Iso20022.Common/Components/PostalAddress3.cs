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
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_QHMLJdp-Ed-ak6NoX_4Aeg_1886908463")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PostalAddress3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PostalAddress3( AddressType1Code reqAddressType,System.String reqMailingIndicator,System.String reqRegistrationAddressIndicator,NameAndAddress4 reqNameAndAddress )
    {
        AddressType = reqAddressType;
        MailingIndicator = reqMailingIndicator;
        RegistrationAddressIndicator = reqRegistrationAddressIndicator;
        NameAndAddress = reqNameAndAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    [IsoId("_QHMLJtp-Ed-ak6NoX_4Aeg_1886909524")]
    [DisplayName("Address Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrTp")]
    #endif
    [IsoXmlTag("AdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AddressType1Code AddressType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AddressType1Code AddressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressType1Code AddressType { get; init; } 
    #else
    public AddressType1Code AddressType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether mail should be sent to an address.
    /// </summary>
    [IsoId("_QHMLJ9p-Ed-ak6NoX_4Aeg_1886909609")]
    [DisplayName("Mailing Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngInd")]
    #endif
    [IsoXmlTag("MlngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MailingIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MailingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MailingIndicator { get; init; } 
    #else
    public System.String MailingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    [IsoId("_QHMLKNp-Ed-ak6NoX_4Aeg_1886909661")]
    [DisplayName("Registration Address Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAdrInd")]
    #endif
    [IsoXmlTag("RegnAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator RegistrationAddressIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RegistrationAddressIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RegistrationAddressIndicator { get; init; } 
    #else
    public System.String RegistrationAddressIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QHVVENp-Ed-ak6NoX_4Aeg_1886909998")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NameAndAddress4 NameAndAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NameAndAddress4 NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress4 NameAndAddress { get; init; } 
    #else
    public NameAndAddress4 NameAndAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
