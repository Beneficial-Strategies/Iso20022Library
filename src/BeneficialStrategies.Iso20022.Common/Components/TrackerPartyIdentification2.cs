// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of a person or an organisation or a financial institution in the tracker.
/// </summary>
[IsoId("_qEoGKGOSEeq5Ar_w98FvsA")]
[DisplayName("Tracker Party Identification")]
public record TrackerPartyIdentification2
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_qEoGKmOSEeq5Ar_w98FvsA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_qEoGLmOSEeq5Ar_w98FvsA")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress24? PostalAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of a party.
    /// </summary>
    [IsoId("_qEoGK2OSEeq5Ar_w98FvsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public TrackerParty2Choice_? Identification { get; init; }
}
