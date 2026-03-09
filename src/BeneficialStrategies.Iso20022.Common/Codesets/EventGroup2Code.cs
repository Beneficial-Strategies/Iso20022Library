// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qP240K2oEea8JNaCEJBGAA")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[DerivedFrom(typeof(EventGroupCode))]
public enum EventGroup2Code
{
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_rxKTga2oEea8JNaCEJBGAA")]
    [Description(@"Distribution domain events.")]
    Distribution = EventGroupCode.Distribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_r2Nyoa2oEea8JNaCEJBGAA")]
    [Description(@"Redemption domain events.")]
    Redemption = EventGroupCode.Redemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reorganization domain events.
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_r7bCwa2oEea8JNaCEJBGAA")]
    [Description(@"Reorganization domain events.")]
    Reorganization = EventGroupCode.Reorganization, // same ordinal as derivation source for type conversions
    
}
