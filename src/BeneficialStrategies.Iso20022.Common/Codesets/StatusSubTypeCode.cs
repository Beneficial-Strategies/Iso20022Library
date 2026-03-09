// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the sub status of the trade notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T_BfoB3cEeKXIbeXfdPzuw")]
[Description(@"Indicates the sub status of the trade notification.")]
[Derivations(typeof(StatusSubType1Code),typeof(StatusSubType2Code))]
public enum StatusSubTypeCode
{
    /// <summary>
    /// No flag has been set for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_fI1ssB3cEeKXIbeXfdPzuw")]
    [Description(@"No flag has been set for the sub status of the trade notification.")]
    NoFlagsSet,
    
    /// <summary>
    /// Same day flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;SMDY&quot;.
    /// </summary>
    [EnumMember(Value = "SMDY")]
    [IsoId("_lXEJgB3cEeKXIbeXfdPzuw")]
    [Description(@"Same day flag has been set to true for the sub status of the trade notification.")]
    OnlySameDayFlagTrue,
    
    /// <summary>
    /// Pending flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_sw0lUB3cEeKXIbeXfdPzuw")]
    [Description(@"Pending flag has been set to true for the sub status of the trade notification.")]
    OnlyPendingFlagTrue,
    
    /// <summary>
    /// Both the same day and pending flags have been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;SDPG&quot;.
    /// </summary>
    [EnumMember(Value = "SDPG")]
    [IsoId("_yIHaIB3cEeKXIbeXfdPzuw")]
    [Description(@"Both the same day and pending flags have been set to true for the sub status of the trade notification.")]
    SameDayAndPendingFlagsTrue,
    
}
