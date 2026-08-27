// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the transaction published by a contributor.
/// </summary>
[IsoId("_Nf1zgGIlEfCeoPFCHQnhvA")]
[DisplayName("Contributor Publication Data1")]
public record ContributorPublicationData1
{
    /// <summary>
    /// Date and time when the transaction was published by a trading venue or Approved Publication Arrangement (APA).
    /// </summary>
    [IsoId("_W28FwGIlEfCeoPFCHQnhvA")]
    [DisplayName("Publication Date Time")]
    [IsoXmlTag("PblctnDtTm")]
    public required IsoISODateTime PublicationDateTime { get; init; }

    /// <summary>
    /// Identifies the trading venue and Approved Publication Arrangement (APA) publishing the transaction.
    /// </summary>
    [IsoId("_d3APMGIlEfCeoPFCHQnhvA")]
    [DisplayName("Publication Venue Identification")]
    [IsoXmlTag("PblctnVnId")]
    public required IsoMICIdentifier PublicationVenueIdentification { get; init; }

    /// <summary>
    /// Date and time when the transaction report was received by an Approved Publication Arrangement (APA).
    /// Usage: Only applicable for input data.
    /// </summary>
    [IsoId("_sCyrsKUREfCmoeslmyBN5Q")]
    [DisplayName("Reception Date Time")]
    [IsoXmlTag("RcptnDtTm")]
    public IsoISODateTime? ReceptionDateTime { get; init; }
}
