// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of event related to a system&apos;s operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRZQ5dp-Ed-ak6NoX_4Aeg_1212494654")]
[Description(@"Specifies a type of event related to a system's operation.")]
[DerivedFrom(typeof(SystemEventTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SystemEventType2Code>))]
#endif
public enum SystemEventType2Code
{
    /// <summary>
    /// Event is the cutoff time for low value payments processed by the system.
    /// Encoded/decoded by serializers as &quot;LVCO&quot;.
    /// </summary>
    [EnumMember(Value = "LVCO")]
    [IsoId("_ZRZQ5tp-Ed-ak6NoX_4Aeg_1212494689")]
    [Description(@"Event is the cutoff time for low value payments processed by the system.")]
    LVPCutOff = SystemEventTypeCode.LVPCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time after which low value payments can no longer be cancelled.
    /// Encoded/decoded by serializers as &quot;LVCC&quot;.
    /// </summary>
    [EnumMember(Value = "LVCC")]
    [IsoId("_ZRZQ59p-Ed-ak6NoX_4Aeg_1212495290")]
    [Description(
        @"Event is the cutoff time after which low value payments can no longer be cancelled."
    )]
    LVPCancellationCutOff = SystemEventTypeCode.LVPCancellationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the time at which the members will be provided with the report corresponding to the processing of low value payments.
    /// Encoded/decoded by serializers as &quot;LVRT&quot;.
    /// </summary>
    [EnumMember(Value = "LVRT")]
    [IsoId("_ZRZQ6Np-Ed-ak6NoX_4Aeg_1212495602")]
    [Description(
        @"Event is the time at which the members will be provided with the report corresponding to the processing of low value payments."
    )]
    LVPCutOffReportTime = SystemEventTypeCode.LVPCutOffReportTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the opening of the Euro 1 system operation.
    /// Encoded/decoded by serializers as &quot;EUSU&quot;.
    /// </summary>
    [EnumMember(Value = "EUSU")]
    [IsoId("_ZRjB4Np-Ed-ak6NoX_4Aeg_1212495637")]
    [Description(@"Event is the opening of the Euro 1 system operation.")]
    Euro1StartUp = SystemEventTypeCode.Euro1StartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the Step 1 system operation.
    /// Encoded/decoded by serializers as &quot;STSU&quot;.
    /// </summary>
    [EnumMember(Value = "STSU")]
    [IsoId("_ZRjB4dp-Ed-ak6NoX_4Aeg_1212495662")]
    [Description(@"Event is the start of the Step 1 system operation.")]
    Step1StartUp = SystemEventTypeCode.Step1StartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the limit warning period.
    /// Encoded/decoded by serializers as &quot;LWSU&quot;.
    /// </summary>
    [EnumMember(Value = "LWSU")]
    [IsoId("_ZRjB4tp-Ed-ak6NoX_4Aeg_1212495697")]
    [Description(@"Event is the start of the limit warning period.")]
    LimitWarningStartUp = SystemEventTypeCode.LimitWarningStartUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions.
    /// Encoded/decoded by serializers as &quot;EUCO&quot;.
    /// </summary>
    [EnumMember(Value = "EUCO")]
    [IsoId("_ZRjB49p-Ed-ak6NoX_4Aeg_1212495722")]
    [Description(
        @"Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions."
    )]
    Euro1CutOff = SystemEventTypeCode.Euro1CutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the report after all operations have ceased in the system.
    /// Encoded/decoded by serializers as &quot;FIRE&quot;.
    /// </summary>
    [EnumMember(Value = "FIRE")]
    [IsoId("_ZRjB5Np-Ed-ak6NoX_4Aeg_1213415728")]
    [Description(@"Event is the report after all operations have ceased in the system.")]
    FinalReporting = SystemEventTypeCode.FinalReporting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the start of the operating day.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_ZRjB5dp-Ed-ak6NoX_4Aeg_1213415771")]
    [Description(@"Event is the start of the operating day.")]
    StartOfDay = SystemEventTypeCode.StartOfDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTNC&quot;.
    /// </summary>
    [EnumMember(Value = "LTNC")]
    [IsoId("_ZRjB5tp-Ed-ak6NoX_4Aeg_1213415806")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system."
    )]
    LTNCutOff = SystemEventTypeCode.LTNCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the cash reservation window.
    /// Encoded/decoded by serializers as &quot;CRCO&quot;.
    /// </summary>
    [EnumMember(Value = "CRCO")]
    [IsoId("_ZRjB59p-Ed-ak6NoX_4Aeg_1213415841")]
    [Description(@"Event is the cutoff for the cash reservation window.")]
    CashReservationCutOff = SystemEventTypeCode.CashReservationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system.
    /// Encoded/decoded by serializers as &quot;RECC&quot;.
    /// </summary>
    [EnumMember(Value = "RECC")]
    [IsoId("_ZRsy4Np-Ed-ak6NoX_4Aeg_1213415866")]
    [Description(
        @"Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system."
    )]
    RecCutOff = SystemEventTypeCode.RecCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the daytime cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTGC&quot;.
    /// </summary>
    [EnumMember(Value = "LTGC")]
    [IsoId("_ZRsy4dp-Ed-ak6NoX_4Aeg_1213415926")]
    [Description(@"Event is the cutoff for the daytime cycle of the securities settlement system.")]
    LTGCutOff = SystemEventTypeCode.LTGCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTDC&quot;.
    /// </summary>
    [EnumMember(Value = "LTDC")]
    [IsoId("_ZRsy4tp-Ed-ak6NoX_4Aeg_1213415961")]
    [Description(
        @"Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system."
    )]
    LTDCutOff = SystemEventTypeCode.LTDCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for customer payments.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_ZRsy49p-Ed-ak6NoX_4Aeg_1213415978")]
    [Description(@"Event is the cutoff for customer payments.")]
    CustomerCutOff = SystemEventTypeCode.CustomerCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for interbank payments.
    /// Encoded/decoded by serializers as &quot;IBKC&quot;.
    /// </summary>
    [EnumMember(Value = "IBKC")]
    [IsoId("_ZRsy5Np-Ed-ak6NoX_4Aeg_1213416239")]
    [Description(@"Event is the cutoff for interbank payments.")]
    InterbankCutOff = SystemEventTypeCode.InterbankCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the system.
    /// Encoded/decoded by serializers as &quot;SYSC&quot;.
    /// </summary>
    [EnumMember(Value = "SYSC")]
    [IsoId("_ZRsy5dp-Ed-ak6NoX_4Aeg_1213416274")]
    [Description(@"Event is the cutoff for the system.")]
    SystemCutOff = SystemEventTypeCode.SystemCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff for the securities settlement system cash reservation window.
    /// Encoded/decoded by serializers as &quot;SSSC&quot;.
    /// </summary>
    [EnumMember(Value = "SSSC")]
    [IsoId("_ZRsy5tp-Ed-ak6NoX_4Aeg_1213416299")]
    [Description(
        @"Event is the cutoff for the securities settlement system cash reservation window."
    )]
    NetSSSReservationCutOff = SystemEventTypeCode.NetSSSReservationCutOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the expected resume time for a TARGET component.
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_ZRsy59p-Ed-ak6NoX_4Aeg_1213416334")]
    [Description(@"Event is the expected resume time for a TARGET component.")]
    ResumeOperation = SystemEventTypeCode.ResumeOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the processing of payments.
    /// Encoded/decoded by serializers as &quot;PCOT&quot;.
    /// </summary>
    [EnumMember(Value = "PCOT")]
    [IsoId("_ZRsy6Np-Ed-ak6NoX_4Aeg_1213416359")]
    [Description(@"Event is the cutoff time for the processing of payments.")]
    ProcessingCutOffTime = SystemEventTypeCode.ProcessingCutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cutoff time for the receipt of new commercial payments.
    /// Encoded/decoded by serializers as &quot;NPCT&quot;.
    /// </summary>
    [EnumMember(Value = "NPCT")]
    [IsoId("_ZRsy6dp-Ed-ak6NoX_4Aeg_1213416394")]
    [Description(@"Event is the cutoff time for the receipt of new commercial payments.")]
    NewPaymentCutOffTime = SystemEventTypeCode.NewPaymentCutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is the cut off for the standing facilities.
    /// Encoded/decoded by serializers as &quot;ESTF&quot;.
    /// </summary>
    [EnumMember(Value = "ESTF")]
    [IsoId("_ZRsy6tp-Ed-ak6NoX_4Aeg_1213416677")]
    [Description(@"Event is the cut off for the standing facilities.")]
    EndOfStandingFacilities = SystemEventTypeCode.EndOfStandingFacilities, // same ordinal as derivation source for type conversions
}
