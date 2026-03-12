// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment token information.
/// </summary>
[IsoId("__GUTcGkgEeSTIuB9A-QJ6g")]
[DisplayName("Card Payment Token")]
public partial record CardPaymentToken1
{
    #nullable enable
    
    /// <summary>
    /// Additional token payment information.
    /// </summary>
    [IsoId("_GB7asGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Token Characteristic")]
    [IsoXmlTag("TknChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TokenCharacteristic { get; init; } 
    
    /// <summary>
    /// Identifier of a token provider requestor.
    /// </summary>
    [IsoId("_k2kzoGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Token Requestor")]
    [IsoXmlTag("TknRqstr")]
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    
    
    #nullable disable
    
}
