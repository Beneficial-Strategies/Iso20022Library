// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQgqke5NEeCisYr99QEiWA_-1469267591")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(ModificationProcessingStatusCode))]
public enum ModificationProcessingStatus1Code
{
    /// <summary>
    /// Modification request has been acknowledged for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_jQgqku5NEeCisYr99QEiWA_1714788286")]
    [Description(
        @"Modification request has been acknowledged for further processing by the account servicer."
    )]
    Accepted = ModificationProcessingStatusCode.Accepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_jQgqk-5NEeCisYr99QEiWA_1892906958")]
    [Description(@"Modification has been rejected for further processing.")]
    Rejected = ModificationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification has been completed.
    /// Encoded/decoded by serializers as &quot;MODC&quot;.
    /// </summary>
    [EnumMember(Value = "MODC")]
    [IsoId("_jQgqlO5NEeCisYr99QEiWA_-1404987985")]
    [Description(@"Modification has been completed.")]
    Completed = ModificationProcessingStatusCode.Completed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification will not be executed.
    /// Encoded/decoded by serializers as &quot;DEND&quot;.
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_jQp0gO5NEeCisYr99QEiWA_2006746024")]
    [Description(@"Modification will not be executed.")]
    Denied = ModificationProcessingStatusCode.Denied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification is pending. It is not known at this time whether modified can be executed.
    /// Encoded/decoded by serializers as &quot;MODP&quot;.
    /// </summary>
    [EnumMember(Value = "MODP")]
    [IsoId("_jQp0ge5NEeCisYr99QEiWA_1828627352")]
    [Description(
        @"Modification is pending. It is not known at this time whether modified can be executed."
    )]
    Pending = ModificationProcessingStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification request is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_jQp0gu5NEeCisYr99QEiWA_831554999")]
    [Description(@"Modification request is in repair.")]
    InRepair = ModificationProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
}
