// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the cash values to be settled as of the start and maturity date of the transaction.
/// </summary>
[IsoId("_xJW_4bOYEemDE9K-I5TT8Q")]
[DisplayName("Principal Amount")]
public record PrincipalAmount2
{
    /// <summary>
    /// Cash value to be settled as of the start date of the transaction.
    /// </summary>
    [IsoId("_xRAgAbOYEemDE9K-I5TT8Q")]
    [DisplayName("Value Date Amount")]
    [IsoXmlTag("ValDtAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ValueDateAmount { get; init; }

    /// <summary>
    /// Cash value to be settled as of the maturity date of the transaction.
    /// </summary>
    [IsoId("_xRAgA7OYEemDE9K-I5TT8Q")]
    [DisplayName("Maturity Date Amount")]
    [IsoXmlTag("MtrtyDtAmt")]
    public ActiveOrHistoricCurrencyAndAmount? MaturityDateAmount { get; init; }
}
