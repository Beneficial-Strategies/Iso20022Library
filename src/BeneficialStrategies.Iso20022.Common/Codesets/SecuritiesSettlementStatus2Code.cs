// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of settlement of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JhIYoUABEeCaq78Ig8ATcA")]
[Description(@"Provides the status of settlement of an instruction.")]
[DerivedFrom(typeof(SecuritiesSettlementStatusCode))]
public enum SecuritiesSettlementStatus2Code
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_JhIYp0ABEeCaq78Ig8ATcA")]
    [Description(
        @"Instruction is pending. Settlement at the instructed settlement date is still possible."
    )]
    Pending = SecuritiesSettlementStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_JhIYq0ABEeCaq78Ig8ATcA")]
    [Description(
        @"Instruction is failing. Settlement at the instructed settlement date is no longer possible."
    )]
    Failing = SecuritiesSettlementStatusCode.Failing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is unsettled.
    /// Encoded/decoded by serializers as &quot;USET&quot;.
    /// </summary>
    [EnumMember(Value = "USET")]
    [IsoId("_q2JGs2tdEeCY4-KZ9JEyUQ_1848862818")]
    [Description(@"Instruction is unsettled.")]
    Unsettled = SecuritiesSettlementStatusCode.Unsettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full settlement.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_q2JGtGtdEeCY4-KZ9JEyUQ_371262845")]
    [Description(@"Full settlement.")]
    Settled = SecuritiesSettlementStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part of the instruction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_q2JGtWtdEeCY4-KZ9JEyUQ_-263558716")]
    [Description(@"Part of the instruction remains unsettled.")]
    PartialSettlement = SecuritiesSettlementStatusCode.PartialSettlement, // same ordinal as derivation source for type conversions
}
