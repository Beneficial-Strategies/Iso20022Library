// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the value is net (inclusive of tax) or gross.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zEIoUH6HEeSAlrUr1Vow5g")]
[Description(@"Specifies whether the value is net (inclusive of tax) or gross.")]
[DerivedFrom(typeof(ClearingMethodCode))]
public enum ClearingMethod1Code
{
    /// <summary>
    /// Each trade is settled by a single entry to the account of the beneficiary.
    /// Encoded/decoded by serializers as &quot;GRNE&quot;.
    /// </summary>
    [EnumMember(Value = "GRNE")]
    [IsoId("_2LokwX6HEeSAlrUr1Vow5g")]
    [Description(@"Each trade is settled by a single entry to the account of the beneficiary.")]
    GrossNegotiation = ClearingMethodCode.GrossNegotiation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively.
    /// Encoded/decoded by serializers as &quot;NEMA&quot;.
    /// </summary>
    [EnumMember(Value = "NEMA")]
    [IsoId("_2RCCIX6HEeSAlrUr1Vow5g")]
    [Description(
        @"In a foreign exchange transaction, the third party as a central clearing counterparty will settle the transaction for both sides respectively."
    )]
    NetMatch = ClearingMethodCode.NetMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement done by netting amounts (for trades in the same currency and for the same value date).
    /// Encoded/decoded by serializers as &quot;NENE&quot;.
    /// </summary>
    [EnumMember(Value = "NENE")]
    [IsoId("_2WbfgX6HEeSAlrUr1Vow5g")]
    [Description(
        @"Settlement done by netting amounts (for trades in the same currency and for the same value date)."
    )]
    NetNegotiation = ClearingMethodCode.NetNegotiation, // same ordinal as derivation source for type conversions
}
