// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status requested to be assigned to the baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bckvBdp-Ed-ak6NoX_4Aeg_-554101264")]
[Description(@"Specifies the status requested to be assigned to the baseline.")]
[DerivedFrom(typeof(BaselineStatusCode))]
public enum BaselineStatus2Code
{
    /// <summary>
    /// State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bckvBtp-Ed-ak6NoX_4Aeg_-492223407")]
    [Description(@"State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.")]
    Complete = BaselineStatusCode.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final state of a baseline, in which only reporting is allowed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_bcugANp-Ed-ak6NoX_4Aeg_-492223372")]
    [Description(@"Final state of a baseline, in which only reporting is allowed.")]
    Closed = BaselineStatusCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bcugAdp-Ed-ak6NoX_4Aeg_-1284169111")]
    [Description(@"State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.")]
    Active = BaselineStatusCode.Active, // same ordinal as derivation source for type conversions
    
}
