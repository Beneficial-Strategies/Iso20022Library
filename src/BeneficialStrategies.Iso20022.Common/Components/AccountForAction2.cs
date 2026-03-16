// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_Itngkw38EeKGXqvMN6jpiw")]
[DisplayName("Account For Action")]
public record AccountForAction2
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_JC7pMQ38EeKGXqvMN6jpiw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the account. In case of conflict between the Account Identification and the Account Name, it is recommended that the Account Servicer ask for clarification by means of the Request for Additional Information message.
    /// </summary>
    [IsoId("_Rky8kA38EeKGXqvMN6jpiw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_JC7pNQ38EeKGXqvMN6jpiw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }
}
