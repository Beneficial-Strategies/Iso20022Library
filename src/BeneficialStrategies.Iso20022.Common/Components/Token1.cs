// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unencrypted sensitive data of a token.
/// </summary>
[IsoId("_aMY2QEaoEeeIjf8aP9KbJA")]
[DisplayName("Token")]
public record Token1
{
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_AGbkkEapEeeIjf8aP9KbJA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PaymentToken { get; init; }

    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_aGyjMfGoEeiGNursv3uE_g")]
    [DisplayName("Token Expiry Date")]
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? TokenExpiryDate { get; init; }

    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_ZQAboEaqEeeIjf8aP9KbJA")]
    [DisplayName("Token Requestor Identification")]
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; }

    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_iTVdUEaqEeeIjf8aP9KbJA")]
    [DisplayName("Token Assurance Data")]
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TokenAssuranceData { get; init; }

    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_z4Zf8sR0EeeA1oP8xzmLQg")]
    [DisplayName("Token Assurance Method")]
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; }

    /// <summary>
    /// Original transaction was initiated by Token.
    /// </summary>
    [IsoId("_aGpUsJKHEempjNUC7bi_Ng")]
    [DisplayName("Token Initiated Indicator")]
    [IsoXmlTag("TknInittdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; }
}
