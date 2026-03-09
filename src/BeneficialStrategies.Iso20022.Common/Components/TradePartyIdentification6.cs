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
[IsoId("_rbRD8SjaEeK1Sbo8NpBROA")]
[DisplayName("Trade Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePartyIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePartyIdentification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePartyIdentification6( PartyIdentification73Choice_ reqSubmittingParty )
    {
        SubmittingParty = reqSubmittingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that submits the foreign exchange trade to the matching system or to the settlement system or to the counterparty.
    /// </summary>
    [IsoId("_rou4OSjaEeK1Sbo8NpBROA")]
    [DisplayName("Submitting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgPty")]
    #endif
    [IsoXmlTag("SubmitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification73Choice_ SubmittingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification73Choice_ SubmittingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_ SubmittingParty { get; init; } 
    #else
    public PartyIdentification73Choice_ SubmittingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the foreign exchange trade. This party may be the same as the submitting party.
    /// </summary>
    [IsoId("_rou4PSjaEeK1Sbo8NpBROA")]
    [DisplayName("Trade Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPty")]
    #endif
    [IsoXmlTag("TradPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? TradeParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? TradeParty { get; init; } 
    #else
    public PartyIdentification73Choice_? TradeParty { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the fund that is one of the parties in the foreign exchange trade.
    /// </summary>
    [IsoId("_rou4QSjaEeK1Sbo8NpBROA")]
    [DisplayName("Fund Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndId")]
    #endif
    [IsoXmlTag("FndId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundIdentification4? FundIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundIdentification4? FundIdentification { get; init; } 
    #else
    public FundIdentification4? FundIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
