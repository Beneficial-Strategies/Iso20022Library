// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the debit instrument.
/// </summary>
[IsoId("_4kVygcnUEeWpf-ImB_F2gQ")]
[DisplayName("Debt Instrument")]
public record DebtInstrument4
{
    /// <summary>
    /// Maturity date/time at which an interest bearing financial instrument becomes due, that is original date of expiry of the reported financial instrument.
    /// </summary>
    [IsoId("_5CgVM8nUEeWpf-ImB_F2gQ")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MaturityDate { get; init; }
}
