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
[IsoId("__nSawVWsEeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
public partial record Transaction101
{
    #nullable enable
    
    /// <summary>
    /// Transaction Identification of the Error message.
    /// </summary>
    [IsoId("__ymS5VWsEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification12 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Contains error details.
    ///  ISO 8583:2003, bit 18
    /// </summary>
    [IsoId("_lYOcEMczEeiYIbmhB2-RrQ")]
    [DisplayName("Error Detail")]
    [IsoXmlTag("ErrDtl")]
    public ValueList<ErrorDetails1> ErrorDetail { get; init; } = [];
    // ID for the above is _lYOcEMczEeiYIbmhB2-RrQ
    
    /// <summary>
    /// Original request that caused the party to reject it.
    /// </summary>
    [IsoId("_N7FMUVW0EeeiG_nL4vgKnQ")]
    [DisplayName("Original Message")]
    [IsoXmlTag("OrgnlMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_Yjjn8vF-EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_5nuuYRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
