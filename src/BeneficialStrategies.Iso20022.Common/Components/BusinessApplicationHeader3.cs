// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies specific data from the Business Application Header of the Business Message.
/// </summary>
[IsoId("_O1C_XEvwEeWw591U1lOHyQ")]
[DisplayName("Business Application Header")]
public partial record BusinessApplicationHeader3
{
    #nullable enable
    
    /// <summary>
    /// The sending MessagingEndpoint that has created this Business Message for the receiving MessagingEndpoint that will process this Business Message.
    /// Note	the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_O1C_Z0vwEeWw591U1lOHyQ")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party29Choice_ From { get; init; } 
    
    /// <summary>
    /// The MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this Business Message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_O1C_X0vwEeWw591U1lOHyQ")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party29Choice_ To { get; init; } 
    
    /// <summary>
    /// Unambiguously identifies the Business Message to the MessagingEndpoint that has created the Business Message.
    /// </summary>
    [IsoId("_O1C_YUvwEeWw591U1lOHyQ")]
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; } 
    
    /// <summary>
    /// Contains the MessageIdentifier that defines the BusinessMessage.
    /// It must contain a MessageIdentifier published on the ISO 20022 website.
    /// example	camt.001.001.03.
    /// </summary>
    [IsoId("_O1C_ZkvwEeWw591U1lOHyQ")]
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    ///  To be used when there is a choice of processing services or processing service levels.
    /// Example: E&amp;I.
    /// </summary>
    [IsoId("_O1C_ZUvwEeWw591U1lOHyQ")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; } 
    
    /// <summary>
    /// Date and time when this Business Message (header) was created.
    /// Note Times must be normalized, using the &quot;Z&quot; annotation.
    /// </summary>
    [IsoId("_O1C_ZEvwEeWw591U1lOHyQ")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    [IsoSimpleType(IsoSimpleType.ISONormalisedDateTime)]
    public required IsoISONormalisedDateTime CreationDate { get; init; } 
    
    
    #nullable disable
    
}
