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
/// Response Data to a Reversal request.
/// </summary>
[IsoId("_7Q2AIVS5EeuUvsVXOV79DQ")]
[DisplayName("Reversal Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalResponse5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalResponse5( TransactionIdentifier1 reqSaleTransactionIdentification,TransactionIdentifier1 reqPOITransactionIdentification,RetailerReversalResult3 reqReversalTransactionResult )
    {
        SaleTransactionIdentification = reqSaleTransactionIdentification;
        POITransactionIdentification = reqPOITransactionIdentification;
        ReversalTransactionResult = reqReversalTransactionResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_7W8oIVS5EeuUvsVXOV79DQ")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_7W8oI1S5EeuUvsVXOV79DQ")]
    [DisplayName("Sale Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefId")]
    #endif
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceIdentification { get; init; } 
    #else
    public System.String? SaleReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_7W8oJVS5EeuUvsVXOV79DQ")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_7W8oJ1S5EeuUvsVXOV79DQ")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIReconciliationIdentification { get; init; } 
    #else
    public System.String? POIReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_7W8oKVS5EeuUvsVXOV79DQ")]
    [DisplayName("Issuer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrRefData")]
    #endif
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? IssuerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerReferenceData { get; init; } 
    #else
    public System.String? IssuerReferenceData { get; set; } 
    #endif
    
    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_7W8oK1S5EeuUvsVXOV79DQ")]
    [DisplayName("Reversal Transaction Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslTxRslt")]
    #endif
    [IsoXmlTag("RvslTxRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerReversalResult3 ReversalTransactionResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerReversalResult3 ReversalTransactionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerReversalResult3 ReversalTransactionResult { get; init; } 
    #else
    public RetailerReversalResult3 ReversalTransactionResult { get; set; } 
    #endif
    
    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_7W8oLVS5EeuUvsVXOV79DQ")]
    [DisplayName("Reversed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdAmt")]
    #endif
    [IsoXmlTag("RvsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ReversedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_7W8oL1S5EeuUvsVXOV79DQ")]
    [DisplayName("Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rct")]
    #endif
    [IsoXmlTag("Rct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReceipt3? Receipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt3? Receipt { get; init; } 
    #else
    public PaymentReceipt3? Receipt { get; set; } 
    #endif
    
    
    #nullable disable
    
}
