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
[IsoId("_XoMGANfOEeiJ1vId85LeLw")]
[Description(@"Specifies the type of report for the penalties.")]
[Derivations(typeof(PenaltyListType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyListTypeCode>))]
public enum PenaltyListTypeCode
{
    /// <summary>
    /// To report the new penalties and the modified penalties in one single message /report.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_dd7xYNfOEeiJ1vId85LeLw")]
    [Description(@"To report the new penalties and the modified penalties in one single message /report.")]
    Current,

    /// <summary>
    /// To report a penalty list that has been amended.
    /// Encoded/decoded by serializers as &quot;FWAM&quot;.
    /// </summary>
    [EnumMember(Value = "FWAM")]
    [IsoId("_dZyRMNfOEeiJ1vId85LeLw")]
    [Description(
        @"To report a penalty list that has been amended (that is the penalty list contains only updated and/or removed penalties that have already been previously reported in a FWIS Penalty List)."
    )]
    ForwardAmend,

    /// <summary>
    /// To report a daily penalty list created for the first time.
    /// Encoded/decoded by serializers as &quot;FWIS&quot;.
    /// </summary>
    [EnumMember(Value = "FWIS")]
    [IsoId("_dVJo0NfOEeiJ1vId85LeLw")]
    [Description(
        @"To report a daily penalty list created for the first time (that is the penalty list contains only newly computed penalties)."
    )]
    ForwardInitialSubmission,
}
