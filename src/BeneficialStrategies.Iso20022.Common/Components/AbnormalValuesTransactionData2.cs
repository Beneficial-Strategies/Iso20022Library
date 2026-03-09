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
/// Detailed information about derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
/// </summary>
[IsoId("_x6yxOVyGEe24CqbZJK5XxA")]
[DisplayName("Abnormal Values Transaction Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AbnormalValuesTransactionData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AbnormalValuesTransactionData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AbnormalValuesTransactionData2( TradeTransactionIdentification24 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_x7sJEVyGEe24CqbZJK5XxA")]
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
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    [IsoId("_x7sJE1yGEe24CqbZJK5XxA")]
    [DisplayName("Notional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmt")]
    #endif
    [IsoXmlTag("NtnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalAmountLegs5? NotionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalAmountLegs5? NotionalAmount { get; init; } 
    #else
    public NotionalAmountLegs5? NotionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.
    /// </summary>
    [IsoId("_x7sJFVyGEe24CqbZJK5XxA")]
    [DisplayName("Notional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQty")]
    #endif
    [IsoXmlTag("NtnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 
    #else
    public NotionalQuantityLegs5? NotionalQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
