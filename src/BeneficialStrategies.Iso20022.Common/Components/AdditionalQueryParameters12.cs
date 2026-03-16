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
[IsoId("_8QboD5NLEeWGlc8L7oPDIg")]
[DisplayName("Additional Query Parameters")]
public record AdditionalQueryParameters12
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_8QboEZNLEeWGlc8L7oPDIg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status22Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_8QboFZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Reason17Choice_? Reason { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_8QboGZNLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }
}
