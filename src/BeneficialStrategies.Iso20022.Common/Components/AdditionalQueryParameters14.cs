// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional specific query criteria.
/// </summary>
[IsoId("_gAQSTzi8Eeydid5dcNPKvg")]
[DisplayName("Additional Query Parameters")]
public record AdditionalQueryParameters14
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_gAQSUTi8Eeydid5dcNPKvg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status22Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_gAQSVTi8Eeydid5dcNPKvg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<Reason20Choice_> Reason { get; init; } = [];

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_gAQSWTi8Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification20> FinancialInstrumentIdentification { get; init; } =
        [];
}
