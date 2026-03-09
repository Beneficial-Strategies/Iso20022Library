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
[IsoId("_WbeBEXbGEeef9c2nwgY9Xw")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction79
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction79 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction79( System.String reqFraudTransactionIdentification,ReportedFraud1 reqReportedFraud,FraudulentTransactionData1 reqFraudulentTransactionData )
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
    [IsoId("_zl4FwHbGEeef9c2nwgY9Xw")]
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
    [IsoId("_Gl5aEHbHEeef9c2nwgY9Xw")]
    [DisplayName("Reported Fraud")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdFrd")]
    #endif
    [IsoXmlTag("RptdFrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportedFraud1 ReportedFraud { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportedFraud1 ReportedFraud { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportedFraud1 ReportedFraud { get; init; } 
    #else
    public ReportedFraud1 ReportedFraud { get; set; } 
    #endif
    
    /// <summary>
    /// Data pertaining to fraudulent reported transaction.
    /// </summary>
    [IsoId("_O-9WwHbHEeef9c2nwgY9Xw")]
    [DisplayName("Fraudulent Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdlntTxData")]
    #endif
    [IsoXmlTag("FrdlntTxData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FraudulentTransactionData1 FraudulentTransactionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FraudulentTransactionData1 FraudulentTransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FraudulentTransactionData1 FraudulentTransactionData { get; init; } 
    #else
    public FraudulentTransactionData1 FraudulentTransactionData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of a not-received card.
    /// </summary>
    [IsoId("_R6MukZiiEee2DZ9xp6Fx_g")]
    [DisplayName("Card Not Received Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardNotRcvdDtls")]
    #endif
    [IsoXmlTag("CardNotRcvdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardNotReceivedDetails1? CardNotReceivedDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardNotReceivedDetails1? CardNotReceivedDetails { get; init; } 
    #else
    public CardNotReceivedDetails1? CardNotReceivedDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Cardholder name as it appears on the card.
    /// </summary>
    [IsoId("_3E3koHdUEeeKH6vrEwvLHA")]
    [DisplayName("Cardholder Card Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrCardNm")]
    #endif
    [IsoXmlTag("CrdhldrCardNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName1? CardholderCardName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName1? CardholderCardName { get; init; } 
    #else
    public CardholderName1? CardholderCardName { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_1zLZQvF9EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_WnE0LXbGEeef9c2nwgY9Xw")]
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
    [IsoId("_YzY5IRqnEeqH1IQNpbVpEw")]
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
