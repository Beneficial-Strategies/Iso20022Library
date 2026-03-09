// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of regulatory reporting pre-trade waiver.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sNAZ0O8UEeSLA89yUYsVSw")]
[Description(@"Specifies the type of regulatory reporting pre-trade waiver.")]
[Derivations(typeof(ReportingWaiverType1Code),typeof(ReportingWaiverType3Code))]
public enum ReportingWaiverTypeCode
{
    /// <summary>
    /// Large-in-scale transactions. Applicable for all instruments.
    /// Encoded/decoded by serializers as &quot;LRGS&quot;.
    /// </summary>
    [EnumMember(Value = "LRGS")]
    [IsoId("_-1R8gO8UEeSLA89yUYsVSw")]
    [Description(@"Large-in-scale transactions. Applicable for all instruments.")]
    LargeInScale,
    
    /// <summary>
    /// Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;SIZE&quot;.
    /// </summary>
    [EnumMember(Value = "SIZE")]
    [IsoId("_Kgj34O8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for an above specific size transaction. Applicable to non-equity instruments.")]
    AboveSpecificSizeTransaction,
    
    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction in illiquid financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;OILQ&quot;.
    /// </summary>
    [EnumMember(Value = "OILQ")]
    [IsoId("_VeVNAe8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for a negotiated transaction in illiquid financial instruments. Applicable to equity instruments.")]
    NegotiatedTransactionInIlliquidFinancialInstrument,
    
    /// <summary>
    /// Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments.
    /// Encoded/decoded by serializers as &quot;ILQD&quot;.
    /// </summary>
    [EnumMember(Value = "ILQD")]
    [IsoId("_V9420e8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for an illiquid instrument transaction. Applicable to non-equity instruments.")]
    IlliquidInstrumentTransaction,
    
    /// <summary>
    /// Pre-trade waiver was for a reference price transaction. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;RFPT&quot;.
    /// </summary>
    [EnumMember(Value = "RFPT")]
    [IsoId("_WWfkEe8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for a reference price transaction. Applicable to equity instruments.")]
    ReferencePriceTransaction,
    
    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction in liquid financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_oYE6Me8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for a negotiated transaction in liquid financial instruments. Applicable to equity instruments.")]
    NegotiatedTransactionInLiquidFinancialInstrument,
    
    /// <summary>
    /// Pre-trade waiver was for a negotiated transaction subject to conditions other than the current market price of that financial instruments. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_pL3uoe8VEeSLA89yUYsVSw")]
    [Description(@"Pre-trade waiver was for a negotiated transaction subject to conditions other than the current market price of that financial instruments. Applicable to equity instruments.")]
    NegotiatedTransactionWithConditions,
    
    /// <summary>
    /// Benchmark transaction.
    /// Encoded/decoded by serializers as &quot;BENC&quot;.
    /// </summary>
    [EnumMember(Value = "BENC")]
    [IsoId("_sIJwcBqBEeWZfqhJDVHHrQ")]
    [Description(@"Benchmark transaction.")]
    BenchmarkTransaction,
    
    /// <summary>
    /// Agency cross transaction.
    /// Encoded/decoded by serializers as &quot;ACTX&quot;.
    /// </summary>
    [EnumMember(Value = "ACTX")]
    [IsoId("_0OYQsBqBEeWZfqhJDVHHrQ")]
    [Description(@"Agency cross transaction.")]
    AgencyCrossTransaction,
    
    /// <summary>
    /// Non-price forming transactions.
    /// Encoded/decoded by serializers as &quot;NPFT&quot;.
    /// </summary>
    [EnumMember(Value = "NPFT")]
    [IsoId("_5X-AsBqBEeWZfqhJDVHHrQ")]
    [Description(@"Non-price forming transactions.")]
    NonPriceFormingTransaction,
    
    /// <summary>
    /// Cancellations.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_RupQoBqCEeWZfqhJDVHHrQ")]
    [Description(@"Cancellations.|")]
    Cancellations,
    
    /// <summary>
    /// Special dividend transactions.
    /// Encoded/decoded by serializers as &quot;SDIV&quot;.
    /// </summary>
    [EnumMember(Value = "SDIV")]
    [IsoId("_WvjlwBqCEeWZfqhJDVHHrQ")]
    [Description(@"Special dividend transactions.|")]
    SpecialDividendTransaction,
    
    /// <summary>
    /// Amendments.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_YqJDIBqCEeWZfqhJDVHHrQ")]
    [Description(@"Amendments.")]
    Amendments,
    
    /// <summary>
    /// Algorithmic transactions. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;ALGO&quot;.
    /// </summary>
    [EnumMember(Value = "ALGO")]
    [IsoId("_x0nukBqCEeWZfqhJDVHHrQ")]
    [Description(@"Algorithmic transactions. Applicable to equity instruments.")]
    AlgorithmicTransaction,
    
    /// <summary>
    /// Transactions which have received price improvement. Applicable to equity instruments.
    /// Encoded/decoded by serializers as &quot;RPRI&quot;.
    /// </summary>
    [EnumMember(Value = "RPRI")]
    [IsoId("_XrZGcBqDEeWZfqhJDVHHrQ")]
    [Description(@"Transactions which have received price improvement. Applicable to equity instruments.")]
    TransactionWithPriceImprovment,
    
    /// <summary>
    /// Duplicative trade reports.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_hzmFgBqDEeWZfqhJDVHHrQ")]
    [Description(@"Duplicative trade reports.")]
    DuplicativeTradeReport,
    
    /// <summary>
    /// Transactions not contributing to the price discovery process.
    /// Encoded/decoded by serializers as &quot;TNCP&quot;.
    /// </summary>
    [EnumMember(Value = "TNCP")]
    [IsoId("_6kelQEWxEeWh1Y8PiCwMhg")]
    [Description(@"Transactions not contributing to the price discovery process.")]
    TransactionNotContributingToPriceDiscovery,
    
    /// <summary>
    /// Package transaction.
    /// Encoded/decoded by serializers as &quot;TPAC&quot;.
    /// </summary>
    [EnumMember(Value = "TPAC")]
    [IsoId("__tGr8EWxEeWh1Y8PiCwMhg")]
    [Description(@"Package transaction.")]
    PackageTransaction,
    
    /// <summary>
    /// Transaction where the contract on a commodity is exchanged for the actual physical good.
    /// Encoded/decoded by serializers as &quot;XFPH&quot;.
    /// </summary>
    [EnumMember(Value = "XFPH")]
    [IsoId("_N4PO4FyxEeWBopJHIRjb4g")]
    [Description(@"Transaction where the contract on a commodity is exchanged for the actual physical good.")]
    ExchangeForPhysical,
    
}
