// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by an organisation, to unambiguously identify a party.
/// </summary>
[IsoId("_ynQ8AEkIEeaOe8w0NJ11wQ")]
[DisplayName("Party Identification")]
public record PartyIdentification116
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_HxZ-gEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required OrganisationIdentification28 PartyIdentification { get; init; }

    /// <summary>
    /// Identifier and name of an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_5D82IEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation1? LegalOrganisation { get; init; }

    /// <summary>
    /// TaxParty.
    /// </summary>
    [IsoId("_-F1boEkJEeaOe8w0NJ11wQ")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public TaxParty1? TaxParty { get; init; }
}
