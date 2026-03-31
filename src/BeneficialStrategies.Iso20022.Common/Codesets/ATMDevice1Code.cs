// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// ATM device to output message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVx90IqIEeSRT5rEzcAHEw")]
[Description(@"ATM device to output message.")]
[DerivedFrom(typeof(ATMDeviceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMDevice1Code>))]
#endif
public enum ATMDevice1Code
{
    /// <summary>
    /// Customer display and keyboard.
    /// Encoded/decoded by serializers as &quot;CDIS&quot;.
    /// </summary>
    [EnumMember(Value = "CDIS")]
    [IsoId("_dJrg0YqIEeSRT5rEzcAHEw")]
    [Description(@"Customer display and keyboard.")]
    CustomerConsole = ATMDeviceCode.CustomerConsole, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Printer for full-size forms documents and supporting the printing of text and graphic.
    /// Encoded/decoded by serializers as &quot;DPRN&quot;.
    /// </summary>
    [EnumMember(Value = "DPRN")]
    [IsoId("_dOmdEYqIEeSRT5rEzcAHEw")]
    [Description(
        @"Printer for full-size forms documents and supporting the printing of text and graphic."
    )]
    DocumentPrinter = ATMDeviceCode.DocumentPrinter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event log.
    /// Encoded/decoded by serializers as &quot;JRNL&quot;.
    /// </summary>
    [EnumMember(Value = "JRNL")]
    [IsoId("_dTqjQYqIEeSRT5rEzcAHEw")]
    [Description(@"Event log.")]
    Journal = ATMDeviceCode.Journal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements.
    /// Encoded/decoded by serializers as &quot;JPRN&quot;.
    /// </summary>
    [EnumMember(Value = "JPRN")]
    [IsoId("_dY4acYqIEeSRT5rEzcAHEw")]
    [Description(
        @"Continuous form device used to record a hardcopy audit trail of transactions, and for certain report printing requirements."
    )]
    JournalPrinter = ATMDeviceCode.JournalPrinter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt printer used to print cut sheet documents.
    /// Encoded/decoded by serializers as &quot;RPRN&quot;.
    /// </summary>
    [EnumMember(Value = "RPRN")]
    [IsoId("_desukYqIEeSRT5rEzcAHEw")]
    [Description(@"Receipt printer used to print cut sheet documents.")]
    ReceiptPrinter = ATMDeviceCode.ReceiptPrinter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receipt of the withdrawal transactions.
    /// Encoded/decoded by serializers as &quot;RWDR&quot;.
    /// </summary>
    [EnumMember(Value = "RWDR")]
    [IsoId("_djnDwYqIEeSRT5rEzcAHEw")]
    [Description(@"Receipt of the withdrawal transactions.")]
    WithdrawalReceipt = ATMDeviceCode.WithdrawalReceipt, // same ordinal as derivation source for type conversions
}
