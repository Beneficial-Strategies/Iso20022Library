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
[IsoId("_UwhqMa9FEfCwC48u9hnlfA")]
[DisplayName("Local Data24")]
public record LocalData24
{
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_UyicYa9FEfCwC48u9hnlfA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; }

    /// <summary>
    /// Data encoding format for local data.
    /// </summary>
    [IsoId("_UyicY69FEfCwC48u9hnlfA")]
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; }

    /// <summary>
    /// Name of the financial customer in the local language.
    /// </summary>
    [IsoId("_UyicZa9FEfCwC48u9hnlfA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName2? Name { get; init; }

    /// <summary>
    /// Alias name of the customer in local language.
    /// </summary>
    [IsoId("_UyicZ69FEfCwC48u9hnlfA")]
    [DisplayName("Alias Name")]
    [IsoXmlTag("AliasNm")]
    public IsoMax140Text? AliasName { get; init; }

    /// <summary>
    /// Occupation of the customer in local language.
    /// </summary>
    [IsoId("_Uyicaa9FEfCwC48u9hnlfA")]
    [DisplayName("Occupation")]
    [IsoXmlTag("Ocptn")]
    public IsoMax70Text? Occupation { get; init; }

    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_Uyica69FEfCwC48u9hnlfA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public LocalAddress2? Address { get; init; }

    /// <summary>
    /// Complete shipping address of the cardholder.
    /// </summary>
    [IsoId("_Uyicba9FEfCwC48u9hnlfA")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public ValueList<LocalAddress1> ShippingAddress { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_Uyicb69FEfCwC48u9hnlfA")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Uyicca9FEfCwC48u9hnlfA")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
