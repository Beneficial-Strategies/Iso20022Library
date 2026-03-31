// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of bid request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_beXexNp-Ed-ak6NoX_4Aeg_453364379")]
[Description(@"Identifies the type of bid request.")]
[DerivedFrom(typeof(BidTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BidType1Code>))]
#endif
public enum BidType1Code
{
    /// <summary>
    /// Bid type is non disclosed.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_beXexdp-Ed-ak6NoX_4Aeg_943753955")]
    [Description(@"Bid type is non disclosed.")]
    NonDisclosed = BidTypeCode.NonDisclosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid type is disclosed.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_beXextp-Ed-ak6NoX_4Aeg_943753997")]
    [Description(@"Bid type is disclosed.")]
    Disclosed = BidTypeCode.Disclosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// List order is not related to a bid.
    /// Encoded/decoded by serializers as &quot;NOBI&quot;.
    /// </summary>
    [EnumMember(Value = "NOBI")]
    [IsoId("_beXex9p-Ed-ak6NoX_4Aeg_943754015")]
    [Description(@"List order is not related to a bid.")]
    NoBid = BidTypeCode.NoBid, // same ordinal as derivation source for type conversions
}
