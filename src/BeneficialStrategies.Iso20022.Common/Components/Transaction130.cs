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
[IsoId("_S466AYv3EeumSPwlS1PkxQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction130
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction130 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction130( System.String reqFraudTransactionIdentification,ReportedFraud3 reqReportedFraud,FraudulentTransactionData2 reqFraudulentTransactionData )
    {
        FraudTransactionIdentification = reqFraudTransactionIdentification;
        ReportedFraud = reqReportedFraud;
        FraudulentTransactionData = reqFraudulentTransactionData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_S-Ft4Yv3EeumSPwlS1PkxQ")]
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
    [IsoId("_S-Ft44v3EeumSPwlS1PkxQ")]
    [DisplayName("Reported Fraud")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdFrd")]
    #endif
    [IsoXmlTag("RptdFrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportedFraud3 ReportedFraud { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportedFraud3 ReportedFraud { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportedFraud3 ReportedFraud { get; init; } 
    #else
    public ReportedFraud3 ReportedFraud { get; set; } 
    #endif
    
    /// <summary>
    /// Data pertaining to fraudulent reported transaction.
    /// </summary>
    [IsoId("_S-Ft5Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Fraudulent Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdlntTxData")]
    #endif
    [IsoXmlTag("FrdlntTxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudulentTransactionData2 FraudulentTransactionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudulentTransactionData2 FraudulentTransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudulentTransactionData2 FraudulentTransactionData { get; init; } 
    #else
    public FraudulentTransactionData2 FraudulentTransactionData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a not-received card.
    /// </summary>
    [IsoId("_S-Ft54v3EeumSPwlS1PkxQ")]
    [DisplayName("Card Not Received Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardNotRcvdDtls")]
    #endif
    [IsoXmlTag("CardNotRcvdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardNotReceivedDetails2? CardNotReceivedDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardNotReceivedDetails2? CardNotReceivedDetails { get; init; } 
    #else
    public CardNotReceivedDetails2? CardNotReceivedDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder name as it appears on the card.
    /// </summary>
    [IsoId("_S-Ft6Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Cardholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrNm")]
    #endif
    [IsoXmlTag("CrdhldrNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName3? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName3? CardholderName { get; init; } 
    #else
    public CardholderName3? CardholderName { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_S-Ft64v3EeumSPwlS1PkxQ")]
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
    [IsoId("_S-Ft7Yv3EeumSPwlS1PkxQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation22? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_S-Ft74v3EeumSPwlS1PkxQ")]
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
    
    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_psRykMXKEeumGdYElfgmbw")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData6? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData6? LocalData { get; init; } 
    #else
    public LocalData6? LocalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
