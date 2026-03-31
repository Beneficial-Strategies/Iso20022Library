// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement2.
/// </summary>
[IsoId("_trf6l5IPEe-HRNGM304Vlw")]
[DisplayName("Settlement2")]
public record Settlement2
{
    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification255Choice_? Depository { get; init; }

    /// <summary>
    /// Settlement Amount.
    /// </summary>
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; }
}
