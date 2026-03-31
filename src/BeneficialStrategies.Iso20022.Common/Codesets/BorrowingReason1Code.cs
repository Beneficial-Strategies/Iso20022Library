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
[IsoId("__0Ti1dojEeC60axPepSq7g_467150193")]
[Description(@"Identifies the underlying reason for the borrowing.")]
[DerivedFrom(typeof(BorrowingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BorrowingReason1Code>))]
#endif
public enum BorrowingReason1Code
{
    /// <summary>
    /// The borrowing reason is for Self consumption.
    /// Encoded/decoded by serializers as &quot;SFCT&quot;.
    /// </summary>
    [EnumMember(Value = "SFCT")]
    [IsoId("__0dT0NojEeC60axPepSq7g_-351803488")]
    [Description(@"The borrowing reason is for Self consumption.")]
    SelfConsumption = BorrowingReasonCode.SelfConsumption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The borrowing reason is for Transfer to thrid party.
    /// Encoded/decoded by serializers as &quot;TTTP&quot;.
    /// </summary>
    [EnumMember(Value = "TTTP")]
    [IsoId("__0dT0dojEeC60axPepSq7g_1231215891")]
    [Description(@"The borrowing reason is for Transfer to thrid party.")]
    TransferToThirdParty = BorrowingReasonCode.TransferToThirdParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The borrowing reason is for Market making purpose.
    /// Encoded/decoded by serializers as &quot;MMPP&quot;.
    /// </summary>
    [EnumMember(Value = "MMPP")]
    [IsoId("__0dT0tojEeC60axPepSq7g_-1596602642")]
    [Description(@"The borrowing reason is for Market making purpose.")]
    MarketMakingPurpose = BorrowingReasonCode.MarketMakingPurpose, // same ordinal as derivation source for type conversions
}
