// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to counterparty identification.
/// </summary>
[IsoId("_P6R6gQz4Ee2YoLD-1vFj0g")]
[DisplayName("Counterparty")]
public record Counterparty46
{
    /// <summary>
    /// Indicates if the counterparty is a legal entity or a natural person.
    /// </summary>
    [IsoId("_P7Cvgwz4Ee2YoLD-1vFj0g")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public PartyIdentification248Choice_? IdentificationType { get; init; }

    /// <summary>
    /// Indicates if the counterparty is a central counterparty, a financial, non-financial counterparty or other type of counterparty in accordance with regulation.
    /// </summary>
    [IsoId("_P7CvhQz4Ee2YoLD-1vFj0g")]
    [DisplayName("Nature")]
    [IsoXmlTag("Ntr")]
    public CounterpartyTradeNature15Choice_? Nature { get; init; }

    /// <summary>
    /// Indicator of whether the counterparty 2 has the reporting obligation (irrespective of who is responsible and legally liable for its reporting).
    /// Usage: If the element is not present, the ReportingObligation is False.
    /// </summary>
    [IsoId("_P7Cvhwz4Ee2YoLD-1vFj0g")]
    [DisplayName("Reporting Obligation")]
    [IsoXmlTag("RptgOblgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReportingObligation { get; init; }
}
