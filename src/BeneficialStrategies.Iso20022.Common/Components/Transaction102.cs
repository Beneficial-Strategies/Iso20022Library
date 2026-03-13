// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment transaction.
/// </summary>
[IsoId("_Mt51QVW5EeeiG_nL4vgKnQ")]
[DisplayName("Transaction")]
public partial record Transaction102
{
    #nullable enable
    
    /// <summary>
    /// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
    /// </summary>
    [IsoId("_M6lmYVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Amended Data")]
    [IsoXmlTag("AmddData")]
    public ValueList<DetailedError1> AmendedData { get; init; } = [];
    // ID for the above is _M6lmYVW5EeeiG_nL4vgKnQ
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_M6lmZVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Original message before correction/amendment.
    /// </summary>
    [IsoId("_M6lmY1W5EeeiG_nL4vgKnQ")]
    [DisplayName("Original Message")]
    [IsoXmlTag("OrgnlMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    
    /// <summary>
    /// Message amended.
    /// </summary>
    [IsoId("_M6lmaVW5EeeiG_nL4vgKnQ")]
    [DisplayName("Message Amended")]
    [IsoXmlTag("MsgAmdd")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? MessageAmended { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_aD1CwRqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
