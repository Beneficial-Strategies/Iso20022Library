// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user should take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpr9-dp-Ed-ak6NoX_4Aeg_-339875295")]
[Description(@"Specifies which type of action a user should take.")]
[DerivedFrom(typeof(ActionCode))]
public enum Action2Code
{
    /// <summary>
    /// Request to submit a twin baseline.
    /// Encoded/decoded by serializers as &quot;SBTW&quot;.
    /// </summary>
    [EnumMember(Value = "SBTW")]
    [IsoId("_bp1u8Np-Ed-ak6NoX_4Aeg_-339875060")]
    [Description(@"Request to submit a twin baseline.")]
    SubmitTwin = ActionCode.SubmitTwin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to resubmit a twin baseline.
    /// Encoded/decoded by serializers as &quot;RSTW&quot;.
    /// </summary>
    [EnumMember(Value = "RSTW")]
    [IsoId("_bp1u8dp-Ed-ak6NoX_4Aeg_-339875035")]
    [Description(@"Request to resubmit a twin baseline.")]
    ReSubmitTwin = ActionCode.ReSubmitTwin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to resubmit a baseline.
    /// Encoded/decoded by serializers as &quot;RSBS&quot;.
    /// </summary>
    [EnumMember(Value = "RSBS")]
    [IsoId("_bp1u8tp-Ed-ak6NoX_4Aeg_-339875018")]
    [Description(@"Request to resubmit a baseline.")]
    ReSubmitBaseline = ActionCode.ReSubmitBaseline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject mismatched data set(s).
    /// Encoded/decoded by serializers as &quot;ARDM&quot;.
    /// </summary>
    [EnumMember(Value = "ARDM")]
    [IsoId("_bp1u89p-Ed-ak6NoX_4Aeg_-339875000")]
    [Description(@"Request to accept or reject mismatched data set(s).")]
    AcceptOrRejectDataSetMisMatches = ActionCode.AcceptOrRejectDataSetMisMatches, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for a change of status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARCS&quot;.
    /// </summary>
    [EnumMember(Value = "ARCS")]
    [IsoId("_bp1u9Np-Ed-ak6NoX_4Aeg_-339874965")]
    [Description(@"Request to accept or reject a request for a change of status of the baseline.")]
    AcceptOrRejectChangeOfStatus = ActionCode.AcceptOrRejectChangeOfStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for an extension of the period of validity of the status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_bp1u9dp-Ed-ak6NoX_4Aeg_-339874940")]
    [Description(
        @"Request to accept or reject a request for an extension of the period of validity of the status of the baseline."
    )]
    AcceptOrRejectExtensionOfStatus = ActionCode.AcceptOrRejectExtensionOfStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to wait until the baseline is established.
    /// Encoded/decoded by serializers as &quot;WAIT&quot;.
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_bp1u9tp-Ed-ak6NoX_4Aeg_-339874923")]
    [Description(@"Request to wait until the baseline is established.")]
    WaitForBaselineEstablished = ActionCode.WaitForBaselineEstablished, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to update and resend.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_bp1u99p-Ed-ak6NoX_4Aeg_-339874905")]
    [Description(@"Request to update and resend.")]
    UpdateAndResend = ActionCode.UpdateAndResend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to submit data set(s).
    /// Encoded/decoded by serializers as &quot;SBDS&quot;.
    /// </summary>
    [EnumMember(Value = "SBDS")]
    [IsoId("_bp1u-Np-Ed-ak6NoX_4Aeg_-339874615")]
    [Description(@"Request to submit data set(s).")]
    SubmitDataSet = ActionCode.SubmitDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a request for a baseline amendment.
    /// Encoded/decoded by serializers as &quot;ARBA&quot;.
    /// </summary>
    [EnumMember(Value = "ARBA")]
    [IsoId("_bp1u-dp-Ed-ak6NoX_4Aeg_-339874597")]
    [Description(@"Request to accept or reject a request for a baseline amendment.")]
    AcceptOrRejectBaselineAmendment = ActionCode.AcceptOrRejectBaselineAmendment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to accept or reject a baseline and the role contained in it for the financial institution.
    /// Encoded/decoded by serializers as &quot;ARRO&quot;.
    /// </summary>
    [EnumMember(Value = "ARRO")]
    [IsoId("_bp-44Np-Ed-ak6NoX_4Aeg_-1348151246")]
    [Description(
        @"Request to accept or reject a baseline and the role contained in it for the financial institution."
    )]
    AcceptOrRejectBaselineAndRole = ActionCode.AcceptOrRejectBaselineAndRole, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request to check invoice number because it was not found.
    /// Encoded/decoded by serializers as &quot;CINR&quot;.
    /// </summary>
    [EnumMember(Value = "CINR")]
    [IsoId("_bp-44dp-Ed-ak6NoX_4Aeg_82175680")]
    [Description(@"Request to check invoice number because it was not found.")]
    CheckInvoiceReference = ActionCode.CheckInvoiceReference, // same ordinal as derivation source for type conversions
}
