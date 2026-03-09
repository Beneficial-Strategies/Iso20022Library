// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which type of action a user should take.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bp-44tp-Ed-ak6NoX_4Aeg_-1917186008")]
[Description(@"Specifies which type of action a user should take.")]
[Derivations(typeof(Action1Code),typeof(Action2Code))]
public enum ActionCode
{
    /// <summary>
    /// Request to submit a twin baseline.
    /// Encoded/decoded by serializers as &quot;SBTW&quot;.
    /// </summary>
    [EnumMember(Value = "SBTW")]
    [IsoId("_bp-449p-Ed-ak6NoX_4Aeg_-1863623745")]
    [Description(@"Request to submit a twin baseline.")]
    SubmitTwin,
    
    /// <summary>
    /// Request to resubmit a twin baseline.
    /// Encoded/decoded by serializers as &quot;RSTW&quot;.
    /// </summary>
    [EnumMember(Value = "RSTW")]
    [IsoId("_bp-45Np-Ed-ak6NoX_4Aeg_-1806365973")]
    [Description(@"Request to resubmit a twin baseline.")]
    ReSubmitTwin,
    
    /// <summary>
    /// Request to resubmit a baseline.
    /// Encoded/decoded by serializers as &quot;RSBS&quot;.
    /// </summary>
    [EnumMember(Value = "RSBS")]
    [IsoId("_bp-45dp-Ed-ak6NoX_4Aeg_-1765731022")]
    [Description(@"Request to resubmit a baseline.")]
    ReSubmitBaseline,
    
    /// <summary>
    /// Request to accept or reject mismatched data set(s).
    /// Encoded/decoded by serializers as &quot;ARDM&quot;.
    /// </summary>
    [EnumMember(Value = "ARDM")]
    [IsoId("_bp-45tp-Ed-ak6NoX_4Aeg_-1487752158")]
    [Description(@"Request to accept or reject mismatched data set(s).")]
    AcceptOrRejectDataSetMisMatches,
    
    /// <summary>
    /// Request to accept or reject a request for a change of status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARCS&quot;.
    /// </summary>
    [EnumMember(Value = "ARCS")]
    [IsoId("_bp-459p-Ed-ak6NoX_4Aeg_-1086943853")]
    [Description(@"Request to accept or reject a request for a change of status of the baseline.")]
    AcceptOrRejectChangeOfStatus,
    
    /// <summary>
    /// Request to accept or reject a request for an extension of the period of validity of the status of the baseline.
    /// Encoded/decoded by serializers as &quot;ARES&quot;.
    /// </summary>
    [EnumMember(Value = "ARES")]
    [IsoId("_bp-46Np-Ed-ak6NoX_4Aeg_-1057389344")]
    [Description(@"Request to accept or reject a request for an extension of the period of validity of the status of the baseline.")]
    AcceptOrRejectExtensionOfStatus,
    
    /// <summary>
    /// Request to wait until the baseline is established.
    /// Encoded/decoded by serializers as &quot;WAIT&quot;.
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_bqIp4Np-Ed-ak6NoX_4Aeg_-30131670")]
    [Description(@"Request to wait until the baseline is established.")]
    WaitForBaselineEstablished,
    
    /// <summary>
    /// Request to update and resend.
    /// Encoded/decoded by serializers as &quot;UPDT&quot;.
    /// </summary>
    [EnumMember(Value = "UPDT")]
    [IsoId("_bqIp4dp-Ed-ak6NoX_4Aeg_-30131189")]
    [Description(@"Request to update and resend.")]
    UpdateAndResend,
    
    /// <summary>
    /// Request to submit data set(s).
    /// Encoded/decoded by serializers as &quot;SBDS&quot;.
    /// </summary>
    [EnumMember(Value = "SBDS")]
    [IsoId("_bqIp4tp-Ed-ak6NoX_4Aeg_-1048974781")]
    [Description(@"Request to submit data set(s).")]
    SubmitDataSet,
    
    /// <summary>
    /// Request to accept or reject a request for a baseline amendment.
    /// Encoded/decoded by serializers as &quot;ARBA&quot;.
    /// </summary>
    [EnumMember(Value = "ARBA")]
    [IsoId("_bqIp49p-Ed-ak6NoX_4Aeg_-1730447921")]
    [Description(@"Request to accept or reject a request for a baseline amendment.")]
    AcceptOrRejectBaselineAmendment,
    
    /// <summary>
    /// Request to accept or reject a baseline and the role contained in it for the financial institution.
    /// Encoded/decoded by serializers as &quot;ARRO&quot;.
    /// </summary>
    [EnumMember(Value = "ARRO")]
    [IsoId("_bqIp5Np-Ed-ak6NoX_4Aeg_1290822788")]
    [Description(@"Request to accept or reject a baseline and the role contained in it for the financial institution.")]
    AcceptOrRejectBaselineAndRole,
    
    /// <summary>
    /// Request to check invoice number because it was not found.
    /// Encoded/decoded by serializers as &quot;CINR&quot;.
    /// </summary>
    [EnumMember(Value = "CINR")]
    [IsoId("_bqIp5dp-Ed-ak6NoX_4Aeg_1290822819")]
    [Description(@"Request to check invoice number because it was not found.")]
    CheckInvoiceReference,
    
}
