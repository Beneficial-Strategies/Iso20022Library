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
/// Provides details about business parties involved in the transaction.
/// </summary>
[IsoId("_AOPFx9okEeC60axPepSq7g_1209561399")]
[DisplayName("Other Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherParties18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_AOYPsNokEeC60axPepSq7g_1095722333")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount79? Investor { get; init; } 
    #else
    public PartyIdentificationAndAccount79? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    [IsoId("_AOYPsdokEeC60axPepSq7g_98649980")]
    [DisplayName("Stock Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchg")]
    #endif
    [IsoXmlTag("StockXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount87? StockExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount87? StockExchange { get; init; } 
    #else
    public PartyIdentificationAndAccount87? StockExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    [IsoId("_AOYPstokEeC60axPepSq7g_-898422373")]
    [DisplayName("Trade Regulator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRgltr")]
    #endif
    [IsoXmlTag("TradRgltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount87? TradeRegulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount87? TradeRegulator { get; init; } 
    #else
    public PartyIdentificationAndAccount87? TradeRegulator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_AOYPs9okEeC60axPepSq7g_-1895494726")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount83? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount83? TripartyAgent { get; init; } 
    #else
    public PartyIdentificationAndAccount83? TripartyAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_AOYPtNokEeC60axPepSq7g_907764690")]
    [DisplayName("Qualified Foreign Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfdFrgnIntrmy")]
    #endif
    [IsoXmlTag("QlfdFrgnIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount77? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount77? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentificationAndAccount77? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
