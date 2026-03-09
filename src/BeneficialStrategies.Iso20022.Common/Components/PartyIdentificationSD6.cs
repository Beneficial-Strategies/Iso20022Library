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
/// Provides additional information regarding the existing agent component.
/// </summary>
[IsoId("_bTHFYb5XEeexmbB7KsjCwA")]
[DisplayName("Party Identification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_bjVSs75XEeexmbB7KsjCwA")]
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
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_bjVStb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtId")]
    #endif
    [IsoXmlTag("AgtId")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8Text? AgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentIdentification { get; init; } 
    #else
    public System.String? AgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Telephone number of the agent.
    /// </summary>
    [IsoId("_bjVSvb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Telephone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtTelNb")]
    #endif
    [IsoXmlTag("AgtTelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? AgentTelephoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentTelephoneNumber { get; init; } 
    #else
    public System.String? AgentTelephoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Agent designated contact information details.
    /// </summary>
    [IsoId("_bjVSxb5XEeexmbB7KsjCwA")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationSD4? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationSD4? ContactInformation { get; init; } 
    #else
    public PartyIdentificationSD4? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Email address of the event agent.
    /// </summary>
    [IsoId("_bjVSzb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtEmailAdr")]
    #endif
    [IsoXmlTag("AgtEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AgentEmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentEmailAddress { get; init; } 
    #else
    public System.String? AgentEmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Event agent address.
    /// </summary>
    [IsoId("_bjVS1b5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtAdr")]
    #endif
    [IsoXmlTag("AgtAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? AgentAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? AgentAddress { get; init; } 
    #else
    public PostalAddress1? AgentAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
