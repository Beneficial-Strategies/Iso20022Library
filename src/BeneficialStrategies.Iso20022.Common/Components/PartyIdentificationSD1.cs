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
[IsoId("_1URL8DL3EeKU9IrkkToqcw_45902877")]
[DisplayName("Party Identification SD")]
public partial record PartyIdentificationSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1URL8TL3EeKU9IrkkToqcw_1123856043")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Function the agent is performing.
    /// </summary>
    [IsoId("_1URL8jL3EeKU9IrkkToqcw_-2093090915")]
    [DisplayName("Agent Type")]
    [IsoXmlTag("AgtTp")]
    public required AgentType1Code AgentType { get; init; } 
    
    /// <summary>
    /// DTC agent identification number.
    /// </summary>
    [IsoId("_1URL8zL3EeKU9IrkkToqcw_1090964962")]
    [DisplayName("Agent Identification")]
    [IsoXmlTag("AgtId")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? AgentIdentification { get; init; } 
    
    /// <summary>
    /// Name and address of the agent.
    /// </summary>
    [IsoId("_1URL9DL3EeKU9IrkkToqcw_815297485")]
    [DisplayName("Agent Name And Address")]
    [IsoXmlTag("AgtNmAndAdr")]
    public required NameAndAddress5 AgentNameAndAddress { get; init; } 
    
    /// <summary>
    /// Telephone number of the agent.
    /// </summary>
    [IsoId("_1URL9TL3EeKU9IrkkToqcw_-262167746")]
    [DisplayName("Agent Telephone Number")]
    [IsoXmlTag("AgtTelNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? AgentTelephoneNumber { get; init; } 
    
    /// <summary>
    /// Email address of the event agent.
    /// </summary>
    [IsoId("_1URL9jL3EeKU9IrkkToqcw_1124868377")]
    [DisplayName("Agent Email Address")]
    [IsoXmlTag("AgtEmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? AgentEmailAddress { get; init; } 
    
    /// <summary>
    /// Agent designated contact Information details.
    /// </summary>
    [IsoId("_1UaV4DL3EeKU9IrkkToqcw_381369949")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public PartyIdentificationSD4? ContactInformation { get; init; } 
    
    
    #nullable disable
    
}
