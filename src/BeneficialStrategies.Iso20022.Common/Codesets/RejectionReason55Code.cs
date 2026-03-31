// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IH_MOkIEemm4qhb2yFPOw")]
[Description(@"Specifies the reason the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason55Code>))]
#endif
public enum RejectionReason55Code
{
    /// <summary>
    /// Disagreement in beneficial ownership.
    /// Encoded/decoded by serializers as &quot;BENO&quot;.
    /// </summary>
    [EnumMember(Value = "BENO")]
    [IsoId("_8E9YIekJEemm4qhb2yFPOw")]
    [Description(@"Disagreement in beneficial ownership.")]
    BeneficialOwnershipDisagreement = RejectionReasonV3Code.BeneficialOwnershipDisagreement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate action pending on the financial instrument instructed.
    /// Encoded/decoded by serializers as &quot;CAEV&quot;.
    /// </summary>
    [EnumMember(Value = "CAEV")]
    [IsoId("_AXmSAekKEemm4qhb2yFPOw")]
    [Description(@"Corporate action pending on the financial instrument instructed.")]
    CorporateActionRejection = RejectionReasonV3Code.CorporateActionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_CvfWcekKEemm4qhb2yFPOw")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_T9KjYekKEemm4qhb2yFPOw")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched. It is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_P4QuEekLEemm4qhb2yFPOw")]
    [Description(@"Instruction has not been matched. It is a possible duplicate instruction.")]
    PossibleDuplicate = RejectionReasonV3Code.PossibleDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_V9wFoekLEemm4qhb2yFPOw")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing Settlement Instruction is unknown or invalid.
    /// Encoded/decoded by serializers as &quot;SSID&quot;.
    /// </summary>
    [EnumMember(Value = "SSID")]
    [IsoId("_kHyicekLEemm4qhb2yFPOw")]
    [Description(@"Standing Settlement Instruction is unknown or invalid.")]
    StandingSettlementInstructionRejection =
        RejectionReasonV3Code.StandingSettlementInstructionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_FJq80emtEemUgrefIx730g")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions
}
