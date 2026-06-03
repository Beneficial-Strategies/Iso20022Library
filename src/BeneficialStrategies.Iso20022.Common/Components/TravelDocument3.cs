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
    [IsoId("_Cmg2UVN7EfC0lMwgjvMClw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required OfficialDocumentType2Code Type { get; init; }

    [IsoId("_Cmg2U1N7EfC0lMwgjvMClw")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; }

    [IsoId("_Cmg2VVN7EfC0lMwgjvMClw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax70Text Identification { get; init; }

    [IsoId("_Cmg2V1N7EfC0lMwgjvMClw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax70Text? Assigner { get; init; }

    [IsoId("_Cmg2WVN7EfC0lMwgjvMClw")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    public IsoISODate? IssuanceDate { get; init; }

    [IsoId("_Cmg2W1N7EfC0lMwgjvMClw")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public IsoISODate? ExpirationDate { get; init; }

    [IsoId("_Cmg2XVN7EfC0lMwgjvMClw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }
}
