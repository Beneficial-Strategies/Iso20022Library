// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method under which assignment was conducted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bfaAlNp-Ed-ak6NoX_4Aeg_-1937835864")]
[Description(@"Method under which assignment was conducted.")]
[Derivations(typeof(AssignmentMethod1Code))]
public enum AssignmentMethodCode
{
    /// <summary>
    /// Assignment was conducted randomly.
    /// Encoded/decoded by serializers as &quot;RAND&quot;.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_bfaAldp-Ed-ak6NoX_4Aeg_-1677400986")]
    [Description(@"Assignment was conducted randomly.")]
    Random,
    
    /// <summary>
    /// Assignment was conducted on a prorata basis.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_bfaAltp-Ed-ak6NoX_4Aeg_-1652467505")]
    [Description(@"Assignment was conducted on a prorata basis.")]
    Prorata,
    
}
