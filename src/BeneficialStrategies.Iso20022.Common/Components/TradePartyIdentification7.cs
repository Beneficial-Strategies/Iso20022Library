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
/// Entity involved in an activity.
/// </summary>
[IsoId("_D2EMMAfeEeSLV4FSBR_q6A")]
[DisplayName("Trade Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyIdentification7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyIdentification7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyIdentification7( OptionParty1Code reqBuyerOrSellerIndicator,OptionParty3Code reqInitiatorIndicator,PartyIdentification78 reqTradePartyIdentification,PartyIdentificationAndAccount119 reqSubmittingParty )
    {
        BuyerOrSellerIndicator = reqBuyerOrSellerIndicator;
        InitiatorIndicator = reqInitiatorIndicator;
        TradePartyIdentification = reqTradePartyIdentification;
        SubmittingParty = reqSubmittingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the fund which is one of the parties in a treasury trade.
    /// </summary>
    [IsoId("_3YpMwAfeEeSLV4FSBR_q6A")]
    [DisplayName("Fund Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndInf")]
    #endif
    [IsoXmlTag("FndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundIdentification3? FundInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundIdentification3? FundInformation { get; init; } 
    #else
    public FundIdentification3? FundInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which is the buyer or the seller.
    /// </summary>
    [IsoId("_DbIuQAffEeSLV4FSBR_q6A")]
    [DisplayName("Buyer Or Seller Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrOrSellrInd")]
    #endif
    [IsoXmlTag("BuyrOrSellrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionParty1Code BuyerOrSellerIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionParty1Code BuyerOrSellerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty1Code BuyerOrSellerIndicator { get; init; } 
    #else
    public OptionParty1Code BuyerOrSellerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a trade party is a taker or a maker.
    /// </summary>
    [IsoId("_EFezsEVUEeSGWeX3z5zSZQ")]
    [DisplayName("Initiator Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitrInd")]
    #endif
    [IsoXmlTag("InitrInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionParty3Code InitiatorIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionParty3Code InitiatorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionParty3Code InitiatorIndicator { get; init; } 
    #else
    public OptionParty3Code InitiatorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_PLv5kIHFEeSY3ulMDfpmvA")]
    [DisplayName("Trade Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPtyId")]
    #endif
    [IsoXmlTag("TradPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification78 TradePartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification78 TradePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification78 TradePartyIdentification { get; init; } 
    #else
    public PartyIdentification78 TradePartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which submits a treasury trade to a matching system or to a settlement system or to a counterparty.
    /// </summary>
    [IsoId("_LaETsAffEeSLV4FSBR_q6A")]
    [DisplayName("Submitting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgPty")]
    #endif
    [IsoXmlTag("SubmitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentificationAndAccount119 SubmittingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentificationAndAccount119 SubmittingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount119 SubmittingParty { get; init; } 
    #else
    public PartyIdentificationAndAccount119 SubmittingParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
