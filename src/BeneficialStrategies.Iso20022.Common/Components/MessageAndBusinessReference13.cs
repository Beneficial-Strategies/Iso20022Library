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
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("_STWoEdvdEeqxGfKJubfhIw")]
[DisplayName("Message And Business Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageAndBusinessReference13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageAndBusinessReference13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageAndBusinessReference13( System.String reqTransferReference )
    {
        TransferReference = reqTransferReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the message or communication that was previously sent.
    /// </summary>
    [IsoId("_Spi6gdvdEeqxGfKJubfhIw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References68Choice_? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References68Choice_? Reference { get; init; } 
    #else
    public References68Choice_? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Type of request required.
    /// </summary>
    [IsoId("_thRx8NvdEeqxGfKJubfhIw")]
    [DisplayName("Type Of Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfReq")]
    #endif
    [IsoXmlTag("TpOfReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfRequest1Choice_? TypeOfRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfRequest1Choice_? TypeOfRequest { get; init; } 
    #else
    public TypeOfRequest1Choice_? TypeOfRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Spi6g9vdEeqxGfKJubfhIw")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Spi6hdvdEeqxGfKJubfhIw")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Spi6h9vdEeqxGfKJubfhIw")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference10? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference10? ClientReference { get; init; } 
    #else
    public AdditionalReference10? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Spi6idvdEeqxGfKJubfhIw")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("_BoGWAdx9EeqKxsvOxFQHKA")]
    [DisplayName("Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instrm")]
    #endif
    [IsoXmlTag("Instrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument63Choice_? Instrument { get; init; } 
    #else
    public FinancialInstrument63Choice_? Instrument { get; set; } 
    #endif
    
    /// <summary>
    /// Investment account information of the transfer for which the status or information is requested.
    /// </summary>
    [IsoId("_Spi6i9vdEeqxGfKJubfhIw")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account33? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account33? InvestmentAccountDetails { get; init; } 
    #else
    public Account33? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("_Zy7pAXdiEeuvip1zrZRWzw")]
    [DisplayName("Intermediary Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyInf")]
    #endif
    [IsoXmlTag("IntrmyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary48? IntermediaryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary48? IntermediaryInformation { get; init; } 
    #else
    public Intermediary48? IntermediaryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the query.
    /// </summary>
    [IsoId("_MGY6EdveEeqxGfKJubfhIw")]
    [DisplayName("Query Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryInf")]
    #endif
    [IsoXmlTag("QryInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation25? QueryInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation25? QueryInformation { get; init; } 
    #else
    public AdditionalInformation25? QueryInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the request message.
    /// </summary>
    [IsoId("_J_KUondqEeuvip1zrZRWzw")]
    [DisplayName("Request Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqIssr")]
    #endif
    [IsoXmlTag("ReqIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? RequestIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? RequestIssuer { get; init; } 
    #else
    public PartyIdentification139? RequestIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the request message.
    /// </summary>
    [IsoId("_J_K7sHdqEeuvip1zrZRWzw")]
    [DisplayName("Request Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRcpt")]
    #endif
    [IsoXmlTag("ReqRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification139? RequestRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification139? RequestRecipient { get; init; } 
    #else
    public PartyIdentification139? RequestRecipient { get; set; } 
    #endif
    
    
    #nullable disable
    
}
