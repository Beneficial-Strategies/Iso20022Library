// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Dutch auction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DutchAuctionType1Code")]
[Description(@"Specifies the type of Dutch auction.")]
[DerivedFrom(typeof(DutchAuctionTypeCode))]
public enum DutchAuctionType1Code
{
    /// <summary>
    /// All instructions are accepted at the same price (issuer bid).
    /// Encoded/decoded by serializers as &quot;MDFD&quot;.
    /// </summary>
    [EnumMember(Value = "MDFD")]
    [IsoId("_DutchAuctionType1Code_Modified")]
    [Description(@"All instructions are accepted at the same price (issuer bid).")]
    Modified = DutchAuctionTypeCode.Modified,

    /// <summary>
    /// All instructions are accepted at the instructed price (offering bid).
    /// Encoded/decoded by serializers as &quot;UNMD&quot;.
    /// </summary>
    [EnumMember(Value = "UNMD")]
    [IsoId("_DutchAuctionType1Code_Unmodified")]
    [Description(@"All instructions are accepted at the instructed price (offering bid).")]
    Unmodified = DutchAuctionTypeCode.Unmodified,
}
