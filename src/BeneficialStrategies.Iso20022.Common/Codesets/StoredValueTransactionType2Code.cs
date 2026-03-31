// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o7PfIYYKEemxIqbaFEE8-w")]
[Description(
    @"Identification of operation to proceed on the stored value account or the stored value card."
)]
[DerivedFrom(typeof(StoredValueTransactionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<StoredValueTransactionType2Code>))]
#endif
public enum StoredValueTransactionType2Code
{
    /// <summary>
    /// Activate the account or the card.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_pFpYUYYKEemxIqbaFEE8-w")]
    [Description(@"Activate the account or the card.")]
    Activate = StoredValueTransactionTypeCode.Activate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplicate the code or number provided by the loading or activation.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_pFpYU4YKEemxIqbaFEE8-w")]
    [Description(@"Duplicate the code or number provided by the loading or activation.")]
    Duplicate = StoredValueTransactionTypeCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Load the account or the card with money.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("_pFpYVYYKEemxIqbaFEE8-w")]
    [Description(@"Load the account or the card with money.")]
    Load = StoredValueTransactionTypeCode.Load, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserve the account (e.g. get an activation code).
    /// Encoded/decoded by serializers as &quot;RESV&quot;.
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("_pFpYV4YKEemxIqbaFEE8-w")]
    [Description(@"Reserve the account (e.g. get an activation code).")]
    Reserve = StoredValueTransactionTypeCode.Reserve, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reverse an activation or loading.
    /// Encoded/decoded by serializers as &quot;REVS&quot;.
    /// </summary>
    [EnumMember(Value = "REVS")]
    [IsoId("_pFpYWYYKEemxIqbaFEE8-w")]
    [Description(@"Reverse an activation or loading.")]
    Reverse = StoredValueTransactionTypeCode.Reverse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unload the account.
    /// Encoded/decoded by serializers as &quot;ULOA&quot;.
    /// </summary>
    [EnumMember(Value = "ULOA")]
    [IsoId("_pFpYW4YKEemxIqbaFEE8-w")]
    [Description(@"Unload the account.")]
    Unload = StoredValueTransactionTypeCode.Unload, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Close the account.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_ezGTwYa1EemfPtKsRXC1Ag")]
    [Description(@"Close the account.")]
    CloseAccount = StoredValueTransactionTypeCode.CloseAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deactivate the account or the card.
    /// Encoded/decoded by serializers as &quot;DCTV&quot;.
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("_e6GToYa1EemfPtKsRXC1Ag")]
    [Description(@"Deactivate the account or the card.")]
    Deactivate = StoredValueTransactionTypeCode.Deactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Open the account.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_fEp90Ya1EemfPtKsRXC1Ag")]
    [Description(@"Open the account.")]
    OpenAccount = StoredValueTransactionTypeCode.OpenAccount, // same ordinal as derivation source for type conversions
}
