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
[IsoId("_LWGZgeaZEd-q8fx_Zl_34A")]
[DisplayName("Additional Query Parameters")]
public record AdditionalQueryParameters3
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_LWGZg-aZEd-q8fx_Zl_34A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status8Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_LWGZheaZEd-q8fx_Zl_34A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<Reason6Choice_> Reason { get; init; } = [];

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_LWGZh-aZEd-q8fx_Zl_34A")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification14> FinancialInstrumentIdentification { get; init; } =
        [];
}
