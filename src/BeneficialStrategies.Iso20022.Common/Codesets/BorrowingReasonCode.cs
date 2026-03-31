// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the underlying reason for the borrowing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0dT09ojEeC60axPepSq7g_1572602070")]
[Description(@"Identifies the underlying reason for the borrowing.")]
[Derivations(typeof(BorrowingReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BorrowingReasonCode>))]
#endif
public enum BorrowingReasonCode
{
    /// <summary>
    /// The borrowing reason is for Self consumption.
    /// Encoded/decoded by serializers as &quot;SFCT&quot;.
    /// </summary>
    [EnumMember(Value = "SFCT")]
    [IsoId("__0dT1NojEeC60axPepSq7g_-1791555155")]
    [Description(@"The borrowing reason is for Self consumption.")]
    SelfConsumption,

    /// <summary>
    /// The borrowing reason is for Transfer to thrid party.
    /// Encoded/decoded by serializers as &quot;TTTP&quot;.
    /// </summary>
    [EnumMember(Value = "TTTP")]
    [IsoId("__0dT1dojEeC60axPepSq7g_987437691")]
    [Description(@"The borrowing reason is for Transfer to thrid party.")]
    TransferToThirdParty,

    /// <summary>
    /// The borrowing reason is for Market making purpose.
    /// Encoded/decoded by serializers as &quot;MMPP&quot;.
    /// </summary>
    [EnumMember(Value = "MMPP")]
    [IsoId("__0dT1tojEeC60axPepSq7g_-236314202")]
    [Description(@"The borrowing reason is for Market making purpose.")]
    MarketMakingPurpose,
}
