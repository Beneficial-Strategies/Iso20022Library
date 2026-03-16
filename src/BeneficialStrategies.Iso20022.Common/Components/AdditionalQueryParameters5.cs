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
[IsoId("_E2DtEf4hEeCH9dkaY_DhYw")]
[DisplayName("Additional Query Parameters")]
public record AdditionalQueryParameters5
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_E2DtF_4hEeCH9dkaY_DhYw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status8Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_E2DtIf4hEeCH9dkaY_DhYw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Reason7Choice_? Reason { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_E2DtK_4hEeCH9dkaY_DhYw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification14? FinancialInstrumentIdentification { get; init; }
}
