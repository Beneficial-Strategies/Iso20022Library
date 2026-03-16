// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty programme used for partial payment in loyalty value (debit) and computation of loyalty value gained on the monetary value paid by the customer (credit).
/// </summary>
[IsoId("_bMhUgcW2EeuhguwJmlgagQ")]
[DisplayName("Loyalty Programme")]
public record LoyaltyProgramme3
{
    /// <summary>
    /// Eligibility for loyalty.
    /// True: Eligible for loyalty
    /// False: Not eligible for loyalty
    /// Default: False.
    /// </summary>
    [IsoId("_bQ4QEcW2EeuhguwJmlgagQ")]
    [DisplayName("Programme Eligibility Indicator")]
    [IsoXmlTag("PrgrmmElgbltyInd")]
    public SimpleValueList<IsoTrueFalseIndicator> ProgrammeEligibilityIndicator { get; init; } = [];

    /// <summary>
    /// Entity issuing the loyalty programme.
    /// </summary>
    [IsoId("_bQ4QE8W2EeuhguwJmlgagQ")]
    [DisplayName("Programme Issuer")]
    [IsoXmlTag("PrgrmmIssr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProgrammeIssuer { get; init; }

    /// <summary>
    /// Details about the member of the loyalty programme
    /// </summary>
    [IsoId("_bQ4QFcW2EeuhguwJmlgagQ")]
    [DisplayName("Loyalty Member")]
    [IsoXmlTag("LltyMmb")]
    public LoyaltyMember2? LoyaltyMember { get; init; }
}
