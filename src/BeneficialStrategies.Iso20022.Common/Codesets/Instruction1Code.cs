// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW12Adp-Ed-ak6NoX_4Aeg_-499701817")]
[Description(
    @"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s)."
)]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction1Code
{
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as &quot;PBEN&quot;.
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_aW12Atp-Ed-ak6NoX_4Aeg_-499701816")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity.")]
    PayTheBeneficiary = InstructionCode.PayTheBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as &quot;TTIL&quot;.
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_aW12A9p-Ed-ak6NoX_4Aeg_-499701815")]
    [Description(
        @"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected."
    )]
    TimeTill = InstructionCode.TimeTill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as &quot;TFRO&quot;.
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_aW12BNp-Ed-ak6NoX_4Aeg_-499701814")]
    [Description(
        @"Payment instruction will be valid and eligible for execution from the date and time stipulated."
    )]
    TimeFrom = InstructionCode.TimeFrom, // same ordinal as derivation source for type conversions
}
