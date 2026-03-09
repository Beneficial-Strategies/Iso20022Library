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
[IsoId("_JfYFQR5dEeWE3PufGMdJ3w")]
[DisplayName("Other Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherParties26
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
    [IsoId("_J-xWZR5dEeWE3PufGMdJ3w")]
    [DisplayName("Investor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invstr")]
    #endif
    [IsoXmlTag("Invstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification99? Investor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification99? Investor { get; init; } 
    #else
    public PartyIdentification99? Investor { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    [IsoId("_J-xWbR5dEeWE3PufGMdJ3w")]
    [DisplayName("Stock Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockXchg")]
    #endif
    [IsoXmlTag("StockXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? StockExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? StockExchange { get; init; } 
    #else
    public PartyIdentification100? StockExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    [IsoId("_J-xWdR5dEeWE3PufGMdJ3w")]
    [DisplayName("Trade Regulator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRgltr")]
    #endif
    [IsoXmlTag("TradRgltr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification100? TradeRegulator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification100? TradeRegulator { get; init; } 
    #else
    public PartyIdentification100? TradeRegulator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
