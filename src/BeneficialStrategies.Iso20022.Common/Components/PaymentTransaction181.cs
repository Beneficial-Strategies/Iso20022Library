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
[IsoId("35ae8c59-46db-440f-bb8b-e9720b3da711")]
[DisplayName("Payment Transaction181")]
public record PaymentTransaction181
{
    /// <summary>
    /// Choice between cash-in or cash-out.
    /// </summary>
    [IsoId("3762239f-2a3a-45d1-aefb-34b6c077c259")]
    [DisplayName("Cash In Or Out")]
    [IsoXmlTag("CshInOrOut")]
    public required CashInOrOut8Choice CashInOrOut { get; init; }
}
