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
[IsoId("_HCkrDx5dEeWE3PufGMdJ3w")]
[DisplayName("Account")]
public record Account18
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Hh0Lwx5dEeWE3PufGMdJ3w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification26 Identification { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Hh0Lyx5dEeWE3PufGMdJ3w")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification71Choice_? AccountServicer { get; init; }
}
