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
[IsoId("_6TNIgTH8EeWRJePX1ORoaw")]
[DisplayName("Record Technical Data")]
public record RecordTechnicalData2
{
    /// <summary>
    /// Defines the date and time when the report was originally received by the national competent authority.
    /// </summary>
    [IsoId("_6nJ_RTH8EeWRJePX1ORoaw")]
    [DisplayName("Receipt Date Time")]
    [IsoXmlTag("RctDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ReceiptDateTime { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation the transaction.
    /// </summary>
    [IsoId("_xFDToJHzEeWL7bXuV2k5pg")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CancelledStatusReason15Code CancellationReason { get; init; }
}
