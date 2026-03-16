// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Data16.
/// </summary>
[IsoId("_mssGoZkPEe6Qpd-x8YgzaA")]
[DisplayName("Local Data16")]
public partial record LocalData16
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation22> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Cardholder Name.
    /// </summary>
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName2? CardholderName { get; init; } 

    /// <summary>
    /// Encoding Format.
    /// </summary>
    [DisplayName("Encoding Format")]
    [IsoXmlTag("NcodgFrmt")]
    public IsoMax35Text? EncodingFormat { get; init; } 

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; } 

    /// <summary>
    /// Mailed From Postal Code.
    /// </summary>
    [DisplayName("Mailed From Postal Code")]
    [IsoXmlTag("MldFrPstlCd")]
    public IsoMax35Text? MailedFromPostalCode { get; init; } 

    /// <summary>
    /// Mailing Address.
    /// </summary>
    [DisplayName("Mailing Address")]
    [IsoXmlTag("MlngAdr")]
    public LocalAddress1? MailingAddress { get; init; } 

    /// <summary>
    /// Mailing Address Unstructured.
    /// </summary>
    [DisplayName("Mailing Address Unstructured")]
    [IsoXmlTag("MlngAdrUstrd")]
    public IsoMax512Text? MailingAddressUnstructured { get; init; } 

    
    #nullable disable
    
}
