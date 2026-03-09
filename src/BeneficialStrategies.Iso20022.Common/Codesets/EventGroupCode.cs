// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) processing domain for the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oFf0zL3EeKU9IrkkToqcw_648096752")]
[Description(@"Specifies DTC (The Depository Trust Company) processing domain for the event.")]
[Derivations(typeof(EventGroup1Code),typeof(EventGroup2Code),typeof(EventGroup3Code),typeof(EventGroup4Code))]
public enum EventGroupCode
{
    /// <summary>
    /// Redemption domain events.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_1oFf1DL3EeKU9IrkkToqcw_-934083267")]
    [Description(@"Redemption domain events.")]
    Redemption,
    
    /// <summary>
    /// Reorganization domain events.
    /// Encoded/decoded by serializers as &quot;REOR&quot;.
    /// </summary>
    [EnumMember(Value = "REOR")]
    [IsoId("_yQlqgK2nEea8JNaCEJBGAA")]
    [Description(@"Reorganization domain events.")]
    Reorganization,
    
    /// <summary>
    /// Distribution domain events.
    /// Encoded/decoded by serializers as &quot;DISN&quot;.
    /// </summary>
    [EnumMember(Value = "DISN")]
    [IsoId("_j3dzYK2oEea8JNaCEJBGAA")]
    [Description(@"Distribution domain events.")]
    Distribution,
    
    /// <summary>
    /// General domain events.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_ZJKr4AB8EeqouY-yI_q3qQ")]
    [Description(@"General domain events.")]
    General,
    
}
