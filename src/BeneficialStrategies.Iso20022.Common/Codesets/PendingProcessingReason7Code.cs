// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tdvxgKoZEfCG2_q2WT-90w")]
[Description(
    @"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible."
)]
[DerivedFrom(typeof(PendingFailingReasonV4Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingProcessingReason7Code>))]
public enum PendingProcessingReason7Code
{
    /// <summary>
    /// Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_0w5YUym4EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction was received after the account servicer's deadline. It will be managed as per the bilateral service agreement between the account servicer and account owner."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonV4Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_0w5YUSm4EfGfZ9PfK70MMg")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonV4Code.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_0w5YVym4EfGfZ9PfK70MMg")]
    [Description(
        @"Awaiting financial instruments from a corporate action or other procedure, for example, conversion, dematerialisation, exchange, registration, stamping, splitting."
    )]
    AwaitingSecurities = PendingFailingReasonV4Code.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting cancellation of one of the party.
    /// Encoded/decoded by serializers as &quot;CDAC&quot;.
    /// </summary>
    [EnumMember(Value = "CDAC")]
    [IsoId("_0w5YXSm4EfGfZ9PfK70MMg")]
    [Description(@"Awaiting cancellation of one of the party.")]
    ConditionalDeliveryAwaitingCancellation = PendingFailingReasonV4Code.ConditionalDeliveryAwaitingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery.
    /// Encoded/decoded by serializers as &quot;CDEL&quot;.
    /// </summary>
    [EnumMember(Value = "CDEL")]
    [IsoId("_0w5YWym4EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditional delivery rules in the market infrastructure platform for conditional delivery."
    )]
    ConditionalDelivery = PendingFailingReasonV4Code.ConditionalDelivery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release.
    /// Encoded/decoded by serializers as &quot;CDLR&quot;.
    /// </summary>
    [EnumMember(Value = "CDLR")]
    [IsoId("_0w5YXym4EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode. Market infrastructure platform is awaiting release."
    )]
    ConditionalDeliveryAwaitingRelease = PendingFailingReasonV4Code.ConditionalDeliveryAwaitingRelease, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_0w5Yfym4EfGfZ9PfK70MMg")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonV4Code.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are not deliverable as they are pledged as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_0w5Yeym4EfGfZ9PfK70MMg")]
    [Description(@"Financial instruments are not deliverable as they are pledged as collateral.")]
    SecuritiesPledgedAsCollateral = PendingFailingReasonV4Code.SecuritiesPledgedAsCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central securities depository sets the instruction in a hold/frozen/preadvice mode.
    /// Encoded/decoded by serializers as &quot;CSDH&quot;.
    /// </summary>
    [EnumMember(Value = "CSDH")]
    [IsoId("_0w5YYSm4EfGfZ9PfK70MMg")]
    [Description(
        @"Central securities depository sets the instruction in a hold/frozen/preadvice mode."
    )]
    CSDHold = PendingFailingReasonV4Code.CSDHold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform.
    /// Encoded/decoded by serializers as &quot;CVAL&quot;.
    /// </summary>
    [EnumMember(Value = "CVAL")]
    [IsoId("_0w5YYym4EfGfZ9PfK70MMg")]
    [Description(
        @"Instruction is in a hold/frozen/preadvice mode as it fulfils predefined conditions of a restriction processing type in the market infrastructure platform."
    )]
    CSDValidation = PendingFailingReasonV4Code.CSDValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_0w5YgSm4EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity = PendingFailingReasonV4Code.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_0w5YVSm4EfGfZ9PfK70MMg")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou = PendingFailingReasonV4Code.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached.
    /// Encoded/decoded by serializers as &quot;FLIM&quot;.
    /// </summary>
    [EnumMember(Value = "FLIM")]
    [IsoId("_0w5Ybym4EfGfZ9PfK70MMg")]
    [Description(
        @"Insufficient deliverable financial instruments in your account as maximum foreign limit has been reached."
    )]
    MaximumForeignLimitReached = PendingFailingReasonV4Code.MaximumForeignLimitReached, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement cannot be executed; financial instruments are in global form.
    /// Encoded/decoded by serializers as &quot;GLOB&quot;.
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_0w5YZSm4EfGfZ9PfK70MMg")]
    [Description(@"Settlement cannot be executed; financial instruments are in global form.")]
    GlobalFormSecurities = PendingFailingReasonV4Code.GlobalFormSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not all the instructions part of a pool have been received.
    /// Encoded/decoded by serializers as &quot;INBC&quot;.
    /// </summary>
    [EnumMember(Value = "INBC")]
    [IsoId("_0w5YZym4EfGfZ9PfK70MMg")]
    [Description(@"Not all the instructions part of a pool have been received.")]
    IncompleteNumberCount = PendingFailingReasonV4Code.IncompleteNumberCount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient financial instruments in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_0w5YbSm4EfGfZ9PfK70MMg")]
    [Description(@"Insufficient financial instruments in your account.")]
    LackOfSecurities = PendingFailingReasonV4Code.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instruments are out on loan.
    /// Encoded/decoded by serializers as &quot;LALO&quot;.
    /// </summary>
    [EnumMember(Value = "LALO")]
    [IsoId("_0w5YeSm4EfGfZ9PfK70MMg")]
    [Description(@"Financial instruments are out on loan.")]
    SecuritiesLoanedOut = PendingFailingReasonV4Code.SecuritiesLoanedOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank liquidity is insufficient.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_0w5YaSm4EfGfZ9PfK70MMg")]
    [Description(@"Central bank liquidity is insufficient.")]
    InsufficientCentralBankLiquidity = PendingFailingReasonV4Code.InsufficientCentralBankLiquidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_0w5YcSm4EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonV4Code.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient money in your account.
    /// Encoded/decoded by serializers as &quot;MONY&quot;.
    /// </summary>
    [EnumMember(Value = "MONY")]
    [IsoId("_0w5Yaym4EfGfZ9PfK70MMg")]
    [Description(@"Insufficient money in your account.")]
    InsufficientMoney = PendingFailingReasonV4Code.InsufficientMoney, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_0w5Ycym4EfGfZ9PfK70MMg")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonV4Code.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Next process is launched. No processing pending problems to be reported.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_0w5YdSm4EfGfZ9PfK70MMg")]
    [Description(@"Next process is launched. No processing pending problems to be reported.")]
    NextProcess = PendingFailingReasonV4Code.NextProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A foreign exchange instruction from you is missing.
    /// Encoded/decoded by serializers as &quot;NOFX&quot;.
    /// </summary>
    [EnumMember(Value = "NOFX")]
    [IsoId("_0w5Ydym4EfGfZ9PfK70MMg")]
    [Description(@"A foreign exchange instruction from you is missing.")]
    NoForeignExchangeInstruction = PendingFailingReasonV4Code.NoForeignExchangeInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0w5YfSm4EfGfZ9PfK70MMg")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV4Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral in your account to execute the instruction.
    /// Encoded/decoded by serializers as &quot;YCOL&quot;.
    /// </summary>
    [EnumMember(Value = "YCOL")]
    [IsoId("_0w5YWSm4EfGfZ9PfK70MMg")]
    [Description(@"Insufficient collateral in your account to execute the instruction.")]
    CollateralShortage = PendingFailingReasonV4Code.CollateralShortage, // same ordinal as derivation source for type conversions
}
