// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of allowed service adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6V6hwpqlEeGSON8vddiWzQ_-380579229")]
[Description(@"Defines the type of allowed service adjustment.")]
[Derivations(typeof(ServiceAdjustmentType1Code))]
public enum ServiceAdjustmentTypeCode
{
    /// <summary>
    /// Adjustment applies to a service which is balance compensable. Earnings credits based on average balances maintained in the account can be used to offset the service charge.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_6V6hw5qlEeGSON8vddiWzQ_137368753")]
    [Description(@"Adjustment applies to a service which is balance compensable. Earnings credits based on average balances maintained in the account can be used to offset the service charge.")]
    Compensable,
    
    /// <summary>
    /// Adjustment applies to a service which is not balance compensable. Balance based credits cannot be used to offset the service charge.
    /// Encoded/decoded by serializers as &quot;NCMP&quot;.
    /// </summary>
    [EnumMember(Value = "NCMP")]
    [IsoId("_6V6hxJqlEeGSON8vddiWzQ_-1159790259")]
    [Description(@"Adjustment applies to a service which is not balance compensable. Balance based credits cannot be used to offset the service charge.")]
    NonCompensable,
    
}
