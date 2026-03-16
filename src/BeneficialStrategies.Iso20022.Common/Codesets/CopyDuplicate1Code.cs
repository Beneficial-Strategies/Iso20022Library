// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCWRI9p-Ed-ak6NoX_4Aeg_-462671342")]
[Description(@"Specifies if this document is a copy, a duplicate, or a duplicate of a copy.")]
[DerivedFrom(typeof(CopyDuplicateCode))]
public enum CopyDuplicate1Code
{
    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as &quot;CODU&quot;.
    /// </summary>
    [EnumMember(Value = "CODU")]
    [IsoId("_bCWRJNp-Ed-ak6NoX_4Aeg_-462671298")]
    [Description(
        @"Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent."
    )]
    CopyDuplicate = CopyDuplicateCode.CopyDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes.
    /// Encoded/decoded by serializers as &quot;COPY&quot;.
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_bCWRJdp-Ed-ak6NoX_4Aeg_-462671239")]
    [Description(
        @"Message is being sent as a copy to a party other than the account owner, for information purposes."
    )]
    Copy = CopyDuplicateCode.Copy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is for information/confirmation purposes. It is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bCWRJtp-Ed-ak6NoX_4Aeg_-462671187")]
    [Description(
        @"Message is for information/confirmation purposes. It is a duplicate of a message previously sent."
    )]
    Duplicate = CopyDuplicateCode.Duplicate, // same ordinal as derivation source for type conversions
}
