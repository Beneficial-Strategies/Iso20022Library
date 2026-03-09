// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of ATM devices.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1m2agIqtEeSIDtZ76p6McQ")]
[Description(@"List of ATM devices.")]
[DerivedFrom(typeof(ATMDeviceCode))]
public enum ATMDevice2Code
{
    /// <summary>
    /// Alarm sensors, such as tamper, seismic or heat sensors.
    /// Encoded/decoded by serializers as &quot;ALRM&quot;.
    /// </summary>
    [EnumMember(Value = "ALRM")]
    [IsoId("_6MaQYYqtEeSIDtZ76p6McQ")]
    [Description(@"Alarm sensors, such as tamper, seismic or heat sensors.")]
    AlarmSensors = ATMDeviceCode.AlarmSensors, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device scanning barcodes using any scanning technology.
    /// Encoded/decoded by serializers as &quot;BRCD&quot;.
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_6VDPA4qtEeSIDtZ76p6McQ")]
    [Description(@"Device scanning barcodes using any scanning technology.")]
    BarCodeReader = ATMDeviceCode.BarCodeReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Camera, recorder, video mixer.
    /// Encoded/decoded by serializers as &quot;CAMR&quot;.
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_6WicwYqtEeSIDtZ76p6McQ")]
    [Description(@"Camera, recorder, video mixer.")]
    Camera = ATMDeviceCode.Camera, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device dispensing card to a consumer.
    /// Encoded/decoded by serializers as &quot;CRDD&quot;.
    /// </summary>
    [EnumMember(Value = "CRDD")]
    [IsoId("_6jM_w4qtEeSIDtZ76p6McQ")]
    [Description(@"Device dispensing card to a consumer.")]
    CardDispenser = ATMDeviceCode.CardDispenser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device to read and optionally write card with various entry modes.
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_6oH8AYqtEeSIDtZ76p6McQ")]
    [Description(@"Device to read and optionally write card with various entry modes.")]
    CardUnit = ATMDeviceCode.CardUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device dispensing cash in an automated environment, or with an operator present.
    /// Encoded/decoded by serializers as &quot;CSHD&quot;.
    /// </summary>
    [EnumMember(Value = "CSHD")]
    [IsoId("_6w6ro4qtEeSIDtZ76p6McQ")]
    [Description(@"Device dispensing cash in an automated environment, or with an operator present.")]
    CashDispenser = ATMDeviceCode.CashDispenser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device accepting in-out of items as coupons, documents, bills and coins.
    /// Encoded/decoded by serializers as &quot;CSHI&quot;.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_62Ii04qtEeSIDtZ76p6McQ")]
    [Description(@"Device accepting in-out of items as coupons, documents, bills and coins.")]
    CashInModule = ATMDeviceCode.CashInModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Compound device with cash in module, cash dispenser, and cash exchange.
    /// Encoded/decoded by serializers as &quot;CSHR&quot;.
    /// </summary>
    [EnumMember(Value = "CSHR")]
    [IsoId("_6-LEgYqtEeSIDtZ76p6McQ")]
    [Description(@"Compound device with cash in module, cash dispenser, and cash exchange.")]
    CashRecycler = ATMDeviceCode.CashRecycler, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Check reader and check image scanner.
    /// Encoded/decoded by serializers as &quot;CHCK&quot;.
    /// </summary>
    [EnumMember(Value = "CHCK")]
    [IsoId("_7G90I4qtEeSIDtZ76p6McQ")]
    [Description(@"Check reader and check image scanner.")]
    CheckReader = ATMDeviceCode.CheckReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer display and keyboard.
    /// Encoded/decoded by serializers as &quot;CDIS&quot;.
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("_7Ido8YqtEeSIDtZ76p6McQ")]
    [Description(@"Customer display and keyboard.")]
    CustomerConsole = ATMDeviceCode.CustomerConsole, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device for the deposit of media in envelopes or deposit of bags containing bulk media.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_7hMSAYqtEeSIDtZ76p6McQ")]
    [Description(@"Device for the deposit of media in envelopes or deposit of bags containing bulk media.")]
    Deposit = ATMDeviceCode.Deposit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Printer for full-size forms documents and supporting the printing of text and graphic.
    /// Encoded/decoded by serializers as &quot;DPRN&quot;.
    /// </summary>
    [EnumMember(Value = "DPRN")]
    [IsoId("_7pFpwYqtEeSIDtZ76p6McQ")]
    [Description(@"Printer for full-size forms documents and supporting the printing of text and graphic.")]
    DocumentPrinter = ATMDeviceCode.DocumentPrinter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Door sensors, such as cabinet, safe or vandal shield doors.
    /// Encoded/decoded by serializers as &quot;DOOR&quot;.
    /// </summary>
    [EnumMember(Value = "DOOR")]
    [IsoId("_7yCKYYqtEeSIDtZ76p6McQ")]
    [Description(@"Door sensors, such as cabinet, safe or vandal shield doors.")]
    DoorSensors = ATMDeviceCode.DoorSensors, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Self service device processing items.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_75e2MYqtEeSIDtZ76p6McQ")]
    [Description(@"Self service device processing items.")]
    InputProcessingModule = ATMDeviceCode.InputProcessingModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event log.
    /// Encoded/decoded by serializers as &quot;JRNL&quot;.
    /// </summary>
    [EnumMember(Value = "JRNL")]
    [IsoId("_8BYN8YqtEeSIDtZ76p6McQ")]
    [Description(@"Event log.")]
    Journal = ATMDeviceCode.Journal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.
    /// Encoded/decoded by serializers as &quot;JPRN&quot;.
    /// </summary>
    [EnumMember(Value = "JPRN")]
    [IsoId("_8MtUMYqtEeSIDtZ76p6McQ")]
    [Description(@"Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.")]
    JournalPrinter = ATMDeviceCode.JournalPrinter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other sensors and indicators unit.
    /// Encoded/decoded by serializers as &quot;SNSR&quot;.
    /// </summary>
    [EnumMember(Value = "SNSR")]
    [IsoId("_8YoQUYqtEeSIDtZ76p6McQ")]
    [Description(@"Other sensors and indicators unit.")]
    OtherSensor = ATMDeviceCode.OtherSensor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Passbook device supporting automatic positioning of the book.
    /// Encoded/decoded by serializers as &quot;PSBK&quot;.
    /// </summary>
    [EnumMember(Value = "PSBK")]
    [IsoId("_8g-UAYqtEeSIDtZ76p6McQ")]
    [Description(@"Passbook device supporting automatic positioning of the book.")]
    PassbookPrinter = ATMDeviceCode.PassbookPrinter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_8oa_0YqtEeSIDtZ76p6McQ")]
    [Description(@"Hardware security module allowing the PIN (Personal Identification Number) entry, secure storing of cryptographic keys, and other cryptographic functions.")]
    PINKeypad = ATMDeviceCode.PINKeypad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receipt printer used to print cut sheet documents.
    /// Encoded/decoded by serializers as &quot;RPRN&quot;.
    /// </summary>
    [EnumMember(Value = "RPRN")]
    [IsoId("_8wxDgYqtEeSIDtZ76p6McQ")]
    [Description(@"Receipt printer used to print cut sheet documents.")]
    ReceiptPrinter = ATMDeviceCode.ReceiptPrinter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device incorporating both the capabilities to scan inserted documents and optionally to print on them.
    /// Encoded/decoded by serializers as &quot;SCAN&quot;.
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_840MQYqtEeSIDtZ76p6McQ")]
    [Description(@"Device incorporating both the capabilities to scan inserted documents and optionally to print on them.")]
    ScannerPrinter = ATMDeviceCode.ScannerPrinter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Receipt of the withdrawal transactions.
    /// Encoded/decoded by serializers as &quot;RWDR&quot;.
    /// </summary>
    [EnumMember(Value = "RWDR")]
    [IsoId("_YA_OIY65EeSUpManOYhRpw")]
    [Description(@"Receipt of the withdrawal transactions.")]
    WithdrawalReceipt = ATMDeviceCode.WithdrawalReceipt, // same ordinal as derivation source for type conversions
    
}
