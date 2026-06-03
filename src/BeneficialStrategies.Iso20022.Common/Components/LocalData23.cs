// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
[IsoId("_kKVjEXR8EfC68Y4jZPNEug")]
[DisplayName("Local Data23")]
public record LocalData23
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_kM1dcXR8EfC68Y4jZPNEug")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_kM1dc3R8EfC68Y4jZPNEug")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of where the card was mailed to.
    /// </summary>
    [IsoId("_kM1ddXR8EfC68Y4jZPNEug")]
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public LocalAddress1? MailingAddress { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the unstructured mailing address where the card was mailed to.
    /// </summary>
    [IsoId("_kM1dd3R8EfC68Y4jZPNEug")]
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    public IsoMax512Text? MailingAddressUnstructured { get; init; }

    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the postal code where the card was mailed from.
    /// </summary>
    [IsoId("_kM1deXR8EfC68Y4jZPNEug")]
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    public IsoMax35Text? MailedFromPostalCode { get; init; }

    /// <summary>
    /// Local language equivalent of the cardholder name.
    /// </summary>
    [IsoId("_kM1de3R8EfC68Y4jZPNEug")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName2? CardholderName { get; init; }

    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_kM1dfXR8EfC68Y4jZPNEug")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoATICALaxProcessing> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_1nxDQnR8EfC68Y4jZPNEug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_1nxDQ3R8EfC68Y4jZPNEug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
