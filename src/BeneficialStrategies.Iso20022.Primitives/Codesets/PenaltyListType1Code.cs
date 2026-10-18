// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of report for the penalties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ALeugNfPEeiJ1vId85LeLw")]
[Description(@"Specifies the type of report for the penalties.")]
[DerivedFrom(typeof(PenaltyListTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyListType1Code>))]
public enum PenaltyListType1Code
{
    /// <summary>
    /// To report the new penalties and the modified penalties in one single message /report.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_YuzTUdfPEeiJ1vId85LeLw")]
    [Description(@"To report the new penalties and the modified penalties in one single message /report.")]
    Current = PenaltyListTypeCode.Current, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To report a penalty list that has been amended.
    /// Encoded/decoded by serializers as &quot;FWAM&quot;.
    /// </summary>
    [EnumMember(Value = "FWAM")]
    [IsoId("_Y4Vp0tfPEeiJ1vId85LeLw")]
    [Description(
        @"To report a penalty list that has been amended (that is the penalty list contains only updated and/or removed penalties that have already been previously reported in a FWIS Penalty List)."
    )]
    ForwardAmend = PenaltyListTypeCode.ForwardAmend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To report a daily penalty list created for the first time.
    /// Encoded/decoded by serializers as &quot;FWIS&quot;.
    /// </summary>
    [EnumMember(Value = "FWIS")]
    [IsoId("_Y9HcIdfPEeiJ1vId85LeLw")]
    [Description(
        @"To report a daily penalty list created for the first time (that is the penalty list contains only newly computed penalties)."
    )]
    ForwardInitialSubmission = PenaltyListTypeCode.ForwardInitialSubmission, // same ordinal as derivation source for type conversions
}
