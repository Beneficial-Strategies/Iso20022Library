// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indication whether both counterparties to the transaction have reported to the same trade repository or each counterparty to the transaction reported two different trade repository.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZzVAYNIGEeiG-o-KpBT4-g")]
[Description(
    @"Indication whether both counterparties to the transaction have reported to the same trade repository or each counterparty to the transaction reported two different trade repository."
)]
[DerivedFrom(typeof(TradeRepositoryReportingTypeCode))]
public enum TradeRepositoryReportingType1Code
{
    /// <summary>
    /// Only one counterparty to the transaction has reported to the same trade repository.
    /// Encoded/decoded by serializers as &quot;SWOS&quot;.
    /// </summary>
    [EnumMember(Value = "SWOS")]
    [IsoId("_LbInAdKvEeiQpdi3IGzUkA")]
    [Description(
        @"Only one counterparty to the transaction has reported to the same trade repository."
    )]
    SingleSided = TradeRepositoryReportingTypeCode.SingleSided, // same ordinal as derivation source for type conversions

    /// <summary>
    ///  Both counterparties to the transaction have reported to the same trade repository.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_LmKyUdKvEeiQpdi3IGzUkA")]
    [Description(
        @" Both counterparties to the transaction have reported to the same trade repository."
    )]
    DualSided = TradeRepositoryReportingTypeCode.DualSided, // same ordinal as derivation source for type conversions
}
