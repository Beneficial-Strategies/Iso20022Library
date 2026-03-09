// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b2Sp0Y8UEe6r6f2NSkdeiA")]
[Description(@"Identification of operation to proceed on the stored value account or the stored value card.")]
[DerivedFrom(typeof(StoredValueTransactionTypeCode))]
public enum StoredValueTransactionType3Code
{
    /// <summary>
    /// Activate the account or the card.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("")]
    [Description(@"Activate the account or the card.")]
    Activate = StoredValueTransactionTypeCode.Activate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance enquiry.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("")]
    [Description(@"Balance enquiry.")]
    Balance = StoredValueTransactionTypeCode.Balance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Close the account.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("")]
    [Description(@"Close the account.")]
    CloseAccount = StoredValueTransactionTypeCode.CloseAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deactivate the account or the card.
    /// Encoded/decoded by serializers as &quot;DCTV&quot;.
    /// </summary>
    [EnumMember(Value = "DCTV")]
    [IsoId("")]
    [Description(@"Deactivate the account or the card.")]
    Deactivate = StoredValueTransactionTypeCode.Deactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplicate the code or number provided by the loading or activation.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("")]
    [Description(@"Duplicate the code or number provided by the loading or activation.")]
    Duplicate = StoredValueTransactionTypeCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Load the account or the card with money.
    /// Encoded/decoded by serializers as &quot;LOAD&quot;.
    /// </summary>
    [EnumMember(Value = "LOAD")]
    [IsoId("")]
    [Description(@"Load the account or the card with money.")]
    Load = StoredValueTransactionTypeCode.Load, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Open the account.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("")]
    [Description(@"Open the account.")]
    OpenAccount = StoredValueTransactionTypeCode.OpenAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reserve the account (e.g. get an activation code).
    /// Encoded/decoded by serializers as &quot;RESV&quot;.
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("")]
    [Description(@"Reserve the account (e.g. get an activation code).")]
    Reserve = StoredValueTransactionTypeCode.Reserve, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reverse an activation or loading.
    /// Encoded/decoded by serializers as &quot;REVS&quot;.
    /// </summary>
    [EnumMember(Value = "REVS")]
    [IsoId("")]
    [Description(@"Reverse an activation or loading.")]
    Reverse = StoredValueTransactionTypeCode.Reverse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unload the account.
    /// Encoded/decoded by serializers as &quot;ULOA&quot;.
    /// </summary>
    [EnumMember(Value = "ULOA")]
    [IsoId("")]
    [Description(@"Unload the account.")]
    Unload = StoredValueTransactionTypeCode.Unload, // same ordinal as derivation source for type conversions

}
