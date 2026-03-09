// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the status of a baseline.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bcugAtp-Ed-ak6NoX_4Aeg_-310506131")]
[Description(@"Indicates the status of a baseline.")]
[DerivedFrom(typeof(BaselineStatusCode))]
public enum BaselineStatus3Code
{
    /// <summary>
    /// Initial state of a baseline in the push-through model.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_bcugA9p-Ed-ak6NoX_4Aeg_-310506101")]
    [Description(@"Initial state of a baseline in the push-through model.")]
    Proposed = BaselineStatusCode.Proposed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final state of a baseline, in which only reporting is allowed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_bcugBNp-Ed-ak6NoX_4Aeg_-310506100")]
    [Description(@"Final state of a baseline, in which only reporting is allowed.")]
    Closed = BaselineStatusCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.
    /// Encoded/decoded by serializers as &quot;PMTC&quot;.
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_bcugBdp-Ed-ak6NoX_4Aeg_-310506070")]
    [Description(@"State of the baseline when an initial and at least one twin baselines have been submitted but it has not yet been agreed by all parties.")]
    PartiallyMatched = BaselineStatusCode.PartiallyMatched, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of the baseline when it has been agreed by all parties.
    /// Encoded/decoded by serializers as &quot;ESTD&quot;.
    /// </summary>
    [EnumMember(Value = "ESTD")]
    [IsoId("_bcugBtp-Ed-ak6NoX_4Aeg_-310506039")]
    [Description(@"State of the baseline when it has been agreed by all parties.")]
    Established = BaselineStatusCode.Established, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_bcugB9p-Ed-ak6NoX_4Aeg_-310506038")]
    [Description(@"State of a baseline, after establishment, when one or more instructions (eg, amendment request, data set submission) have been processed.")]
    Active = BaselineStatusCode.Active, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_bcugCNp-Ed-ak6NoX_4Aeg_-310506009")]
    [Description(@"State of a baseline, after establishment, when all match instructions have been processed, and no such instruction is allowed anymore.")]
    Complete = BaselineStatusCode.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;AMRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AMRQ")]
    [IsoId("_bcugCdp-Ed-ak6NoX_4Aeg_-310505730")]
    [Description(@"State of a baseline, after establishment, when an amendment has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    AmendmentRequested = BaselineStatusCode.AmendmentRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;RARQ&quot;.
    /// </summary>
    [EnumMember(Value = "RARQ")]
    [IsoId("_bc3p8Np-Ed-ak6NoX_4Aeg_-310505729")]
    [Description(@"State of a baseline, after establishment, when an reactivation has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    ReActivateRequested = BaselineStatusCode.ReActivateRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;CLRQ&quot;.
    /// </summary>
    [EnumMember(Value = "CLRQ")]
    [IsoId("_bc3p8dp-Ed-ak6NoX_4Aeg_-310505699")]
    [Description(@"State of a baseline, after establishment, when a closure has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CloseRequested = BaselineStatusCode.CloseRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;SCRQ&quot;.
    /// </summary>
    [EnumMember(Value = "SCRQ")]
    [IsoId("_bc3p8tp-Ed-ak6NoX_4Aeg_-310505698")]
    [Description(@"State of a baseline, after establishment, when a completion has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    CompleteRequested = BaselineStatusCode.CompleteRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline when a status extension has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).
    /// Encoded/decoded by serializers as &quot;SERQ&quot;.
    /// </summary>
    [EnumMember(Value = "SERQ")]
    [IsoId("_bc3p89p-Ed-ak6NoX_4Aeg_-255095303")]
    [Description(@"State of a baseline when a status extension has been requested by one party and has not yet been accepted or rejected by the counterparty(ies).")]
    StatusExtensionRequested = BaselineStatusCode.StatusExtensionRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// State of a baseline, after establishment, when data set acceptance has been requested by the matching engine and not all responses have been received from the relevant party(ies).
    /// Encoded/decoded by serializers as &quot;DARQ&quot;.
    /// </summary>
    [EnumMember(Value = "DARQ")]
    [IsoId("_bc3p9Np-Ed-ak6NoX_4Aeg_-231081862")]
    [Description(@"State of a baseline, after establishment, when data set acceptance has been requested by the matching engine and not all responses have been received from the relevant party(ies).")]
    DataSetAcceptanceRequested = BaselineStatusCode.DataSetAcceptanceRequested, // same ordinal as derivation source for type conversions
    
}
