// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of payment card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a1-pFdp-Ed-ak6NoX_4Aeg_309816465")]
[Description(@"Specifies the type of payment card.")]
[Derivations(typeof(CardType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardTypeCode>))]
#endif
public enum CardTypeCode
{
    /// <summary>
    /// Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_a1-pFtp-Ed-ak6NoX_4Aeg_309816466")]
    [Description(
        @"Card where the holder has been granted a line of credit. The card enables the holder to make purchases and withdraw cash up to a pre-arranged ceiling."
    )]
    CreditCard,

    /// <summary>
    /// Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_a2IaENp-Ed-ak6NoX_4Aeg_309816467")]
    [Description(
        @"Card enabling the holder to have its purchases directly charged to its account. The card may also combine other functions, for example, cash card or cheque guaranteed card."
    )]
    DebitCard,
}
