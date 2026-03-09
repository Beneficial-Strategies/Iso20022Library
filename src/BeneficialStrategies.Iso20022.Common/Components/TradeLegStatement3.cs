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
/// Provides the trade leg statement details.
/// </summary>
[IsoId("_dEWFES6XEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeLegStatement3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_dXY84S6XEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcct")]
    #endif
    [IsoXmlTag("ClrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    #else
    public SecuritiesAccount18? ClearingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_dXY84y6XEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSgmt")]
    #endif
    [IsoXmlTag("ClrSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #else
    public PartyIdentification35Choice_? ClearingSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_dXY85S6XEeSQQqw1BT_aMg")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the lists of all trades during the period in consideration for the statement.
    /// </summary>
    [IsoId("_dXY85y6XEeSQQqw1BT_aMg")]
    [DisplayName("Trade Legs Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLegsDtls")]
    #endif
    [IsoXmlTag("TradLegsDtls")]
    public ValueList<TradeLeg9> TradeLegsDetails { get; init; } = new ValueList<TradeLeg9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dXY85y6XEeSQQqw1BT_aMg
    
    
    #nullable disable
    
}
