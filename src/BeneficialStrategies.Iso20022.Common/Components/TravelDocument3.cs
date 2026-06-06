// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of travel document used for identification and/or authentication of the customer.
/// </summary>
[IsoId("_CkD_QVN7EfC0lMwgjvMClw")]
[DisplayName("Travel Document3")]
public record TravelDocument3
{
    /// <summary>
    /// Type of travel document. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_Cmg2UVN7EfC0lMwgjvMClw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OfficialDocumentType2Code Type { get; init; }

    /// <summary>
    /// Form of travel document.
    /// </summary>
    [IsoId("_Cmg2U1N7EfC0lMwgjvMClw")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; }

    /// <summary>
    /// Identification of travel document (for example, passport number).
    /// </summary>
    [IsoId("_Cmg2VVN7EfC0lMwgjvMClw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Party assigning the travel document.
    /// </summary>
    [IsoId("_Cmg2V1N7EfC0lMwgjvMClw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax70Text? Assigner { get; init; }

    /// <summary>
    /// Issuance date of travel document.
    /// </summary>
    [IsoId("_Cmg2WVN7EfC0lMwgjvMClw")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    public IsoISODate? IssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of travel document (if and when relevant).
    /// </summary>
    [IsoId("_Cmg2W1N7EfC0lMwgjvMClw")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the travel document.
    /// </summary>
    [IsoId("_Cmg2XVN7EfC0lMwgjvMClw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }
}
