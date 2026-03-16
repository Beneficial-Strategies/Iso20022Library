// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the verification of identification data for which verification was requested.
/// </summary>
[IsoId("_d114MdcZEeqRFcf2R4bPBw")]
[DisplayName("Verification Report")]
public record VerificationReport4
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the original message.
    /// </summary>
    [IsoId("_d4SIMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Identification")]
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalIdentification { get; init; }

    /// <summary>
    /// Identifies whether the party and/or account information received is correct.
    /// </summary>
    [IsoId("_d4SIM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    [IsoSimpleType(IsoSimpleType.IdentificationVerificationIndicator)]
    public required IsoIdentificationVerificationIndicator Verification { get; init; }

    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [IsoId("_d4SINdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public VerificationReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_d4SvQdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation4? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Provides party and/or account identification information.
    /// </summary>
    [IsoId("_d4SvQ9cZEeqRFcf2R4bPBw")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public IdentificationInformation4? UpdatedPartyAndAccountIdentification { get; init; }
}
