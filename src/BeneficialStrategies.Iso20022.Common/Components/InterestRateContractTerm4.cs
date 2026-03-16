// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes how interest rates are reported.
/// </summary>
[IsoId("_7KQYpVfREeqqKf65rDYWYw")]
[DisplayName("Interest Rate Contract Term")]
public record InterestRateContractTerm4
{
    /// <summary>
    /// Unit for the rate basis.
    /// </summary>
    [IsoId("_7j19U1fREeqqKf65rDYWYw")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public Frequency13Code? Unit { get; init; }

    /// <summary>
    /// Specifies the number of time units (as expressed by the payment frequency period) that detemines the frequency at which periodic payment dates occur.
    /// </summary>
    [IsoId("_7j19VVfREeqqKf65rDYWYw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? Value { get; init; }
}
