// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the type and amount of the cash reinvestment in a given currency.
/// </summary>
[IsoId("_TRivacKzEeuFNp8LZAnorg")]
[DisplayName("Reinvested Cash Type And Amount")]
public record ReinvestedCashTypeAndAmount2
{
    /// <summary>
    /// Provides details on the type of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_TS8dgcKzEeuFNp8LZAnorg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReinvestmentType1Code Type { get; init; }

    /// <summary>
    /// Medium of exchange of currency.
    /// </summary>
    [IsoId("_TS8dg8KzEeuFNp8LZAnorg")]
    [DisplayName("Reinvested Cash Currency")]
    [IsoXmlTag("RinvstdCshCcy")]
    public required ActiveOrHistoricCurrencyCode ReinvestedCashCurrency { get; init; }
}
