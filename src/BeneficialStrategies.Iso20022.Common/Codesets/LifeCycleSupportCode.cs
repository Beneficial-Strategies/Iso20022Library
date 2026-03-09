// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0g248FJ3EeeHVODnW-1ONQ")]
[Description(@"Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.")]
[Derivations(typeof(LifeCycleSupport1Code))]
public enum LifeCycleSupportCode
{
    /// <summary>
    /// Assigned at authorisation time.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_88m9QFJ3EeeHVODnW-1ONQ")]
    [Description(@"Assigned at authorisation time.")]
    Authorisation,
    
    /// <summary>
    /// Assigned at financial time.
    /// Encoded/decoded by serializers as &quot;FINC&quot;.
    /// </summary>
    [EnumMember(Value = "FINC")]
    [IsoId("_BxBHcFJ4EeeHVODnW-1ONQ")]
    [Description(@"Assigned at financial time.")]
    Financial,
    
}
