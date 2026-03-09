// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of merger for the TSE/JASDEC extension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DppzQFOzEeGs_NnqHXQZkw")]
[Description(@"Types of merger for the TSE/JASDEC extension.")]
public enum MergerTypeCode
{
    /// <summary>
    /// The type of merger is an ordinary merger.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_MvsxwFOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is an ordinary merger.")]
    OrdinaryMerger,
    
    /// <summary>
    /// The type of merger is an exchange of shares.
    /// Encoded/decoded by serializers as &quot;EXSH&quot;.
    /// </summary>
    [EnumMember(Value = "EXSH")]
    [IsoId("_bCyc4FOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is an exchange of shares.")]
    ExchangeofShares,
    
    /// <summary>
    /// The type of merger is a transfer of shares.
    /// Encoded/decoded by serializers as &quot;TRSH&quot;.
    /// </summary>
    [EnumMember(Value = "TRSH")]
    [IsoId("_gOo2sFOzEeGs_NnqHXQZkw")]
    [Description(@"The type of merger is a transfer of shares.")]
    TransferofShares,
    
}
