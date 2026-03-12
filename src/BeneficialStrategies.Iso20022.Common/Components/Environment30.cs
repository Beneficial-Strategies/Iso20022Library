// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
[IsoId("_ELI3AY2kEeuUX8RS9eNYdA")]
[DisplayName("Environment")]
public partial record Environment30
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_ERNCwY2kEeuUX8RS9eNYdA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; } 
    
    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_QMhlQY2kEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; } 
    
    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_ERNCw42kEeuUX8RS9eNYdA")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; } 
    
    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    [IsoId("_ERNCxY2kEeuUX8RS9eNYdA")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; } 
    
    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_fxWUQTvbEeyuG4d2lhAp-w")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification255? Acceptor { get; init; } 
    
    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_RmkhYY2kEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; } 
    
    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_awiDUUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; } 
    
    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_ERNCyY2kEeuUX8RS9eNYdA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData2? Card { get; init; } 
    
    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_ERNCy42kEeuUX8RS9eNYdA")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; } 
    
    
    #nullable disable
    
}
