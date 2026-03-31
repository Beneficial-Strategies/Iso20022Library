// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation Identification49.
/// </summary>
[IsoId("_Yxi7seJJEe-5wchdE0oJYw")]
[DisplayName("Organisation Identification49")]
public record OrganisationIdentification49
{
    /// <summary>
    /// Alternate Organisation Identification.
    /// </summary>
    [DisplayName("Alternate Organisation Identification")]
    [IsoXmlTag("AltrnOrgId")]
    public ValueList<GenericOrganisationIdentification3> AlternateOrganisationIdentification { get; init; } =
        [];

    /// <summary>
    /// Entity Size.
    /// </summary>
    [DisplayName("Entity Size")]
    [IsoXmlTag("NttySz")]
    public ExternalEntitySize1Code? EntitySize { get; init; }

    /// <summary>
    /// Entity Type.
    /// </summary>
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public ExternalEntityType1Code? EntityType { get; init; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// NPI.
    /// </summary>
    [DisplayName("NPI")]
    [IsoXmlTag("NPI")]
    public IsoNPIIdentifier? NPI { get; init; }

    /// <summary>
    /// Organisation Name.
    /// </summary>
    [DisplayName("Organisation Name")]
    [IsoXmlTag("OrgNm")]
    public ValueList<PartyName5> OrganisationName { get; init; } = [];

    /// <summary>
    /// Person Name.
    /// </summary>
    [DisplayName("Person Name")]
    [IsoXmlTag("PrsnNm")]
    public ValueList<IsoMax500Text> PersonName { get; init; } = [];

    /// <summary>
    /// Registered Country.
    /// </summary>
    [DisplayName("Registered Country")]
    [IsoXmlTag("RegdCtry")]
    public CountryCode? RegisteredCountry { get; init; }

    /// <summary>
    /// Sector.
    /// </summary>
    [DisplayName("Sector")]
    [IsoXmlTag("Sctr")]
    public ValueList<IndustrySector3Choice_> Sector { get; init; } = [];
}
