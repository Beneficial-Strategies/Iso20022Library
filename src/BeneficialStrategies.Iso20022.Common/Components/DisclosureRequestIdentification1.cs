// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information identifying the disclosure request for shareholders identification published by the issuer or third party nominated by the issuer in order to receive the disclosure responses from intermediaries in the custody chain.
/// </summary>
[IsoId("_im8pMDqgEemL_ewJY9QP1g")]
[DisplayName("Disclosure Request Identification")]
public record DisclosureRequestIdentification1
{
    /// <summary>
    /// Official and unique reference assigned to a shareholders identification disclosure request process by the issuer or third party nominated by him.
    /// </summary>
    [IsoId("_O-niQzqhEemL_ewJY9QP1g")]
    [DisplayName("Issuer Disclosure Request Identification")]
    [IsoXmlTag("IssrDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; }

    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_O-niRDqhEemL_ewJY9QP1g")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day.
    /// </summary>
    [IsoId("_O-niRTqhEemL_ewJY9QP1g")]
    [DisplayName("Shareholders Disclosure Record Date")]
    [IsoXmlTag("ShrhldrsDsclsrRcrdDt")]
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; }
}
