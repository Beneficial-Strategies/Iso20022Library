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
/// Other parties information.
/// </summary>
[IsoId("_PYQBgtp-Ed-ak6NoX_4Aeg_-983026121")]
[DisplayName("Other Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherParties2
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
    [IsoId("_PYQBg9p-Ed-ak6NoX_4Aeg_-23320401")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount19? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount19? Investor { get; init; } 
    #else
    public PartyIdentificationAndAccount19? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    [IsoId("_PYQBhNp-Ed-ak6NoX_4Aeg_1373557313")]
    [DisplayName("Qualified Foreign Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfdFrgnIntrmy")]
    #endif
    [IsoXmlTag("QlfdFrgnIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount21? QualifiedForeignIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount21? QualifiedForeignIntermediary { get; init; } 
    #else
    public PartyIdentificationAndAccount21? QualifiedForeignIntermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_PYQBhdp-Ed-ak6NoX_4Aeg_-6696620")]
    [DisplayName("Stock Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchg")]
    #endif
    [IsoXmlTag("StockXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount21? StockExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount21? StockExchange { get; init; } 
    #else
    public PartyIdentificationAndAccount21? StockExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_PYQBhtp-Ed-ak6NoX_4Aeg_894661680")]
    [DisplayName("Trade Regulator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRgltr")]
    #endif
    [IsoXmlTag("TradRgltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount21? TradeRegulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount21? TradeRegulator { get; init; } 
    #else
    public PartyIdentificationAndAccount21? TradeRegulator { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    [IsoId("_PYQBh9p-Ed-ak6NoX_4Aeg_921443554")]
    [DisplayName("Triparty Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgt")]
    #endif
    [IsoXmlTag("TrptyAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount21? TripartyAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount21? TripartyAgent { get; init; } 
    #else
    public PartyIdentificationAndAccount21? TripartyAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
