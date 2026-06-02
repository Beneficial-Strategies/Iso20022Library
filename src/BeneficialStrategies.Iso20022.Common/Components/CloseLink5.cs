// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the close links as defined in the collateral reference data.
/// </summary>
[IsoId("_J3BXAaX_EeynsLtPxJMJTQ")]
[DisplayName("Close Link5")]
public record CloseLink5
{
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_J-LH4aX_EeynsLtPxJMJTQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    [MinLength(1)]
    public ValueList<SecurityIdentification19> SecurityIdentification { get; init; } = [];

    /// <summary>
    /// Identifies the party for which the close link is defined.
    /// </summary>
    [IsoId("_J-LH46X_EeynsLtPxJMJTQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification2Choice PartyIdentification { get; init; }

    /// <summary>
    /// Identifies the credit provider party for which the close link information is provided.
    /// </summary>
    [IsoId("_J-LH5aX_EeynsLtPxJMJTQ")]
    [DisplayName("Credit Provider Identification")]
    [IsoXmlTag("CdtPrvdrId")]
    public SystemPartyIdentification2Choice? CreditProviderIdentification { get; init; }
}
