// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCWRJ9p-Ed-ak6NoX_4Aeg_-1110982463")]
[Description(@"Specifies if this document is a copy, a duplicate, or a duplicate of a copy.")]
[Derivations(typeof(CopyDuplicate1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CopyDuplicateCode>))]
#endif
public enum CopyDuplicateCode
{
    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as &quot;CODU&quot;.
    /// </summary>
    [EnumMember(Value = "CODU")]
    [IsoId("_bCWRKNp-Ed-ak6NoX_4Aeg_-683393794")]
    [Description(
        @"Message is being sent as a copy to a party other than the account owner, for information purposes and the message is a duplicate of a message previously sent."
    )]
    CopyDuplicate,

    /// <summary>
    /// Message is being sent as a copy to a party other than the account owner, for information purposes.
    /// Encoded/decoded by serializers as &quot;COPY&quot;.
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_bCgCINp-Ed-ak6NoX_4Aeg_-623363428")]
    [Description(
        @"Message is being sent as a copy to a party other than the account owner, for information purposes."
    )]
    Copy,

    /// <summary>
    /// Message is for information/confirmation purposes. It is a duplicate of a message previously sent.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_bCgCIdp-Ed-ak6NoX_4Aeg_-621515903")]
    [Description(
        @"Message is for information/confirmation purposes. It is a duplicate of a message previously sent."
    )]
    Duplicate,
}
