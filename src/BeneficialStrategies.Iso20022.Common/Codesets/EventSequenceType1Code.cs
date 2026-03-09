// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the event is an interim or a final event in a series of successive events. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WabLMLXIEeiTob_PrFFUxA")]
[Description(@"Specifies whether the event is an interim or a final event in a series of successive events. ")]
[DerivedFrom(typeof(EventSequenceTypeCode))]
public enum EventSequenceType1Code
{
    /// <summary>
    /// Final event in a series of successive events.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_OQhPYbXJEeiTob_PrFFUxA")]
    [Description(@"Final event in a series of successive events.")]
    Final = EventSequenceTypeCode.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interim event in a series of successive events.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_OWxBUbXJEeiTob_PrFFUxA")]
    [Description(@"Interim event in a series of successive events.")]
    Interim = EventSequenceTypeCode.Interim, // same ordinal as derivation source for type conversions
    
}
