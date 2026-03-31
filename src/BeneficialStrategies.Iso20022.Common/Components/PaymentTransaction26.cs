// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_Px4Cetp-Ed-ak6NoX_4Aeg_1001233565")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction26
{
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("_PyBzcNp-Ed-ak6NoX_4Aeg_1001234323")]
    [DisplayName("Cash In Or Out")]
    [IsoXmlTag("CshInOrOut")]
    public CashInOrOut6Choice_? CashInOrOut { get; init; }
}
