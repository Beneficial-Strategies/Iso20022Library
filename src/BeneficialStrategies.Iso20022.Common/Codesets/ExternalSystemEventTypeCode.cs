// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type an event generated within a system, as published in an system event type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SrUekJ05Eeet_4BCDEBLdQ")]
[Description(
    @"Specifies the type an event generated within a system, as published in an system event type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalSystemEventType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalSystemEventTypeCode>))]
#endif
public enum ExternalSystemEventTypeCode
{
    /// <summary>
    /// Event is the cutoff for the cash reservation window.
    /// Encoded/decoded by serializers as &quot;CRCO&quot;.
    /// </summary>
    [EnumMember(Value = "CRCO")]
    [IsoId("_uhK2Y_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the cash reservation window.")]
    CashReservationCutOff,

    /// <summary>
    /// Event is the cutoff for customer payments.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_uhUAUPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for customer payments.")]
    CustomerCutOff,

    /// <summary>
    /// Event is the cut off for the standing facilities.
    /// Encoded/decoded by serializers as &quot;ESTF&quot;.
    /// </summary>
    [EnumMember(Value = "ESTF")]
    [IsoId("_uhUAU_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cut off for the standing facilities.")]
    EndOfStandingFacilities,

    /// <summary>
    /// Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions.
    /// Encoded/decoded by serializers as &quot;EUCO&quot;.
    /// </summary>
    [EnumMember(Value = "EUCO")]
    [IsoId("_uhUAVvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions."
    )]
    Euro1CutOff,

    /// <summary>
    /// Event is the opening of the Euro 1 system operation.
    /// Encoded/decoded by serializers as &quot;EUSU&quot;.
    /// </summary>
    [EnumMember(Value = "EUSU")]
    [IsoId("_uhdxUPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the opening of the Euro 1 system operation.")]
    Euro1StartUp,

    /// <summary>
    /// Event is the report after all operations have ceased in the system.
    /// Encoded/decoded by serializers as &quot;FIRE&quot;.
    /// </summary>
    [EnumMember(Value = "FIRE")]
    [IsoId("_uhdxU_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the report after all operations have ceased in the system.")]
    FinalReporting,

    /// <summary>
    /// Event is the cutoff for interbank payments.
    /// Encoded/decoded by serializers as &quot;IBKC&quot;.
    /// </summary>
    [EnumMember(Value = "IBKC")]
    [IsoId("_uhdxVvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for interbank payments.")]
    InterbankCutOff,

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTDC&quot;.
    /// </summary>
    [EnumMember(Value = "LTDC")]
    [IsoId("_uhniUPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system."
    )]
    LTDCutOff,

    /// <summary>
    /// Event is the cutoff for the daytime cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTGC&quot;.
    /// </summary>
    [EnumMember(Value = "LTGC")]
    [IsoId("_uhniU_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the daytime cycle of the securities settlement system.")]
    LTGCutOff,

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTNC&quot;.
    /// </summary>
    [EnumMember(Value = "LTNC")]
    [IsoId("_uhniVvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system."
    )]
    LTNCutOff,

    /// <summary>
    /// Event is the cutoff time after which low value payments can no longer be cancelled.
    /// Encoded/decoded by serializers as &quot;LVCC&quot;.
    /// </summary>
    [EnumMember(Value = "LVCC")]
    [IsoId("_uhniWfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff time after which low value payments can no longer be cancelled."
    )]
    LVPCancellationCutOff,

    /// <summary>
    /// Event is the cutoff time for low value payments processed by the system.
    /// Encoded/decoded by serializers as &quot;LVCO&quot;.
    /// </summary>
    [EnumMember(Value = "LVCO")]
    [IsoId("_uhwsQPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for low value payments processed by the system.")]
    LVPCutOff,

    /// <summary>
    /// Event is the time at which the members will be provided with the report corresponding to the processing of low value payments.
    /// Encoded/decoded by serializers as &quot;LVRT&quot;.
    /// </summary>
    [EnumMember(Value = "LVRT")]
    [IsoId("_uhwsQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the time at which the members will be provided with the report corresponding to the processing of low value payments."
    )]
    LVPCutOffReportTime,

    /// <summary>
    /// Event is the start of the limit warning period.
    /// Encoded/decoded by serializers as &quot;LWSU&quot;.
    /// </summary>
    [EnumMember(Value = "LWSU")]
    [IsoId("_uhwsRvRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the limit warning period.")]
    LimitWarningStartUp,

    /// <summary>
    /// Event is the cutoff time for the receipt of new commercial payments.
    /// Encoded/decoded by serializers as &quot;NPCT&quot;.
    /// </summary>
    [EnumMember(Value = "NPCT")]
    [IsoId("_uhwsSfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for the receipt of new commercial payments.")]
    NewPaymentCutOffTime,

    /// <summary>
    /// Event is the cutoff time for the processing of payments.
    /// Encoded/decoded by serializers as &quot;PCOT&quot;.
    /// </summary>
    [EnumMember(Value = "PCOT")]
    [IsoId("_uhwsTPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff time for the processing of payments.")]
    ProcessingCutOffTime,

    /// <summary>
    /// Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system.
    /// Encoded/decoded by serializers as &quot;RECC&quot;.
    /// </summary>
    [EnumMember(Value = "RECC")]
    [IsoId("_uh6dQPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system."
    )]
    RecCutOff,

    /// <summary>
    /// Event is the expected resume time for a TARGET component.
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_uh6dQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Event is the expected resume time for a TARGET component.")]
    ResumeOperation,

    /// <summary>
    /// Event is the cutoff for the securities settlement system cash reservation window.
    /// Encoded/decoded by serializers as &quot;SSSC&quot;.
    /// </summary>
    [EnumMember(Value = "SSSC")]
    [IsoId("_uh6dRvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Event is the cutoff for the securities settlement system cash reservation window."
    )]
    NetSSSReservationCutOff,

    /// <summary>
    /// Event is the start of the operating day.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_uh6dSfRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the operating day.")]
    StartOfDay,

    /// <summary>
    /// Event is the start of the Step 1 system operation.
    /// Encoded/decoded by serializers as &quot;STSU&quot;.
    /// </summary>
    [EnumMember(Value = "STSU")]
    [IsoId("_uh6dTPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the start of the Step 1 system operation.")]
    Step1StartUp,

    /// <summary>
    /// Event is the cutoff for the system.
    /// Encoded/decoded by serializers as &quot;SYSC&quot;.
    /// </summary>
    [EnumMember(Value = "SYSC")]
    [IsoId("_uiDnMPRYEeuLhpyIdtJzwg")]
    [Description(@"Event is the cutoff for the system.")]
    SystemCutOff,
}
