// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the event is an interim or a final event in a series of successive events. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vPbyYLXHEeiTob_PrFFUxA")]
[Description(@"Specifies whether the event is an interim or a final event in a series of successive events. ")]
[Derivations(typeof(EventSequenceType1Code))]
public enum EventSequenceTypeCode
{
    /// <summary>
    /// Final event in a series of successive events.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_LVpPILXIEeiTob_PrFFUxA")]
    [Description(@"Final event in a series of successive events.")]
    Final,
    
    /// <summary>
    /// Interim event in a series of successive events.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_O_xXgLXIEeiTob_PrFFUxA")]
    [Description(@"Interim event in a series of successive events.")]
    Interim,
    
}
