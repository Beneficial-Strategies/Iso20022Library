// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification Modification5.
/// </summary>
[IsoId("_zKXVUTEyEe6g-ffJsqGiSA")]
[DisplayName("Identification Modification5")]
public record IdentificationModification5
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax140Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Original Party And Account Identification.
    /// </summary>
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation5? OriginalPartyAndAccountIdentification { get; init; }

    /// <summary>
    /// Updated Party And Account Identification.
    /// </summary>
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public required IdentificationInformation5 UpdatedPartyAndAccountIdentification { get; init; }
}
