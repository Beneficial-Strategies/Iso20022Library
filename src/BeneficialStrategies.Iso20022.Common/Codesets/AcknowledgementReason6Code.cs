// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mppcAlIEeGATtfOBToyew_753988061")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
public enum AcknowledgementReason6Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_0mppcQlIEeGATtfOBToyew_818267667")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = AcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.
    /// Encoded/decoded by serializers as &quot;SMPG&quot;.
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_0mppcglIEeGATtfOBToyew_-243084292")]
    [Description(
        @"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process."
    )]
    MarketPracticeRuleDiscrepency = AcknowledgementReasonCode.MarketPracticeRuleDiscrepency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0mppcwlIEeGATtfOBToyew_-64965620")]
    [Description(@"Other. See Narrative.")]
    Other = AcknowledgementReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_0mppdAlIEeGATtfOBToyew_-1062037973")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually."
    )]
    NotStraightThroughProcessing = AcknowledgementReasonCode.NotStraightThroughProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_0mppdQlIEeGATtfOBToyew_-1175877039")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = AcknowledgementReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
}
