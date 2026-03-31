// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of shareholding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6ElLcD6JEemPvNTzinB5Vw")]
[Description(@"Specifies the type of shareholding.")]
[DerivedFrom(typeof(ShareholdingTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ShareholdingType1Code>))]
#endif
public enum ShareholdingType1Code
{
    /// <summary>
    /// Shares are held on behalf of the beneficial owner.
    /// Usage: this type should be used to report assets the intermediary holds on behalf of a final beneficial owner.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_7_n70T6JEemPvNTzinB5Vw")]
    [Description(
        @"Shares are held on behalf of the beneficial owner. |Usage: this type should be used to report assets the intermediary holds on behalf of a final beneficial owner."
    )]
    BeneficialShareholding = ShareholdingTypeCode.BeneficialShareholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shares are held on behalf of an intermediary.
    /// Usage: this type should be used to report assets the intermediary holds on behalf of another intermediary.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_8LX40j6JEemPvNTzinB5Vw")]
    [Description(
        @"Shares are held on behalf of an intermediary.|Usage: this type should be used to report assets the intermediary holds on behalf of another intermediary."
    )]
    NomineeShareholding = ShareholdingTypeCode.NomineeShareholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shares are held by the responding intermediary for its own account.
    /// Usage: this type should only be used to report the intermediary’s own assets if and when the intermediary comingles them with the one of their clients.  Within jurisdictions where commingling is not allowed, this type should not be used.
    /// Encoded/decoded by serializers as &quot;OOAC&quot;.
    /// </summary>
    [EnumMember(Value = "OOAC")]
    [IsoId("_8Nc8cT6JEemPvNTzinB5Vw")]
    [Description(
        @"Shares are held by the responding intermediary for its own account.|Usage: this type should only be used to report the intermediary’s own assets if and when the intermediary comingles them with the one of their clients.  Within jurisdictions where commingling is not allowed, this type should not be used."
    )]
    OnOwnAccount = ShareholdingTypeCode.OnOwnAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shareholding type is unknown.
    /// Usage: this type should be used when the intermediary’s client hasn’t been classified.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_8Uc8UT6JEemPvNTzinB5Vw")]
    [Description(
        @"Shareholding type is unknown.|Usage: this type should be used when the intermediary’s client hasn’t been classified."
    )]
    Unknown = ShareholdingTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
