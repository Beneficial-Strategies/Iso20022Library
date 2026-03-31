// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies payment type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1orVsTL3EeKU9IrkkToqcw_-1263884737")]
[Description(@"Specifies payment type.")]
[Derivations(typeof(InterimFinalPayment1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InterimFinalPaymentCode>))]
#endif
public enum InterimFinalPaymentCode
{
    /// <summary>
    /// Interim payment. Pending possible future payments.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_1orVsjL3EeKU9IrkkToqcw_241333812")]
    [Description(@"Interim payment. Pending possible future payments.")]
    Interim,

    /// <summary>
    /// Final payment positions will be debited.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_1orVszL3EeKU9IrkkToqcw_731384259")]
    [Description(@"Final payment positions will be debited.")]
    Final,
}
