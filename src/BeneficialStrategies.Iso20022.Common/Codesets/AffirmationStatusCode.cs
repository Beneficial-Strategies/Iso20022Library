// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the affirmation status of a trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bndJUtp-Ed-ak6NoX_4Aeg_693549629")]
[Description(@"Specifies the affirmation status of a trade.")]
[Derivations(typeof(AffirmationStatus1Code))]
public enum AffirmationStatusCode
{
    /// <summary>
    /// Status of the transaction is affirmed.
    /// Encoded/decoded by serializers as &quot;AFFI&quot;.
    /// </summary>
    [EnumMember(Value = "AFFI")]
    [IsoId("_bndJU9p-Ed-ak6NoX_4Aeg_693549919")]
    [Description(@"Status of the transaction is affirmed.")]
    Affirmed,

    /// <summary>
    /// Status of the transaction is unaffirmed.
    /// Encoded/decoded by serializers as &quot;NAFI&quot;.
    /// </summary>
    [EnumMember(Value = "NAFI")]
    [IsoId("_bndJVNp-Ed-ak6NoX_4Aeg_693549937")]
    [Description(@"Status of the transaction is unaffirmed.")]
    Unaffirmed,
}
