// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer.
/// </summary>
[IsoId("_e7TtMVNxEfC0lMwgjvMClw")]
[DisplayName("Customer10")]
public record Customer10
{
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_e-WaIVNxEfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_eC0Jg1NyEfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_eC0JhFNyEfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_eC0JhVNyEfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Details of the party identification.
    /// </summary>
    [IsoId("_e-WaI1NxEfC0lMwgjvMClw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Credentials3? Identification { get; init; }

    /// <summary>
    /// Number or code assigned by an airline, company or other party to track or uniquely identify a person, department or project.
    /// </summary>
    [IsoId("_e-WaJVNxEfC0lMwgjvMClw")]
    [DisplayName("Customer File Reference Number")]
    [IsoXmlTag("CstmrFileRefNb")]
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; }

    /// <summary>
    /// Age of the customer.
    /// </summary>
    [IsoId("_e-WaJ1NxEfC0lMwgjvMClw")]
    [DisplayName("Age")]
    [IsoXmlTag("Age")]
    public IsoMax2NumericText? Age { get; init; }

    /// <summary>
    /// Address details of the customer.
    /// </summary>
    [IsoId("_e-WaKVNxEfC0lMwgjvMClw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_e-WaK1NxEfC0lMwgjvMClw")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal2? Contact { get; init; }
}
