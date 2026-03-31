// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of transfer status or transfer event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_16omUNydEeqzDbuoooxhdw")]
[Description(@"Specifies a type of transfer status or transfer event.")]
[DerivedFrom(typeof(TransferStatusTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferStatusType2Code>))]
#endif
public enum TransferStatusType2Code
{
    /// <summary>
    /// Status report is sent in response to an account holding information request.
    /// Encoded/decoded by serializers as &quot;S019&quot;.
    /// </summary>
    [EnumMember(Value = "S019")]
    [IsoId("_4NeysdydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent in response to an account holding information request.")]
    AccountHoldingInformationRequest = TransferStatusTypeCode.AccountHoldingInformationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises one or more Benefit Crystallisation Events (BCE) have occurred.
    /// Encoded/decoded by serializers as &quot;BCEV&quot;.
    /// </summary>
    [EnumMember(Value = "BCEV")]
    [IsoId("_4ULQkdydEeqzDbuoooxhdw")]
    [Description(
        @"Status report advises one or more Benefit Crystallisation Events (BCE) have occurred."
    )]
    BenefitCrystallisationEvent = TransferStatusTypeCode.BenefitCrystallisationEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent to provide information required for a CSD or ICSD settlement leg.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_4ZrbodydEeqzDbuoooxhdw")]
    [Description(
        @"Status report is sent to provide information required for a CSD or ICSD settlement leg."
    )]
    CSDorICSDSettlementInformation = TransferStatusTypeCode.CSDorICSDSettlementInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises one or more drawdowns.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_4ghDcdydEeqzDbuoooxhdw")]
    [Description(@"Status report advises one or more drawdowns.")]
    Drawdown = TransferStatusTypeCode.Drawdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises cash is or has been instructed.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_4ojlIdydEeqzDbuoooxhdw")]
    [Description(@"Status report advises cash is or has been instructed.")]
    PaymentAdvice = TransferStatusTypeCode.PaymentAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a portfolio transfer instruction.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_4t5_MdydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent in response to a portfolio transfer instruction.")]
    PortfolioTransferInstruction = TransferStatusTypeCode.PortfolioTransferInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_42iWwdydEeqzDbuoooxhdw")]
    [Description(
        @"Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status."
    )]
    Information = TransferStatusTypeCode.Information, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_48Ch0dydEeqzDbuoooxhdw")]
    [Description(
        @"Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status."
    )]
    Status = TransferStatusTypeCode.Status, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a transfer-in instruction.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_5CcEwdydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent in response to a transfer-in instruction.")]
    TransferInInstruction = TransferStatusTypeCode.TransferInInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a transfer-out instruction.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_5IY7wdydEeqzDbuoooxhdw")]
    [Description(@"Status report is sent in response to a transfer-out instruction.")]
    TransferOutInstruction = TransferStatusTypeCode.TransferOutInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent to provide the number of units following a conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_mYWJ0XwiEeuQY_68iqAoCQ")]
    [Description(@"Status report is sent to provide the number of units following a conversion.")]
    ConversionStatus = TransferStatusTypeCode.ConversionStatus, // same ordinal as derivation source for type conversions
}
