// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bj5NMzFwEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC codes for planned, maximum and minimum of shares to be purchased.")]
[Derivations(typeof(SecuritiesQuantity1Code), typeof(SecuritiesQuantity2Code))]
public enum SecuritiesQuantityTypeCode
{
    /// <summary>
    /// No Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as &quot;SQNO&quot;.
    /// </summary>
    [EnumMember(Value = "SQNO")]
    [IsoId("_QXSwEDFwEeGKkIZzgd38VA")]
    [Description(@"No Maximum / Minimum number provided.")]
    No,

    /// <summary>
    /// Maximum / Minimum number provided.
    /// Encoded/decoded by serializers as &quot;SQYS&quot;.
    /// </summary>
    [EnumMember(Value = "SQYS")]
    [IsoId("_3HRA0DFwEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number provided.")]
    Yes,

    /// <summary>
    /// Maximum / Minimum number is unknown or not decided.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_AQa9sDFxEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number is unknown or not decided.")]
    Unknown,
}
