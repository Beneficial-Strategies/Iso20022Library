// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification data that is requested to be verified.
/// </summary>
[IsoId("_fevvsdcZEeqRFcf2R4bPBw")]
[DisplayName("Identification Verification")]
public partial record IdentificationVerification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_fgQyo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Party and/or account identification information for which verification is requested.
    /// </summary>
    [IsoId("_fgQypdcZEeqRFcf2R4bPBw")]
    [DisplayName("Party And Account Identification")]
    [IsoXmlTag("PtyAndAcctId")]
    public required IdentificationInformation4 PartyAndAccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
