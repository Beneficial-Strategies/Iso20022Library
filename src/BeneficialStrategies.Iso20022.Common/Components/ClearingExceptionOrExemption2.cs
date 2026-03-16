// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further details on clearing exceptions or exemptions.
/// </summary>
[IsoId("_AjSxdZPuEey0rJ3Gl6WZVA")]
[DisplayName("Clearing Exception Or Exemption")]
public record ClearingExceptionOrExemption2
{
    /// <summary>
    /// Identifies the type of clearing exemption or exception that the reporting counterparty has elected.
    /// </summary>
    [IsoId("_Ak0bcZPuEey0rJ3Gl6WZVA")]
    [DisplayName("Reporting Counterparty")]
    [IsoXmlTag("RptgCtrPty")]
    public required NonClearingReason2 ReportingCounterparty { get; init; }

    /// <summary>
    /// Identifies the type of clearing exemption or exception that the other counterparty has elected.
    /// </summary>
    [IsoId("_Ak0bc5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Other Counterparty")]
    [IsoXmlTag("OthrCtrPty")]
    public NonClearingReason2? OtherCounterparty { get; init; }
}
