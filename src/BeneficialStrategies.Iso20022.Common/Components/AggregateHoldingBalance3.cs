// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall holding position, in a single financial instrument, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_YlFnMVV3Eea1MPROA61PoQ")]
[DisplayName("Aggregate Holding Balance")]
public record AggregateHoldingBalance3
{
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_g8YpUlV3Eea1MPROA61PoQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateHoldingBalance1> BalanceForAccount { get; init; } = [];

    // ID for the above is _g8YpUlV3Eea1MPROA61PoQ

    /// <summary>
    /// Agent of the financial instrument, for example, a trade intermediary.
    /// </summary>
    [IsoId("_g8YpU1V3Eea1MPROA61PoQ")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public ValueList<Intermediary29> Agent { get; init; } = [];
}
