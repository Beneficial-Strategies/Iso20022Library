// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0bOh5Re2EeyPHpqpKwtFdw")]
[Description(@"Identification of the type of the transaction.")]
[DerivedFrom(typeof(ExposureTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExposureType10Code>))]
#endif
public enum ExposureType10Code
{
    /// <summary>
    /// Securities buy sell back.
    /// Encoded/decoded by serializers as &quot;SBSC&quot;.
    /// </summary>
    [EnumMember(Value = "SBSC")]
    [IsoId("_6abEMRe2EeyPHpqpKwtFdw")]
    [Description(@"Securities buy sell back.")]
    SecuritiesBuySellSellBuyBack = ExposureTypeV2Code.SecuritiesBuySellSellBuyBack, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Margin lending transaction.
    /// Encoded/decoded by serializers as &quot;MGLD&quot;.
    /// </summary>
    [EnumMember(Value = "MGLD")]
    [IsoId("_6abEMxe2EeyPHpqpKwtFdw")]
    [Description(@"Margin lending transaction. ")]
    MarginLending = ExposureTypeV2Code.MarginLending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exposure is linked to a securities lending or borrowing activity.
    /// Encoded/decoded by serializers as &quot;SLEB&quot;.
    /// </summary>
    [EnumMember(Value = "SLEB")]
    [IsoId("_6abENRe2EeyPHpqpKwtFdw")]
    [Description(@"Exposure is linked to a securities lending or borrowing activity.")]
    SecuritiesLendingAndBorrowing = ExposureTypeV2Code.SecuritiesLendingAndBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to repurchase agreement trading.
    /// Encoded/decoded by serializers as &quot;REPO&quot;.
    /// </summary>
    [EnumMember(Value = "REPO")]
    [IsoId("__sPjIRe2EeyPHpqpKwtFdw")]
    [Description(@"Relates to repurchase agreement trading.")]
    Repo = ExposureTypeV2Code.Repo, // same ordinal as derivation source for type conversions
}
