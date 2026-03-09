// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Journey type data in a car rental service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LnTHAF1jEeeu75xdwwAXQw")]
[Description(@"Journey type data in a car rental service.")]
[Derivations(typeof(JourneyType1Code))]
public enum JourneyTypeCode
{
    /// <summary>
    /// Early arrival or departure
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_SeCVUF1jEeeu75xdwwAXQw")]
    [Description(@"Early arrival or departure")]
    Early,
    
    /// <summary>
    /// Late arrival or departure.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_WazF0F1jEeeu75xdwwAXQw")]
    [Description(@"Late arrival or departure.")]
    Late,
    
    /// <summary>
    /// On-time arrival or departure
    /// Encoded/decoded by serializers as &quot;ONTM&quot;.
    /// </summary>
    [EnumMember(Value = "ONTM")]
    [IsoId("_Y7xNwF1jEeeu75xdwwAXQw")]
    [Description(@"On-time arrival or departure")]
    OnTime,
    
    /// <summary>
    /// Coach number
    /// Encoded/decoded by serializers as &quot;COAC&quot;.
    /// </summary>
    [EnumMember(Value = "COAC")]
    [IsoId("_grfSgF1jEeeu75xdwwAXQw")]
    [Description(@"Coach number")]
    CoachNumber,
    
    /// <summary>
    /// Train number.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_nuaisF1jEeeu75xdwwAXQw")]
    [Description(@"Train number.")]
    TrainNumber,
    
    /// <summary>
    /// Flight number.
    /// Encoded/decoded by serializers as &quot;FLGT&quot;.
    /// </summary>
    [EnumMember(Value = "FLGT")]
    [IsoId("_ryLTEF1jEeeu75xdwwAXQw")]
    [Description(@"Flight number.")]
    FlightNumber,
    
    /// <summary>
    /// Vessel number
    /// Encoded/decoded by serializers as &quot;VESS&quot;.
    /// </summary>
    [EnumMember(Value = "VESS")]
    [IsoId("_w5B4IF1jEeeu75xdwwAXQw")]
    [Description(@"Vessel number")]
    VesselNumber,
    
    /// <summary>
    /// Other type of journey.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0sIWUF1jEeeu75xdwwAXQw")]
    [Description(@"Other type of journey.")]
    Other,
    
}
