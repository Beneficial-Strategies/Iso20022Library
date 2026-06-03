// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tax exemption details.
/// </summary>
[IsoId("_enNREPsaEemYNq6Sxm5nlg")]
[DisplayName("Tax Exemption1")]
public record TaxExemption1
{
    [IsoId("_enNREPsaEemYNq6Sxm5nlg-exmt")]
    [DisplayName("Exempted Amount")]
    [IsoXmlTag("XmptdAmt")]
    public required ActiveCurrencyAndAmount ExemptedAmount { get; init; }

    [IsoId("_enNREPsaEemYNq6Sxm5nlg-rsn")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax210Text? Reason { get; init; }
}
