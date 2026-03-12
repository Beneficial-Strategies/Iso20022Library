// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_STWoEdvdEeqxGfKJubfhIw")]
[DisplayName("Message And Business Reference")]
public partial record MessageAndBusinessReference13
{
    #nullable enable
    
    /// <summary>
    /// Reference to the message or communication that was previously sent.
    /// </summary>
    [IsoId("_Spi6gdvdEeqxGfKJubfhIw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References68Choice_? Reference { get; init; } 
    
    /// <summary>
    /// Type of request required.
    /// </summary>
    [IsoId("_thRx8NvdEeqxGfKJubfhIw")]
    [DisplayName("Type Of Request")]
    [IsoXmlTag("TpOfReq")]
    public TypeOfRequest1Choice_? TypeOfRequest { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Spi6g9vdEeqxGfKJubfhIw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Spi6hdvdEeqxGfKJubfhIw")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Spi6h9vdEeqxGfKJubfhIw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Spi6idvdEeqxGfKJubfhIw")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_BoGWAdx9EeqKxsvOxFQHKA")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    
    /// <summary>
    /// Investment account information of the transfer for which the status or information is requested.
    /// </summary>
    [IsoId("_Spi6i9vdEeqxGfKJubfhIw")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public Account33? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Zy7pAXdiEeuvip1zrZRWzw")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public Intermediary48? IntermediaryInformation { get; init; } 
    
    /// <summary>
    /// Information about the query.
    /// </summary>
    [IsoId("_MGY6EdveEeqxGfKJubfhIw")]
    [DisplayName("Query Information")]
    [IsoXmlTag("QryInf")]
    public AdditionalInformation25? QueryInformation { get; init; } 
    
    /// <summary>
    /// Party that issues the request message.
    /// </summary>
    [IsoId("_J_KUondqEeuvip1zrZRWzw")]
    [DisplayName("Request Issuer")]
    [IsoXmlTag("ReqIssr")]
    public PartyIdentification139? RequestIssuer { get; init; } 
    
    /// <summary>
    /// Party that receives the request message.
    /// </summary>
    [IsoId("_J_K7sHdqEeuvip1zrZRWzw")]
    [DisplayName("Request Recipient")]
    [IsoXmlTag("ReqRcpt")]
    public PartyIdentification139? RequestRecipient { get; init; } 
    
    
    #nullable disable
    
}
