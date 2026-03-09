// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha_UsWliEeGaMcKyqKNRfQ_-489593390")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeCode))]
public enum SecuritiesTransactionType11Code
{
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as &quot;NSYN&quot;.
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ha_UsmliEeGaMcKyqKNRfQ_-1686330340")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated = SecuritiesTransactionTypeCode.NonSyndicated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as &quot;SYND&quot;.
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ha_Us2liEeGaMcKyqKNRfQ_835025507")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters = SecuritiesTransactionTypeCode.SyndicateUnderwriters, // same ordinal as derivation source for type conversions
    
}
