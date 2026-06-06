// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel agency component provides details of travel agency, airline, or railway transactions.
/// </summary>
[IsoId("_670H4UhrEfCMZJtj4J7UGQ")]
[DisplayName("Travel Agency5")]
public record TravelAgency5
{
    /// <summary>
    /// Contains an agency code or name.
    /// </summary>
    [IsoId("_6-irwUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax35Text? Code { get; init; }

    /// <summary>
    /// Assigner of the agency code.
    /// </summary>
    [IsoId("_6-irw0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Contains the International Air Transport Association (IATA) code identifying the company that purchased the ticket.
    /// </summary>
    [IsoId("_6-irxUhrEfCMZJtj4J7UGQ")]
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    public IsoMax35Text? IATACode { get; init; }

    /// <summary>
    /// Name of the travel agency.
    /// </summary>
    [IsoId("_6-irx0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Short name of the travel agency.
    /// </summary>
    [IsoId("_6-iryUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Address of the travel agency.
    /// </summary>
    [IsoId("_6-iry0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Contact information related to the travel agency.
    /// </summary>
    [IsoId("_6-irzUhrEfCMZJtj4J7UGQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactBusiness2? Contact { get; init; }

    /// <summary>
    /// Provides detailed information about the travel package, excluding specific itinerary data.
    /// </summary>
    [IsoId("_6-irz0hrEfCMZJtj4J7UGQ")]
    [DisplayName("Travel Package")]
    [IsoXmlTag("TrvlPackg")]
    public ValueList<TravelAgencyPackage2> TravelPackage { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_tETlgkhrEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_tETlg0hrEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
