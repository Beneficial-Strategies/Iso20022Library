// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides account and balance information.
/// </summary>
[IsoId("_x6R8RTq3EeWQ1Y7f8kds2A")]
[DisplayName("Account And Balance")]
public record AccountAndBalance35
{
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_yHFCBTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SafekeepingAccount { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_yHFCDTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification92Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_yHFCFTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Provides information about balance related to a corporate action.
    /// </summary>
    [IsoId("_yHFCHTq3EeWQ1Y7f8kds2A")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails32? Balance { get; init; }
}
