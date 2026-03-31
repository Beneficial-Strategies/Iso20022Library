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
[IsoId("_3CmvvzbsEead9bDRE_1DAQ")]
[DisplayName("Payment Transaction")]
public record PaymentTransaction71
{
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("_3a23czbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Or Out")]
    [IsoXmlTag("CshInOrOut")]
    public required CashInOrOut7Choice_ CashInOrOut { get; init; }
}
