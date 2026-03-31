// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[IsoId("_Sge40zozEeOr__K5A0LSog")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount97
{
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [IsoId("_Sge41TozEeOr__K5A0LSog")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification62 PartyIdentification { get; init; }

    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_Sge41DozEeOr__K5A0LSog")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification26? AccountIdentification { get; init; }
}
