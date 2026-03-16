// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type an event generated within a system, as published in an system event type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8OFBVqMgEeCJ6YNENx4h-w_1804878644")]
[Description(
    @"Specifies the type an event generated within a system, as published in an system event type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalSystemEventTypeCode))]
public enum ExternalSystemEventType1Code
{
    /// <summary>
    /// Event is the cutoff for the cash reservation window.
    /// Encoded/decoded by serializers as &quot;CRCO&quot;.
    /// </summary>
    [EnumMember(Value = "CRCO")]
    [IsoId("_uhK2ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the cash reservation window.")]
    CashReservationCutOff = ExternalSystemEventTypeCode.CashReservationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for customer payments.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_uhUAUvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for customer payments.")]
    CustomerCutOff = ExternalSystemEventTypeCode.CustomerCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cut off for the standing facilities.
    /// Encoded/decoded by serializers as &quot;ESTF&quot;.
    /// </summary>
    [EnumMember(Value = "ESTF")]
    [IsoId("_uhUAVfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cut off for the standing facilities.")]
    EndOfStandingFacilities = ExternalSystemEventTypeCode.EndOfStandingFacilities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions.
    /// Encoded/decoded by serializers as &quot;EUCO&quot;.
    /// </summary>
    [EnumMember(Value = "EUCO")]
    [IsoId("_uhUAWPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions."
    )]
    Euro1CutOff = ExternalSystemEventTypeCode.Euro1CutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the opening of the Euro 1 system operation.
    /// Encoded/decoded by serializers as &quot;EUSU&quot;.
    /// </summary>
    [EnumMember(Value = "EUSU")]
    [IsoId("_uhdxUvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the opening of the Euro 1 system operation.")]
    Euro1StartUp = ExternalSystemEventTypeCode.Euro1StartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the report after all operations have ceased in the system.
    /// Encoded/decoded by serializers as &quot;FIRE&quot;.
    /// </summary>
    [EnumMember(Value = "FIRE")]
    [IsoId("_uhdxVfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the report after all operations have ceased in the system.")]
    FinalReporting = ExternalSystemEventTypeCode.FinalReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for interbank payments.
    /// Encoded/decoded by serializers as &quot;IBKC&quot;.
    /// </summary>
    [EnumMember(Value = "IBKC")]
    [IsoId("_uhdxWPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for interbank payments.")]
    InterbankCutOff = ExternalSystemEventTypeCode.InterbankCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTDC&quot;.
    /// </summary>
    [EnumMember(Value = "LTDC")]
    [IsoId("_uhniUvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system."
    )]
    LTDCutOff = ExternalSystemEventTypeCode.LTDCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the daytime cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTGC&quot;.
    /// </summary>
    [EnumMember(Value = "LTGC")]
    [IsoId("_uhniVfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the daytime cycle of the securities settlement system.")]
    LTGCutOff = ExternalSystemEventTypeCode.LTGCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTNC&quot;.
    /// </summary>
    [EnumMember(Value = "LTNC")]
    [IsoId("_uhniWPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system."
    )]
    LTNCutOff = ExternalSystemEventTypeCode.LTNCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time after which low value payments can no longer be cancelled.
    /// Encoded/decoded by serializers as &quot;LVCC&quot;.
    /// </summary>
    [EnumMember(Value = "LVCC")]
    [IsoId("_uhniW_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff time after which low value payments can no longer be cancelled."
    )]
    LVPCancellationCutOff = ExternalSystemEventTypeCode.LVPCancellationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for low value payments processed by the system.
    /// Encoded/decoded by serializers as &quot;LVCO&quot;.
    /// </summary>
    [EnumMember(Value = "LVCO")]
    [IsoId("_uhwsQvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for low value payments processed by the system.")]
    LVPCutOff = ExternalSystemEventTypeCode.LVPCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the time at which the members will be provided with the report corresponding to the processing of low value payments.
    /// Encoded/decoded by serializers as &quot;LVRT&quot;.
    /// </summary>
    [EnumMember(Value = "LVRT")]
    [IsoId("_uhwsRfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the time at which the members will be provided with the report corresponding to the processing of low value payments."
    )]
    LVPCutOffReportTime = ExternalSystemEventTypeCode.LVPCutOffReportTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the limit warning period.
    /// Encoded/decoded by serializers as &quot;LWSU&quot;.
    /// </summary>
    [EnumMember(Value = "LWSU")]
    [IsoId("_uhwsSPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the limit warning period.")]
    LimitWarningStartUp = ExternalSystemEventTypeCode.LimitWarningStartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the receipt of new commercial payments.
    /// Encoded/decoded by serializers as &quot;NPCT&quot;.
    /// </summary>
    [EnumMember(Value = "NPCT")]
    [IsoId("_uhwsS_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for the receipt of new commercial payments.")]
    NewPaymentCutOffTime = ExternalSystemEventTypeCode.NewPaymentCutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the processing of payments.
    /// Encoded/decoded by serializers as &quot;PCOT&quot;.
    /// </summary>
    [EnumMember(Value = "PCOT")]
    [IsoId("_uhwsTvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for the processing of payments.")]
    ProcessingCutOffTime = ExternalSystemEventTypeCode.ProcessingCutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system.
    /// Encoded/decoded by serializers as &quot;RECC&quot;.
    /// </summary>
    [EnumMember(Value = "RECC")]
    [IsoId("_uh6dQvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system."
    )]
    RecCutOff = ExternalSystemEventTypeCode.RecCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the expected resume time for a TARGET component.
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_uh6dRfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the expected resume time for a TARGET component.")]
    ResumeOperation = ExternalSystemEventTypeCode.ResumeOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the securities settlement system cash reservation window.
    /// Encoded/decoded by serializers as &quot;SSSC&quot;.
    /// </summary>
    [EnumMember(Value = "SSSC")]
    [IsoId("_uh6dSPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the securities settlement system cash reservation window."
    )]
    NetSSSReservationCutOff = ExternalSystemEventTypeCode.NetSSSReservationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the operating day.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_uh6dS_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the operating day.")]
    StartOfDay = ExternalSystemEventTypeCode.StartOfDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the Step 1 system operation.
    /// Encoded/decoded by serializers as &quot;STSU&quot;.
    /// </summary>
    [EnumMember(Value = "STSU")]
    [IsoId("_uh6dTvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the Step 1 system operation.")]
    Step1StartUp = ExternalSystemEventTypeCode.Step1StartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the system.
    /// Encoded/decoded by serializers as &quot;SYSC&quot;.
    /// </summary>
    [EnumMember(Value = "SYSC")]
    [IsoId("_uiDnMvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the system.")]
    SystemCutOff = ExternalSystemEventTypeCode.SystemCutOff, // same ordinal as derivation source for type conversions
}
