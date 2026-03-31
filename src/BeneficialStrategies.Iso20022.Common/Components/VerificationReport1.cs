// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information concerning the verification of identification data for which verification was requested.
/// </summary>
[IsoId("_Qo3U19p-Ed-ak6NoX_4Aeg_380722125")]
[DisplayName("Verification Report")]
public record VerificationReport1
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the original message.
    /// </summary>
    [IsoId("_QpBF0Np-Ed-ak6NoX_4Aeg_981569162")]
    [DisplayName("Original Identification")]
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalIdentification { get; init; }

    /// <summary>
    /// Identifies whether the party and/or account information received is correct.
    /// </summary>
    [IsoId("_QpBF0dp-Ed-ak6NoX_4Aeg_-153090260")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    [IsoSimpleType(IsoSimpleType.IdentificationVerificationIndicator)]
    public required IsoIdentificationVerificationIndicator Verification { get; init; }

    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [IsoId("_QpBF0tp-Ed-ak6NoX_4Aeg_680603005")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public VerificationReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_QpBF09p-Ed-ak6NoX_4Aeg_263554852")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation1? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Provides party and/or account identification information.
    /// </summary>
    [IsoId("_QpBF1Np-Ed-ak6NoX_4Aeg_1647252329")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public IdentificationInformation1? UpdatedPartyAndAccountIdentification { get; init; }
}
