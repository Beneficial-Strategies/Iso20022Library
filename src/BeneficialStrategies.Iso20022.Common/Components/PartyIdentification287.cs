// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification287.
/// </summary>
[IsoId("_5kDx4W9lEe6DxcrvCrq6hQ")]
[DisplayName("Party Identification287")]
public record PartyIdentification287
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
    /// Contact.
    /// </summary>
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal1? Contact { get; init; }

    /// <summary>
    /// Country Of Birth.
    /// </summary>
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public ISOMax3ACountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Credentials.
    /// </summary>
    [DisplayName("Credentials")]
    [IsoXmlTag("Crdntls")]
    public ValueList<Credentials3> Credentials { get; init; } = [];

    /// <summary>
    /// Date Of Birth.
    /// </summary>
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Designation.
    /// </summary>
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax2NumericText? Designation { get; init; }

    /// <summary>
    /// Financial Institution.
    /// </summary>
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution8? FinancialInstitution { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData15? LocalData { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName3? Name { get; init; }

    /// <summary>
    /// Nationality.
    /// </summary>
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public ISOMax3ACountryCode? Nationality { get; init; }
}
