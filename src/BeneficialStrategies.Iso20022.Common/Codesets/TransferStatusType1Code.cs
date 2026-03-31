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
[IsoId("_GrGf0FUWEeiQFOf5GRHqeQ")]
[Description(@"Specifies a type of transfer status or transfer event.")]
[DerivedFrom(typeof(TransferStatusTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferStatusType1Code>))]
#endif
public enum TransferStatusType1Code
{
    /// <summary>
    /// Status report is sent in response to an account holding information request.
    /// Encoded/decoded by serializers as &quot;S019&quot;.
    /// </summary>
    [EnumMember(Value = "S019")]
    [IsoId("_HqVIMVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report is sent in response to an account holding information request.")]
    AccountHoldingInformationRequest = TransferStatusTypeCode.AccountHoldingInformationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises one or more Benefit Crystallisation Events (BCE) have occurred.
    /// Encoded/decoded by serializers as &quot;BCEV&quot;.
    /// </summary>
    [EnumMember(Value = "BCEV")]
    [IsoId("_HupngVUWEeiQFOf5GRHqeQ")]
    [Description(
        @"Status report advises one or more Benefit Crystallisation Events (BCE) have occurred."
    )]
    BenefitCrystallisationEvent = TransferStatusTypeCode.BenefitCrystallisationEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises one or more drawdowns.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_Hy9fwVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report advises one or more drawdowns.")]
    Drawdown = TransferStatusTypeCode.Drawdown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report advises cash is or has been instructed.
    /// Encoded/decoded by serializers as &quot;PAYA&quot;.
    /// </summary>
    [EnumMember(Value = "PAYA")]
    [IsoId("_H5EHwVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report advises cash is or has been instructed.")]
    PaymentAdvice = TransferStatusTypeCode.PaymentAdvice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a portfolio transfer instruction.
    /// Encoded/decoded by serializers as &quot;S012&quot;.
    /// </summary>
    [EnumMember(Value = "S012")]
    [IsoId("_H-3NwVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report is sent in response to a portfolio transfer instruction.")]
    PortfolioTransferInstruction = TransferStatusTypeCode.PortfolioTransferInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a transfer-in instruction.
    /// Encoded/decoded by serializers as &quot;S005&quot;.
    /// </summary>
    [EnumMember(Value = "S005")]
    [IsoId("_IFQwsVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report is sent in response to a transfer-in instruction.")]
    TransferInInstruction = TransferStatusTypeCode.TransferInInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent in response to a transfer-out instruction.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_IK6swVUWEeiQFOf5GRHqeQ")]
    [Description(@"Status report is sent in response to a transfer-out instruction.")]
    TransferOutInstruction = TransferStatusTypeCode.TransferOutInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status report is sent to provide information required for a CSD or ICSD settlement leg.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_XZN54ei5EeifCsigq7uLaQ")]
    [Description(
        @"Status report is sent to provide information required for a CSD or ICSD settlement leg."
    )]
    CSDorICSDSettlementInformation = TransferStatusTypeCode.CSDorICSDSettlementInformation, // same ordinal as derivation source for type conversions
}
