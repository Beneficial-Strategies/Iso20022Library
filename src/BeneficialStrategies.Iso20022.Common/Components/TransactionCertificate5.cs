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
/// Certificate in which all currency control transactions are registered.
/// </summary>
[IsoId("_op2wkbMkEeueudaIbClZbQ")]
[DisplayName("Transaction Certificate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCertificate5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionCertificate5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionCertificate5( CertificateReference2 reqReferredDocument,System.DateOnly reqTransactionDate,System.String reqLocalInstrument,ActiveCurrencyAndAmount reqAmount )
    {
        ReferredDocument = reqReferredDocument;
        TransactionDate = reqTransactionDate;
        LocalInstrument = reqLocalInstrument;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the transaction, that is the underlying payment instruction or statement entry.
    /// </summary>
    [IsoId("_orbd4bMkEeueudaIbClZbQ")]
    [DisplayName("Referred Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDoc")]
    #endif
    [IsoXmlTag("RfrdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateReference2 ReferredDocument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateReference2 ReferredDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateReference2 ReferredDocument { get; init; } 
    #else
    public CertificateReference2 ReferredDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the underlying transaction.
    /// </summary>
    [IsoId("_orbd47MkEeueudaIbClZbQ")]
    [DisplayName("Transaction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDt")]
    #endif
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TransactionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TransactionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TransactionDate { get; init; } 
    #else
    public System.DateOnly TransactionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the transaction.
    /// </summary>
    [IsoId("_orbd5bMkEeueudaIbClZbQ")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionType { get; init; } 
    #else
    public System.String? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// User community specific instrument.
    /// Usage: This element is used to specify a local transaction type to further qualify the transaction type.
    /// </summary>
    [IsoId("_orbd57MkEeueudaIbClZbQ")]
    [DisplayName("Local Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclInstrm")]
    #endif
    [IsoXmlTag("LclInstrm")]
    [IsoSimpleType(IsoSimpleType.Exact5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact5NumericText LocalInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LocalInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LocalInstrument { get; init; } 
    #else
    public System.String LocalInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Amount as provided in the transaction to be recorded under the contract.
    /// </summary>
    [IsoId("_orbd6bMkEeueudaIbClZbQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
