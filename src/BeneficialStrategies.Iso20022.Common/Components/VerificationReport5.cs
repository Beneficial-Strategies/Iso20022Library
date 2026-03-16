// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Verification Report5.
/// </summary>
[IsoId("_00AMoTEyEe6g-ffJsqGiSA")]
[DisplayName("Verification Report5")]
public record VerificationReport5
{
    /// <summary>
    /// Original Identification.
    /// </summary>
    [DisplayName("Original Identification")]
    [IsoXmlTag("OrgnlId")]
    public required IsoMax35Text OriginalIdentification { get; init; }

    /// <summary>
    /// Original Party And Account Identification.
    /// </summary>
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation5? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public VerificationReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Updated Party And Account Identification.
    /// </summary>
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public IdentificationInformation5? UpdatedPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Verification.
    /// </summary>
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public required IsoIdentificationVerificationIndicator Verification { get; init; }
}
