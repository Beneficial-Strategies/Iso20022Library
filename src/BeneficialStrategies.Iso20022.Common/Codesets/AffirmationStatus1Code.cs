// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the affirmation status of a trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bnTYWNp-Ed-ak6NoX_4Aeg_519503215")]
[Description(@"Specifies the affirmation status of a trade.")]
[DerivedFrom(typeof(AffirmationStatusCode))]
public enum AffirmationStatus1Code
{
    /// <summary>
    /// Status of the transaction is affirmed.
    /// Encoded/decoded by serializers as &quot;AFFI&quot;.
    /// </summary>
    [EnumMember(Value = "AFFI")]
    [IsoId("_bndJUNp-Ed-ak6NoX_4Aeg_589689024")]
    [Description(@"Status of the transaction is affirmed.")]
    Affirmed = AffirmationStatusCode.Affirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the transaction is unaffirmed.
    /// Encoded/decoded by serializers as &quot;NAFI&quot;.
    /// </summary>
    [EnumMember(Value = "NAFI")]
    [IsoId("_bndJUdp-Ed-ak6NoX_4Aeg_618318083")]
    [Description(@"Status of the transaction is unaffirmed.")]
    Unaffirmed = AffirmationStatusCode.Unaffirmed, // same ordinal as derivation source for type conversions
    
}
