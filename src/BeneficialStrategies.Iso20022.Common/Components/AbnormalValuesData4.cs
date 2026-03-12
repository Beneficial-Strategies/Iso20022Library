// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
/// </summary>
[IsoId("_x5wPZ1yGEe24CqbZJK5XxA")]
[DisplayName("Abnormal Values Data")]
public partial record AbnormalValuesData4
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_x6yxMVyGEe24CqbZJK5XxA")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData92 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Number of reported derivatives.
    /// </summary>
    [IsoId("_x6yxM1yGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported")]
    [IsoXmlTag("NbOfDerivsRptd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDerivativesReported { get; init; } 
    
    /// <summary>
    /// Number of reported derivatives with outliers.
    /// </summary>
    [IsoId("_x6yxNVyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Derivatives Reported With Outliers")]
    [IsoXmlTag("NbOfDerivsRptdWthOtlrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDerivativesReportedWithOutliers { get; init; } 
    
    /// <summary>
    /// Details on abnormal values per transaction.
    /// </summary>
    [IsoId("_x6yxN1yGEe24CqbZJK5XxA")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public AbnormalValuesTransactionData2? TransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
