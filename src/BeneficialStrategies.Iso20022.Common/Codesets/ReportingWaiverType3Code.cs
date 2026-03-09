// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory reporting pre-trade waiver.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ilanfmhhEea4QYLbGPVDhg")]
[Description(@"Specifies the type of regulatory reporting pre-trade waiver.")]
[DerivedFrom(typeof(ReportingWaiverTypeCode))]
public enum ReportingWaiverType3Code
{
    /// <summary>
    /// Benchmark transaction.
    /// Encoded/decoded by serializers as &quot;BENC&quot;.
    /// </summary>
    [EnumMember(Value = "BENC")]
    [IsoId("_ilaniGhhEea4QYLbGPVDhg")]
    [Description(@"Benchmark transaction.")]
    BenchmarkTransaction = ReportingWaiverTypeCode.BenchmarkTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agency cross transaction.
    /// Encoded/decoded by serializers as &quot;ACTX&quot;.
    /// </summary>
    [EnumMember(Value = "ACTX")]
    [IsoId("_ilaniWhhEea4QYLbGPVDhg")]
    [Description(@"Agency cross transaction.")]
    AgencyCrossTransaction = ReportingWaiverTypeCode.AgencyCrossTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;ILQD&quot;.
    /// </summary>
    [EnumMember(Value = "ILQD")]
    [IsoId("_ilanhGhhEea4QYLbGPVDhg")]
    [Description(@"Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments.")]
    IlliquidInstrumentTransaction = ReportingWaiverTypeCode.IlliquidInstrumentTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;SIZE&quot;.
    /// </summary>
    [EnumMember(Value = "SIZE")]
    [IsoId("_ilani2hhEea4QYLbGPVDhg")]
    [Description(@"Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments.")]
    AboveSpecificSizeTransaction = ReportingWaiverTypeCode.AboveSpecificSizeTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellations.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_ilanh2hhEea4QYLbGPVDhg")]
    [Description(@"Cancellations.|")]
    Cancellations = ReportingWaiverTypeCode.Cancellations, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amendments.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_ilangmhhEea4QYLbGPVDhg")]
    [Description(@"Amendments.")]
    Amendments = ReportingWaiverTypeCode.Amendments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special dividend transactions.
    /// Encoded/decoded by serializers as &quot;SDIV&quot;.
    /// </summary>
    [EnumMember(Value = "SDIV")]
    [IsoId("_ilang2hhEea4QYLbGPVDhg")]
    [Description(@"Special dividend transactions.|")]
    SpecialDividendTransaction = ReportingWaiverTypeCode.SpecialDividendTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transactions which have received price improvement. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;RPRI&quot;.
    /// </summary>
    [EnumMember(Value = "RPRI")]
    [IsoId("_ilangWhhEea4QYLbGPVDhg")]
    [Description(@"Transactions which have received price improvement. Applicable to equity instruments.")]
    TransactionWithPriceImprovment = ReportingWaiverTypeCode.TransactionWithPriceImprovment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Duplicative trade reports.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_ilanhmhhEea4QYLbGPVDhg")]
    [Description(@"Duplicative trade reports.")]
    DuplicativeTradeReport = ReportingWaiverTypeCode.DuplicativeTradeReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Large-in-scale transactions. Applicable for all instruments.
    /// Encoded/decoded by serializers as &quot;LRGS&quot;.
    /// </summary>
    [EnumMember(Value = "LRGS")]
    [IsoId("_ilangGhhEea4QYLbGPVDhg")]
    [Description(@"Large-in-scale transactions. Applicable for all instruments.")]
    LargeInScale = ReportingWaiverTypeCode.LargeInScale, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transactions not contributing to the price discovery process.
    /// Encoded/decoded by serializers as &quot;TNCP&quot;.
    /// </summary>
    [EnumMember(Value = "TNCP")]
    [IsoId("_ilanhWhhEea4QYLbGPVDhg")]
    [Description(@"Transactions not contributing to the price discovery process.")]
    TransactionNotContributingToPriceDiscovery = ReportingWaiverTypeCode.TransactionNotContributingToPriceDiscovery, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Package transaction.
    /// Encoded/decoded by serializers as &quot;TPAC&quot;.
    /// </summary>
    [EnumMember(Value = "TPAC")]
    [IsoId("_ilanimhhEea4QYLbGPVDhg")]
    [Description(@"Package transaction.")]
    PackageTransaction = ReportingWaiverTypeCode.PackageTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction where the contract on a commodity is exchanged for the actual physical good.
    /// Encoded/decoded by serializers as &quot;XFPH&quot;.
    /// </summary>
    [EnumMember(Value = "XFPH")]
    [IsoId("_ilanf2hhEea4QYLbGPVDhg")]
    [Description(@"Transaction where the contract on a commodity is exchanged for the actual physical good.")]
    ExchangeForPhysical = ReportingWaiverTypeCode.ExchangeForPhysical, // same ordinal as derivation source for type conversions
    
}
