// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of payment of a security at a particular time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFoFxtp-Ed-ak6NoX_4Aeg_-1237282418")]
[Description(@"Specifies the state of payment of a security at a particular time.")]
[DerivedFrom(typeof(SecuritiesPaymentStatusCode))]
public enum SecuritiesPaymentStatus1Code
{
    /// <summary>
    /// Security is fully paid.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_ZFoFx9p-Ed-ak6NoX_4Aeg_-1185567647")]
    [Description(@"Security is fully paid.")]
    FullyPaid = SecuritiesPaymentStatusCode.FullyPaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is nill paid.
    /// Encoded/decoded by serializers as &quot;NILL&quot;.
    /// </summary>
    [EnumMember(Value = "NILL")]
    [IsoId("_ZFoFyNp-Ed-ak6NoX_4Aeg_-899273641")]
    [Description(@"Security is nill paid.")]
    NillPaid = SecuritiesPaymentStatusCode.NillPaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is partially paid.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_ZFx2wNp-Ed-ak6NoX_4Aeg_-862334871")]
    [Description(@"Security is partially paid.")]
    PartiallyPaid = SecuritiesPaymentStatusCode.PartiallyPaid, // same ordinal as derivation source for type conversions
}
