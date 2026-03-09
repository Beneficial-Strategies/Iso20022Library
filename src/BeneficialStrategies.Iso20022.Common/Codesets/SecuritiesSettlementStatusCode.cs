// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the status of settlement of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2yNp-Ed-ak6NoX_4Aeg_1133514272")]
[Description(@"Provides the status of settlement of an instruction.")]
[Derivations(typeof(SecuritiesSettlementStatus1Code),typeof(SecuritiesSettlementStatus2Code),typeof(SecuritiesSettlementStatus3Code))]
public enum SecuritiesSettlementStatusCode
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZF7AsNp-Ed-ak6NoX_4Aeg_1416111561")]
    [Description(@"Instruction is pending. Settlement at the instructed settlement date is still possible.")]
    Pending,
    
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZF7Asdp-Ed-ak6NoX_4Aeg_1446590809")]
    [Description(@"Instruction is failing. Settlement at the instructed settlement date is no longer possible.")]
    Failing,
    
    /// <summary>
    /// Instruction is unsettled.
    /// Encoded/decoded by serializers as &quot;USET&quot;.
    /// </summary>
    [EnumMember(Value = "USET")]
    [IsoId("_mmp9WUABEeCaq78Ig8ATcA")]
    [Description(@"Instruction is unsettled.")]
    Unsettled,
    
    /// <summary>
    /// Part of the instruction remains unsettled.
    /// Encoded/decoded by serializers as &quot;PAIN&quot;.
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_OBoIWUABEeCaq78Ig8ATcA")]
    [Description(@"Part of the instruction remains unsettled.")]
    PartialSettlement,
    
    /// <summary>
    /// Full settlement.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_iYMY0UABEeCaq78Ig8ATcA")]
    [Description(@"Full settlement.")]
    Settled,
    
}
