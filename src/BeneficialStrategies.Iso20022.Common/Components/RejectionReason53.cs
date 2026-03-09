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
[IsoId("_hV-hKcK4EeuFNp8LZAnorg")]
[DisplayName("Rejection Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionReason53
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionReason53 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionReason53( TransactionIdentification3Choice_ reqTransactionIdentification,ReportingMessageStatus1Code reqStatus )
    {
        TransactionIdentification = reqTransactionIdentification;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    [IsoId("_hXhZQcK4EeuFNp8LZAnorg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification3Choice_ TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification3Choice_ TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification3Choice_ TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification3Choice_ TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_hXhZQ8K4EeuFNp8LZAnorg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportingMessageStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportingMessageStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportingMessageStatus1Code Status { get; init; } 
    #else
    public ReportingMessageStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_hXhZRcK4EeuFNp8LZAnorg")]
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
