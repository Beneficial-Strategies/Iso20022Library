// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the triparty collateral transaction deal.
/// </summary>
[IsoId("_b2hQgRIlEeyLzJfz3xPQNA")]
[DisplayName("Deal Transaction Details")]
public record DealTransactionDetails7
{
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_cQTCcRIlEeyLzJfz3xPQNA")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public required ClosingDate4Choice_ ClosingDate { get; init; }

    /// <summary>
    /// Provide deal amount details.
    /// </summary>
    [IsoId("_cQTCcxIlEeyLzJfz3xPQNA")]
    [DisplayName("Deal Details Amount")]
    [IsoXmlTag("DealDtlsAmt")]
    public CollateralAmount14? DealDetailsAmount { get; init; }
}
