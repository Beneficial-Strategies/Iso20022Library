// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the type of deposit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uGZNwT_dEfCQAqQ9lolFUg")]
[Description(@"Contains the type of deposit.")]
[DerivedFrom(typeof(CardDepositTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardDepositType2Code>))]
public enum CardDepositType2Code
{
    /// <summary>
    /// Envelope
    /// Encoded/decoded by serializers as &quot;ENVL&quot;.
    /// </summary>
    [EnumMember(Value = "ENVL")]
    [IsoId("_uIwlRT_dEfCQAqQ9lolFUg")]
    [Description(@"Envelope")]
    Envelope = CardDepositTypeCode.Envelope,

    /// <summary>
    /// Cheque
    /// Encoded/decoded by serializers as &quot;CHEC&quot;.
    /// </summary>
    [EnumMember(Value = "CHEC")]
    [IsoId("_uIwlRz_dEfCQAqQ9lolFUg")]
    [Description(@"Cheque")]
    Cheque = CardDepositTypeCode.Cheque,

    /// <summary>
    /// Cash
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uIwlST_dEfCQAqQ9lolFUg")]
    [Description(@"Cash")]
    Cash = CardDepositTypeCode.Cash,
}
