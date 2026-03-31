// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the bank in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yh4FcNNsEeKdOs2hjJ_3WQ")]
[Description(@"Specifies the role of the bank in the transaction.")]
[Derivations(typeof(BankRole1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BankRoleCode>))]
#endif
public enum BankRoleCode
{
    /// <summary>
    /// Bank of the buyer.
    /// Encoded/decoded by serializers as &quot;BUYB&quot;.
    /// </summary>
    [EnumMember(Value = "BUYB")]
    [IsoId("_4OpbANNsEeKdOs2hjJ_3WQ")]
    [Description(@"Bank of the buyer.")]
    BuyersBank,

    /// <summary>
    /// Bank of the seller.
    /// Encoded/decoded by serializers as &quot;SELB&quot;.
    /// </summary>
    [EnumMember(Value = "SELB")]
    [IsoId("__ov1ENNsEeKdOs2hjJ_3WQ")]
    [Description(@"Bank of the seller.")]
    SellersBank,

    /// <summary>
    /// Obligor bank.
    /// Encoded/decoded by serializers as &quot;OBLB&quot;.
    /// </summary>
    [EnumMember(Value = "OBLB")]
    [IsoId("_CXLxQNNtEeKdOs2hjJ_3WQ")]
    [Description(@"Obligor bank.")]
    ObligorBank,

    /// <summary>
    /// Recipient bank.
    /// Encoded/decoded by serializers as &quot;RECB&quot;.
    /// </summary>
    [EnumMember(Value = "RECB")]
    [IsoId("_FYWcMNNtEeKdOs2hjJ_3WQ")]
    [Description(@"Recipient bank.")]
    RecipientBank,
}
