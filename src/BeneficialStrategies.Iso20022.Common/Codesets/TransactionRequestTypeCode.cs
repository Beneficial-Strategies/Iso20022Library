// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of information request related to a transaction number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0-HZ0GKCEeGByYwyG-c4ow")]
[Description(@"Specifies the type of information request related to a transaction number.")]
[Derivations(typeof(TransactionRequestType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionRequestTypeCode>))]
#endif
public enum TransactionRequestTypeCode
{
    /// <summary>
    /// Request is the original receipt.
    /// Encoded/decoded by serializers as &quot;OREC&quot;.
    /// </summary>
    [EnumMember(Value = "OREC")]
    [IsoId("_890bXWKCEeGByYwyG-c4ow")]
    [Description(@"Request is the original receipt.")]
    OriginalReceipt,

    /// <summary>
    /// Request is the date and time related to the original transaction numlber.
    /// Encoded/decoded by serializers as &quot;DTTX&quot;.
    /// </summary>
    [EnumMember(Value = "DTTX")]
    [IsoId("_GMETnWKDEeGByYwyG-c4ow")]
    [Description(@"Request is the date and time related to the original transaction numlber.")]
    DateTimeTransaction,
}
