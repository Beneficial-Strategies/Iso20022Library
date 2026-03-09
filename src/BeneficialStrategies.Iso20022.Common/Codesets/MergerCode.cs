// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classification of the regulatory condition of a merger for the TSE/JASDEC extension.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tnAmA1OzEeGs_NnqHXQZkw")]
[Description(@"Classification of the regulatory condition of a merger for the TSE/JASDEC extension.")]
public enum MergerCode
{
    /// <summary>
    /// The merger regulatory condition is unknown.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_98CTsFOzEeGs_NnqHXQZkw")]
    [Description(@"The merger regulatory condition is unknown.")]
    MergerClassificationIsUnknown,
    
    /// <summary>
    /// The merger regulatory condition is: no general shareholders meeting at discontinued company or subsidiary to be acquired.
    /// Encoded/decoded by serializers as &quot;OMIT&quot;.
    /// </summary>
    [EnumMember(Value = "OMIT")]
    [IsoId("__x6QMFOzEeGs_NnqHXQZkw")]
    [Description(@"The merger regulatory condition is: no general shareholders meeting at discontinued company or subsidiary to be acquired.")]
    NoGeneralShareholdersMeeting,
    
}
