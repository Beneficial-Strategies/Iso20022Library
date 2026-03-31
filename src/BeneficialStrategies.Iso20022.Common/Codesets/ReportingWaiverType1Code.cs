// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory reporting pre-trade waiver.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OA4ukO8WEeSLA89yUYsVSw")]
[Description(@"Specifies the type of regulatory reporting pre-trade waiver.")]
[DerivedFrom(typeof(ReportingWaiverTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReportingWaiverType1Code>))]
#endif
public enum ReportingWaiverType1Code
{
    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction in illiquid financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;OILQ&quot;.
    /// </summary>
    [EnumMember(Value = "OILQ")]
    [IsoId("_PgjKge8WEeSLA89yUYsVSw")]
    [Description(
        @"Pre-trade waiver was for a negotiated transaction in illiquid financial instruments. Applicable to equity instruments."
    )]
    NegotiatedTransactionInIlliquidFinancialInstrument =
        ReportingWaiverTypeCode.NegotiatedTransactionInIlliquidFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction in liquid financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_PnWWEe8WEeSLA89yUYsVSw")]
    [Description(
        @"Pre-trade waiver was for a negotiated transaction in liquid financial instruments. Applicable to equity instruments."
    )]
    NegotiatedTransactionInLiquidFinancialInstrument =
        ReportingWaiverTypeCode.NegotiatedTransactionInLiquidFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction subject to conditions other than the current market price of that financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_PxNcse8WEeSLA89yUYsVSw")]
    [Description(
        @"Pre-trade waiver was for a negotiated transaction subject to conditions other than the current market price of that financial instruments. Applicable to equity instruments."
    )]
    NegotiatedTransactionWithConditions =
        ReportingWaiverTypeCode.NegotiatedTransactionWithConditions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;ILQD&quot;.
    /// </summary>
    [EnumMember(Value = "ILQD")]
    [IsoId("_oQTBwe8WEeSLA89yUYsVSw")]
    [Description(
        @"Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments."
    )]
    IlliquidInstrumentTransaction = ReportingWaiverTypeCode.IlliquidInstrumentTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-trade waiver was for a reference price transaction. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;RFPT&quot;.
    /// </summary>
    [EnumMember(Value = "RFPT")]
    [IsoId("_KcKw0fPbEeS_qLctCs2aRQ")]
    [Description(
        @"Pre-trade waiver was for a reference price transaction. Applicable to equity instruments."
    )]
    ReferencePriceTransaction = ReportingWaiverTypeCode.ReferencePriceTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;SIZE&quot;.
    /// </summary>
    [EnumMember(Value = "SIZE")]
    [IsoId("_H_1TMIIjEeW_KPkCyw2GUA")]
    [Description(
        @"Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments."
    )]
    AboveSpecificSizeTransaction = ReportingWaiverTypeCode.AboveSpecificSizeTransaction, // same ordinal as derivation source for type conversions
}
