// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of payment of a security at a particular time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2wdp-Ed-ak6NoX_4Aeg_274626372")]
[Description(@"Specifies the state of payment of a security at a particular time.")]
[Derivations(typeof(SecuritiesPaymentStatus1Code))]
public enum SecuritiesPaymentStatusCode
{
    /// <summary>
    /// Security is fully paid.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_ZFx2wtp-Ed-ak6NoX_4Aeg_274626433")]
    [Description(@"Security is fully paid.")]
    FullyPaid,
    
    /// <summary>
    /// Security is nill paid.
    /// Encoded/decoded by serializers as &quot;NILL&quot;.
    /// </summary>
    [EnumMember(Value = "NILL")]
    [IsoId("_ZFx2w9p-Ed-ak6NoX_4Aeg_274626464")]
    [Description(@"Security is nill paid.")]
    NillPaid,
    
    /// <summary>
    /// Security is partially paid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZFx2xNp-Ed-ak6NoX_4Aeg_274626494")]
    [Description(@"Security is partially paid.")]
    PartiallyPaid,
    
}
