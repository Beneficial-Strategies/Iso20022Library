// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of a telecom billing event.
/// </summary>
[IsoId("_Av2xUVXZEfC0lMwgjvMClw")]
[DisplayName("Telecom Billing Event Amount1")]
public record TelecomBillingEventAmount1
{
    [IsoId("_Av2xUVXZEfC0lMwgjvMClw-dsc")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax35Text? Description { get; init; }

    [IsoId("_Av2xUVXZEfC0lMwgjvMClw-amt")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    [IsoId("_Av2xUVXZEfC0lMwgjvMClw-crdb")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
