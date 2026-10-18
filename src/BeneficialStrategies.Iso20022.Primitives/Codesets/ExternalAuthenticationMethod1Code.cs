// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the authentication method used, as published separately in an external authentication method code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_746_oCxIEeyg-aG5nXcnfg")]
[Description(@"Specifies the authentication method used, as published separately in an external authentication method code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalAuthenticationMethod1Code>))]
public readonly struct ExternalAuthenticationMethod1Code : IIsoExternalCode, IEquatable<ExternalAuthenticationMethod1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given authentication method code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalAuthenticationMethod1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalAuthenticationMethod1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalAuthenticationMethod1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalAuthenticationMethod1Code"/>.</summary>
    public static implicit operator ExternalAuthenticationMethod1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalAuthenticationMethod1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalAuthenticationMethod1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalAuthenticationMethod1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalAuthenticationMethod1Code a, ExternalAuthenticationMethod1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalAuthenticationMethod1Code a, ExternalAuthenticationMethod1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalAuthenticationMethod1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalAuthenticationMethod1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalAuthenticationMethod1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalAuthenticationMethod1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Serial Number of the acceptor's certificate.</summary>
    [IsoId("_w_NQIbJSEe-rYMhHpAEI4A")]
    [Description(@"Serial Number of the acceptor's certificate.")]
    public static readonly ExternalAuthenticationMethod1Code AcceptorCertificateSerialNumber = new("ACSN");

    /// <summary>Cardholder billing address.</summary>
    [IsoId("_w_NQI7JSEe-rYMhHpAEI4A")]
    [Description(@"Cardholder billing address.")]
    public static readonly ExternalAuthenticationMethod1Code BillingAddress = new("ADDB");

    /// <summary>Shipping address.</summary>
    [IsoId("_w_NQJbJSEe-rYMhHpAEI4A")]
    [Description(@"Shipping address.")]
    public static readonly ExternalAuthenticationMethod1Code ShippingAddress = new("ADDS");

    /// <summary>Account-based digital signature authentication.</summary>
    [IsoId("_w_NQJ7JSEe-rYMhHpAEI4A")]
    [Description(@"Account-based digital signature authentication.")]
    public static readonly ExternalAuthenticationMethod1Code AccountDigitalSignature = new("APKI");

    /// <summary>Number assigned by a government agency to identify foreign nationals.</summary>
    [IsoId("_w_NQKbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    public static readonly ExternalAuthenticationMethod1Code AlienRegistrationNumber = new("ARNB");

    /// <summary>Response Card Cryptogram (ARPC) verification.</summary>
    [IsoId("_w_NQK7JSEe-rYMhHpAEI4A")]
    [Description(@"Response Card Cryptogram (ARPC) verification.")]
    public static readonly ExternalAuthenticationMethod1Code ARPC = new("ARPC");

    /// <summary>Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).</summary>
    [IsoId("_w_NQLbJSEe-rYMhHpAEI4A")]
    [Description(@"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).")]
    public static readonly ExternalAuthenticationMethod1Code ARQC = new("ARQC");

    /// <summary>Application Transaction Counter.</summary>
    [IsoId("_w_NQL7JSEe-rYMhHpAEI4A")]
    [Description(@"Application Transaction Counter.")]
    public static readonly ExternalAuthenticationMethod1Code ATC = new("ATCC");

    /// <summary>A value is used to verify an already performed authentication, used for non ThreeDS related authentication.</summary>
    [IsoId("_w_PFVbJSEe-rYMhHpAEI4A")]
    [Description(@"A value is used to verify an already performed authentication, used for non ThreeDS related authentication.")]
    public static readonly ExternalAuthenticationMethod1Code AuthenticationValue = new("AUVA");

    /// <summary>Biometric authentication of the cardholder.</summary>
    [IsoId("_w_NQMbJSEe-rYMhHpAEI4A")]
    [Description(@"Biometric authentication of the cardholder.")]
    public static readonly ExternalAuthenticationMethod1Code Biometry = new("BIOM");

    /// <summary>Date of birth of a person.</summary>
    [IsoId("_w_NQM7JSEe-rYMhHpAEI4A")]
    [Description(@"Date of birth of a person.")]
    public static readonly ExternalAuthenticationMethod1Code BirthDate = new("BTHD");

    /// <summary>Consumer Device Cardholder Verification Method.</summary>
    [IsoId("_w_NQNbJSEe-rYMhHpAEI4A")]
    [Description(@"Consumer Device Cardholder Verification Method.")]
    public static readonly ExternalAuthenticationMethod1Code CDCVM = new("CDCM");

    /// <summary>Cardholder data provided for verification.</summary>
    [IsoId("_w_N3MbJSEe-rYMhHpAEI4A")]
    [Description(@"Cardholder data provided for verification.")]
    public static readonly ExternalAuthenticationMethod1Code CardholderIdentificationData = new("CDHI");

    /// <summary>Name of cardholder.</summary>
    [IsoId("_w_N3M7JSEe-rYMhHpAEI4A")]
    [Description(@"Name of cardholder.")]
    public static readonly ExternalAuthenticationMethod1Code CardholderName = new("CHDN");

    /// <summary>Cardholder address.</summary>
    [IsoId("_w_N3NbJSEe-rYMhHpAEI4A")]
    [Description(@"Cardholder address.")]
    public static readonly ExternalAuthenticationMethod1Code CardholderAddress = new("CHSA");

    /// <summary>Serial Number of the cardholder's certificate.</summary>
    [IsoId("_w_N3N7JSEe-rYMhHpAEI4A")]
    [Description(@"Serial Number of the cardholder's certificate.")]
    public static readonly ExternalAuthenticationMethod1Code CardholderCertificateSerialNumber = new("CHSN");

    /// <summary>Registration number of a company.</summary>
    [IsoId("_w_PFYbJSEe-rYMhHpAEI4A")]
    [Description(@"Registration number of a company.")]
    public static readonly ExternalAuthenticationMethod1Code CompanyRegistrationNumber = new("CPNY");

    /// <summary>Electronic signature capture (handwritten signature).</summary>
    [IsoId("_w_N3ObJSEe-rYMhHpAEI4A")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    public static readonly ExternalAuthenticationMethod1Code SignatureCapture = new("CPSG");

    /// <summary>Verification of Card Security Code.</summary>
    [IsoId("_w_N3O7JSEe-rYMhHpAEI4A")]
    [Description(@"Verification of Card Security Code.")]
    public static readonly ExternalAuthenticationMethod1Code CSCVerification = new("CSCV");

    /// <summary>Authentication performed during a secure electronic commerce transaction.</summary>
    [IsoId("_w_N3PbJSEe-rYMhHpAEI4A")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    public static readonly ExternalAuthenticationMethod1Code SecureElectronicCommerce = new("CSEC");

    /// <summary>Customer number used as a mechanism of authentication.</summary>
    [IsoId("_w_N3P7JSEe-rYMhHpAEI4A")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    public static readonly ExternalAuthenticationMethod1Code CustomerIdentification = new("CUID");

    /// <summary>Number assigned by a driving license authority to a person.</summary>
    [IsoId("_w_N3QbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a driving license authority to a person.")]
    public static readonly ExternalAuthenticationMethod1Code DriverLicenseNumber = new("DRID");

    /// <summary>Identification of a driver in a fleet of vehicles.</summary>
    [IsoId("_w_N3Q7JSEe-rYMhHpAEI4A")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    public static readonly ExternalAuthenticationMethod1Code DriverIdentification = new("DRVI");

    /// <summary>Electronic mail address.</summary>
    [IsoId("_w_N3RbJSEe-rYMhHpAEI4A")]
    [Description(@"Electronic mail address.")]
    public static readonly ExternalAuthenticationMethod1Code Email = new("EMAL");

    /// <summary>Number assigned to an employee by an employer.</summary>
    [IsoId("_w_N3R7JSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned to an employee by an employer.")]
    public static readonly ExternalAuthenticationMethod1Code EmployeeIdentificationNumber = new("EMIN");

    /// <summary>Number assigned to an employer by a registration authority.</summary>
    [IsoId("_w_N3SbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    public static readonly ExternalAuthenticationMethod1Code EmployerIdentificationNumber = new("EMRN");

    /// <summary>Biographics authentication in an offline mode.</summary>
    [IsoId("_w_N3S7JSEe-rYMhHpAEI4A")]
    [Description(@"Biographics authentication in an offline mode.")]
    public static readonly ExternalAuthenticationMethod1Code OffLineBiographics = new("FBIG");

    /// <summary>Biometrics authentication in an offline mode.</summary>
    [IsoId("_w_N3TbJSEe-rYMhHpAEI4A")]
    [Description(@"Biometrics authentication in an offline mode.")]
    public static readonly ExternalAuthenticationMethod1Code OffLineBiometrics = new("FBIO");

    /// <summary>PIN generated offline and transmitted in clear</summary>
    [IsoId("_w_N3T7JSEe-rYMhHpAEI4A")]
    [Description(@"PIN generated offline and transmitted in clear")]
    public static readonly ExternalAuthenticationMethod1Code OffLinePINInClear = new("FCPN");

    /// <summary>Off-line PIN authentication (Personal Identification Number).</summary>
    [IsoId("_w_N3UbJSEe-rYMhHpAEI4A")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    public static readonly ExternalAuthenticationMethod1Code OfflinePIN = new("FPIN");

    /// <summary>Number assigned by a national authority to an identity card.</summary>
    [IsoId("_w_N3U7JSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    public static readonly ExternalAuthenticationMethod1Code IdentityCardNumber = new("IDCN");

    /// <summary>Identification of law enforcement.</summary>
    [IsoId("_w_PFW7JSEe-rYMhHpAEI4A")]
    [Description(@"Identification of law enforcement.")]
    public static readonly ExternalAuthenticationMethod1Code LawEnforcementIdentification = new("LAWE");

    /// <summary>Manual verification, for example passport or drivers license.</summary>
    [IsoId("_w_N3VbJSEe-rYMhHpAEI4A")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    public static readonly ExternalAuthenticationMethod1Code ManualVerification = new("MANU");

    /// <summary>Identification of military.</summary>
    [IsoId("_w_PFXbJSEe-rYMhHpAEI4A")]
    [Description(@"Identification of military.")]
    public static readonly ExternalAuthenticationMethod1Code MilitaryIdentification = new("MILI");

    /// <summary>Customer mobile phone number.</summary>
    [IsoId("_w_N3V7JSEe-rYMhHpAEI4A")]
    [Description(@"Customer mobile phone number.")]
    public static readonly ExternalAuthenticationMethod1Code PhoneMobile = new("MOBL");

    /// <summary>Biographics authentication in an online mode.</summary>
    [IsoId("_w_N3WbJSEe-rYMhHpAEI4A")]
    [Description(@"Biographics authentication in an online mode.")]
    public static readonly ExternalAuthenticationMethod1Code OnLineBiographics = new("NBIG");

    /// <summary>On-line PIN authentication (Personal Identification Number).</summary>
    [IsoId("_w_OeQbJSEe-rYMhHpAEI4A")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    public static readonly ExternalAuthenticationMethod1Code OnLinePIN = new("NPIN");

    /// <summary>National Identifier.</summary>
    [IsoId("_w_OeQ7JSEe-rYMhHpAEI4A")]
    [Description(@"National Identifier.")]
    public static readonly ExternalAuthenticationMethod1Code NationalIdentifer = new("NTID");

    /// <summary>Non visible Card Security Code.</summary>
    [IsoId("_w_OeRbJSEe-rYMhHpAEI4A")]
    [Description(@"Non visible Card Security Code.")]
    public static readonly ExternalAuthenticationMethod1Code NonVisibleCSC = new("NVSC");

    /// <summary>Other cardholder data provided for identification.</summary>
    [IsoId("_w_OeR7JSEe-rYMhHpAEI4A")]
    [Description(@"Other cardholder data provided for identification.")]
    public static readonly ExternalAuthenticationMethod1Code OtherCardholderIdentification = new("OCHI");

    /// <summary>PIN generated offline and transmitted encrypted.</summary>
    [IsoId("_w_OeSbJSEe-rYMhHpAEI4A")]
    [Description(@"PIN generated offline and transmitted encrypted.")]
    public static readonly ExternalAuthenticationMethod1Code OffLinePINEncrypted = new("OFPE");

    /// <summary>Authentication of data in an offline mode.</summary>
    [IsoId("_w_OeS7JSEe-rYMhHpAEI4A")]
    [Description(@"Authentication of data in an offline mode.")]
    public static readonly ExternalAuthenticationMethod1Code OffLineDataAuthentication = new("OLDA");

    /// <summary>Analysis of signature transmitted offline.</summary>
    [IsoId("_w_OeTbJSEe-rYMhHpAEI4A")]
    [Description(@"Analysis of signature transmitted offline.")]
    public static readonly ExternalAuthenticationMethod1Code OffLineDigitisedSignatureAnalysis = new("OLDS");

    /// <summary>Other type of verification defined at national level.</summary>
    [IsoId("_w_OeT7JSEe-rYMhHpAEI4A")]
    [Description(@"Other type of verification defined at national level.")]
    public static readonly ExternalAuthenticationMethod1Code OtherNational = new("OTHN");

    /// <summary>Other type of verification defined at private level.</summary>
    [IsoId("_w_OeUbJSEe-rYMhHpAEI4A")]
    [Description(@"Other type of verification defined at private level.")]
    public static readonly ExternalAuthenticationMethod1Code OtherPrivate = new("OTHP");

    /// <summary>Verification of a one-time password provided by the issuer.</summary>
    [IsoId("_w_OeU7JSEe-rYMhHpAEI4A")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    public static readonly ExternalAuthenticationMethod1Code OneTimePassword = new("OTPW");

    /// <summary>Number assigned by a passport authority to a passport.</summary>
    [IsoId("_w_OeVbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    public static readonly ExternalAuthenticationMethod1Code PassportNumber = new("PASS");

    /// <summary>Verification based on digits of the postal code.</summary>
    [IsoId("_w_OeV7JSEe-rYMhHpAEI4A")]
    [Description(@"Verification based on digits of the postal code.")]
    public static readonly ExternalAuthenticationMethod1Code PostalCode = new("PCDV");

    /// <summary>Generical phone number.</summary>
    [IsoId("_w_OeW7JSEe-rYMhHpAEI4A")]
    [Description(@"Generical phone number.")]
    public static readonly ExternalAuthenticationMethod1Code PhoneNumber = new("PHNB");

    /// <summary>Customer home phone number.</summary>
    [IsoId("_w_OeWbJSEe-rYMhHpAEI4A")]
    [Description(@"Customer home phone number.")]
    public static readonly ExternalAuthenticationMethod1Code PhoneHome = new("PHOM");

    /// <summary>PKI (Public Key Infrastructure) based digital signature.</summary>
    [IsoId("_w_OeXbJSEe-rYMhHpAEI4A")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    public static readonly ExternalAuthenticationMethod1Code PKISignature = new("PKIS");

    /// <summary>Place of birth of a person.</summary>
    [IsoId("_w_OeX7JSEe-rYMhHpAEI4A")]
    [Description(@"Place of birth of a person.")]
    public static readonly ExternalAuthenticationMethod1Code PlaceOfBirth = new("PLOB");

    /// <summary>Handwritten paper signature.</summary>
    [IsoId("_w_OeYbJSEe-rYMhHpAEI4A")]
    [Description(@"Handwritten paper signature.")]
    public static readonly ExternalAuthenticationMethod1Code PaperSignature = new("PPSG");

    /// <summary>Proxy.</summary>
    [IsoId("_w_OeY7JSEe-rYMhHpAEI4A")]
    [Description(@"Proxy.")]
    public static readonly ExternalAuthenticationMethod1Code Proxy = new("PRXY");

    /// <summary>Authentication by a passcode.</summary>
    [IsoId("_w_OeZbJSEe-rYMhHpAEI4A")]
    [Description(@"Authentication by a passcode.")]
    public static readonly ExternalAuthenticationMethod1Code Passcode = new("PSCD");

    /// <summary>Authentication based on statistical cardholder behaviour.</summary>
    [IsoId("_w_OeZ7JSEe-rYMhHpAEI4A")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    public static readonly ExternalAuthenticationMethod1Code PassiveAuthentication = new("PSVE");

    /// <summary>Authentication by a password.</summary>
    [IsoId("_w_OeabJSEe-rYMhHpAEI4A")]
    [Description(@"Authentication by a password.")]
    public static readonly ExternalAuthenticationMethod1Code Password = new("PSWD");

    /// <summary>Customer business phone number.</summary>
    [IsoId("_w_Oea7JSEe-rYMhHpAEI4A")]
    [Description(@"Customer business phone number.")]
    public static readonly ExternalAuthenticationMethod1Code PhoneBusiness = new("PWOR");

    /// <summary>Qualified Certificate.</summary>
    [IsoId("_w_OebbJSEe-rYMhHpAEI4A")]
    [Description(@"Qualified Certificate.")]
    public static readonly ExternalAuthenticationMethod1Code QualifiedCertificate = new("QWAC");

    /// <summary>Channel-encrypted transaction.</summary>
    [IsoId("_w_Oeb7JSEe-rYMhHpAEI4A")]
    [Description(@"Channel-encrypted transaction.")]
    public static readonly ExternalAuthenticationMethod1Code SecuredChannel = new("SCNL");

    /// <summary>Electronic commerce transaction secured with the X.509 certificate of a customer.</summary>
    [IsoId("_w_OecbJSEe-rYMhHpAEI4A")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    public static readonly ExternalAuthenticationMethod1Code SecureCertificate = new("SCRT");

    /// <summary>Shipping address from verification.</summary>
    [IsoId("_w_Oec7JSEe-rYMhHpAEI4A")]
    [Description(@"Shipping address from verification.")]
    public static readonly ExternalAuthenticationMethod1Code ShippingAddressFrom = new("SHAF");

    /// <summary>Shipping address to verification</summary>
    [IsoId("_w_OedbJSEe-rYMhHpAEI4A")]
    [Description(@"Shipping address to verification")]
    public static readonly ExternalAuthenticationMethod1Code ShippingAddressTo = new("SHAT");

    /// <summary>Number assigned by a social security agency.</summary>
    [IsoId("_w_PFUbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a social security agency.")]
    public static readonly ExternalAuthenticationMethod1Code SocialSecurityNumber = new("SSYN");

    /// <summary>A value used to validate the authorised use of a token.</summary>
    [IsoId("_w_PFV7JSEe-rYMhHpAEI4A")]
    [Description(@"A value used to validate the authorised use of a token.")]
    public static readonly ExternalAuthenticationMethod1Code TokenAuthenticationValue = new("TAVV");

    /// <summary>Authentication performed during a secure electronic commerce transaction.</summary>
    [IsoId("_w_PFU7JSEe-rYMhHpAEI4A")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    public static readonly ExternalAuthenticationMethod1Code ThreeDS = new("THDS");

    /// <summary>Identification used for travel.</summary>
    [IsoId("_w_PFX7JSEe-rYMhHpAEI4A")]
    [Description(@"Identification used for travel.")]
    public static readonly ExternalAuthenticationMethod1Code TravelIdentification = new("TRVL");

    /// <summary>Number assigned by a tax authority to an entity.</summary>
    [IsoId("_w_PFWbJSEe-rYMhHpAEI4A")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    public static readonly ExternalAuthenticationMethod1Code TaxIdentificationNumber = new("TXID");
}
