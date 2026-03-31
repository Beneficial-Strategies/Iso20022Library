// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification data that is advised to be modified.
/// </summary>
[IsoId("_ezRJwdcZEeqRFcf2R4bPBw")]
[DisplayName("Identification Modification")]
public record IdentificationModification4
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_e0iVE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_e0iVFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation4? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Provides updated party and/or account identification information.
    /// </summary>
    [IsoId("_e0iVF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public required IdentificationInformation4 UpdatedPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Additional information, in free text form, to complement the modification information.
    /// </summary>
    [IsoId("_e0iVGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
