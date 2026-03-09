// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tTXAjL3EeKU9IrkkToqcw_-1870797912")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup1Code
{
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_1tTXAzL3EeKU9IrkkToqcw_-766484011")]
    [Description(@"Redemption domain events.")]
    Redemption = EventGroupCode.Redemption, // same ordinal as derivation source for type conversions
    
}
