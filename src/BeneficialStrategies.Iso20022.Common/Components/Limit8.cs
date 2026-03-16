// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the limits.
/// </summary>
[IsoId("_OUj-4Z-YEee28J7y9KlTWg")]
[DisplayName("Limit")]
public record Limit8
{
    /// <summary>
    /// Date and time at which the limit becomes effective.
    /// </summary>
    [IsoId("_OfBicZ-YEee28J7y9KlTWg")]
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public DateAndDateTime2Choice_? StartDateTime { get; init; }

    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [IsoId("_OfBic5-YEee28J7y9KlTWg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; }

    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [IsoId("_OfBidZ-YEee28J7y9KlTWg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }
}
