// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
/// </summary>
[IsoId("_XEpRcLVZEeadLcJesEbkTQ")]
[DisplayName("Open Interest")]
public record OpenInterest1
{
    /// <summary>
    /// Gross notional of product cleared, if applicable.
    /// </summary>
    [IsoId("_bzGkoLVZEeadLcJesEbkTQ")]
    [DisplayName("Gross Notional Amount")]
    [IsoXmlTag("GrssNtnlAmt")]
    public required ActiveCurrencyAnd24Amount GrossNotionalAmount { get; init; }

    /// <summary>
    /// Open interest in number of lots, if applicable.
    /// </summary>
    [IsoId("_nF1dILVZEeadLcJesEbkTQ")]
    [DisplayName("Number Of Lots")]
    [IsoXmlTag("NbOfLots")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public IsoPositiveNumber? NumberOfLots { get; init; }
}
