// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tcg9DL3EeKU9IrkkToqcw_710704652")]
[Description(@"Specifies payment type.")]
[DerivedFrom(typeof(InterimFinalPaymentCode))]
public enum InterimFinalPayment1Code
{
    /// <summary>
    /// Interim payment. Pending possible future payments.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_1tcg9TL3EeKU9IrkkToqcw_579708614")]
    [Description(@"Interim payment. Pending possible future payments.")]
    Interim = InterimFinalPaymentCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final payment positions will be debited.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_1tcg9jL3EeKU9IrkkToqcw_465869548")]
    [Description(@"Final payment positions will be debited.")]
    Final = InterimFinalPaymentCode.Final, // same ordinal as derivation source for type conversions
}
