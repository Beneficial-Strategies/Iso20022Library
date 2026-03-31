// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user should take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpi0B9p-Ed-ak6NoX_4Aeg_679462086")]
[Description(@"Specifies which type of action a user should take.")]
[DerivedFrom(typeof(ActionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Action1Code>))]
#endif
public enum Action1Code
{
    /// <summary>
    /// Request to submit a twin baseline.
    /// Encoded/decoded by serializers as &quot;SBTW&quot;.
    /// </summary>
    [EnumMember(Value = "SBTW")]
    [IsoId("_bpi0CNp-Ed-ak6NoX_4Aeg_722866594")]
    [Description(@"Request to submit a twin baseline.")]
    SubmitTwin = ActionCode.SubmitTwin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to resubmit a twin baseline.
    /// Encoded/decoded by serializers as &quot;RSTW&quot;.
    /// </summary>
    [EnumMember(Value = "RSTW")]
    [IsoId("_bpr98Np-Ed-ak6NoX_4Aeg_722866612")]
    [Description(@"Request to resubmit a twin baseline.")]
    ReSubmitTwin = ActionCode.ReSubmitTwin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to resubmit a baseline.
    /// Encoded/decoded by serializers as &quot;RSBS&quot;.
    /// </summary>
    [EnumMember(Value = "RSBS")]
    [IsoId("_bpr98dp-Ed-ak6NoX_4Aeg_722866637")]
    [Description(@"Request to resubmit a baseline.")]
    ReSubmitBaseline = ActionCode.ReSubmitBaseline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject mismatched data set(s).
    /// Encoded/decoded by serializers as &quot;ARDM&quot;.
    /// </summary>
    [EnumMember(Value = "ARDM")]
    [IsoId("_bpr98tp-Ed-ak6NoX_4Aeg_722866638")]
    [Description(@"Request to accept or reject mismatched data set(s).")]
    AcceptOrRejectDataSetMisMatches = ActionCode.AcceptOrRejectDataSetMisMatches, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for a change of status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARCS&quot;.
    /// </summary>
    [EnumMember(Value = "ARCS")]
    [IsoId("_bpr989p-Ed-ak6NoX_4Aeg_722866655")]
    [Description(@"Request to accept or reject a request for a change of status of the baseline.")]
    AcceptOrRejectChangeOfStatus = ActionCode.AcceptOrRejectChangeOfStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for an extension of the period of validity of the status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_bpr99Np-Ed-ak6NoX_4Aeg_722866672")]
    [Description(
        @"Request to accept or reject a request for an extension of the period of validity of the status of the baseline."
    )]
    AcceptOrRejectExtensionOfStatus = ActionCode.AcceptOrRejectExtensionOfStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to wait until the baseline is established.
    /// Encoded/decoded by serializers as &quot;WAIT&quot;.
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_bpr99dp-Ed-ak6NoX_4Aeg_-394921817")]
    [Description(@"Request to wait until the baseline is established.")]
    WaitForBaselineEstablished = ActionCode.WaitForBaselineEstablished, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to update and resend.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_bpr99tp-Ed-ak6NoX_4Aeg_-98474441")]
    [Description(@"Request to update and resend.")]
    UpdateAndResend = ActionCode.UpdateAndResend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to submit data set(s).
    /// Encoded/decoded by serializers as &quot;SBDS&quot;.
    /// </summary>
    [EnumMember(Value = "SBDS")]
    [IsoId("_bpr999p-Ed-ak6NoX_4Aeg_-851340559")]
    [Description(@"Request to submit data set(s).")]
    SubmitDataSet = ActionCode.SubmitDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for a baseline amendment.
    /// Encoded/decoded by serializers as &quot;ARBA&quot;.
    /// </summary>
    [EnumMember(Value = "ARBA")]
    [IsoId("_bpr9-Np-Ed-ak6NoX_4Aeg_1978739457")]
    [Description(@"Request to accept or reject a request for a baseline amendment.")]
    AcceptOrRejectBaselineAmendment = ActionCode.AcceptOrRejectBaselineAmendment, // same ordinal as derivation source for type conversions
}
