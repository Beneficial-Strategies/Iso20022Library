// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the deliverability of a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_be9Uotp-Ed-ak6NoX_4Aeg_965330840")]
[Description(@"Specifies the deliverability of a security.")]
[DerivedFrom(typeof(AppearanceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Appearance1Code>))]
#endif
public enum Appearance1Code
{
    /// <summary>
    /// Physical certificates exist.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_be9Uo9p-Ed-ak6NoX_4Aeg_1019818408")]
    [Description(@"Physical certificates exist.")]
    Deliverable = AppearanceCode.Deliverable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not yet deliverable contract.
    /// Encoded/decoded by serializers as &quot;NDEL&quot;.
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_be9UpNp-Ed-ak6NoX_4Aeg_1019818683")]
    [Description(@"Not yet deliverable contract.")]
    NotDeliverable = AppearanceCode.NotDeliverable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Limited or partial deliverability.
    /// Encoded/decoded by serializers as &quot;LIMI&quot;.
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_be9Updp-Ed-ak6NoX_4Aeg_1019818935")]
    [Description(@"Limited or partial deliverability.")]
    Limited = AppearanceCode.Limited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security exists only as an electronic record, ie, there are no physical certificates representing the security.
    /// Encoded/decoded by serializers as &quot;BENT&quot;.
    /// </summary>
    [EnumMember(Value = "BENT")]
    [IsoId("_be9Uptp-Ed-ak6NoX_4Aeg_1019818978")]
    [Description(
        @"Security exists only as an electronic record, ie, there are no physical certificates representing the security."
    )]
    BookEntry = AppearanceCode.BookEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred printing, book entry.
    /// Encoded/decoded by serializers as &quot;DFBE&quot;.
    /// </summary>
    [EnumMember(Value = "DFBE")]
    [IsoId("_be9Up9p-Ed-ak6NoX_4Aeg_1019819013")]
    [Description(@"Deferred printing, book entry.")]
    DeferredBookEntry = AppearanceCode.DeferredBookEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deliverable, book entry.
    /// Encoded/decoded by serializers as &quot;DLBE&quot;.
    /// </summary>
    [EnumMember(Value = "DLBE")]
    [IsoId("_be9UqNp-Ed-ak6NoX_4Aeg_1020739027")]
    [Description(@"Deliverable, book entry.")]
    DeliverableBookEntry = AppearanceCode.DeliverableBookEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deferred printing, global certificate.
    /// Encoded/decoded by serializers as &quot;TMPG&quot;.
    /// </summary>
    [EnumMember(Value = "TMPG")]
    [IsoId("_bfHFoNp-Ed-ak6NoX_4Aeg_1020739087")]
    [Description(@"Deferred printing, global certificate.")]
    TemporaryGlobal = AppearanceCode.TemporaryGlobal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not deliverable, global certificate.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_bfHFodp-Ed-ak6NoX_4Aeg_1020739165")]
    [Description(@"Not deliverable, global certificate.")]
    Global = AppearanceCode.Global, // same ordinal as derivation source for type conversions
}
