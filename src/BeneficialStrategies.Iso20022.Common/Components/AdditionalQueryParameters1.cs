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
[IsoId("_QqNYpNp-Ed-ak6NoX_4Aeg_-288378828")]
[DisplayName("Additional Query Parameters")]
public record AdditionalQueryParameters1
{
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_QqNYpdp-Ed-ak6NoX_4Aeg_-247743689")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public Status1Choice_? Status { get; init; }

    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_QqNYptp-Ed-ak6NoX_4Aeg_-237586189")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Reason1Choice_? Reason { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_QqNYp9p-Ed-ak6NoX_4Aeg_-380866954")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification11? FinancialInstrumentIdentification { get; init; }
}
