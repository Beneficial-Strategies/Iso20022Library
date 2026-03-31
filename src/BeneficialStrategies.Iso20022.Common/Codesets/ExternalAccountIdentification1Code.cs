// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amL5ktp-Ed-ak6NoX_4Aeg_-2079691647")]
[Description(
    @"Specifies the external account identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAccountIdentificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAccountIdentification1Code>))]
#endif
public enum ExternalAccountIdentification1Code
{
    /// <summary>
    /// Issuer Identification Number (IIN) - identifies a card issuing institution in an international interchange environment. Issued by ABA (American Bankers Association).
    /// Encoded/decoded by serializers as &quot;AIIN&quot;.
    /// </summary>
    [EnumMember(Value = "AIIN")]
    [IsoId("_teaY4vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Issuer Identification Number (IIN) - identifies a card issuing institution in an international interchange environment. Issued by ABA (American Bankers Association)."
    )]
    IssuerIdentificationNumber = ExternalAccountIdentificationCode.IssuerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer.
    /// Encoded/decoded by serializers as &quot;BBAN&quot;.
    /// </summary>
    [EnumMember(Value = "BBAN")]
    [IsoId("_teaY5fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Basic Bank Account Number (BBAN) - identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), to uniquely identify the account of a customer."
    )]
    BBANIdentifier = ExternalAccountIdentificationCode.BBANIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_teaY6PRYEeuLhpyIdtJzwg")]
    [Description(
        @"(United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House."
    )]
    CHIPSUniversalIdentifier = ExternalAccountIdentificationCode.CHIPSUniversalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes.
    /// Encoded/decoded by serializers as &quot;UPIC&quot;.
    /// </summary>
    [EnumMember(Value = "UPIC")]
    [IsoId("_teji0vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Universal Payment Identification Code (UPIC) - identifier used by the New York Clearing House to mask confidential data, such as bank accounts and bank routing numbers. UPIC numbers remain with business customers, regardless of banking relationship changes."
    )]
    UPICIdentifier = ExternalAccountIdentificationCode.UPICIdentifier, // same ordinal as derivation source for type conversions
}
