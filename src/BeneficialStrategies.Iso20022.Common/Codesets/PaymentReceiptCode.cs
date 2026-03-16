// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is a payment, or a receipt or none.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oMVPoA5EEeenr-7g_0TYag")]
[Description(@"Specifies if an operation is a payment, or a receipt or none.")]
[Derivations(typeof(PaymentReceipt1Code))]
public enum PaymentReceiptCode
{
    /// <summary>
    /// Operation is a payment.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_t7Wn8A5EEeenr-7g_0TYag")]
    [Description(@"Operation is a payment.")]
    Payment,

    /// <summary>
    /// Operation is a receipt.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_yRapQA5EEeenr-7g_0TYag")]
    [Description(@"Operation is a receipt.")]
    Receipt,

    /// <summary>
    /// Operation is null.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_2kqAEA5EEeenr-7g_0TYag")]
    [Description(@"Operation is null.")]
    None,
}
