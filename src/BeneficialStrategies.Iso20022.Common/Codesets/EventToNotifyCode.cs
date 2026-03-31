// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Event the POI notifies to the sale system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cViSQN6aEeiwsev40qZGEQ")]
[Description(@"Event the POI notifies to the sale system.")]
[Derivations(typeof(EventToNotify1Code), typeof(EventToNotify2Code))]
public enum EventToNotifyCode
{
    /// <summary>
    /// Maintenance required by the POI.
    /// Encoded/decoded by serializers as &quot;MAIR&quot;.
    /// </summary>
    [EnumMember(Value = "MAIR")]
    [IsoId("_hTcWsN6aEeiwsev40qZGEQ")]
    [Description(@"Maintenance required by the POI.")]
    MaintenanceRequired,

    /// <summary>
    /// Begin of POI Maintenance.
    /// Encoded/decoded by serializers as &quot;MAIB&quot;.
    /// </summary>
    [EnumMember(Value = "MAIB")]
    [IsoId("_jvdtMN6aEeiwsev40qZGEQ")]
    [Description(@"Begin of POI Maintenance.")]
    BeginMaintenance,

    /// <summary>
    /// End of POI Maintenance.
    /// Encoded/decoded by serializers as &quot;MAIE&quot;.
    /// </summary>
    [EnumMember(Value = "MAIE")]
    [IsoId("_mIgoMN6aEeiwsev40qZGEQ")]
    [Description(@"End of POI Maintenance.")]
    EndMaintenance,

    /// <summary>
    /// The POI Terminal or the POI System is shutting down.
    /// Encoded/decoded by serializers as &quot;SHUT&quot;.
    /// </summary>
    [EnumMember(Value = "SHUT")]
    [IsoId("_oZ2YsN6aEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System is shutting down.")]
    Shutdown,

    /// <summary>
    /// The POI Terminal or the POI System is now ready to work.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_sIWDsN6aEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System is now ready to work.")]
    Initialised,

    /// <summary>
    /// The POI Terminal or the POI System cannot work.
    /// Encoded/decoded by serializers as &quot;OODR&quot;.
    /// </summary>
    [EnumMember(Value = "OODR")]
    [IsoId("_upKaoN6aEeiwsev40qZGEQ")]
    [Description(@"The POI Terminal or the POI System cannot work.")]
    OutOfOrder,

    /// <summary>
    /// An Abort request has been sent to abort a message which is already completed.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_xDquMN6aEeiwsev40qZGEQ")]
    [Description(@"An Abort request has been sent to abort a message which is already completed.")]
    Completed,

    /// <summary>
    /// One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests.
    /// Encoded/decoded by serializers as &quot;ABRT&quot;.
    /// </summary>
    [EnumMember(Value = "ABRT")]
    [IsoId("_1UlJwN6aEeiwsev40qZGEQ")]
    [Description(
        @"One or several device request has been sent by the POI during the processing of a service requested by the Sale System. The processing is cancelled by the Customer or stopped by the POI. If the device response is not received by the POI, an event is sent to inform the Sale to abort internally these device requests."
    )]
    Abort,

    /// <summary>
    /// A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification.
    /// Encoded/decoded by serializers as &quot;SWUP&quot;.
    /// </summary>
    [EnumMember(Value = "SWUP")]
    [IsoId("_5V64QN6aEeiwsev40qZGEQ")]
    [Description(
        @"A POI terminal requests the payment of the transaction identified by the content of EventDetails in the Event notification."
    )]
    SaleWakeUp,

    /// <summary>
    /// The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day.
    /// Encoded/decoded by serializers as &quot;SADM&quot;.
    /// </summary>
    [EnumMember(Value = "SADM")]
    [IsoId("_BkajsN6bEeiwsev40qZGEQ")]
    [Description(
        @"The POI has performed, or want to perform an automatic administrative process, e.g. the reports at the end of day."
    )]
    SaleAdmin,

    /// <summary>
    /// The customer has selected a different language on the POI.
    /// Encoded/decoded by serializers as &quot;CUSL&quot;.
    /// </summary>
    [EnumMember(Value = "CUSL")]
    [IsoId("_EbXisN6bEeiwsev40qZGEQ")]
    [Description(@"The customer has selected a different language on the POI.")]
    CustomerLanguage,

    /// <summary>
    /// The customer has pressed a specific key on the POI.
    /// Encoded/decoded by serializers as &quot;KEYP&quot;.
    /// </summary>
    [EnumMember(Value = "KEYP")]
    [IsoId("_GmwcMN6bEeiwsev40qZGEQ")]
    [Description(@"The customer has pressed a specific key on the POI.")]
    KeyPressed,

    /// <summary>
    /// Problem of security.
    /// Encoded/decoded by serializers as &quot;SECA&quot;.
    /// </summary>
    [EnumMember(Value = "SECA")]
    [IsoId("_JIlfwN6bEeiwsev40qZGEQ")]
    [Description(@"Problem of security.")]
    SecurityAlarm,

    /// <summary>
    /// When the Customer assistance is stopped, because the Customer has completed its input.
    /// Encoded/decoded by serializers as &quot;SASS&quot;.
    /// </summary>
    [EnumMember(Value = "SASS")]
    [IsoId("_L1ApwN6bEeiwsev40qZGEQ")]
    [Description(
        @"When the Customer assistance is stopped, because the Customer has completed its input."
    )]
    StopAssistance,

    /// <summary>
    /// A card is inserted in the card reader (see Input request and NotifyCardInputFlag).
    /// Encoded/decoded by serializers as &quot;CRDI&quot;.
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_PO5WsN6bEeiwsev40qZGEQ")]
    [Description(
        @"A card is inserted in the card reader (see Input request and NotifyCardInputFlag)."
    )]
    CardInserted,

    /// <summary>
    /// A card is removed from the card reader.
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_SGw7sN6bEeiwsev40qZGEQ")]
    [Description(@"A card is removed from the card reader.")]
    CardRemoved,

    /// <summary>
    /// Connection has been set up.
    /// Encoded/decoded by serializers as &quot;CNTN&quot;.
    /// </summary>
    [EnumMember(Value = "CNTN")]
    [IsoId("_zdxhEO2sEei-V5h0ja04AA")]
    [Description(@"Connection has been set up.")]
    Connected,

    /// <summary>
    /// A disconnection occurred.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_6WGq0O2sEei-V5h0ja04AA")]
    [Description(@"A disconnection occurred.")]
    Disconnected,

    /// <summary>
    /// Transaction has been processed and approved by the POI.
    /// Encoded/decoded by serializers as &quot;TNOK&quot;.
    /// </summary>
    [EnumMember(Value = "TNOK")]
    [IsoId("_3vo-IA0uEeqUVL7sB4m7NA")]
    [Description(@"Transaction has been processed and approved by the POI.")]
    TransactionApproved,

    /// <summary>
    /// Transaction has been processed but has been declined.
    /// Encoded/decoded by serializers as &quot;TNKO&quot;.
    /// </summary>
    [EnumMember(Value = "TNKO")]
    [IsoId("_8_QdoA0uEeqUVL7sB4m7NA")]
    [Description(@"Transaction has been processed but has been declined.")]
    TransactionDeclined,
}
