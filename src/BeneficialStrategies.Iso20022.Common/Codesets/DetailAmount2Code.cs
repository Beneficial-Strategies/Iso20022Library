// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of detail amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fca5gFjpEeiTlKUpxxSxEw")]
[Description(@"Type of detail amount.")]
[DerivedFrom(typeof(DetailAmountCode))]
public enum DetailAmount2Code
{
    /// <summary>
    /// Other type of amount defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_ioqzEVjpEeiTlKUpxxSxEw")]
    [Description(@"Other type of amount defined at national level")]
    OtherNational = DetailAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ixNEAVjpEeiTlKUpxxSxEw")]
    [Description(@"Other type of amount defined at private level")]
    OtherPrivate = DetailAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged by the acceptor for the transaction.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_i-ZLcVjpEeiTlKUpxxSxEw")]
    [Description(@"Fee charged by the acceptor for the transaction.")]
    Surcharge = DetailAmountCode.Surcharge, // same ordinal as derivation source for type conversions
    
}
