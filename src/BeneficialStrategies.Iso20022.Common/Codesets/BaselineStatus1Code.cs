// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VroEEtp-Ed-ak6NoX_4Aeg_-553164939")]
[Description(@"Indicates the status of a baseline.")]
[DerivedFrom(typeof(BaselineStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BaselineStatus1Code>))]
#endif
public enum BaselineStatus1Code
{
    /// <summary>
    /// Initial state of a baseline in the push-through model.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_VroEE9p-Ed-ak6NoX_4Aeg_-466355902")]
    [Description(@"Initial state of a baseline in the push-through model.")]
    Proposed = BaselineStatusCode.Proposed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final state of a baseline, in which only reporting is allowed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_VroEFNp-Ed-ak6NoX_4Aeg_-466355652")]
    [Description(@"Final state of a baseline, in which only reporting is allowed.")]
    Closed = BaselineStatusCode.Closed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.
    /// Encoded/decoded by serializers as &quot;PMTC&quot;.
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_VroEFdp-Ed-ak6NoX_4Aeg_-466355340")]
    [Description(
        @"State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties."
    )]
    PartiallyMatched = BaselineStatusCode.PartiallyMatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of the baseline when it has been agreed by all parties.
    /// Encoded/decoded by serializers as &quot;ESTD&quot;.
    /// </summary>
    [EnumMember(Value = "ESTD")]
    [IsoId("_VroEFtp-Ed-ak6NoX_4Aeg_-466354989")]
    [Description(@"State of the baseline when it has been agreed by all parties.")]
    Established = BaselineStatusCode.Established, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_VroEF9p-Ed-ak6NoX_4Aeg_-466354859")]
    [Description(
        @"State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed."
    )]
    Active = BaselineStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_VroEGNp-Ed-ak6NoX_4Aeg_-466354782")]
    [Description(
        @"State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore."
    )]
    Complete = BaselineStatusCode.Complete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;AMRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AMRQ")]
    [IsoId("_VroEGdp-Ed-ak6NoX_4Aeg_1702042057")]
    [Description(
        @"State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies)."
    )]
    AmendmentRequested = BaselineStatusCode.AmendmentRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;RARQ&quot;.
    /// </summary>
    [EnumMember(Value = "RARQ")]
    [IsoId("_VrxOANp-Ed-ak6NoX_4Aeg_1729748001")]
    [Description(
        @"State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies)."
    )]
    ReActivateRequested = BaselineStatusCode.ReActivateRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_VrxOAdp-Ed-ak6NoX_4Aeg_1755607224")]
    [Description(
        @"State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies)."
    )]
    CloseRequested = BaselineStatusCode.CloseRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;SCRQ&quot;.
    /// </summary>
    [EnumMember(Value = "SCRQ")]
    [IsoId("_VrxOAtp-Ed-ak6NoX_4Aeg_1181914907")]
    [Description(
        @"State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies)."
    )]
    CompleteRequested = BaselineStatusCode.CompleteRequested, // same ordinal as derivation source for type conversions
}
