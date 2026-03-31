// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_rRiDQZS_EemqYPWMBuVawg")]
[DisplayName("Account")]
public record Account32
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_rm9gs5S_EemqYPWMBuVawg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    [IsoId("_rm9gtZS_EemqYPWMBuVawg")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification125Choice_ AccountServicer { get; init; }
}
