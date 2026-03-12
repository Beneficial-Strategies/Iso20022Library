// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Body of the Abort Request message.
/// </summary>
[IsoId("_Ck5osQuIEeqYM5yH99IYQw")]
[DisplayName("Abort Data")]
public partial record AbortData2
{
    #nullable enable
    
    /// <summary>
    /// Message identifier.
    /// </summary>
    [IsoId("_Cx5i4QuIEeqYM5yH99IYQw")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Reason of aborting a transaction.
    /// </summary>
    [IsoId("_Cx5i4wuIEeqYM5yH99IYQw")]
    [DisplayName("Abort Reason")]
    [IsoXmlTag("AbrtRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text AbortReason { get; init; } 
    
    /// <summary>
    /// To display an abort message to the Customer.
    /// </summary>
    [IsoId("_Cx5i5QuIEeqYM5yH99IYQw")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage7? DisplayOutput { get; init; } 
    
    /// <summary>
    /// Outcome of the transaction at the acceptor.
    /// </summary>
    [IsoId("_tvcAQQuIEeqYM5yH99IYQw")]
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TransactionSuccess { get; init; } 
    
    
    #nullable disable
    
}
