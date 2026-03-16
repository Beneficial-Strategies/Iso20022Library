// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel Agency4.
/// </summary>
[IsoId("_R_K-QXQ6Ee6Y1uOeeiF_Eg")]
[DisplayName("Travel Agency4")]
public record TravelAgency4
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax35Text? Code { get; init; }

    /// <summary>
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactBusiness1? Contact { get; init; }

    /// <summary>
    /// IATA Code.
    /// </summary>
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    public IsoMax35Text? IATACode { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Travel Package.
    /// </summary>
    [DisplayName("Travel Package")]
    [IsoXmlTag("TrvlPackg")]
    public ValueList<TravelAgencyPackage2> TravelPackage { get; init; } = [];
}
