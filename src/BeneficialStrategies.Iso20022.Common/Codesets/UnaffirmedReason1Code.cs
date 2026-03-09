// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__qxMUtojEeC60axPepSq7g_-749392575")]
[Description(@"Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.")]
[DerivedFrom(typeof(UnaffirmedReasonCode))]
public enum UnaffirmedReason1Code
{
    /// <summary>
    /// Specifies the reason the counterparty has not affirmed.
    /// Encoded/decoded by serializers as &quot;NAFF&quot;.
    /// </summary>
    [EnumMember(Value = "NAFF")]
    [IsoId("__qxMU9ojEeC60axPepSq7g_2031513196")]
    [Description(@"Specifies the reason the counterparty has not affirmed.")]
    CounterpartyNotAffirmed = UnaffirmedReasonCode.CounterpartyNotAffirmed, // same ordinal as derivation source for type conversions
    
}
