// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the processing status of an investment fund transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuO5ddp-Ed-ak6NoX_4Aeg_-163376568")]
[Description(@"Specifies the processing status of an investment fund transaction.")]
[Derivations(typeof(TransactionStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionStatusCode>))]
#endif
public enum TransactionStatusCode
{
    /// <summary>
    /// Transaction has been reversed.
    /// Encoded/decoded by serializers as &quot;RVSL&quot;.
    /// </summary>
    [EnumMember(Value = "RVSL")]
    [IsoId("_YuO5dtp-Ed-ak6NoX_4Aeg_-163376564")]
    [Description(@"Transaction has been reversed.")]
    Reversal,

    /// <summary>
    /// Transaction has been rebooked.
    /// Encoded/decoded by serializers as &quot;REBO&quot;.
    /// </summary>
    [EnumMember(Value = "REBO")]
    [IsoId("_YuO5d9p-Ed-ak6NoX_4Aeg_-163376563")]
    [Description(@"Transaction has been rebooked.")]
    Rebooked,

    /// <summary>
    /// Transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_YuYqcNp-Ed-ak6NoX_4Aeg_-163376562")]
    [Description(@"Transaction has been cancelled.")]
    Cancelled,
}
