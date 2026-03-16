// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unprotected sensitive detailed information about the cardholder.
/// </summary>
[IsoId("_91eHMEarEeeIjf8aP9KbJA")]
[DisplayName("Cardholder")]
public record Cardholder15
{
    /// <summary>
    /// Contains the registered cardholder name that issuer knows to be correct.
    /// </summary>
    [IsoId("_Ozg8sEasEeeIjf8aP9KbJA")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName1? CardholderName { get; init; }

    /// <summary>
    /// Identification of the cardholder.
    /// ISO 8583:87 bit 56 (TLV tag 03/dataset 73)
    /// ISO 8583:93 bit 112 (TLV tag 03/dataset 73)
    /// ISO 8583:2003 bit 51 (TLV tag 03/dataset 73)
    /// </summary>
    [IsoId("_Wy6cMEasEeeIjf8aP9KbJA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Credentials1? Identification { get; init; }

    /// <summary>
    /// Complete address of the cardholder.
    /// </summary>
    [IsoId("_mALlsEauEeeIjf8aP9KbJA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address1? Address { get; init; }

    /// <summary>
    /// Contact information.
    /// ISO 8583:87 bit 56 (TLV tag 02/dataset 72)
    /// ISO 8583:93 bit 112 (TLV tag 02/dataset 72)
    /// ISO 8583:2003 bit 51 (TLV tag 02/dataset 72)
    /// </summary>
    [IsoId("_VXD3MJjHEeeMBq7G6mQ32Q")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public Contact1? ContactInformation { get; init; }

    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("_ZM4VARqYEeqH1IQNpbVpEw")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }
}
