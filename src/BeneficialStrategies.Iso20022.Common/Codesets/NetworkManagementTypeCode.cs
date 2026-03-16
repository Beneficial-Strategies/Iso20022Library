// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of network management service
/// ISO 8583 bit 24.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pkktIFWOEeeiG_nL4vgKnQ")]
[Description(@"Type of network management service|ISO 8583 bit 24.")]
[Derivations(typeof(NetworkManagementType1Code))]
public enum NetworkManagementTypeCode
{
    /// <summary>
    /// Disable receipt of store and forward advice and notification messages.
    /// Encoded/decoded by serializers as &quot;DSFW&quot;.
    /// </summary>
    [EnumMember(Value = "DSFW")]
    [IsoId("_xhPBsFWOEeeiG_nL4vgKnQ")]
    [Description(@"Disable receipt of store and forward advice and notification messages.")]
    DisableStoreAndForward,

    /// <summary>
    /// Detects whether communication at application level is still active.
    /// Encoded/decoded by serializers as &quot;ECTS&quot;.
    /// </summary>
    [EnumMember(Value = "ECTS")]
    [IsoId("_8HWEwFWOEeeiG_nL4vgKnQ")]
    [Description(@"Detects whether communication at application level is still active.")]
    EchoTest,

    /// <summary>
    /// Enable receipt of store and forward advice and notification messages.
    /// Encoded/decoded by serializers as &quot;ESFW&quot;.
    /// </summary>
    [EnumMember(Value = "ESFW")]
    [IsoId("_IAxJ0FWPEeeiG_nL4vgKnQ")]
    [Description(@"Enable receipt of store and forward advice and notification messages.")]
    EnableStoreAndForward,

    /// <summary>
    /// Establish communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNN&quot;.
    /// </summary>
    [EnumMember(Value = "SGNN")]
    [IsoId("_RrN14FWPEeeiG_nL4vgKnQ")]
    [Description(@"Establish communication at application level.")]
    SignOn,

    /// <summary>
    /// Terminate communication at application level.
    /// Encoded/decoded by serializers as &quot;SGNF&quot;.
    /// </summary>
    [EnumMember(Value = "SGNF")]
    [IsoId("_aDGG0FWPEeeiG_nL4vgKnQ")]
    [Description(@"Terminate communication at application level.")]
    SignOff,

    /// <summary>
    /// Other type of communication management service defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_hQJjYFWPEeeiG_nL4vgKnQ")]
    [Description(@"Other type of communication management service defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of network management service defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_mJURwFWPEeeiG_nL4vgKnQ")]
    [Description(@"Other type of network management service defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// System condition/target system unavailable
    /// Encoded/decoded by serializers as &quot;TSUN&quot;.
    /// </summary>
    [EnumMember(Value = "TSUN")]
    [IsoId("_jZ4pkMWSEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/target system unavailable|")]
    TargetSystemUnavailable,

    /// <summary>
    /// System condition/message originator&apos;s system in backup.
    /// Encoded/decoded by serializers as &quot;MOSB&quot;.
    /// </summary>
    [EnumMember(Value = "MOSB")]
    [IsoId("_7XAxEMWSEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/message originator's system in backup.")]
    MessageOriginatorSystemInBackup,

    /// <summary>
    /// System condition/special instruction
    /// Encoded/decoded by serializers as &quot;SPIN&quot;.
    /// </summary>
    [EnumMember(Value = "SPIN")]
    [IsoId("_B_vYkMWTEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/special instruction")]
    SpecialInstruction,

    /// <summary>
    /// System condition/initiate alternate routing
    /// Encoded/decoded by serializers as &quot;IART&quot;.
    /// </summary>
    [EnumMember(Value = "IART")]
    [IsoId("_GYQQ8MWTEeiCfKAZkk6ZAQ")]
    [Description(@"System condition/initiate alternate routing")]
    InitiateAlternateRouting,

    /// <summary>
    /// Clock synchronization
    /// Encoded/decoded by serializers as &quot;SYCL&quot;.
    /// </summary>
    [EnumMember(Value = "SYCL")]
    [IsoId("_t9eusMWTEeiCfKAZkk6ZAQ")]
    [Description(@"Clock synchronization")]
    SynchronizeClock,

    /// <summary>
    /// Enable the receipt of recurring billing.
    /// Encoded/decoded by serializers as &quot;ERBI&quot;.
    /// </summary>
    [EnumMember(Value = "ERBI")]
    [IsoId("_N_pjcOkHEemeDPHh-U9b6w")]
    [Description(@"Enable the receipt of recurring billing.")]
    EnableRecurringBilling,

    /// <summary>
    /// Disable the receipt of recurring billing.
    /// Encoded/decoded by serializers as &quot;DRBI&quot;.
    /// </summary>
    [EnumMember(Value = "DRBI")]
    [IsoId("_ZWuJYOkHEemeDPHh-U9b6w")]
    [Description(@"Disable the receipt of recurring billing.")]
    DisableRecurringBilling,
}
