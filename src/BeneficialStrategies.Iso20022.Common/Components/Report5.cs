// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the settlement obligation report.
/// </summary>
[IsoId("_7jLUES9dEeS94oXWDaBauA")]
[DisplayName("Report")]
public record Report5
{
    /// <summary>
    /// Provides the identification for the non-clearing member. This is mandatory if the clearing member identification equals a general clearing member.
    /// </summary>
    [IsoId("_71U0AS9dEeS94oXWDaBauA")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public ValueList<PartyIdentificationAndAccount31> NonClearingMember { get; init; } = [];

    /// <summary>
    /// Provides information about the settlement obligation details.
    /// </summary>
    [IsoId("_71U0Ay9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Obligation Details")]
    [IsoXmlTag("SttlmOblgtnDtls")]
    public ValueList<SettlementObligation8> SettlementObligationDetails { get; init; } = [];
    // ID for the above is _71U0Ay9dEeS94oXWDaBauA
}
