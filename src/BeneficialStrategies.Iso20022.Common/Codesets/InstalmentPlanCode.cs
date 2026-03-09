// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of instalment plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pQ8HgDDgEeO9waS4ina8CA")]
[Description(@"Type of instalment plan.")]
[Derivations(typeof(InstalmentPlan1Code))]
public enum InstalmentPlanCode
{
    /// <summary>
    /// The payment is split in several instalments of equal amounts.
    /// Encoded/decoded by serializers as &quot;EQPM&quot;.
    /// </summary>
    [EnumMember(Value = "EQPM")]
    [IsoId("_-LwUkDDgEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of equal amounts.")]
    EqualPayment,
    
    /// <summary>
    /// The payment is split in several instalments of different amounts.
    /// Encoded/decoded by serializers as &quot;NQPM&quot;.
    /// </summary>
    [EnumMember(Value = "NQPM")]
    [IsoId("_CtHm8DDhEeO9waS4ina8CA")]
    [Description(@"The payment is split in several instalments of different amounts.")]
    InequalPayment,
    
    /// <summary>
    /// The first instalment is deferred.
    /// Encoded/decoded by serializers as &quot;DFRI&quot;.
    /// </summary>
    [EnumMember(Value = "DFRI")]
    [IsoId("_gt1ZwDGrEeOVuYdyXoFwuA")]
    [Description(@"The first instalment is deferred.")]
    DeferredInstalment,
    
}
