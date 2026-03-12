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
[IsoId("_5yLZUWltEeSGkpGpjm7tzg")]
[DisplayName("Card Payment Token")]
public partial record CardPaymentToken3
{
    #nullable enable
    
    /// <summary>
    /// Additional payment token information.
    /// </summary>
    [IsoId("_AXb2EGluEeSGkpGpjm7tzg")]
    [DisplayName("Token Characteristic")]
    [IsoXmlTag("TknChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TokenCharacteristic { get; init; } 
    
    /// <summary>
    /// Identifier of a token provider requestor.
    /// </summary>
    [IsoId("_GODrMGluEeSGkpGpjm7tzg")]
    [DisplayName("Token Requestor")]
    [IsoXmlTag("TknRqstr")]
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    
    /// <summary>
    /// Level of confidence resulting of the identification and authentication of the cardholder performed and the entity that performed it.
    /// </summary>
    [IsoId("_5-sLUWltEeSGkpGpjm7tzg")]
    [DisplayName("Token Assurance Level")]
    [IsoXmlTag("TknAssrncLvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TokenAssuranceLevel { get; init; } 
    
    
    #nullable disable
    
}
