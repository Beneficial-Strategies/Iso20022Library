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
[IsoId("_SOMT5dp-Ed-ak6NoX_4Aeg_-661044287")]
[DisplayName("Cash Account")]
public record CashAccount21
{
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SOMT5tp-Ed-ak6NoX_4Aeg_-774883353")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public IsoBICIdentifier? Servicer { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOMT59p-Ed-ak6NoX_4Aeg_-596764681")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification5Choice_ Identification { get; init; }
}
