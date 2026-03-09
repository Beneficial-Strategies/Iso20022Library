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
/// Identifies the submitting entity and Settlement Internaliser of the report.
/// </summary>
[IsoId("_x6_YcO3mEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliser1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliser1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliser1( SettlementInternaliserIdentification1 reqIdentification,InternalisationData1 reqOverallTotal,SettlementInternaliserFinancialInstrument1 reqFinancialInstrument,SettlementInternaliserTransactionType1 reqTransactionType,SettlementInternaliserClientType1 reqClientType,InternalisationData1 reqTotalCashTransfer )
    {
        Identification = reqIdentification;
        OverallTotal = reqOverallTotal;
        FinancialInstrument = reqFinancialInstrument;
        TransactionType = reqTransactionType;
        ClientType = reqClientType;
        TotalCashTransfer = reqTotalCashTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitting entity and settlement Internaliser of the report.
    /// </summary>
    [IsoId("_29gQEO3mEeaWjpoyrnG6Rw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliserIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliserIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliserIdentification1 Identification { get; init; } 
    #else
    public SettlementInternaliserIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Overall aggregated total value and volume of 
    /// - settled and failed and total of internalised settlement instructions, and
    /// - failed rate of internalised settlement instructions
    /// performed during the period covered by the report, for all financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_7EFD4O3mEeaWjpoyrnG6Rw")]
    [DisplayName("Overall Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrllTtl")]
    #endif
    [IsoXmlTag("OvrllTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 OverallTotal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 OverallTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 OverallTotal { get; init; } 
    #else
    public InternalisationData1 OverallTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of a financial instrument according to the categories defined in the relevant legislation.
    /// </summary>
    [IsoId("_99b2oO3mEeaWjpoyrnG6Rw")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrm")]
    #endif
    [IsoXmlTag("FinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; init; } 
    #else
    public SettlementInternaliserFinancialInstrument1 FinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of securities movements according to the categories defined in the relevant legislation.
    /// </summary>
    [IsoId("_ErEMQO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliserTransactionType1 TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliserTransactionType1 TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliserTransactionType1 TransactionType { get; init; } 
    #else
    public SettlementInternaliserTransactionType1 TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of a settlement internaliser&apos;s clients as referred to in the relevant legislation.
    /// </summary>
    [IsoId("_FjS0wO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Client Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntTp")]
    #endif
    [IsoXmlTag("ClntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementInternaliserClientType1 ClientType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementInternaliserClientType1 ClientType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInternaliserClientType1 ClientType { get; init; } 
    #else
    public SettlementInternaliserClientType1 ClientType { get; set; } 
    #endif
    
    /// <summary>
    /// Covers cash payments related to securities transactions.
    /// </summary>
    [IsoId("_H-wKkO3nEeaWjpoyrnG6Rw")]
    [DisplayName("Total Cash Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlCshTrf")]
    #endif
    [IsoXmlTag("TtlCshTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 TotalCashTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 TotalCashTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 TotalCashTransfer { get; init; } 
    #else
    public InternalisationData1 TotalCashTransfer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
