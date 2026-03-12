// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the new agent component.
/// </summary>
[IsoId("_XrLVYb5XEeexmbB7KsjCwA")]
[DisplayName("Party Identification SD")]
public partial record PartyIdentificationSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_X7_Yk75XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Function the agent is performing.
    /// </summary>
    [IsoId("_X7_Ylb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Type")]
    [IsoXmlTag("AgtTp")]
    public required AgentType1Code AgentType { get; init; } 
    
    /// <summary>
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_X7_Ynb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? AgentIdentification { get; init; } 
    
    /// <summary>
    /// Name and address of the agent.
    /// </summary>
    [IsoId("_X7_Ypb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Name And Address")]
    [IsoXmlTag("AgtNmAndAdr")]
    public required NameAndAddress5 AgentNameAndAddress { get; init; } 
    
    /// <summary>
    /// Telephone number of the agent.
    /// </summary>
    [IsoId("_X7_Yrb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Telephone Number")]
    [IsoXmlTag("AgtTelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? AgentTelephoneNumber { get; init; } 
    
    /// <summary>
    /// Email address of the event agent.
    /// </summary>
    [IsoId("_X7_Ytb5XEeexmbB7KsjCwA")]
    [DisplayName("Agent Email Address")]
    [IsoXmlTag("AgtEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AgentEmailAddress { get; init; } 
    
    /// <summary>
    /// Agent designated contact Information details.
    /// </summary>
    [IsoId("_X7_Yvb5XEeexmbB7KsjCwA")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public PartyIdentificationSD4? ContactInformation { get; init; } 
    
    
    #nullable disable
    
}
