// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Error or rejection transaction.
/// </summary>
[IsoId("_g8sk0YgoEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
public partial record Transaction155
{
    #nullable enable
    
    /// <summary>
    /// Transaction Identification of the Error message.
    /// </summary>
    [IsoId("_hCNW8YgoEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Contains error details.
    ///  ISO 8583:2003, bit 18
    /// </summary>
    [IsoId("_hCNW84goEeu8-LhY4KPfWg")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails2> ErrorDetail { get; init; } = new ValueList<ErrorDetails2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _hCNW84goEeu8-LhY4KPfWg
    
    /// <summary>
    /// Original request that caused the party to reject it.
    /// </summary>
    [IsoId("_hCN-AYgoEeu8-LhY4KPfWg")]
    [DisplayName("Original Message")]
    [IsoXmlTag("OrgnlMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_hCN-A4goEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_hCN-BYgoEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
