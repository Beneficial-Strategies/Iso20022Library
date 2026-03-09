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
[IsoId("_rtPOiVowEe23K4GXSpBSeg")]
[DisplayName("Missing Margin Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MissingMarginData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MissingMarginData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MissingMarginData2( CounterpartyData92 reqCounterpartyIdentification,System.UInt64 reqNumberOfOutstandingDerivatives,System.UInt64 reqNumberOfOutstandingDerivativesWithNoMarginInformation,System.UInt64 reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        NumberOfOutstandingDerivatives = reqNumberOfOutstandingDerivatives;
        NumberOfOutstandingDerivativesWithNoMarginInformation = reqNumberOfOutstandingDerivativesWithNoMarginInformation;
        NumberOfOutstandingDerivativesWithOutdatedMarginInformation = reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_rud9kVowEe23K4GXSpBSeg")]
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
    [IsoId("_rud9k1owEe23K4GXSpBSeg")]
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
    /// Number of outstanding derivatives with no margin information.
    /// </summary>
    [IsoId("_rud9lVowEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOutsdngDerivsWthNoMrgnInf")]
    #endif
    [IsoXmlTag("NbOfOutsdngDerivsWthNoMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives with outdated margin information.
    /// </summary>
    [IsoId("_rud9l1owEe23K4GXSpBSeg")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfOutsdngDerivsWthOutdtdMrgnInf")]
    #endif
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdMrgnInf")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of missing margins per transaction.
    /// </summary>
    [IsoId("_rud9mVowEe23K4GXSpBSeg")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MissingMarginTransactionData2? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MissingMarginTransactionData2? TransactionDetails { get; init; } 
    #else
    public MissingMarginTransactionData2? TransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
