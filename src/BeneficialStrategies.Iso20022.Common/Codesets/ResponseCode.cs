// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Response code of a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVMfEAEcEeCQm6a_G2yO_w_2073012408")]
[Description(@"Response code of a transaction.")]
[Derivations(
    typeof(Response10Code),
    typeof(Response6Code),
    typeof(Response4Code),
    typeof(Response5Code),
    typeof(Response3Code),
    typeof(Response11Code),
    typeof(Response2Code),
    typeof(Response1Code),
    typeof(Response8Code),
    typeof(Response9Code)
)]
public enum ResponseCode
{
    /// <summary>
    /// Service is declined.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_TVMfEQEcEeCQm6a_G2yO_w_-587786230")]
    [Description(@"Service is declined.")]
    Declined,

    /// <summary>
    /// Service has been successfuly provided.
    /// Encoded/decoded by serializers as &quot;APPR&quot;.
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_TVMfEgEcEeCQm6a_G2yO_w_-1484977108")]
    [Description(@"Service has been successfuly provided.")]
    Approved,

    /// <summary>
    /// Service has been partialy provided.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_TVWQAAEcEeCQm6a_G2yO_w_652071159")]
    [Description(@"Service has been partialy provided.")]
    PartialApproved,

    /// <summary>
    /// Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem).
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_TVWQAQEcEeCQm6a_G2yO_w_1120878574")]
    [Description(
        @"Service cannot be provided for technical reason (eg timeout contacting the Issuer, security problem)."
    )]
    TechnicalError,

    /// <summary>
    /// Further action required to complete the transaction, for instance a referral.
    /// Encoded/decoded by serializers as &quot;FRTH&quot;.
    /// </summary>
    [EnumMember(Value = "FRTH")]
    [IsoId("_cjP3wHuGEeSZrqGdHyoIrw")]
    [Description(@"Further action required to complete the transaction, for instance a referral.")]
    FurtherAction,

    /// <summary>
    /// Advice message could not be processed.
    /// Encoded/decoded by serializers as &quot;UNPR&quot;.
    /// </summary>
    [EnumMember(Value = "UNPR")]
    [IsoId("_fW3O4HuGEeSZrqGdHyoIrw")]
    [Description(@"Advice message could not be processed.")]
    NotProcessed,

    /// <summary>
    /// Advice message is processed.
    /// Encoded/decoded by serializers as &quot;PRCS&quot;.
    /// </summary>
    [EnumMember(Value = "PRCS")]
    [IsoId("_iO0TcHuGEeSZrqGdHyoIrw")]
    [Description(@"Advice message is processed.")]
    Processed,

    /// <summary>
    /// Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_m3eIEGpUEemFuJNacM8hZA")]
    [Description(
        @"Processing of the request fails for various reasons. Some further processing according to the type of requested service, the context of the process, and some additional precision about the failure notified in the ErrorCondition data element."
    )]
    Failure,

    /// <summary>
    /// Processing OK. Information related to the result of the processing is contained in other parts of the response message.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_uKnlkGpUEemFuJNacM8hZA")]
    [Description(
        @"Processing OK. Information related to the result of the processing is contained in other parts of the response message."
    )]
    Success,

    /// <summary>
    /// Procesing of the service is deferred.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_maOtmXyLEemHsOqJOzMVfg")]
    [Description(@"Procesing of the service is deferred.")]
    Deferred,

    /// <summary>
    /// Request is still in progress.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_maOtmnyLEemHsOqJOzMVfg")]
    [Description(@"Request is still in progress.")]
    InProgress,

    /// <summary>
    /// Validate the data that couold be verified.
    /// Encoded/decoded by serializers as &quot;NRTD&quot;.
    /// </summary>
    [EnumMember(Value = "NRTD")]
    [IsoId("_maOtm3yLEemHsOqJOzMVfg")]
    [Description(@"Validate the data that couold be verified.")]
    NoReasonToDecline,

    /// <summary>
    /// Other type of processing result defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_maOtnHyLEemHsOqJOzMVfg")]
    [Description(@"Other type of processing result defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of processing result defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_maOtnXyLEemHsOqJOzMVfg")]
    [Description(@"Other type of processing result defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Other type of result.
    /// Encoded/decoded by serializers as &quot;OTRD&quot;.
    /// </summary>
    [EnumMember(Value = "OTRD")]
    [IsoId("_maOtnnyLEemHsOqJOzMVfg")]
    [Description(@"Other type of result.")]
    OtherResult,

    /// <summary>
    /// Processing of the service has been partially performed.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_maOtn3yLEemHsOqJOzMVfg")]
    [Description(@"Processing of the service has been partially performed.")]
    PartiallyProcessed,

    /// <summary>
    /// Service was rejected.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_maOtoHyLEemHsOqJOzMVfg")]
    [Description(@"Service was rejected.")]
    Rejected,

    /// <summary>
    /// Service is under review.
    /// Encoded/decoded by serializers as &quot;UNRV&quot;.
    /// </summary>
    [EnumMember(Value = "UNRV")]
    [IsoId("_maOtoXyLEemHsOqJOzMVfg")]
    [Description(@"Service is under review.")]
    UnderReview,

    /// <summary>
    /// Transaction has been received but hasn&apos;t been processed.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_v2JPUA1PEeqjM-rxn3HuXQ")]
    [Description(@"Transaction has been received but hasn't been processed.")]
    Suspended,

    /// <summary>
    /// An additional Response Code, mainly a functional one, should be considered to identify the outcome of the request.
    /// Encoded/decoded by serializers as &quot;WARN&quot;.
    /// </summary>
    [EnumMember(Value = "WARN")]
    [IsoId("_ubWUEC8MEeu125Ip9zFcsQ")]
    [Description(
        @"An additional Response Code, mainly a functional one, should be considered to identify the outcome of the request."
    )]
    Warning,
}
