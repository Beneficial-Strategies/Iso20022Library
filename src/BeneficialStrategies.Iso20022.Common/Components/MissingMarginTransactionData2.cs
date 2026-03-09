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
/// Detailed information about the outstanding derivatives for which no margin or outdated margin information has been reported.
/// </summary>
[IsoId("_rud9m1owEe23K4GXSpBSeg")]
[DisplayName("Missing Margin Transaction Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingMarginTransactionData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingMarginTransactionData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingMarginTransactionData2( TradeTransactionIdentification24 reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_rvjisVowEe23K4GXSpBSeg")]
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
    /// Indicates the date and time of the last collateral amount determination or calculation.
    /// </summary>
    [IsoId("_rvjis1owEe23K4GXSpBSeg")]
    [DisplayName("Collateral Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTmStmp")]
    #endif
    [IsoXmlTag("CollTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CollateralTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CollateralTimeStamp { get; init; } 
    #else
    public System.DateTime? CollateralTimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
