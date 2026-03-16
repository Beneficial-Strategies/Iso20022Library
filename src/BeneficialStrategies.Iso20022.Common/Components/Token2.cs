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
[IsoId("_vbKOYZF8EeukDPgU2BMkjQ")]
[DisplayName("Token")]
public record Token2
{
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_vhjxUZF8EeukDPgU2BMkjQ")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    public IsoMax19NumericText? PaymentToken { get; init; }

    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_vhjxU5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Expiry Date")]
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? TokenExpiryDate { get; init; }

    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_vhjxVZF8EeukDPgU2BMkjQ")]
    [DisplayName("Token Requestor Identification")]
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; }

    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_vhjxV5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Assurance Data")]
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? TokenAssuranceData { get; init; }

    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_vhjxWZF8EeukDPgU2BMkjQ")]
    [DisplayName("Token Assurance Method")]
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; }

    /// <summary>
    /// Original transaction was initiated by Token.
    /// </summary>
    [IsoId("_vhjxW5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Initiated Indicator")]
    [IsoXmlTag("TknInittdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; }

    /// <summary>
    /// Storage location of the token.
    /// </summary>
    [IsoId("_riI4cJx_EeuwYeL1lHu9zw")]
    [DisplayName("Storage Location")]
    [IsoXmlTag("StorgLctn")]
    public StorageLocation1Code? StorageLocation { get; init; }

    /// <summary>
    /// Other private or national storage location code.
    /// </summary>
    [IsoId("_RjZpEJyAEeuo7tDc4CDHXg")]
    [DisplayName("Other Storage Location")]
    [IsoXmlTag("OthrStorgLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherStorageLocation { get; init; }

    /// <summary>
    /// Method used to protect the token.
    /// </summary>
    [IsoId("_iCA7IJyBEeuo7tDc4CDHXg")]
    [DisplayName("Protection Method")]
    [IsoXmlTag("PrtcnMtd")]
    public ProtectionMethod1Code? ProtectionMethod { get; init; }

    /// <summary>
    /// Other national or private protection method code.
    /// </summary>
    [IsoId("_oN2LQJyBEeuo7tDc4CDHXg")]
    [DisplayName("Other Protection Method")]
    [IsoXmlTag("OthrPrtcnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherProtectionMethod { get; init; }

    /// <summary>
    /// Additional token data.
    /// </summary>
    [IsoId("_uAZ_wJyBEeuo7tDc4CDHXg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
