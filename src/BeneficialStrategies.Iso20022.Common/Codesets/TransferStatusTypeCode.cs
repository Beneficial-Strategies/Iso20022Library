// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of transfer status or transfer event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RqsCgFNYEeijdq8ilaxyOA")]
[Description(@"Specifies a type of transfer status or transfer event.")]
[Derivations(typeof(TransferStatusType1Code), typeof(TransferStatusType2Code))]
public enum TransferStatusTypeCode
{
    /// <summary>
    /// Status report is sent in response to an account holding information request.
    /// Encoded/decoded by serializers as &quot;S019&quot;.
    /// </summary>
    [EnumMember(Value = "S019")]
    [IsoId("_WVIYYFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to an account holding information request.")]
    AccountHoldingInformationRequest,

    /// <summary>
    /// Status report is sent in response to a portfolio transfer instruction.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_YfySEFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a portfolio transfer instruction.")]
    PortfolioTransferInstruction,

    /// <summary>
    /// Status report is sent in response to a transfer-out instruction.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_geE-UFNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a transfer-out instruction.")]
    TransferOutInstruction,

    /// <summary>
    /// Status report is sent in response to a transfer-in instruction.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_nru30FNYEeijdq8ilaxyOA")]
    [Description(@"Status report is sent in response to a transfer-in instruction.")]
    TransferInInstruction,

    /// <summary>
    /// Status report advises one or more drawdowns.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_rZUj4FNYEeijdq8ilaxyOA")]
    [Description(@"Status report advises one or more drawdowns.")]
    Drawdown,

    /// <summary>
    /// Status report advises one or more Benefit Crystallisation Events (BCE) have occurred.
    /// Encoded/decoded by serializers as &quot;BCEV&quot;.
    /// </summary>
    [EnumMember(Value = "BCEV")]
    [IsoId("_tvbfoFNYEeijdq8ilaxyOA")]
    [Description(
        @"Status report advises one or more Benefit Crystallisation Events (BCE) have occurred."
    )]
    BenefitCrystallisationEvent,

    /// <summary>
    /// Status report advises cash is or has been instructed.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_VzEPYFUUEeiQFOf5GRHqeQ")]
    [Description(@"Status report advises cash is or has been instructed.")]
    PaymentAdvice,

    /// <summary>
    /// Status report is sent to provide information required for a CSD or ICSD settlement leg.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_HuLkYOi5EeifCsigq7uLaQ")]
    [Description(
        @"Status report is sent to provide information required for a CSD or ICSD settlement leg."
    )]
    CSDorICSDSettlementInformation,

    /// <summary>
    /// Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_XKONINydEeqzDbuoooxhdw")]
    [Description(
        @"Status report is sent to provide the status of a transfer. May be sent in response to a request for transfer status."
    )]
    Status,

    /// <summary>
    /// Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_p16QMNydEeqzDbuoooxhdw")]
    [Description(
        @"Status report is sent to provide information pertinent to the transfer. May be sent in response to a request for transfer status."
    )]
    Information,

    /// <summary>
    /// Status report is sent to provide the number of units following a conversion.
    /// Encoded/decoded by serializers as &quot;CONV&quot;.
    /// </summary>
    [EnumMember(Value = "CONV")]
    [IsoId("_7XAr0G-PEeuEaaCd4BkUFQ")]
    [Description(@"Status report is sent to provide the number of units following a conversion.")]
    ConversionStatus,
}
