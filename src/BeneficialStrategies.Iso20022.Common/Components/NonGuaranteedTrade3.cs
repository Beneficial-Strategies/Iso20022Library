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
/// Provides the non guaranteed trade details.
/// </summary>
[IsoId("_C9INcWpUEeSgo9vJrfSF_Q")]
[DisplayName("Non Guaranteed Trade")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonGuaranteedTrade3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonGuaranteedTrade3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonGuaranteedTrade3( PartyIdentification35Choice_ reqTradeCounterpartyMemberIdentification,PartyIdentification35Choice_ reqTradeCounterpartyClearingMemberIdentification )
    {
        TradeCounterpartyMemberIdentification = reqTradeCounterpartyMemberIdentification;
        TradeCounterpartyClearingMemberIdentification = reqTradeCounterpartyClearingMemberIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// External identification of the member who is the market counterpart member of the current trade leg (in case of non guarantee trades, this field allows buyer and seller to identify each other).
    /// </summary>
    [IsoId("_DallgWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Trade Counterparty Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradCtrPtyMmbId")]
    #endif
    [IsoXmlTag("TradCtrPtyMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ TradeCounterpartyMemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ TradeCounterpartyMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ TradeCounterpartyMemberIdentification { get; init; } 
    #else
    public PartyIdentification35Choice_ TradeCounterpartyMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// External identification of the clearing member of the market couterpart member (in case of non guarantee trades, this field allows buyer and seller to identify each other).
    /// </summary>
    [IsoId("_Dallg2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Trade Counterparty Clearing Member Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradCtrPtyClrMmbId")]
    #endif
    [IsoXmlTag("TradCtrPtyClrMmbId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ TradeCounterpartyClearingMemberIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ TradeCounterpartyClearingMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ TradeCounterpartyClearingMemberIdentification { get; init; } 
    #else
    public PartyIdentification35Choice_ TradeCounterpartyClearingMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the delivering parties involved in the settlement chain.
    /// </summary>
    [IsoId("_DallhWpUEeSgo9vJrfSF_Q")]
    [DisplayName("Delivering Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgPties")]
    #endif
    [IsoXmlTag("DlvrgPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveringPartiesAndAccount11? DeliveringParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveringPartiesAndAccount11? DeliveringParties { get; init; } 
    #else
    public DeliveringPartiesAndAccount11? DeliveringParties { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the receiving parties involved in the settlement chain.
    /// </summary>
    [IsoId("_Dallh2pUEeSgo9vJrfSF_Q")]
    [DisplayName("Receiving Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgPties")]
    #endif
    [IsoXmlTag("RcvgPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceivingPartiesAndAccount11? ReceivingParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivingPartiesAndAccount11? ReceivingParties { get; init; } 
    #else
    public ReceivingPartiesAndAccount11? ReceivingParties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
