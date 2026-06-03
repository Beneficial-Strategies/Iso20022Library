// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acquirer.
/// </summary>
[IsoId("_KqlEoR7cEfCkq6-p7S3J1Q")]
[DisplayName("Originator Data2")]
public record OriginatorData2
{
    /// <summary>
    /// Identification of the originator.
    /// </summary>
    [IsoId("_Kxb6kR7cEfCkq6-p7S3J1Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    /// <summary>
    /// Business or client identification for the originator.
    /// </summary>
    [IsoId("_Kxb6mR7cEfCkq6-p7S3J1Q")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    /// <summary>
    /// Country of the originator.
    /// </summary>
    [IsoId("_Kxb6mx7cEfCkq6-p7S3J1Q")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Business name of the originator.
    /// </summary>
    [IsoId("_Kxb6nR7cEfCkq6-p7S3J1Q")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the originator.
    /// </summary>
    [IsoId("_Kxb6nx7cEfCkq6-p7S3J1Q")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_43O3dx7eEfCkq6-p7S3J1Q")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_Q7k9UkVXEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Q7k9U0VXEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_Kxb6ox7cEfCkq6-p7S3J1Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
