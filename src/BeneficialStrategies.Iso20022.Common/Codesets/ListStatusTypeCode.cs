// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afe0o9p-Ed-ak6NoX_4Aeg_-430711327")]
[Description(@"Identifies the type of status.")]
[Derivations(typeof(ListStatusType1Code))]
public enum ListStatusTypeCode
{
    /// <summary>
    /// Status is an acknowledgement of the ListOrder.
    /// Encoded/decoded by serializers as &quot;ACKN&quot;.
    /// </summary>
    [EnumMember(Value = "ACKN")]
    [IsoId("_afe0pNp-Ed-ak6NoX_4Aeg_-113022536")]
    [Description(@"Status is an acknowledgement of the ListOrder.")]
    Acknowledgement,
    
    /// <summary>
    /// Status is a response to a previously sent StatusRequest.
    /// Encoded/decoded by serializers as &quot;RESP&quot;.
    /// </summary>
    [EnumMember(Value = "RESP")]
    [IsoId("_afe0pdp-Ed-ak6NoX_4Aeg_435548983")]
    [Description(@"Status is a response to a previously sent StatusRequest.")]
    Response,
    
    /// <summary>
    /// Status indicates that the ListOrder has been executed.
    /// Encoded/decoded by serializers as &quot;ADON&quot;.
    /// </summary>
    [EnumMember(Value = "ADON")]
    [IsoId("_afe0ptp-Ed-ak6NoX_4Aeg_-1600157522")]
    [Description(@"Status indicates that the ListOrder has been executed.")]
    AllDone,
    
    /// <summary>
    /// Status indicates that any of the individual orders of the ListOrder have a status that requires something to be done.
    /// Encoded/decoded by serializers as &quot;ALER&quot;.
    /// </summary>
    [EnumMember(Value = "ALER")]
    [IsoId("_afe0p9p-Ed-ak6NoX_4Aeg_-1492105658")]
    [Description(@"Status indicates that any of the individual orders of the ListOrder have a status that requires something to be done.")]
    Alert,
    
    /// <summary>
    /// Status indicates that the Execution has started.
    /// Encoded/decoded by serializers as &quot;EXST&quot;.
    /// </summary>
    [EnumMember(Value = "EXST")]
    [IsoId("_afe0qNp-Ed-ak6NoX_4Aeg_-1372044609")]
    [Description(@"Status indicates that the Execution has started.")]
    ExecutionStarted,
    
    /// <summary>
    /// Status indicated that time limit for the order has expired.
    /// Encoded/decoded by serializers as &quot;TIME&quot;.
    /// </summary>
    [EnumMember(Value = "TIME")]
    [IsoId("_afoloNp-Ed-ak6NoX_4Aeg_286598761")]
    [Description(@"Status indicated that time limit for the order has expired.")]
    Timed,
    
}
