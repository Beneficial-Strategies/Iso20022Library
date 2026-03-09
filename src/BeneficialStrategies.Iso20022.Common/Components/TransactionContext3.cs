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
/// Context of the card payment transaction
/// </summary>
[IsoId("_iMrMUSehEeiTrZHuJ0M1-Q")]
[DisplayName("Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionContext3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction.
    /// ISO 8583:87 bit 18, ISO 8583:93 bit 18 &amp; 26, ISO 8583:2003 bit 26
    /// ISO 18245
    /// </summary>
    [IsoId("_w_ElwOwGEeiMkKo2clXHdQ")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact4NumericText? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategoryCode { get; init; } 
    #else
    public System.String? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_bJBIoGzgEemD24gVaMSpeA")]
    [DisplayName("Transaction Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInitr")]
    #endif
    [IsoXmlTag("TxInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    #else
    public TransactionInitiator1Code? TransactionInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    [IsoId("_iZeSNyehEeiTrZHuJ0M1-Q")]
    [DisplayName("Card Programme Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPrgrmmApld")]
    #endif
    [IsoXmlTag("CardPrgrmmApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProgrammeMode1? CardProgrammeApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProgrammeMode1? CardProgrammeApplied { get; init; } 
    #else
    public CardProgrammeMode1? CardProgrammeApplied { get; set; } 
    #endif
    
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_iZeSOSehEeiTrZHuJ0M1-Q")]
    [DisplayName("Settlement Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmSvc")]
    #endif
    [IsoXmlTag("SttlmSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementService2? SettlementService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementService2? SettlementService { get; init; } 
    #else
    public SettlementService2? SettlementService { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_iZeSOyehEeiTrZHuJ0M1-Q")]
    [DisplayName("Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcncltn")]
    #endif
    [IsoXmlTag("Rcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reconciliation3? Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reconciliation3? Reconciliation { get; init; } 
    #else
    public Reconciliation3? Reconciliation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
