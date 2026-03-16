// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v7edEOgcEei5aPS232E3Mw")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup3Code
{
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_y02d8egcEei5aPS232E3Mw")]
    [Description(@"Distribution domain events.")]
    Distribution = EventGroupCode.Distribution, // same ordinal as derivation source for type conversions
}
