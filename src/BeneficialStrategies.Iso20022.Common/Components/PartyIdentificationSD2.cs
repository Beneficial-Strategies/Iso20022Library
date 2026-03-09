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
[IsoId("_1SUrNTL3EeKU9IrkkToqcw_-650886899")]
[DisplayName("Party Identification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationSD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationSD2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationSD2( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1SUrNjL3EeKU9IrkkToqcw_-499458347")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_1SUrNzL3EeKU9IrkkToqcw_166499706")]
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
    [IsoId("_1SecMDL3EeKU9IrkkToqcw_1493400736")]
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
    [IsoId("_1SecMTL3EeKU9IrkkToqcw_2014524246")]
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
    [IsoId("_1SecMjL3EeKU9IrkkToqcw_1284201148")]
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
    [IsoId("_1SecMzL3EeKU9IrkkToqcw_-600131637")]
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
