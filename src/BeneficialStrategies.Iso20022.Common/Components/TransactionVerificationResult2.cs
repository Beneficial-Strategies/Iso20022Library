// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the verifications performed by the issuer to deliver or decline the authorisation.
/// </summary>
[IsoId("_8MCksR2xEeKyZ4l838zwaQ")]
[DisplayName("Transaction Verification Result")]
public record TransactionVerificationResult2
{
    /// <summary>
    /// Result of an e-commerce authentication process.
    /// </summary>
    [IsoId("_8YFcoR2xEeKyZ4l838zwaQ")]
    [DisplayName("Electronic Commerce Authentication Result")]
    [IsoXmlTag("ElctrncComrcAuthntcnRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? ElectronicCommerceAuthenticationResult { get; init; }

    /// <summary>
    /// Result of the printed card security code (CSC) validation.
    /// </summary>
    [IsoId("_8YFcpR2xEeKyZ4l838zwaQ")]
    [DisplayName("CSC Result")]
    [IsoXmlTag("CSCRslt")]
    public CSCResult1Code? CSCResult { get; init; }

    /// <summary>
    /// Result of the cardholder verification address checks on the street number and the postal code.
    /// </summary>
    [IsoId("_8YFcqR2xEeKyZ4l838zwaQ")]
    [DisplayName("Cardholder Address Verification Result")]
    [IsoXmlTag("CrdhldrAdrVrfctnRslt")]
    public SimpleValueList<CardholderAddressVerificationResult1Code> CardholderAddressVerificationResult { get; init; } =
        [];

    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    [IsoId("_8YFcrR2xEeKyZ4l838zwaQ")]
    [DisplayName("Declined Product Code")]
    [IsoXmlTag("DclndPdctCd")]
    public SimpleValueList<IsoMax70Text> DeclinedProductCode { get; init; } = [];
}
