// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PrK9iNp-Ed-ak6NoX_4Aeg_-727218247")]
[DisplayName("Group Header")]
public partial record GroupHeader31
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the instructed party, to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PrUugNp-Ed-ak6NoX_4Aeg_-726298236")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_PrUugdp-Ed-ak6NoX_4Aeg_-726298215")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// User identification or any user key to be used to check the authority of the initiating party.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_PrUugtp-Ed-ak6NoX_4Aeg_263177191")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = new ValueList<Authorisation1Choice_>(){};
    
    /// <summary>
    /// Party that initiates the mandate message.
    /// </summary>
    [IsoId("_PrUug9p-Ed-ak6NoX_4Aeg_-726298169")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification32? InitiatingParty { get; init; } 
    
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructing agent is the party sending the amendment and cancellation request message and not the party that sent the original mandate initiation request message.|In case of acceptance report message, the instructing agent is the party sending the acceptance report message and not the party that sent the original mandate request message.
    /// </summary>
    [IsoId("_PrUuhNp-Ed-ak6NoX_4Aeg_-726298030")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; } 
    
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out an instruction.||Usage Rule: |In case of amendment and cancellation request messages, the instructed agent is the party receiving the amendment and cancellation request message and not the party that received the original mandate initiation request message.|In case of acceptance report message, the instructed agent is the party receiving the acceptance report message and not the party that received the original mandate request message.
    /// </summary>
    [IsoId("_PrUuhdp-Ed-ak6NoX_4Aeg_-726298061")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; } 
    
    
    #nullable disable
    
}
