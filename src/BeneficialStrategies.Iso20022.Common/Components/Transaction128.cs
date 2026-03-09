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
/// Fraud reporting transaction.
/// </summary>
[IsoId("_BfzYwYgrEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction128
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction128 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction128( System.String reqFraudTransactionIdentification,ReportedFraud2 reqReportedFraud )
    {
        FraudTransactionIdentification = reqFraudTransactionIdentification;
        ReportedFraud = reqReportedFraud;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_BkxYUYgrEeu8-LhY4KPfWg")]
    [DisplayName("Fraud Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdTxId")]
    #endif
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text FraudTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FraudTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FraudTransactionIdentification { get; init; } 
    #else
    public System.String FraudTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Fraud reporting type information.
    /// </summary>
    [IsoId("_BkxYU4grEeu8-LhY4KPfWg")]
    [DisplayName("Reported Fraud")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdFrd")]
    #endif
    [IsoXmlTag("RptdFrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportedFraud2 ReportedFraud { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportedFraud2 ReportedFraud { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportedFraud2 ReportedFraud { get; init; } 
    #else
    public ReportedFraud2 ReportedFraud { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_BkxYVYgrEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_BkxYV4grEeu8-LhY4KPfWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation30? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BkxYWYgrEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
