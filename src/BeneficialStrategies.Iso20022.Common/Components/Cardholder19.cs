// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the cardholder.
/// </summary>
[IsoId("__kNqIZ1EEeublrfU-wN95w")]
[DisplayName("Cardholder")]
public record Cardholder19
{
    /// <summary>
    /// Contains the registered cardholder name that issuer knows to be correct.
    /// </summary>
    [IsoId("__o_ccZ1EEeublrfU-wN95w")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public CardholderName3? CardholderName { get; init; }

    /// <summary>
    /// Identification of the cardholder.
    /// ISO 8583:87 bit 56 (TLV tag 03/dataset 73)
    /// ISO 8583:93 bit 112 (TLV tag 03/dataset 73)
    /// ISO 8583:2003 bit 51 (TLV tag 03/dataset 73)
    /// </summary>
    [IsoId("__o_cc51EEeublrfU-wN95w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Credentials2? Identification { get; init; }

    /// <summary>
    /// Complete address of the cardholder.
    /// </summary>
    [IsoId("__o_cdZ1EEeublrfU-wN95w")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Contact information.
    /// ISO 8583:87 bit 56 (TLV tag 02/dataset 72)
    /// ISO 8583:93 bit 112 (TLV tag 02/dataset 72)
    /// ISO 8583:2003 bit 51 (TLV tag 02/dataset 72)
    /// </summary>
    [IsoId("__o_cd51EEeublrfU-wN95w")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public Contact1? ContactInformation { get; init; }

    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("__o_ceZ1EEeublrfU-wN95w")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Identifies a cardholder that is a highly valued individual (e.g., Very Important Person).
    /// </summary>
    [IsoId("_VdeccJ1FEeublrfU-wN95w")]
    [DisplayName("High Value Customer Indicator")]
    [IsoXmlTag("HghValCstmrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? HighValueCustomerIndicator { get; init; }

    /// <summary>
    /// Additional cardholder data.
    /// </summary>
    [IsoId("_GL2qMMXOEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_zCvrUcXNEeumGdYElfgmbw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData7? LocalData { get; init; }
}
