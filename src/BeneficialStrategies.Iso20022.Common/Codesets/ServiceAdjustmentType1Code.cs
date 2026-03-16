// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of allowed service adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6VwwyJqlEeGSON8vddiWzQ_96495385")]
[Description(@"Defines the type of allowed service adjustment.")]
[DerivedFrom(typeof(ServiceAdjustmentTypeCode))]
public enum ServiceAdjustmentType1Code
{
    /// <summary>
    /// Adjustment applies to a service which is balance compensable. Earnings credits based on average balances maintained in the account can be used to offset the service charge.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_6V6hwJqlEeGSON8vddiWzQ_1688850679")]
    [Description(
        @"Adjustment applies to a service which is balance compensable. Earnings credits based on average balances maintained in the account can be used to offset the service charge."
    )]
    Compensable = ServiceAdjustmentTypeCode.Compensable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Adjustment applies to a service which is not balance compensable. Balance based credits cannot be used to offset the service charge.
    /// Encoded/decoded by serializers as &quot;NCMP&quot;.
    /// </summary>
    [EnumMember(Value = "NCMP")]
    [IsoId("_6V6hwZqlEeGSON8vddiWzQ_1677751902")]
    [Description(
        @"Adjustment applies to a service which is not balance compensable. Balance based credits cannot be used to offset the service charge."
    )]
    NonCompensable = ServiceAdjustmentTypeCode.NonCompensable, // same ordinal as derivation source for type conversions
}
