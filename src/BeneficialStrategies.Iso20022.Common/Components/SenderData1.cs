// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the sender of the message.
/// </summary>
[IsoId("_g-kHQR7gEfCkq6-p7S3J1Q")]
[DisplayName("Sender Data1")]
public record SenderData1
{
    [IsoId("_g-kHRR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax11NumericText Identification { get; init; }

    [IsoId("_g-kHSR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Business Identification")]
    [IsoXmlTag("BizId")]
    public IsoMax15AlphaNumericText? BusinessIdentification { get; init; }

    [IsoId("_g-kHTR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    [IsoId("_g-kHUR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    [IsoId("_g-kHVR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    [IsoId("_g-kHWR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    [IsoId("_g-kHXR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_g-kHYR7gEfCkq6-p7S3J1Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    [IsoId("_g-kHZR7gEfCkq6-p7S3J1Q")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData20> LocalData { get; init; } = [];
}
