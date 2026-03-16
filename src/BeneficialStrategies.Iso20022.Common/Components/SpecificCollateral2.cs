// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where a single, pre defined, financial instrument is sold and repurchased.
/// </summary>
[IsoId("_u1WsobcREeabfchHYoktpA")]
[DisplayName("Specific Collateral")]
public record SpecificCollateral2
{
    /// <summary>
    /// Identification of collateral placed as security for repo.
    /// </summary>
    [IsoId("_u_BmAbcREeabfchHYoktpA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; }
}
