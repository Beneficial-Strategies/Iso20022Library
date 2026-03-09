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
/// Detailed statistics on derivatives submitted for reconciliation per counterparty pair.
/// </summary>
[IsoId("_cHKG8VovEe23K4GXSpBSeg")]
[DisplayName("Reconciliation Counterparty Pair Statistics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReconciliationCounterpartyPairStatistics6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReconciliationCounterpartyPairStatistics6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReconciliationCounterpartyPairStatistics6( CounterpartyData91 reqCounterpartyIdentification,System.UInt64 reqTotalNumberOfTransactions )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        TotalNumberOfTransactions = reqTotalNumberOfTransactions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_cIzswVovEe23K4GXSpBSeg")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData91 CounterpartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData91 CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData91 CounterpartyIdentification { get; init; } 
    #else
    public CounterpartyData91 CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of all reports per status on derivatives submitted for reconciliation per counterparty pair.
    /// </summary>
    [IsoId("_cIzsw1ovEe23K4GXSpBSeg")]
    [DisplayName("Total Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxs")]
    #endif
    [IsoXmlTag("TtlNbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfTransactions { get; init; } 
    #else
    public System.UInt64 TotalNumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    [IsoId("_cIzsxVovEe23K4GXSpBSeg")]
    [DisplayName("Reconciliation Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnRpt")]
    #endif
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport14> ReconciliationReport { get; init; } = new ValueList<ReconciliationReport14>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _cIzsxVovEe23K4GXSpBSeg
    
    
    #nullable disable
    
}
