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
[IsoId("_Pofc9tp-Ed-ak6NoX_4Aeg_787090516")]
[DisplayName("Account")]
public record Account2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Pofc99p-Ed-ak6NoX_4Aeg_787090535")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification1? Identification { get; init; }

    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    [IsoId("_PopN8Np-Ed-ak6NoX_4Aeg_787090559")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification2Choice_ AccountServicer { get; init; }
}
