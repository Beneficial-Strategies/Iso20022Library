// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument specific technical data to support identification.
/// </summary>
[IsoId("_XjVHpZ26Eeuwmdq0KtnICg")]
[DisplayName("Record Technical Data")]
public record RecordTechnicalData5
{
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    [IsoId("_X5iBAZ26Eeuwmdq0KtnICg")]
    [DisplayName("Receipt Date Time")]
    [IsoXmlTag("RctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReceiptDateTime { get; init; }

    /// <summary>
    /// Describes the reason for the exchange of the transaction report between the competent authorities.
    /// </summary>
    [IsoId("_X5iBA526Eeuwmdq0KtnICg")]
    [DisplayName("Exchange Reason")]
    [IsoXmlTag("XchgRsn")]
    public SimpleValueList<ExternalAuthorityExchangeReason1Code> ExchangeReason { get; init; } = [];
    // ID for the above is _X5iBA526Eeuwmdq0KtnICg
}
