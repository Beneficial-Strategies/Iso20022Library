// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_5raDnfM0Eei4qfiLgRIZBA")]
[DisplayName("Party Identification")]
public record PartyIdentification206
{
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_5raDn_M0Eei4qfiLgRIZBA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <summary>
    /// Identification of the customer.
    /// </summary>
    [IsoId("_5raDqPM0Eei4qfiLgRIZBA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification197? Identification { get; init; }

    /// <summary>
    /// Address of the customer.
    /// </summary>
    [IsoId("_5raDoPM0Eei4qfiLgRIZBA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_5raDpfM0Eei4qfiLgRIZBA")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact3? Contact { get; init; }

    /// <summary>
    /// Identification of the customer recognized by the taxation authority.
    /// </summary>
    [IsoId("_5raDqfM0Eei4qfiLgRIZBA")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Additional information about the seller.
    /// </summary>
    [IsoId("_5raDovM0Eei4qfiLgRIZBA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? AdditionalInformation { get; init; }
}
