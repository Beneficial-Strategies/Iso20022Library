// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the sub status of the trade notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8VSYwB3cEeKXIbeXfdPzuw")]
[Description(@"Indicates the sub status of the trade notification.")]
[DerivedFrom(typeof(StatusSubTypeCode))]
public enum StatusSubType1Code
{
    /// <summary>
    /// No flag has been set for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_95DRkR3cEeKXIbeXfdPzuw")]
    [Description(@"No flag has been set for the sub status of the trade notification.")]
    NoFlagsSet = StatusSubTypeCode.NoFlagsSet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_99_b8R3cEeKXIbeXfdPzuw")]
    [Description(@"Pending flag has been set to true for the sub status of the trade notification.")]
    OnlyPendingFlagTrue = StatusSubTypeCode.OnlyPendingFlagTrue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Same day flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;SMDY&quot;.
    /// </summary>
    [EnumMember(Value = "SMDY")]
    [IsoId("_-INu8R3cEeKXIbeXfdPzuw")]
    [Description(@"Same day flag has been set to true for the sub status of the trade notification.")]
    OnlySameDayFlagTrue = StatusSubTypeCode.OnlySameDayFlagTrue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Both the same day and pending flags have been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;SDPG&quot;.
    /// </summary>
    [EnumMember(Value = "SDPG")]
    [IsoId("_-NepcR3cEeKXIbeXfdPzuw")]
    [Description(@"Both the same day and pending flags have been set to true for the sub status of the trade notification.")]
    SameDayAndPendingFlagsTrue = StatusSubTypeCode.SameDayAndPendingFlagsTrue, // same ordinal as derivation source for type conversions
    
}
