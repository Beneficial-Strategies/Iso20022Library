// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fraud reporting transaction.
/// </summary>
[IsoId("_WbeBEXbGEeef9c2nwgY9Xw")]
[DisplayName("Transaction")]
public partial record Transaction79
{
    #nullable enable
    
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_zl4FwHbGEeef9c2nwgY9Xw")]
    [DisplayName("Fraud Transaction Identification")]
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text FraudTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Fraud reporting type information.
    /// </summary>
    [IsoId("_Gl5aEHbHEeef9c2nwgY9Xw")]
    [DisplayName("Reported Fraud")]
    [IsoXmlTag("RptdFrd")]
    public required ReportedFraud1 ReportedFraud { get; init; } 
    
    /// <summary>
    /// Data pertaining to fraudulent reported transaction.
    /// </summary>
    [IsoId("_O-9WwHbHEeef9c2nwgY9Xw")]
    [DisplayName("Fraudulent Transaction Data")]
    [IsoXmlTag("FrdlntTxData")]
    public required FraudulentTransactionData1 FraudulentTransactionData { get; init; } 
    
    /// <summary>
    /// Details of a not-received card.
    /// </summary>
    [IsoId("_R6MukZiiEee2DZ9xp6Fx_g")]
    [DisplayName("Card Not Received Details")]
    [IsoXmlTag("CardNotRcvdDtls")]
    public CardNotReceivedDetails1? CardNotReceivedDetails { get; init; } 
    
    /// <summary>
    /// Cardholder name as it appears on the card.
    /// </summary>
    [IsoId("_3E3koHdUEeeKH6vrEwvLHA")]
    [DisplayName("Cardholder Card Name")]
    [IsoXmlTag("CrdhldrCardNm")]
    public CardholderName1? CardholderCardName { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_1zLZQvF9EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_WnE0LXbGEeef9c2nwgY9Xw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_YzY5IRqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
