// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account identification information.
/// </summary>
[IsoId("_9C2Zw_fEEeiNZp_PtLohLw")]
[DisplayName("Account Identification")]
public record AccountIdentification49
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_9C3A0_fEEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_9C3A2_fEEeiNZp_PtLohLw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification136Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_9C3A4_fEEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat34Choice_? SafekeepingPlace { get; init; }
}
