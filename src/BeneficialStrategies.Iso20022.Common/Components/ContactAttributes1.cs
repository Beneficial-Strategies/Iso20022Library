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
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_QJt6wNp-Ed-ak6NoX_4Aeg_1489374809")]
[DisplayName("Contact Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContactAttributes1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContactAttributes1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContactAttributes1( System.String reqName,PostalAddress1 reqPostalAddress,System.String reqPhoneNumber )
    {
        Name = reqName;
        PostalAddress = reqPostalAddress;
        PhoneNumber = reqPhoneNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QJt6wdp-Ed-ak6NoX_4Aeg_1489374811")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QJt6wtp-Ed-ak6NoX_4Aeg_1490295913")]
    [DisplayName("Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlAdr")]
    #endif
    [IsoXmlTag("PstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress1 PostalAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PostalAddress1 PostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1 PostalAddress { get; init; } 
    #else
    public PostalAddress1 PostalAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJt6w9p-Ed-ak6NoX_4Aeg_1490294902")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhoneNumber { get; init; } 
    #else
    public System.String PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QJ3rsNp-Ed-ak6NoX_4Aeg_1490294964")]
    [DisplayName("Fax Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaxNb")]
    #endif
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? FaxNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FaxNumber { get; init; } 
    #else
    public System.String? FaxNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QJ3rsdp-Ed-ak6NoX_4Aeg_1490294872")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QJ3rstp-Ed-ak6NoX_4Aeg_-1675029450")]
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
    
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under a globally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_QJ3rs9p-Ed-ak6NoX_4Aeg_1489374870")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICIdentifier? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
