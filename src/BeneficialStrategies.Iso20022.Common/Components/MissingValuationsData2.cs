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
[IsoId("_x2ECMVyGEe24CqbZJK5XxA")]
[DisplayName("Missing Valuations Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingValuationsData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingValuationsData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingValuationsData2( CounterpartyData92 reqCounterpartyIdentification,System.UInt64 reqNumberOfOutstandingDerivatives,System.UInt64 reqNumberOfOutstandingDerivativesWithNoValuation,System.UInt64 reqNumberOfOutstandingDerivativesWithOutdatedValuation )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        NumberOfOutstandingDerivatives = reqNumberOfOutstandingDerivatives;
        NumberOfOutstandingDerivativesWithNoValuation = reqNumberOfOutstandingDerivativesWithNoValuation;
        NumberOfOutstandingDerivativesWithOutdatedValuation = reqNumberOfOutstandingDerivativesWithOutdatedValuation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x24hkVyGEe24CqbZJK5XxA")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData92 CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyData92 CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    [IsoId("_x24hk1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOutsdngDerivs")]
    #endif
    [IsoXmlTag("NbOfOutsdngDerivs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivatives { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives for which valuation amount was never reported.
    /// </summary>
    [IsoId("_x24hlVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With No Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOutsdngDerivsWthNoValtn")]
    #endif
    [IsoXmlTag("NbOfOutsdngDerivsWthNoValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithNoValuation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives with outdated valuation.
    /// </summary>
    [IsoId("_x24hl1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Valuation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOutsdngDerivsWthOutdtdValtn")]
    #endif
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedValuation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of missing valuations per transaction.
    /// </summary>
    [IsoId("_x24hmVyGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MissingValuationsTransactionData2? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MissingValuationsTransactionData2? TransactionDetails { get; init; } 
    #else
    public MissingValuationsTransactionData2? TransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
