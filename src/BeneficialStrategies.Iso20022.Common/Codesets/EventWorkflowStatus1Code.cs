// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1yNsNDL3EeKU9IrkkToqcw_804712401")]
[Description(
    @"Specifies the workflow status of the announcement record based on validation procedure."
)]
[DerivedFrom(typeof(EventWorkflowStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventWorkflowStatus1Code>))]
#endif
public enum EventWorkflowStatus1Code
{
    /// <summary>
    /// All of the required data has been populated. Any conflicting data has been resolved. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.
    /// Encoded/decoded by serializers as &quot;WSAP&quot;.
    /// </summary>
    [EnumMember(Value = "WSAP")]
    [IsoId("_1yNsNTL3EeKU9IrkkToqcw_-1182982813")]
    [Description(
        @"All of the required data has been populated. Any conflicting data has been resolved. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed."
    )]
    Approved = EventWorkflowStatusCode.Approved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation review was performed and event has been modified. Event is pending authorised approval.
    /// Encoded/decoded by serializers as &quot;WSPA&quot;.
    /// </summary>
    [EnumMember(Value = "WSPA")]
    [IsoId("_1yXdMDL3EeKU9IrkkToqcw_-1296821879")]
    [Description(
        @"Validation review was performed and event has been modified. Event is pending authorised approval."
    )]
    PendingApproval = EventWorkflowStatusCode.PendingApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Announcement has been confirmed but not all of the required data is available. Event was validated or specific STP criteria was met, however data is still pending confirmation of the event.
    /// Encoded/decoded by serializers as &quot;WSCA&quot;.
    /// </summary>
    [EnumMember(Value = "WSCA")]
    [IsoId("_1yXdMTL3EeKU9IrkkToqcw_1268115494")]
    [Description(
        @"Announcement has been confirmed but not all of the required data is available. Event was validated or specific STP criteria was met, however data is still pending confirmation of the event."
    )]
    ConditionallyApproved = EventWorkflowStatusCode.ConditionallyApproved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation review has been performed and event has been modified. Announcement has been confirmed but not all of the required data is available. Even record is pending authorised approval.
    /// Encoded/decoded by serializers as &quot;WSPN&quot;.
    /// </summary>
    [EnumMember(Value = "WSPN")]
    [IsoId("_1yXdMjL3EeKU9IrkkToqcw_1154276428")]
    [Description(
        @"Validation review has been performed and event has been modified. Announcement has been confirmed but not all of the required data is available. Even record is pending authorised approval."
    )]
    PendingConditionalApproval = EventWorkflowStatusCode.PendingConditionalApproval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two or more sources disagree on one or more data elements.
    /// Encoded/decoded by serializers as &quot;WSCT&quot;.
    /// </summary>
    [EnumMember(Value = "WSCT")]
    [IsoId("_1yXdMzL3EeKU9IrkkToqcw_1722202763")]
    [Description(@"Two or more sources disagree on one or more data elements.")]
    InConflict = EventWorkflowStatusCode.InConflict, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Required data is not available. Announcement record cannot be verified.
    /// Encoded/decoded by serializers as &quot;WSIN&quot;.
    /// </summary>
    [EnumMember(Value = "WSIN")]
    [IsoId("_1yXdNDL3EeKU9IrkkToqcw_1711103986")]
    [Description(@"Required data is not available. Announcement record cannot be verified.")]
    Incomplete = EventWorkflowStatusCode.Incomplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation has determined the announcement record to be invalid. Pending authorisation.
    /// Encoded/decoded by serializers as &quot;WSPD&quot;.
    /// </summary>
    [EnumMember(Value = "WSPD")]
    [IsoId("_1yXdNTL3EeKU9IrkkToqcw_18923789")]
    [Description(
        @"Validation has determined the announcement record to be invalid. Pending authorisation."
    )]
    PendingDeleted = EventWorkflowStatusCode.PendingDeleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Announcement record is not supported by validation service.
    /// Encoded/decoded by serializers as &quot;WSNS&quot;.
    /// </summary>
    [EnumMember(Value = "WSNS")]
    [IsoId("_1ygnIDL3EeKU9IrkkToqcw_-94915277")]
    [Description(@"Announcement record is not supported by validation service.")]
    NotSupported = EventWorkflowStatusCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation has determined that the record is not supported. Pending authorisations.
    /// Encoded/decoded by serializers as &quot;WSPS&quot;.
    /// </summary>
    [EnumMember(Value = "WSPS")]
    [IsoId("_1ygnITL3EeKU9IrkkToqcw_-298852872")]
    [Description(
        @"Validation has determined that the record is not supported. Pending authorisations."
    )]
    PendingNotSupported = EventWorkflowStatusCode.PendingNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation has determined event is being cancelled by the issuer/offeror. Pending authorisation.
    /// Encoded/decoded by serializers as &quot;WSPC&quot;.
    /// </summary>
    [EnumMember(Value = "WSPC")]
    [IsoId("_1ygnIjL3EeKU9IrkkToqcw_1731496793")]
    [Description(
        @"Validation has determined event is being cancelled by the issuer/offeror. Pending authorisation."
    )]
    PendingCancelled = EventWorkflowStatusCode.PendingCancelled, // same ordinal as derivation source for type conversions
}
