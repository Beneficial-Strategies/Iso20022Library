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
[IsoId("_SOMT6Np-Ed-ak6NoX_4Aeg_-1967253219")]
[DisplayName("Cash Account")]
public record CashAccount22
{
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SOWE4Np-Ed-ak6NoX_4Aeg_-1789134547")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_SOWE4dp-Ed-ak6NoX_4Aeg_-2081092285")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier Servicer { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SOWE4tp-Ed-ak6NoX_4Aeg_-1902973613")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification5Choice_ Identification { get; init; }

    /// <summary>
    /// Sub-division of a master or omnibus cash account.
    /// </summary>
    [IsoId("_SOWE49p-Ed-ak6NoX_4Aeg_-286714049")]
    [DisplayName("Secondary Account")]
    [IsoXmlTag("ScndryAcct")]
    public CashAccount21? SecondaryAccount { get; init; }

    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_SOWE5Np-Ed-ak6NoX_4Aeg_-268592078")]
    [DisplayName("Account Type Description")]
    [IsoXmlTag("AcctTpDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountTypeDescription { get; init; }
}
