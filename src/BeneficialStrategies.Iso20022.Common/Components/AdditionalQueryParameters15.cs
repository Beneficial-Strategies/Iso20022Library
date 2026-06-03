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
[IsoId("b4a64159-737c-423c-a95a-1f8a1990db78")]
[DisplayName("Additional Query Parameters15")]
public record AdditionalQueryParameters15
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("f3039ae7-8b41-4ac6-b22b-5732192782ab")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status19Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("1da9214b-38ba-4eb9-9c5e-3fd8aa672ff5")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<Reason21Choice_> Reason { get; init; } = [];

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("088e4502-518a-4f1b-bc31-bee82449a5d5")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public ValueList<SecurityIdentification19> FinancialInstrumentIdentification { get; init; } = [];
}
