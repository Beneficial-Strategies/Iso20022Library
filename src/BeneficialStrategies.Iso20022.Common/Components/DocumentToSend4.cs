// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of document and the type of communication method to be used to notify a party.
/// </summary>
[IsoId("_y2mIcZTFEemqYPWMBuVawg")]
[DisplayName("Document To Send")]
public record DocumentToSend4
{
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_zKhxEZTFEemqYPWMBuVawg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Type { get; init; }

    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    [IsoId("_zKhxE5TFEemqYPWMBuVawg")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required PartyIdentification125Choice_ Recipient { get; init; }

    /// <summary>
    /// Communication method to be used.
    /// </summary>
    [IsoId("_zKhxFZTFEemqYPWMBuVawg")]
    [DisplayName("Method Of Transmission")]
    [IsoXmlTag("MtdOfTrnsmssn")]
    public required CommunicationMethod3Choice_ MethodOfTransmission { get; init; }
}
