// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_PPV2V5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Active Or Historic Currency And Amount Range")]
public record ActiveOrHistoricCurrencyAndAmountRange2
{
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    [IsoId("_PXu9U5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; }

    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    [IsoId("_PXu9VZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    [IsoId("_PXu9V5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; }
}
