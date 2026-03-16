// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the value is net (inclusive of tax) or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_99IlkA8SEeSFHsNYty4C9Q")]
[Description(@"Specifies whether the value is net (inclusive of tax) or gross.")]
[Derivations(typeof(ClearingMethod1Code), typeof(ClearingMethod2Code))]
public enum ClearingMethodCode
{
    /// <summary>
    /// Settlement done by netting amounts (for trades in the same currency and for the same value date).
    /// Encoded/decoded by serializers as &quot;NENE&quot;.
    /// </summary>
    [EnumMember(Value = "NENE")]
    [IsoId("_Gp_A8A8TEeSFHsNYty4C9Q")]
    [Description(
        @"Settlement done by netting amounts (for trades in the same currency and for the same value date)."
    )]
    NetNegotiation,

    /// <summary>
    /// Each trade is settled by a single entry to the account of the beneficiary.
    /// Encoded/decoded by serializers as &quot;GRNE&quot;.
    /// </summary>
    [EnumMember(Value = "GRNE")]
    [IsoId("_NDxNgA8TEeSFHsNYty4C9Q")]
    [Description(@"Each trade is settled by a single entry to the account of the beneficiary.")]
    GrossNegotiation,

    /// <summary>
    /// In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively.
    /// Encoded/decoded by serializers as &quot;NEMA&quot;.
    /// </summary>
    [EnumMember(Value = "NEMA")]
    [IsoId("_Tjg4IA8TEeSFHsNYty4C9Q")]
    [Description(
        @"In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively."
    )]
    NetMatch,

    /// <summary>
    /// Day clearing.
    /// Encoded/decoded by serializers as &quot;DAYC&quot;.
    /// </summary>
    [EnumMember(Value = "DAYC")]
    [IsoId("_sC6yNnx8EemHsOqJOzMVfg")]
    [Description(@"Day clearing.")]
    Day,

    /// <summary>
    /// Clearing to be deferred in time.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_sC6yN3x8EemHsOqJOzMVfg")]
    [Description(@"Clearing to be deferred in time.")]
    Deferred,

    /// <summary>
    /// Clearing for instant payments and transfers.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_sC6yOHx8EemHsOqJOzMVfg")]
    [Description(@"Clearing for instant payments and transfers.")]
    Instant,

    /// <summary>
    /// Other type of clearing method defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_sC6yOXx8EemHsOqJOzMVfg")]
    [Description(@"Other type of clearing method defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of clearing method defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_sC6yOnx8EemHsOqJOzMVfg")]
    [Description(@"Other type of clearing method defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Clearing done in real time.
    /// Encoded/decoded by serializers as &quot;RLTM&quot;.
    /// </summary>
    [EnumMember(Value = "RLTM")]
    [IsoId("_sC6yO3x8EemHsOqJOzMVfg")]
    [Description(@"Clearing done in real time.")]
    RealTime,
}
