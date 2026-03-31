// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Position20.
/// </summary>
[IsoId("_4ECDq4-9Ee-COKgew96POA")]
[DisplayName("Security Position20")]
public record SecurityPosition20
{
    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Position.
    /// </summary>
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    public EligiblePosition18? Position { get; init; }
}
