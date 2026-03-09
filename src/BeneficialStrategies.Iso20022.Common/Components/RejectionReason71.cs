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
/// Provides reasons of rejecting transactions.
/// </summary>
[IsoId("_yAw2W1yGEe24CqbZJK5XxA")]
[DisplayName("Rejection Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionReason71
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionReason71 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionReason71( TradeTransactionIdentification24 reqTransactionIdentification,ReportingMessageStatus2Code reqStatus )
    {
        TransactionIdentification = reqTransactionIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_yBsqcVyGEe24CqbZJK5XxA")]
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
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_yBsqc1yGEe24CqbZJK5XxA")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingMessageStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingMessageStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingMessageStatus2Code Status { get; init; } 
    #else
    public ReportingMessageStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_yBsqdVyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Validation Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldVldtnRule")]
    #endif
    [IsoXmlTag("DtldVldtnRule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    #else
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
