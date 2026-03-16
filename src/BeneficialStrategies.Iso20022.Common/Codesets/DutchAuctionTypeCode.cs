// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Dutch auction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DutchAuctionTypeCode")]
[Description(@"Specifies the type of Dutch auction.")]
public enum DutchAuctionTypeCode
{
    /// <summary>
    /// All instructions are accepted at the same price (issuer bid).
    /// Encoded/decoded by serializers as &quot;MDFD&quot;.
    /// </summary>
    [EnumMember(Value = "MDFD")]
    [IsoId("_DutchAuctionTypeCode_Modified")]
    [Description(@"All instructions are accepted at the same price (issuer bid).")]
    Modified,

    /// <summary>
    /// All instructions are accepted at the instructed price (offering bid).
    /// Encoded/decoded by serializers as &quot;UNMD&quot;.
    /// </summary>
    [EnumMember(Value = "UNMD")]
    [IsoId("_DutchAuctionTypeCode_Unmodified")]
    [Description(@"All instructions are accepted at the instructed price (offering bid).")]
    Unmodified,
}
