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
[IsoId("_PdKWsdp-Ed-ak6NoX_4Aeg_-1580495666")]
[DisplayName("Trade Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyIdentification3( PartyIdentification8Choice_ reqSubmittingParty,PartyIdentification8Choice_ reqTradeParty )
    {
        SubmittingParty = reqSubmittingParty;
        TradeParty = reqTradeParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the fund which is one of the parties in a treasury trade.
    /// </summary>
    [IsoId("_PdKWstp-Ed-ak6NoX_4Aeg_2125581687")]
    [DisplayName("Fund Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndInf")]
    #endif
    [IsoXmlTag("FndInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundIdentification2? FundInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundIdentification2? FundInformation { get; init; } 
    #else
    public FundIdentification2? FundInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which submits a treasury trade to a matching system or to a settlement system or to a counterparty.
    /// </summary>
    [IsoId("_PdKWs9p-Ed-ak6NoX_4Aeg_-1580495262")]
    [DisplayName("Submitting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgPty")]
    #endif
    [IsoXmlTag("SubmitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ SubmittingParty { get; init; } 
    #else
    public PartyIdentification8Choice_ SubmittingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the party which originated a treasury trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_PdKWtNp-Ed-ak6NoX_4Aeg_-1580495304")]
    [DisplayName("Trade Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPty")]
    #endif
    [IsoXmlTag("TradPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8Choice_ TradeParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8Choice_ TradeParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_ TradeParty { get; init; } 
    #else
    public PartyIdentification8Choice_ TradeParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
