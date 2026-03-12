// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the verification of identification data for which verification was requested.
/// </summary>
[IsoId("_tp2JQVkyEeGeoaLUQk__nA_-1657016641")]
[DisplayName("Verification Report")]
public partial record VerificationReport2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the original message.
    /// </summary>
    [IsoId("_tp2JQlkyEeGeoaLUQk__nA_1640878302")]
    [DisplayName("Original Identification")]
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OriginalIdentification { get; init; } 
    
    /// <summary>
    /// Identifies whether the party and/or account information received is correct.
    /// </summary>
    [IsoId("_tp2JQ1kyEeGeoaLUQk__nA_529966883")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    [IsoSimpleType(IsoSimpleType.IdentificationVerificationIndicator)]
    public required IsoIdentificationVerificationIndicator Verification { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [IsoId("_tp_6QFkyEeGeoaLUQk__nA_-1642296495")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public VerificationReason1Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_tp_6QVkyEeGeoaLUQk__nA_1037398288")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; init; } 
    
    /// <summary>
    /// Provides party and/or account identification information.
    /// </summary>
    [IsoId("_tp_6QlkyEeGeoaLUQk__nA_-1839979705")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public IdentificationInformation2? UpdatedPartyAndAccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
