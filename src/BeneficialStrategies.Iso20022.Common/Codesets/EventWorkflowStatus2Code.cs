// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the workflow status of the announcement record based on validation procedure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1ygnIzL3EeKU9IrkkToqcw_-1596979642")]
[Description(
    @"Specifies the workflow status of the announcement record based on validation procedure."
)]
[DerivedFrom(typeof(EventWorkflowStatusCode))]
public enum EventWorkflowStatus2Code
{
    /// <summary>
    /// Announcement record has been deleted/ removed as an invalid record.
    /// Encoded/decoded by serializers as &quot;WSDE&quot;.
    /// </summary>
    [EnumMember(Value = "WSDE")]
    [IsoId("_1ygnJDL3EeKU9IrkkToqcw_-651436427")]
    [Description(@"Announcement record has been deleted/ removed as an invalid record.")]
    Deleted = EventWorkflowStatusCode.Deleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation has determined event is being cancelled by the issuer/offeror. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed.
    /// Encoded/decoded by serializers as &quot;WSCN&quot;.
    /// </summary>
    [EnumMember(Value = "WSCN")]
    [IsoId("_1ygnJTL3EeKU9IrkkToqcw_-1341432055")]
    [Description(
        @"Validation has determined event is being cancelled by the issuer/offeror. Either all information was in agreement (STP) or if manual validation was necessary authorised review and changes/updates were performed."
    )]
    Cancelled = EventWorkflowStatusCode.Cancelled, // same ordinal as derivation source for type conversions
}
