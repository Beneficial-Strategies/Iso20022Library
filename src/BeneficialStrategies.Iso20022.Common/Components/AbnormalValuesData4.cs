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
/// Detailed information about derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
/// </summary>
[IsoId("_x5wPZ1yGEe24CqbZJK5XxA")]
[DisplayName("Abnormal Values Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AbnormalValuesData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AbnormalValuesData4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AbnormalValuesData4( CounterpartyData92 reqCounterpartyIdentification,System.UInt64 reqNumberOfDerivativesReported,System.UInt64 reqNumberOfDerivativesReportedWithOutliers )
    {
        CounterpartyIdentification = reqCounterpartyIdentification;
        NumberOfDerivativesReported = reqNumberOfDerivativesReported;
        NumberOfDerivativesReportedWithOutliers = reqNumberOfDerivativesReportedWithOutliers;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x6yxMVyGEe24CqbZJK5XxA")]
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
    /// Number of reported derivatives.
    /// </summary>
    [IsoId("_x6yxM1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDerivsRptd")]
    #endif
    [IsoXmlTag("NbOfDerivsRptd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDerivativesReported { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDerivativesReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDerivativesReported { get; init; } 
    #else
    public System.UInt64 NumberOfDerivativesReported { get; set; } 
    #endif
    
    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    [IsoId("_x6yxNVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported With Outliers")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDerivsRptdWthOtlrs")]
    #endif
    [IsoXmlTag("NbOfDerivsRptdWthOtlrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDerivativesReportedWithOutliers { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDerivativesReportedWithOutliers { get; init; } 
    #else
    public System.UInt64 NumberOfDerivativesReportedWithOutliers { get; set; } 
    #endif
    
    /// <summary>
    /// Details on abnormal values per transaction.
    /// </summary>
    [IsoId("_x6yxN1yGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AbnormalValuesTransactionData2? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AbnormalValuesTransactionData2? TransactionDetails { get; init; } 
    #else
    public AbnormalValuesTransactionData2? TransactionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
