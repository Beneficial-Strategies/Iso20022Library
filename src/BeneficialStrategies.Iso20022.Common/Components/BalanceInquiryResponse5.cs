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
/// Content of the balance inquiry response message.
/// </summary>
[IsoId("_DM8KUXHDEe2TbaNWBpRZpQ")]
[DisplayName("Balance Inquiry Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BalanceInquiryResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_DT68EXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_DT68E3HDEe2TbaNWBpRZpQ")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_DT68FXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Payment Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcct")]
    #endif
    [IsoXmlTag("PmtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentAccount3? PaymentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentAccount3? PaymentAccount { get; init; } 
    #else
    public PaymentAccount3? PaymentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_DT68F3HDEe2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyAcct")]
    #endif
    [IsoXmlTag("LltyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyAccount3? LoyaltyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyAccount3? LoyaltyAccount { get; init; } 
    #else
    public LoyaltyAccount3? LoyaltyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_DT68GXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Stored Value Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StordValAcct")]
    #endif
    [IsoXmlTag("StordValAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueAccount2? StoredValueAccount { get; init; } 
    #else
    public StoredValueAccount2? StoredValueAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_DT68G3HDEe2TbaNWBpRZpQ")]
    [DisplayName("Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rct")]
    #endif
    [IsoXmlTag("Rct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReceipt5? Receipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt5? Receipt { get; init; } 
    #else
    public PaymentReceipt5? Receipt { get; set; } 
    #endif
    
    
    #nullable disable
    
}
