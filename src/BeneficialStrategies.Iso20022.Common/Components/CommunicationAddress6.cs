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
[IsoId("_IHGxISCBEeWhHbfCMWc1cw")]
[DisplayName("Communication Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommunicationAddress6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of communication address.
    /// </summary>
    [IsoId("_Uk0qgSCLEeWJd9HF2tO7BA")]
    [DisplayName("Address Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrTp")]
    #endif
    [IsoXmlTag("AdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressType1Choice_? AddressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressType1Choice_? AddressType { get; init; } 
    #else
    public AddressType1Choice_? AddressType { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_Iid3cSCBEeWhHbfCMWc1cw")]
    [DisplayName("Email")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Email")]
    #endif
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Email { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Email { get; init; } 
    #else
    public System.String? Email { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3cyCBEeWhHbfCMWc1cw")]
    [DisplayName("Phone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Phne")]
    #endif
    [IsoXmlTag("Phne")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? Phone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Phone { get; init; } 
    #else
    public System.String? Phone { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3dSCBEeWhHbfCMWc1cw")]
    [DisplayName("Mobile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mob")]
    #endif
    [IsoXmlTag("Mob")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? Mobile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Mobile { get; init; } 
    #else
    public System.String? Mobile { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3dyCBEeWhHbfCMWc1cw")]
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
    /// Address for a telex machine.
    /// </summary>
    [IsoId("_Iid3eSCBEeWhHbfCMWc1cw")]
    [DisplayName("Telex Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TlxAdr")]
    #endif
    [IsoXmlTag("TlxAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TelexAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TelexAddress { get; init; } 
    #else
    public System.String? TelexAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_Iid3eyCBEeWhHbfCMWc1cw")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
