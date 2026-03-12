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
[IsoId("_BfzYwYgrEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
public partial record Transaction128
{
    #nullable enable
    
    /// <summary>
    /// Identification of the  transaction reporting the fraud.
    /// </summary>
    [IsoId("_BkxYUYgrEeu8-LhY4KPfWg")]
    [DisplayName("Fraud Transaction Identification")]
    [IsoXmlTag("FrdTxId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text FraudTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Fraud reporting type information.
    /// </summary>
    [IsoId("_BkxYU4grEeu8-LhY4KPfWg")]
    [DisplayName("Reported Fraud")]
    [IsoXmlTag("RptdFrd")]
    public required ReportedFraud2 ReportedFraud { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_BkxYVYgrEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_BkxYV4grEeu8-LhY4KPfWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BkxYWYgrEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
