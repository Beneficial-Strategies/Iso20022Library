// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of event related to a system&apos;s operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZR180Np-Ed-ak6NoX_4Aeg_1960691418")]
[Description(@"Specifies a type of event related to a system's operation.")]
[Derivations(typeof(SystemEventType2Code))]
public enum SystemEventTypeCode
{
    /// <summary>
    /// Event is the cutoff time for low value payments processed by the system.
    /// Encoded/decoded by serializers as &quot;LVCO&quot;.
    /// </summary>
    [EnumMember(Value = "LVCO")]
    [IsoId("_ZR180dp-Ed-ak6NoX_4Aeg_-812777006")]
    [Description(@"Event is the cutoff time for low value payments processed by the system.")]
    LVPCutOff,
    
    /// <summary>
    /// Event is the cutoff time after which low value payments can no longer be cancelled.
    /// Encoded/decoded by serializers as &quot;LVCC&quot;.
    /// </summary>
    [EnumMember(Value = "LVCC")]
    [IsoId("_ZR180tp-Ed-ak6NoX_4Aeg_-812777005")]
    [Description(@"Event is the cutoff time after which low value payments can no longer be cancelled.")]
    LVPCancellationCutOff,
    
    /// <summary>
    /// Event is the time at which the members will be provided with the report corresponding to the processing of low value payments.
    /// Encoded/decoded by serializers as &quot;LVRT&quot;.
    /// </summary>
    [EnumMember(Value = "LVRT")]
    [IsoId("_ZR1809p-Ed-ak6NoX_4Aeg_-812777004")]
    [Description(@"Event is the time at which the members will be provided with the report corresponding to the processing of low value payments.")]
    LVPCutOffReportTime,
    
    /// <summary>
    /// Event is the opening of the Euro 1 system operation.
    /// Encoded/decoded by serializers as &quot;EUSU&quot;.
    /// </summary>
    [EnumMember(Value = "EUSU")]
    [IsoId("_ZR181Np-Ed-ak6NoX_4Aeg_-812777003")]
    [Description(@"Event is the opening of the Euro 1 system operation.")]
    Euro1StartUp,
    
    /// <summary>
    /// Event is the start of the Step 1 system operation.
    /// Encoded/decoded by serializers as &quot;STSU&quot;.
    /// </summary>
    [EnumMember(Value = "STSU")]
    [IsoId("_ZR181dp-Ed-ak6NoX_4Aeg_-812777002")]
    [Description(@"Event is the start of the Step 1 system operation.")]
    Step1StartUp,
    
    /// <summary>
    /// Event is the start of the limit warning period.
    /// Encoded/decoded by serializers as &quot;LWSU&quot;.
    /// </summary>
    [EnumMember(Value = "LWSU")]
    [IsoId("_ZR181tp-Ed-ak6NoX_4Aeg_-812776994")]
    [Description(@"Event is the start of the limit warning period.")]
    LimitWarningStartUp,
    
    /// <summary>
    /// Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions.
    /// Encoded/decoded by serializers as &quot;EUCO&quot;.
    /// </summary>
    [EnumMember(Value = "EUCO")]
    [IsoId("_ZR1819p-Ed-ak6NoX_4Aeg_-812776993")]
    [Description(@"Event is the cutoff time for the Euro1 system, that is, the deadline for processing Euro1 transactions.")]
    Euro1CutOff,
    
    /// <summary>
    /// Event is the report after all operations have ceased in the system.
    /// Encoded/decoded by serializers as &quot;FIRE&quot;.
    /// </summary>
    [EnumMember(Value = "FIRE")]
    [IsoId("_ZR182Np-Ed-ak6NoX_4Aeg_-812776992")]
    [Description(@"Event is the report after all operations have ceased in the system.")]
    FinalReporting,
    
    /// <summary>
    /// Event is the start of the operating day.
    /// Encoded/decoded by serializers as &quot;STDY&quot;.
    /// </summary>
    [EnumMember(Value = "STDY")]
    [IsoId("_ZR_t0Np-Ed-ak6NoX_4Aeg_-1748288461")]
    [Description(@"Event is the start of the operating day.")]
    StartOfDay,
    
    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTNC&quot;.
    /// </summary>
    [EnumMember(Value = "LTNC")]
    [IsoId("_ZR_t0dp-Ed-ak6NoX_4Aeg_-1748288460")]
    [Description(@"Event is the cutoff for the settlement of the cash multilateral balances resulting from the overnight cycle of the securities settlement system.")]
    LTNCutOff,
    
    /// <summary>
    /// Event is the cutoff for the cash reservation window.
    /// Encoded/decoded by serializers as &quot;CRCO&quot;.
    /// </summary>
    [EnumMember(Value = "CRCO")]
    [IsoId("_ZR_t0tp-Ed-ak6NoX_4Aeg_-1748288459")]
    [Description(@"Event is the cutoff for the cash reservation window.")]
    CashReservationCutOff,
    
    /// <summary>
    /// Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system.
    /// Encoded/decoded by serializers as &quot;RECC&quot;.
    /// </summary>
    [EnumMember(Value = "RECC")]
    [IsoId("_ZR_t09p-Ed-ak6NoX_4Aeg_-1748288458")]
    [Description(@"Event is the cutoff for the settlement of the multilateral balances stemming from the retail clearing system.")]
    RecCutOff,
    
    /// <summary>
    /// Event is the cutoff for the daytime cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTGC&quot;.
    /// </summary>
    [EnumMember(Value = "LTGC")]
    [IsoId("_ZR_t1Np-Ed-ak6NoX_4Aeg_-1748288450")]
    [Description(@"Event is the cutoff for the daytime cycle of the securities settlement system.")]
    LTGCutOff,
    
    /// <summary>
    /// Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system.
    /// Encoded/decoded by serializers as &quot;LTDC&quot;.
    /// </summary>
    [EnumMember(Value = "LTDC")]
    [IsoId("_ZR_t1dp-Ed-ak6NoX_4Aeg_-1748288449")]
    [Description(@"Event is the cutoff for the settlement of the cash multilateral balances resulting from the daylight cycle of the securities settlement system.")]
    LTDCutOff,
    
    /// <summary>
    /// Event is the cutoff for customer payments.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_ZR_t1tp-Ed-ak6NoX_4Aeg_-1748288448")]
    [Description(@"Event is the cutoff for customer payments.")]
    CustomerCutOff,
    
    /// <summary>
    /// Event is the cutoff for interbank payments.
    /// Encoded/decoded by serializers as &quot;IBKC&quot;.
    /// </summary>
    [EnumMember(Value = "IBKC")]
    [IsoId("_ZR_t19p-Ed-ak6NoX_4Aeg_-1748288447")]
    [Description(@"Event is the cutoff for interbank payments.")]
    InterbankCutOff,
    
    /// <summary>
    /// Event is the cutoff for the system.
    /// Encoded/decoded by serializers as &quot;SYSC&quot;.
    /// </summary>
    [EnumMember(Value = "SYSC")]
    [IsoId("_ZR_t2Np-Ed-ak6NoX_4Aeg_-1748288446")]
    [Description(@"Event is the cutoff for the system.")]
    SystemCutOff,
    
    /// <summary>
    /// Event is the cutoff for the securities settlement system cash reservation window.
    /// Encoded/decoded by serializers as &quot;SSSC&quot;.
    /// </summary>
    [EnumMember(Value = "SSSC")]
    [IsoId("_ZR_t2dp-Ed-ak6NoX_4Aeg_-1748288445")]
    [Description(@"Event is the cutoff for the securities settlement system cash reservation window.")]
    NetSSSReservationCutOff,
    
    /// <summary>
    /// Event is the expected resume time for a TARGET component.
    /// Encoded/decoded by serializers as &quot;REOP&quot;.
    /// </summary>
    [EnumMember(Value = "REOP")]
    [IsoId("_ZR_t2tp-Ed-ak6NoX_4Aeg_-1748288436")]
    [Description(@"Event is the expected resume time for a TARGET component.")]
    ResumeOperation,
    
    /// <summary>
    /// Event is the cutoff time for the processing of payments.
    /// Encoded/decoded by serializers as &quot;PCOT&quot;.
    /// </summary>
    [EnumMember(Value = "PCOT")]
    [IsoId("_ZSJe0Np-Ed-ak6NoX_4Aeg_-1748288435")]
    [Description(@"Event is the cutoff time for the processing of payments.")]
    ProcessingCutOffTime,
    
    /// <summary>
    /// Event is the cutoff time for the receipt of new commercial payments.
    /// Encoded/decoded by serializers as &quot;NPCT&quot;.
    /// </summary>
    [EnumMember(Value = "NPCT")]
    [IsoId("_ZSJe0dp-Ed-ak6NoX_4Aeg_-1748288434")]
    [Description(@"Event is the cutoff time for the receipt of new commercial payments.")]
    NewPaymentCutOffTime,
    
    /// <summary>
    /// Event is the cut off for the standing facilities.
    /// Encoded/decoded by serializers as &quot;ESTF&quot;.
    /// </summary>
    [EnumMember(Value = "ESTF")]
    [IsoId("_ZSJe0tp-Ed-ak6NoX_4Aeg_-1919614440")]
    [Description(@"Event is the cut off for the standing facilities.")]
    EndOfStandingFacilities,
    
}
