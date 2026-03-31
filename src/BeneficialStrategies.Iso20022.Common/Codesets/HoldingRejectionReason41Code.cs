// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the report item is rejected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0vNGYL3REeO2FLWuu_JIqg")]
[Description(@"Specifies the reason the report item is rejected.")]
[DerivedFrom(typeof(RejectionReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<HoldingRejectionReason41Code>))]
#endif
public enum HoldingRejectionReason41Code
{
    /// <summary>
    /// Price does not comply with the financial instrument&apos;s characteristics.
    /// Encoded/decoded by serializers as &quot;INPR&quot;.
    /// </summary>
    [EnumMember(Value = "INPR")]
    [IsoId("_-tIIEb3REeO2FLWuu_JIqg")]
    [Description(@"Price does not comply with the financial instrument's characteristics.")]
    InvalidPrice = RejectionReasonV2Code.InvalidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction contains an invalid message identification, identification is unknown.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("__3QY4b3REeO2FLWuu_JIqg")]
    [Description(
        @"Instruction contains an invalid message identification, identification is unknown."
    )]
    InvalidIdentification = RejectionReasonV2Code.InvalidIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid agent identification supplied.
    /// Encoded/decoded by serializers as &quot;AGIN&quot;.
    /// </summary>
    [EnumMember(Value = "AGIN")]
    [IsoId("_Agvawb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid agent identification supplied.")]
    InvalidAgent = RejectionReasonV2Code.InvalidAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_Apz3Mb3SEeO2FLWuu_JIqg")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectionReasonV2Code.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected since the provided certification is incorrect or incomplete.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_C0-HMb3SEeO2FLWuu_JIqg")]
    [Description(
        @"Instruction is rejected since the provided certification is incorrect or incomplete."
    )]
    IncorrectCertification = RejectionReasonV2Code.IncorrectCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid business partner number.
    /// Encoded/decoded by serializers as &quot;BPAR&quot;.
    /// </summary>
    [EnumMember(Value = "BPAR")]
    [IsoId("_GT99ob3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid business partner number.")]
    BusinessPartnerNumberRejection = RejectionReasonV2Code.BusinessPartnerNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid bank reference number.
    /// Encoded/decoded by serializers as &quot;BREF&quot;.
    /// </summary>
    [EnumMember(Value = "BREF")]
    [IsoId("_GcLecb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid bank reference number.")]
    BankReferenceNumberRejection = RejectionReasonV2Code.BankReferenceNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address details are incorrect or cannot be recognised.
    /// Encoded/decoded by serializers as &quot;DADR&quot;.
    /// </summary>
    [EnumMember(Value = "DADR")]
    [IsoId("_HW7Pcb3SEeO2FLWuu_JIqg")]
    [Description(@"Address details are incorrect or cannot be recognised.")]
    AddressDetailsRejection = RejectionReasonV2Code.AddressDetailsRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid delivering custodian.
    /// Encoded/decoded by serializers as &quot;DCUS&quot;.
    /// </summary>
    [EnumMember(Value = "DCUS")]
    [IsoId("_JggyIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid delivering custodian.")]
    DeliveringCustodian = RejectionReasonV2Code.DeliveringCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorrect activity type specified, for example, pre-release conversion.
    /// Encoded/decoded by serializers as &quot;IACT&quot;.
    /// </summary>
    [EnumMember(Value = "IACT")]
    [IsoId("_MSB3gb3SEeO2FLWuu_JIqg")]
    [Description(@"Incorrect activity type specified, for example, pre-release conversion.")]
    IncorrectActivityType = RejectionReasonV2Code.IncorrectActivityType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// For tax reclaim, the reclaim is invalid for the tax authorities.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_NrMC0b3SEeO2FLWuu_JIqg")]
    [Description(@"For tax reclaim, the reclaim is invalid for the tax authorities.")]
    InvalidForTaxAuthorities = RejectionReasonV2Code.InvalidForTaxAuthorities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INDT&quot;.
    /// </summary>
    [EnumMember(Value = "INDT")]
    [IsoId("_OBV5Ab3SEeO2FLWuu_JIqg")]
    [Description(
        @"Message details specified in the instruction/request are inconsistent with those that were specified in the relating original message."
    )]
    InvalidDetails = RejectionReasonV2Code.InvalidDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid combination of corporate action option code and corporate action option number.
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_PLzhAb3SEeO2FLWuu_JIqg")]
    [Description(
        @"Invalid combination of corporate action option code and corporate action option number."
    )]
    InvalidOption = RejectionReasonV2Code.InvalidOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_PUDeEb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV2Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details specified in the movement general information block are inconsistent with those that were specified in the relating original message.
    /// Encoded/decoded by serializers as &quot;INMO&quot;.
    /// </summary>
    [EnumMember(Value = "INMO")]
    [IsoId("_Pm7Wwb3SEeO2FLWuu_JIqg")]
    [Description(
        @"Details specified in the movement general information block are inconsistent with those that were specified in the relating original message."
    )]
    InvalidMovementInformation = RejectionReasonV2Code.InvalidMovementInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized modification request.
    /// Encoded/decoded by serializers as &quot;INVM&quot;.
    /// </summary>
    [EnumMember(Value = "INVM")]
    [IsoId("_QhoEcb3SEeO2FLWuu_JIqg")]
    [Description(@"Invalid or unrecognized modification request.")]
    InvalidModificationRequest = RejectionReasonV2Code.InvalidModificationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying security identification does not correspond with the corporate action reference supplied.
    /// Encoded/decoded by serializers as &quot;INUS&quot;.
    /// </summary>
    [EnumMember(Value = "INUS")]
    [IsoId("_RYkTgb3SEeO2FLWuu_JIqg")]
    [Description(
        @"Underlying security identification does not correspond with the corporate action reference supplied."
    )]
    InvalidUnderlyingSecurity = RejectionReasonV2Code.InvalidUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_SZUl4b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV2Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_UJ8O8b3SEeO2FLWuu_JIqg")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate = RejectionReasonV2Code.MissingPeriodEndDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_UREKob3SEeO2FLWuu_JIqg")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate = RejectionReasonV2Code.MissingPeriodStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_UtH0gb3SEeO2FLWuu_JIqg")]
    [Description(@"Second option is mandatory.")]
    MissingOption = RejectionReasonV2Code.MissingOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No holding for the specified underlying security.
    /// Encoded/decoded by serializers as &quot;NOHO&quot;.
    /// </summary>
    [EnumMember(Value = "NOHO")]
    [IsoId("_WYejEb3SEeO2FLWuu_JIqg")]
    [Description(@"No holding for the specified underlying security.")]
    NoHolding = RejectionReasonV2Code.NoHolding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Referred instrument does not exist in combination with the mentioned market.
    /// Encoded/decoded by serializers as &quot;NINS&quot;.
    /// </summary>
    [EnumMember(Value = "NINS")]
    [IsoId("_XEXYsb3SEeO2FLWuu_JIqg")]
    [Description(@"Referred instrument does not exist in combination with the mentioned market.")]
    NoInstrumentMarket = RejectionReasonV2Code.NoInstrumentMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction type is not applicable for mandatory events.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_X5PyQb3SEeO2FLWuu_JIqg")]
    [Description(@"Instruction type is not applicable for mandatory events.")]
    NotApplicable = RejectionReasonV2Code.NotApplicable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Permission to be processed is not granted.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_YCOIEb3SEeO2FLWuu_JIqg")]
    [Description(@"Permission to be processed is not granted.")]
    NotAuthorised = RejectionReasonV2Code.NotAuthorised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_YcozMb3SEeO2FLWuu_JIqg")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent = RejectionReasonV2Code.NotDefinedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ZjjX8b3SEeO2FLWuu_JIqg")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity = RejectionReasonV2Code.NotEligibleDisperseSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to identify correspondent bank.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_aa4Bgb3SEeO2FLWuu_JIqg")]
    [Description(@"Unable to identify correspondent bank.")]
    NotIdentifiedCorrespondentBank = RejectionReasonV2Code.NotIdentifiedCorrespondentBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised, invalid or missing place of safekeeping.
    /// Encoded/decoded by serializers as &quot;INPS&quot;.
    /// </summary>
    [EnumMember(Value = "INPS")]
    [IsoId("_cO3usb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised, invalid or missing place of safekeeping.")]
    PlaceOfSafekeeping = RejectionReasonV2Code.PlaceOfSafekeeping, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid place of trade.
    /// Encoded/decoded by serializers as &quot;PLCE&quot;.
    /// </summary>
    [EnumMember(Value = "PLCE")]
    [IsoId("_ca9C4b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid place of trade.")]
    PlaceOfTrade = RejectionReasonV2Code.PlaceOfTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_c4fTcb3SEeO2FLWuu_JIqg")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds = RejectionReasonV2Code.PriceExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_e0fGEb3SEeO2FLWuu_JIqg")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectionReasonV2Code.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity unit type is not provided.
    /// Encoded/decoded by serializers as &quot;QUNP&quot;.
    /// </summary>
    [EnumMember(Value = "QUNP")]
    [IsoId("_fA3VMb3SEeO2FLWuu_JIqg")]
    [Description(@"Quantity unit type is not provided.")]
    QuantityUnitType = RejectionReasonV2Code.QuantityUnitType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_fSR1Ub3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV2Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_fdpX0b3SEeO2FLWuu_JIqg")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds = RejectionReasonV2Code.QuantityExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid depository.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_gtVeEb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid depository.")]
    ReceivingDeliveringDepository = RejectionReasonV2Code.ReceivingDeliveringDepository, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid receiving agent.
    /// Encoded/decoded by serializers as &quot;RCUS&quot;.
    /// </summary>
    [EnumMember(Value = "RCUS")]
    [IsoId("_g_2KYb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid receiving agent.")]
    ReceivingCustodian = RejectionReasonV2Code.ReceivingCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_iSqdIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV2Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_kPevIb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    SettlementAmountRejection = RejectionReasonV2Code.SettlementAmountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_kX9Vsb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement amount currency.")]
    SettlementAmountCurrencyRejection = RejectionReasonV2Code.SettlementAmountCurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Traded securities quantity not provided.
    /// Encoded/decoded by serializers as &quot;TQNP&quot;.
    /// </summary>
    [EnumMember(Value = "TQNP")]
    [IsoId("_m9_j0b3SEeO2FLWuu_JIqg")]
    [Description(@"Traded securities quantity not provided.")]
    TradedSecuritiesQuantity = RejectionReasonV2Code.TradedSecuritiesQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement transaction type.
    /// Encoded/decoded by serializers as &quot;SETR&quot;.
    /// </summary>
    [EnumMember(Value = "SETR")]
    [IsoId("_pKFn8b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid settlement transaction type.")]
    SettlementTransactionRejection = RejectionReasonV2Code.SettlementTransactionRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_rGPyob3SEeO2FLWuu_JIqg")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonV2Code.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid deal price.
    /// Encoded/decoded by serializers as &quot;DDEA&quot;.
    /// </summary>
    [EnumMember(Value = "DDEA")]
    [IsoId("_t1Sy0b3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid deal price.")]
    DealPrice = RejectionReasonV2Code.DealPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid closing date/time.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_vEOEEb3SEeO2FLWuu_JIqg")]
    [Description(@"Unrecognised or invalid closing date/time.")]
    ClosingDateTimeRejection = RejectionReasonV2Code.ClosingDateTimeRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_AMmhUb3TEeO2FLWuu_JIqg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV2Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_GgCOQb3TEeO2FLWuu_JIqg")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = RejectionReasonV2Code.NarrativeReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRGN&quot;.
    /// </summary>
    [EnumMember(Value = "NRGN")]
    [IsoId("_JdT3sb3TEeO2FLWuu_JIqg")]
    [Description(@"Instruction could not be found.")]
    NotFoundRejection = RejectionReasonV2Code.NotFoundRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction aims at using an invalid balance.
    /// Encoded/decoded by serializers as &quot;INVB&quot;.
    /// </summary>
    [EnumMember(Value = "INVB")]
    [IsoId("_ftvpsUlFEeSxKv6IjBzDlA")]
    [Description(@"Instruction aims at using an invalid balance.")]
    InvalidBalance = RejectionReasonV2Code.InvalidBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_-6ckEUr3EeSHP9pzU4nIpA")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV2Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_IQqskUr4EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid cash account.")]
    CashAccount = RejectionReasonV2Code.CashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid commercialisation contract.
    /// Encoded/decoded by serializers as &quot;COMC&quot;.
    /// </summary>
    [EnumMember(Value = "COMC")]
    [IsoId("_TDt_cUr4EeSHP9pzU4nIpA")]
    [Description(@"Unrecognised or invalid commercialisation contract.")]
    CommercializationContractRejection = RejectionReasonV2Code.CommercializationContractRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Concentration limit was exceeded.
    /// Encoded/decoded by serializers as &quot;CONL&quot;.
    /// </summary>
    [EnumMember(Value = "CONL")]
    [IsoId("_mhjRIUr4EeSHP9pzU4nIpA")]
    [Description(@"Concentration limit was exceeded.")]
    ConcentrationLimitExceeded = RejectionReasonV2Code.ConcentrationLimitExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient balance.
    /// Encoded/decoded by serializers as &quot;INHO&quot;.
    /// </summary>
    [EnumMember(Value = "INHO")]
    [IsoId("_C7apsUr5EeSHP9pzU4nIpA")]
    [Description(@"Insufficient balance.")]
    InsufficientBalance = RejectionReasonV2Code.InsufficientBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient collateral proposed.
    /// Encoded/decoded by serializers as &quot;ICOL&quot;.
    /// </summary>
    [EnumMember(Value = "ICOL")]
    [IsoId("_GKgb4Ur5EeSHP9pzU4nIpA")]
    [Description(@"Insufficient collateral proposed.")]
    InsufficientCollateral = RejectionReasonV2Code.InsufficientCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_bIJTcUr5EeSHP9pzU4nIpA")]
    [Description(
        @"Unrecognised or invalid investor party. May be used by an executing party to reject an instruction for an investor (or portfolio) for which it is not authorised to act."
    )]
    InvalidInvestorParty = RejectionReasonV2Code.InvalidInvestorParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized lot number.
    /// Encoded/decoded by serializers as &quot;INVN&quot;.
    /// </summary>
    [EnumMember(Value = "INVN")]
    [IsoId("_izP98Ur5EeSHP9pzU4nIpA")]
    [Description(@"Invalid or unrecognized lot number.")]
    InvalidLotNumber = RejectionReasonV2Code.InvalidLotNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid or unrecognized link.
    /// Encoded/decoded by serializers as &quot;INVL&quot;.
    /// </summary>
    [EnumMember(Value = "INVL")]
    [IsoId("_jXZM0Ur5EeSHP9pzU4nIpA")]
    [Description(@"Invalid or unrecognized link.")]
    InvalidLink = RejectionReasonV2Code.InvalidLink, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account servicer validation rule rejection.
    /// Encoded/decoded by serializers as &quot;VALR&quot;.
    /// </summary>
    [EnumMember(Value = "VALR")]
    [IsoId("_52CkIUr5EeSHP9pzU4nIpA")]
    [Description(@"Account servicer validation rule rejection.")]
    InvalidRule = RejectionReasonV2Code.InvalidRule, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_E7iR4Ur6EeSHP9pzU4nIpA")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown = RejectionReasonV2Code.InvestorNameAddressUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction/Request arrives too late.
    /// Encoded/decoded by serializers as &quot;LATT&quot;.
    /// </summary>
    [EnumMember(Value = "LATT")]
    [IsoId("_Oa020Ur6EeSHP9pzU4nIpA")]
    [Description(@"Instruction/Request arrives too late.")]
    Late = RejectionReasonV2Code.Late, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_gV4HIUr6EeSHP9pzU4nIpA")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementQuantity = RejectionReasonV2Code.MinimumSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rejected due to missing beneficiary owner details.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_jPGXAUr6EeSHP9pzU4nIpA")]
    [Description(@"Rejected due to missing beneficiary owner details.")]
    MissingBeneficiaryOwnerDetails = RejectionReasonV2Code.MissingBeneficiaryOwnerDetails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_kd8vwUr6EeSHP9pzU4nIpA")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification = RejectionReasonV2Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Missing or invalid power of attorney.
    /// Encoded/decoded by serializers as &quot;IPOA&quot;.
    /// </summary>
    [EnumMember(Value = "IPOA")]
    [IsoId("_qjcHUUr6EeSHP9pzU4nIpA")]
    [Description(@"Missing or invalid power of attorney.")]
    MissingOrInvalidPOA = RejectionReasonV2Code.MissingOrInvalidPOA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_zPQA4Ur6EeSHP9pzU4nIpA")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementQuantity = RejectionReasonV2Code.MultipleSettlementQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid service level agreement pre-agreed narrative information.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_3uiPoUr6EeSHP9pzU4nIpA")]
    [Description(
        @"Unrecognised or invalid service level agreement pre-agreed narrative information."
    )]
    NarrativeInformationRejection = RejectionReasonV2Code.NarrativeInformationRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested financial instrument is not available.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_8njNAUr6EeSHP9pzU4nIpA")]
    [Description(@"Requested financial instrument is not available.")]
    NoInventory = RejectionReasonV2Code.NoInventory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_BRi28Ur7EeSHP9pzU4nIpA")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity = RejectionReasonV2Code.NonEligibleSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_gD5w4Ur7EeSHP9pzU4nIpA")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate = RejectionReasonV2Code.PeriodEndDateBeforeStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_AoqckUr8EeSHP9pzU4nIpA")]
    [Description(
        @"Instruction has a reference identical to another previously received instruction."
    )]
    ReferenceRejection = RejectionReasonV2Code.ReferenceRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Several messages with the same identification.
    /// Encoded/decoded by serializers as &quot;SAID&quot;.
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_fUxkkUr8EeSHP9pzU4nIpA")]
    [Description(@"Several messages with the same identification.")]
    SameIdentification = RejectionReasonV2Code.SameIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Type of ownership indicated is not correct.
    /// Encoded/decoded by serializers as &quot;OWNT&quot;.
    /// </summary>
    [EnumMember(Value = "OWNT")]
    [IsoId("_47XkQUr8EeSHP9pzU4nIpA")]
    [Description(@"Type of ownership indicated is not correct.")]
    TypeOfOwnershipRejection = RejectionReasonV2Code.TypeOfOwnershipRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is not available or unknown.
    /// Encoded/decoded by serializers as &quot;NTAV&quot;.
    /// </summary>
    [EnumMember(Value = "NTAV")]
    [IsoId("_y7FrwSlGEeWwYv6HydV_vw")]
    [Description(@"Reason is not available or unknown.")]
    NotAvailable = RejectionReasonV2Code.NotAvailable, // same ordinal as derivation source for type conversions
}
