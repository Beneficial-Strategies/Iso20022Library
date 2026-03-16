// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the order is placed, eg by quantity of units or by amount of money.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRVD59p-Ed-ak6NoX_4Aeg_-319440710")]
[Description(@"Specifies how the order is placed, eg by quantity of units or by amount of money.")]
[Derivations(
    typeof(OrderQuantityType3Code),
    typeof(OrderQuantityType1Code),
    typeof(OrderQuantityType2Code)
)]
public enum OrderQuantityTypeCode
{
    /// <summary>
    /// Order is placed by unit.
    /// Encoded/decoded by serializers as &quot;UNIT&quot;.
    /// </summary>
    [EnumMember(Value = "UNIT")]
    [IsoId("_aRVD6Np-Ed-ak6NoX_4Aeg_1363215467")]
    [Description(@"Order is placed by unit.")]
    Unit,

    /// <summary>
    /// Order is placed by amount of money.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aReN0Np-Ed-ak6NoX_4Aeg_1395535617")]
    [Description(@"Order is placed by amount of money.")]
    Amount,

    /// <summary>
    /// Transaction is another type of transaction.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aReN0dp-Ed-ak6NoX_4Aeg_-755014973")]
    [Description(@"Transaction is another type of transaction.")]
    Other,

    /// <summary>
    /// For futures - units of Measure per Time Unit (if used - must specify UnitofMeasure and TimeUnit.
    /// Encoded/decoded by serializers as &quot;UMPU&quot;.
    /// </summary>
    [EnumMember(Value = "UMPU")]
    [IsoId("_aReN0tp-Ed-ak6NoX_4Aeg_-921229596")]
    [Description(
        @"For futures - units of Measure per Time Unit (if used - must specify UnitofMeasure and TimeUnit."
    )]
    UnitsOfMeasurePerTimeUnit,

    /// <summary>
    /// Quantity of the financial instrument effectively cancelled (for CPRC status only).
    /// Encoded/decoded by serializers as &quot;AFCA&quot;.
    /// </summary>
    [EnumMember(Value = "AFCA")]
    [IsoId("_TRIcgdUcEeOz093LM8f3Hw")]
    [Description(
        @"Quantity of the financial instrument effectively cancelled (for CPRC status only)."
    )]
    CancelledQuantity,

    /// <summary>
    /// Quantity of financial instrument confirmed.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Yl13aNUcEeOz093LM8f3Hw")]
    [Description(@"Quantity of financial instrument confirmed.")]
    Confirmed,

    /// <summary>
    /// Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment.
    /// Encoded/decoded by serializers as &quot;MAIN&quot;.
    /// </summary>
    [EnumMember(Value = "MAIN")]
    [IsoId("_Yl13adUcEeOz093LM8f3Hw")]
    [Description(
        @"Minimum quantity that applies to every execution. The order may still fill against smaller orders, but the cumulative quantity of the execution must be in multiples of the Match Increment."
    )]
    MatchIncrement,

    /// <summary>
    /// Quantity of financial instrument ordered.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_Yl13atUcEeOz093LM8f3Hw")]
    [Description(@"Quantity of financial instrument ordered.")]
    OriginalOrdered,

    /// <summary>
    /// Quantity of financial instrument that has been previously executed.
    /// Encoded/decoded by serializers as &quot;PREX&quot;.
    /// </summary>
    [EnumMember(Value = "PREX")]
    [IsoId("_Yl13a9UcEeOz093LM8f3Hw")]
    [Description(@"Quantity of financial instrument that has been previously executed.")]
    PreviouslyExecuted,

    /// <summary>
    /// Quantity of financial instrument that is remaining on order.
    /// Encoded/decoded by serializers as &quot;REMI&quot;.
    /// </summary>
    [EnumMember(Value = "REMI")]
    [IsoId("_Yl13bNUcEeOz093LM8f3Hw")]
    [Description(@"Quantity of financial instrument that is remaining on order.")]
    RemainingOnOrder,

    /// <summary>
    /// Quantity of the financial instrument effectively replaced (For RPRC status only).
    /// Encoded/decoded by serializers as &quot;REMA&quot;.
    /// </summary>
    [EnumMember(Value = "REMA")]
    [IsoId("_Yl13bdUcEeOz093LM8f3Hw")]
    [Description(
        @"Quantity of the financial instrument effectively replaced (For RPRC status only)."
    )]
    ReplacedQuantity,

    /// <summary>
    /// Quantity of the financial instrument requested to be cancelled (for CPRC Status only).
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_Yl13btUcEeOz093LM8f3Hw")]
    [Description(
        @"Quantity of the financial instrument requested to be cancelled (for CPRC Status only)."
    )]
    RequestedToBeCancelledQuantity,

    /// <summary>
    /// Quantity of the financial instrument requested to be replaced (for RPRC Status only).
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_Yl13b9UcEeOz093LM8f3Hw")]
    [Description(
        @"Quantity of the financial instrument requested to be replaced (for RPRC Status only)."
    )]
    RequestedToBeReplacedQuantity,
}
