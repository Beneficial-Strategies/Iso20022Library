// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an allegement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bopcINp-Ed-ak6NoX_4Aeg_611998730")]
[Description(@"Specifies the status of an allegement.")]
[DerivedFrom(typeof(AllegementStatusCode))]
public enum AllegementStatus1Code
{
    /// <summary>
    /// Allegement has been cancelled since the previous delta statement. The allegement was cancelled because of a mistake by the sender or because the alleging party cancelled its instruction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bopcIdp-Ed-ak6NoX_4Aeg_611999120")]
    [Description(@"Allegement has been cancelled since the previous delta statement. The allegement was cancelled because of a mistake by the sender or because the alleging party cancelled its instruction.")]
    Cancelled = AllegementStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Allegement has been removed since the previous delta statement. The allegement was removed because the alleged party sent its instruction.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_bopcItp-Ed-ak6NoX_4Aeg_611999162")]
    [Description(@"Allegement has been removed since the previous delta statement. The allegement was removed because the alleged party sent its instruction.")]
    Removed = AllegementStatusCode.Removed, // same ordinal as derivation source for type conversions
    
}
