// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of amount
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kE7gQFjqEeiTlKUpxxSxEw")]
[Description(@"Type of amount")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount17Code
{
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_mpFfEVjqEeiTlKUpxxSxEw")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_m0EnEVjqEeiTlKUpxxSxEw")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee applied by the card issuer to the cardholder.
    /// Encoded/decoded by serializers as &quot;ISCF&quot;.
    /// </summary>
    [EnumMember(Value = "ISCF")]
    [IsoId("_nw0jMVjqEeiTlKUpxxSxEw")]
    [Description(@"Fee applied by the card issuer to the cardholder.")]
    IssuerCardholderFee = TypeOfAmountCode.IssuerCardholderFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount anticipated for the transaction
    /// Encoded/decoded by serializers as &quot;ANTA&quot;.
    /// </summary>
    [EnumMember(Value = "ANTA")]
    [IsoId("_7nV2oa0pEeiBP5PZ97xcEA")]
    [Description(@"Amount anticipated for the transaction")]
    Anticipated = TypeOfAmountCode.Anticipated, // same ordinal as derivation source for type conversions
    
}
