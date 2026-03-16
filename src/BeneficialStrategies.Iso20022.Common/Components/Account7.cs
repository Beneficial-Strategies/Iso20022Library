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
[IsoId("_Pofc8Np-Ed-ak6NoX_4Aeg_-955384190")]
[DisplayName("Account")]
public record Account7
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Pofc8dp-Ed-ak6NoX_4Aeg_-955383852")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification1 Identification { get; init; }

    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    [IsoId("_Pofc8tp-Ed-ak6NoX_4Aeg_-955383783")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; }
}
