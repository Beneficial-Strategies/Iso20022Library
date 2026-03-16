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
[IsoId("_SxbqoAEcEeCQm6a_G2yO_w_1847653135")]
[DisplayName("Transaction Verification Result")]
public record TransactionVerificationResult1
{
    /// <summary>
    /// Result of an e-commerce authentication process.
    /// </summary>
    [IsoId("_SxbqoQEcEeCQm6a_G2yO_w_1653552840")]
    [DisplayName("Electronic Commerce Authentication Result")]
    [IsoXmlTag("ElctrncComrcAuthntcnRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? ElectronicCommerceAuthenticationResult { get; init; }

    /// <summary>
    /// Result of the printed card security code (CSC) validation.
    /// </summary>
    [IsoId("_SxbqogEcEeCQm6a_G2yO_w_742112884")]
    [DisplayName("CSC Result")]
    [IsoXmlTag("CSCRslt")]
    public CSCResult1Code? CSCResult { get; init; }

    /// <summary>
    /// Result of the cardholder verification address checks on the street number and the postal code.
    /// </summary>
    [IsoId("_SxbqowEcEeCQm6a_G2yO_w_-2003718026")]
    [DisplayName("Cardholder Address Verification Result")]
    [IsoXmlTag("CrdhldrAdrVrfctnRslt")]
    public CardholderAddressVerificationResult1Code? CardholderAddressVerificationResult { get; init; }

    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    [IsoId("_SxbqpAEcEeCQm6a_G2yO_w_2039129918")]
    [DisplayName("Declined Product Code")]
    [IsoXmlTag("DclndPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? DeclinedProductCode { get; init; }
}
