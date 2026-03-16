// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// ATM devices.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7UYaUIqHEeSRT5rEzcAHEw")]
[Description(@"ATM devices.")]
[Derivations(typeof(ATMDevice2Code), typeof(ATMDevice1Code))]
public enum ATMDeviceCode
{
    /// <summary>
    /// Customer display and keyboard.
    /// Encoded/decoded by serializers as &quot;CDIS&quot;.
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("__h-cIIqHEeSRT5rEzcAHEw")]
    [Description(@"Customer display and keyboard.")]
    CustomerConsole,

    /// <summary>
    /// Printer for full-size forms documents and supporting the printing of text and graphic.
    /// Encoded/decoded by serializers as &quot;DPRN&quot;.
    /// </summary>
    [EnumMember(Value = "DPRN")]
    [IsoId("_CR0GgIqIEeSRT5rEzcAHEw")]
    [Description(
        @"Printer for full-size forms documents and supporting the printing of text and graphic."
    )]
    DocumentPrinter,

    /// <summary>
    /// Event log.
    /// Encoded/decoded by serializers as &quot;JRNL&quot;.
    /// </summary>
    [EnumMember(Value = "JRNL")]
    [IsoId("_ExtQYIqIEeSRT5rEzcAHEw")]
    [Description(@"Event log.")]
    Journal,

    /// <summary>
    /// Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.
    /// Encoded/decoded by serializers as &quot;JPRN&quot;.
    /// </summary>
    [EnumMember(Value = "JPRN")]
    [IsoId("_HpcSgIqIEeSRT5rEzcAHEw")]
    [Description(
        @"Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements."
    )]
    JournalPrinter,

    /// <summary>
    /// Receipt printer used to print cut sheet documents.
    /// Encoded/decoded by serializers as &quot;RPRN&quot;.
    /// </summary>
    [EnumMember(Value = "RPRN")]
    [IsoId("_KHisoIqIEeSRT5rEzcAHEw")]
    [Description(@"Receipt printer used to print cut sheet documents.")]
    ReceiptPrinter,

    /// <summary>
    /// Receipt of the withdrawal transactions.
    /// Encoded/decoded by serializers as &quot;RWDR&quot;.
    /// </summary>
    [EnumMember(Value = "RWDR")]
    [IsoId("_Mj2-EIqIEeSRT5rEzcAHEw")]
    [Description(@"Receipt of the withdrawal transactions.")]
    WithdrawalReceipt,

    /// <summary>
    /// Alarm sensors, such as tamper, seismic or heat sensors.
    /// Encoded/decoded by serializers as &quot;ALRM&quot;.
    /// </summary>
    [EnumMember(Value = "ALRM")]
    [IsoId("_6Jq64IqsEeSIDtZ76p6McQ")]
    [Description(@"Alarm sensors, such as tamper, seismic or heat sensors.")]
    AlarmSensors,

    /// <summary>
    /// Device scanning barcodes using any scanning technology.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_8i2_0IqsEeSIDtZ76p6McQ")]
    [Description(@"Device scanning barcodes using any scanning technology.")]
    BarCodeReader,

    /// <summary>
    /// Camera, recorder, video mixer.
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_ASBZMIqtEeSIDtZ76p6McQ")]
    [Description(@"Camera, recorder, video mixer.")]
    Camera,

    /// <summary>
    /// Device dispensing card to a consumer.
    /// Encoded/decoded by serializers as &quot;CRDD&quot;.
    /// </summary>
    [EnumMember(Value = "CRDD")]
    [IsoId("_DTlswIqtEeSIDtZ76p6McQ")]
    [Description(@"Device dispensing card to a consumer.")]
    CardDispenser,

    /// <summary>
    /// Device to read and optionally write card with various entry modes.
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_G47bwIqtEeSIDtZ76p6McQ")]
    [Description(@"Device to read and optionally write card with various entry modes.")]
    CardUnit,

    /// <summary>
    /// Device accepting in-out of items as coupons, documents, bills and coins.
    /// Encoded/decoded by serializers as &quot;CSHI&quot;.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_KMFOkIqtEeSIDtZ76p6McQ")]
    [Description(@"Device accepting in-out of items as coupons, documents, bills and coins.")]
    CashInModule,

    /// <summary>
    /// Compound device with cash in module, cash dispenser, and cash exchange.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_MbN_oIqtEeSIDtZ76p6McQ")]
    [Description(@"Compound device with cash in module, cash dispenser, and cash exchange.")]
    CashRecycler,

    /// <summary>
    /// Device dispensing cash in an automated environment, or with an operator present.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_Pd1cEIqtEeSIDtZ76p6McQ")]
    [Description(
        @"Device dispensing cash in an automated environment, or with an operator present."
    )]
    CashDispenser,

    /// <summary>
    /// Check reader and check image scanner.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_RRLB8IqtEeSIDtZ76p6McQ")]
    [Description(@"Check reader and check image scanner.")]
    CheckReader,

    /// <summary>
    /// Device for the deposit of media in envelopes or deposit of bags containing bulk media.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_VS_4oIqtEeSIDtZ76p6McQ")]
    [Description(
        @"Device for the deposit of media in envelopes or deposit of bags containing bulk media."
    )]
    Deposit,

    /// <summary>
    /// Door sensors, such as cabinet, safe or vandal shield doors.
    /// Encoded/decoded by serializers as &quot;DOOR&quot;.
    /// </summary>
    [EnumMember(Value = "DOOR")]
    [IsoId("_ZK9BoIqtEeSIDtZ76p6McQ")]
    [Description(@"Door sensors, such as cabinet, safe or vandal shield doors.")]
    DoorSensors,

    /// <summary>
    /// Self service device processing items.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_b-s7oIqtEeSIDtZ76p6McQ")]
    [Description(@"Self service device processing items.")]
    InputProcessingModule,

    /// <summary>
    /// Other sensors and indicators unit.
    /// Encoded/decoded by serializers as &quot;SNSR&quot;.
    /// </summary>
    [EnumMember(Value = "SNSR")]
    [IsoId("_gAfWEIqtEeSIDtZ76p6McQ")]
    [Description(@"Other sensors and indicators unit.")]
    OtherSensor,

    /// <summary>
    /// Passbook device supporting automatic positioning of the book.
    /// Encoded/decoded by serializers as &quot;PSBK&quot;.
    /// </summary>
    [EnumMember(Value = "PSBK")]
    [IsoId("_jDZtcIqtEeSIDtZ76p6McQ")]
    [Description(@"Passbook device supporting automatic positioning of the book.")]
    PassbookPrinter,

    /// <summary>
    /// Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_ob1KsIqtEeSIDtZ76p6McQ")]
    [Description(
        @"Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions."
    )]
    PINKeypad,

    /// <summary>
    /// Device incorporating both the capabilities to scan inserted documents and optionally to print on them.
    /// Encoded/decoded by serializers as &quot;SCAN&quot;.
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_q6PG0IqtEeSIDtZ76p6McQ")]
    [Description(
        @"Device incorporating both the capabilities to scan inserted documents and optionally to print on them."
    )]
    ScannerPrinter,
}
