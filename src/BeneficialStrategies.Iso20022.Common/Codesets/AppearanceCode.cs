// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the deliverability of a security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfHFotp-Ed-ak6NoX_4Aeg_-1137977786")]
[Description(@"Specifies the deliverability of a security.")]
[Derivations(typeof(Appearance1Code))]
public enum AppearanceCode
{
    /// <summary>
    /// Physical certificates exist.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_bfHFo9p-Ed-ak6NoX_4Aeg_-1137977785")]
    [Description(@"Physical certificates exist.")]
    Deliverable,

    /// <summary>
    /// Not yet deliverable contract.
    /// Encoded/decoded by serializers as &quot;NDEL&quot;.
    /// </summary>
    [EnumMember(Value = "NDEL")]
    [IsoId("_bfHFpNp-Ed-ak6NoX_4Aeg_-1137977784")]
    [Description(@"Not yet deliverable contract.")]
    NotDeliverable,

    /// <summary>
    /// Limited or partial deliverability.
    /// Encoded/decoded by serializers as &quot;LIMI&quot;.
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_bfHFpdp-Ed-ak6NoX_4Aeg_-1137977783")]
    [Description(@"Limited or partial deliverability.")]
    Limited,

    /// <summary>
    /// Security exists only as an electronic record, ie, there are no physical certificates representing the security.
    /// Encoded/decoded by serializers as &quot;BENT&quot;.
    /// </summary>
    [EnumMember(Value = "BENT")]
    [IsoId("_bfHFptp-Ed-ak6NoX_4Aeg_-1137977755")]
    [Description(
        @"Security exists only as an electronic record, ie, there are no physical certificates representing the security."
    )]
    BookEntry,

    /// <summary>
    /// Deferred printing, book entry.
    /// Encoded/decoded by serializers as &quot;DFBE&quot;.
    /// </summary>
    [EnumMember(Value = "DFBE")]
    [IsoId("_bfHFp9p-Ed-ak6NoX_4Aeg_-1137977754")]
    [Description(@"Deferred printing, book entry.")]
    DeferredBookEntry,

    /// <summary>
    /// Deliverable, book entry.
    /// Encoded/decoded by serializers as &quot;DLBE&quot;.
    /// </summary>
    [EnumMember(Value = "DLBE")]
    [IsoId("_bfQPkNp-Ed-ak6NoX_4Aeg_-1137977753")]
    [Description(@"Deliverable, book entry.")]
    DeliverableBookEntry,

    /// <summary>
    /// Deferred printing, global certificate.
    /// Encoded/decoded by serializers as &quot;TMPG&quot;.
    /// </summary>
    [EnumMember(Value = "TMPG")]
    [IsoId("_bfQPkdp-Ed-ak6NoX_4Aeg_-1137977752")]
    [Description(@"Deferred printing, global certificate.")]
    TemporaryGlobal,

    /// <summary>
    /// Not deliverable, global certificate.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_bfQPktp-Ed-ak6NoX_4Aeg_-1137977725")]
    [Description(@"Not deliverable, global certificate.")]
    Global,
}
