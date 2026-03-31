// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_pburgQVKEeq4ZaI1b_-GPA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount194
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_pvXZMwVKEeq4ZaI1b_-GPA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification123Choice_ Identification { get; init; }

    /// <summary>
    /// Legal Entity Identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_pvXZOwVKEeq4ZaI1b_-GPA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for the party.
    /// </summary>
    [IsoId("_pvXZPQVKEeq4ZaI1b_-GPA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [IsoId("_pvXZRQVKEeq4ZaI1b_-GPA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_pvXZTQVKEeq4ZaI1b_-GPA")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_pvXZVQVKEeq4ZaI1b_-GPA")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Additional information about the party.
    /// </summary>
    [IsoId("_pvXZXQVKEeq4ZaI1b_-GPA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation6? AdditionalInformation { get; init; }
}
