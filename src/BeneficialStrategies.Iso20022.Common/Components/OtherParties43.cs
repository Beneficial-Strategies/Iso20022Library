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
/// Other parties&apos; information.
/// </summary>
[IsoId("_hMBrsSqGEeyR9JrVGfaMKw")]
[DisplayName("Other Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherParties43
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_hk6FxyqGEeyR9JrVGfaMKw")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount197? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount197? Investor { get; init; } 
    #else
    public PartyIdentificationAndAccount197? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign financial institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_hk6FzyqGEeyR9JrVGfaMKw")]
    [DisplayName("Qualified Foreign Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfdFrgnIntrmy")]
    #endif
    [IsoXmlTag("QlfdFrgnIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount198? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount198? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentificationAndAccount198? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_hk6F1yqGEeyR9JrVGfaMKw")]
    [DisplayName("Stock Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchg")]
    #endif
    [IsoXmlTag("StockXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount165? StockExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount165? StockExchange { get; init; } 
    #else
    public PartyIdentificationAndAccount165? StockExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_hk6F3yqGEeyR9JrVGfaMKw")]
    [DisplayName("Trade Regulator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRgltr")]
    #endif
    [IsoXmlTag("TradRgltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount165? TradeRegulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount165? TradeRegulator { get; init; } 
    #else
    public PartyIdentificationAndAccount165? TradeRegulator { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_hk6F5yqGEeyR9JrVGfaMKw")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount198? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount198? TripartyAgent { get; init; } 
    #else
    public PartyIdentificationAndAccount198? TripartyAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    [IsoId("_hk6F7yqGEeyR9JrVGfaMKw")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount198? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount198? Broker { get; init; } 
    #else
    public PartyIdentificationAndAccount198? Broker { get; set; } 
    #endif
    
    
    #nullable disable
    
}
