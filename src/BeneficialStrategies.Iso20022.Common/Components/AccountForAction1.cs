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
[IsoId("_SN5Y9Np-Ed-ak6NoX_4Aeg_1820239688")]
[DisplayName("Account For Action")]
public record AccountForAction1
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SN5Y9dp-Ed-ak6NoX_4Aeg_1895968865")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_SN5Y9tp-Ed-ak6NoX_4Aeg_-2095161485")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }
}
