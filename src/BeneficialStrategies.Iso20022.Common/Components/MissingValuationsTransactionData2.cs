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
/// Detailed information about the outstanding derivatives for which no valuation or outdated valuation has been reported.
/// </summary>
[IsoId("_x29aEVyGEe24CqbZJK5XxA")]
[DisplayName("Missing Valuations Transaction Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingValuationsTransactionData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingValuationsTransactionData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingValuationsTransactionData2( TradeTransactionIdentification24 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_x3tA8VyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    #else
    public TradeTransactionIdentification24 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Mark-to-market valuation of the contract, or mark-to-model valuation
    /// </summary>
    [IsoId("_x3tA81yGEe24CqbZJK5XxA")]
    [DisplayName("Valuation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmt")]
    #endif
    [IsoXmlTag("ValtnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection106? ValuationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106? ValuationAmount { get; init; } 
    #else
    public AmountAndDirection106? ValuationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    [IsoId("_x3tA9VyGEe24CqbZJK5XxA")]
    [DisplayName("Valuation Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnTmStmp")]
    #endif
    [IsoXmlTag("ValtnTmStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValuationTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValuationTimeStamp { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValuationTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
