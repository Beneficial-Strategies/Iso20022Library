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
[IsoId("_6HlzcRUXEfC_aaedwHHlmw")]
[DisplayName("Acquirer Data1")]
public record AcquirerData1
{
    /// <summary>
    /// Identification of the Acquirer.
    /// </summary>
    [IsoId("_6O-N0RUXEfC_aaedwHHlmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    /// <summary>
    /// Business or client identification for the acquirer.
    /// </summary>
    [IsoId("_N_kqgBUYEfC_aaedwHHlmw")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    /// <summary>
    /// Country of the acquirer.
    /// </summary>
    [IsoId("_6O-N2xUXEfC_aaedwHHlmw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Business name of the acquirer.
    /// </summary>
    [IsoId("_6O-N3RUXEfC_aaedwHHlmw")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the acquirer.
    /// </summary>
    [IsoId("_6O-N3xUXEfC_aaedwHHlmw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Address of the acquirer.
    /// </summary>
    [IsoId("_uFcTZx7fEfCkq6-p7S3J1Q")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_VlS6ckVXEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_VlS6c0VXEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_6O-N4xUXEfC_aaedwHHlmw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
