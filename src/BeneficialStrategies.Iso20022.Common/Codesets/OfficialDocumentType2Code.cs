// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of official document used for identification or authentication.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EKULYVN7EfC0lMwgjvMClw")]
[Description(@"Type of official document used for identification or authentication.")]
[DerivedFrom(typeof(OfficialDocumentTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OfficialDocumentType2Code>))]
public enum OfficialDocumentType2Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_ENCIMVN7EfC0lMwgjvMClw")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistration = OfficialDocumentTypeCode.AlienRegistration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Travel authorisation assigned by a government agency (e.g. ESTA, etc.)
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_ENCIM1N7EfC0lMwgjvMClw")]
    [Description(@"Travel authorisation assigned by a government agency (e.g. ESTA, etc.)")]
    Authorisation = OfficialDocumentTypeCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Diplomatic passport or travel document.
    /// Encoded/decoded by serializers as &quot;DIPL&quot;.
    /// </summary>
    [EnumMember(Value = "DIPL")]
    [IsoId("_ENCINVN7EfC0lMwgjvMClw")]
    [Description(@"Diplomatic passport or travel document.")]
    Diplomatic = OfficialDocumentTypeCode.Diplomatic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Driving license.
    /// Encoded/decoded by serializers as &quot;DVLC&quot;.
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_ENCIN1N7EfC0lMwgjvMClw")]
    [Description(@"Driving license.")]
    DrivingLicense = OfficialDocumentTypeCode.DrivingLicense, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Europol-issued travel or related document.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_ENCIOVN7EfC0lMwgjvMClw")]
    [Description(@"Europol-issued travel or related document.")]
    Europol = OfficialDocumentTypeCode.Europol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identity card.
    /// Encoded/decoded by serializers as &quot;IDEN&quot;.
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_ENCIO1N7EfC0lMwgjvMClw")]
    [Description(@"Identity card.")]
    IdentityCard = OfficialDocumentTypeCode.IdentityCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interpol-issued travel or related document.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_ENCIP1N7EfC0lMwgjvMClw")]
    [Description(@"Interpol-issued travel or related document ")]
    Interpol = OfficialDocumentTypeCode.Interpol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internal travel document.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_ENCIPVN7EfC0lMwgjvMClw")]
    [Description(@"Internal travel document.")]
    Internal = OfficialDocumentTypeCode.Internal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Emergency travel or related document.
    /// Encoded/decoded by serializers as &quot;LZPR&quot;.
    /// </summary>
    [EnumMember(Value = "LZPR")]
    [IsoId("_ENCIQVN7EfC0lMwgjvMClw")]
    [Description(@"Emergency travel or related document.")]
    Laissezpasser = OfficialDocumentTypeCode.Laissezpasser, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ENCIR1N7EfC0lMwgjvMClw")]
    [Description(@"Passport.")]
    Passport = OfficialDocumentTypeCode.Passport, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Permit.
    /// Encoded/decoded by serializers as &quot;PERM&quot;.
    /// </summary>
    [EnumMember(Value = "PERM")]
    [IsoId("_ENCIS1N7EfC0lMwgjvMClw")]
    [Description(@"Permit.")]
    Permit = OfficialDocumentTypeCode.Permit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Travel or related document issued to refugees.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_ENCITVN7EfC0lMwgjvMClw")]
    [Description(@"Travel or related document issued to refugees.")]
    Refugee = OfficialDocumentTypeCode.Refugee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Visa issued by a government or related authority.
    /// Encoded/decoded by serializers as &quot;VISA&quot;.
    /// </summary>
    [EnumMember(Value = "VISA")]
    [IsoId("_ENCISVN7EfC0lMwgjvMClw")]
    [Description(@"Visa issued by a government or related authority.")]
    PassportVisa = OfficialDocumentTypeCode.PassportVisa, // same ordinal as derivation source for type conversions
}
