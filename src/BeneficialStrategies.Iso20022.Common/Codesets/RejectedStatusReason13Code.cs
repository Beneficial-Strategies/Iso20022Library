// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AlouseijEeuLe8v4JEtDDg")]
[Description(@"Specifies the reason for a transfer or settlement instruction rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum RejectedStatusReason13Code
{
    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_A8SUIeijEeuLe8v4JEtDDg")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_A8SUI-ijEeuLe8v4JEtDDg")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquisition date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IAQD&quot;.
    /// </summary>
    [EnumMember(Value = "IAQD")]
    [IsoId("_A8SUJeijEeuLe8v4JEtDDg")]
    [Description(@"Acquisition date is not recognised or is invalid.")]
    AcquisitionDate = RejectedStatusReasonCode.AcquisitionDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICTN&quot;.
    /// </summary>
    [EnumMember(Value = "ICTN")]
    [IsoId("_A8SUJ-ijEeuLe8v4JEtDDg")]
    [Description(@"Certificate number is not recognised or is invalid.")]
    CertificateNumber = RejectedStatusReasonCode.CertificateNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year.
    /// Encoded/decoded by serializers as &quot;CYPA&quot;.
    /// </summary>
    [EnumMember(Value = "CYPA")]
    [IsoId("_A8SUKeijEeuLe8v4JEtDDg")]
    [Description(
        @"Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year."
    )]
    CurrentYearPartial = RejectedStatusReasonCode.CurrentYearPartial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer reference is a duplicate of a previously received transfer.
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_A8SUK-ijEeuLe8v4JEtDDg")]
    [Description(@"Transfer reference is a duplicate of a previously received transfer.")]
    DuplicateTransferReference = RejectedStatusReasonCode.DuplicateTransferReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_A8SULeijEeuLe8v4JEtDDg")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_A8SUL-ijEeuLe8v4JEtDDg")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName =
        RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_A8SUMeijEeuLe8v4JEtDDg")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument is not valid for the requested tax year.
    /// Encoded/decoded by serializers as &quot;FTAX&quot;.
    /// </summary>
    [EnumMember(Value = "FTAX")]
    [IsoId("_A8SUOeijEeuLe8v4JEtDDg")]
    [Description(@"Financial instrument is not valid for the requested tax year.")]
    FinancialInstrumentTaxYear = RejectedStatusReasonCode.FinancialInstrumentTaxYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor data is insufficient. Applicable when the mandated market practice is not followed.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_A8SUO-ijEeuLe8v4JEtDDg")]
    [Description(
        @"Investor data is insufficient. Applicable when the mandated market practice is not followed."
    )]
    InsufficientInvestorData = RejectedStatusReasonCode.InsufficientInvestorData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account servicer is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_A8SUPeijEeuLe8v4JEtDDg")]
    [Description(@"Account servicer is not recognised or is invalid.")]
    InvalidAccountServicer = RejectedStatusReasonCode.InvalidAccountServicer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_A8SUP-ijEeuLe8v4JEtDDg")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount = RejectedStatusReasonCode.InvalidCashAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// New plan manager is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_A8SUQeijEeuLe8v4JEtDDg")]
    [Description(@"New plan manager is not recognised or is invalid.")]
    InvalidNewPlanManager = RejectedStatusReasonCode.InvalidNewPlanManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Nominee account is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_A8SUQ-ijEeuLe8v4JEtDDg")]
    [Description(@"Nominee account is not recognised or is invalid.")]
    InvalidNomineeAccount = RejectedStatusReasonCode.InvalidNomineeAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_A8SUReijEeuLe8v4JEtDDg")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_A8SUR-ijEeuLe8v4JEtDDg")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown = RejectedStatusReasonCode.InvestorNameAddressUnknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_A8SUSeijEeuLe8v4JEtDDg")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_A8SUS-ijEeuLe8v4JEtDDg")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_A8SUTeijEeuLe8v4JEtDDg")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well.
    /// Encoded/decoded by serializers as &quot;PTNS&quot;.
    /// </summary>
    [EnumMember(Value = "PTNS")]
    [IsoId("_A8SUT-ijEeuLe8v4JEtDDg")]
    [Description(
        @"Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well."
    )]
    PartialNotSupported = RejectedStatusReasonCode.PartialNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_A8SUUeijEeuLe8v4JEtDDg")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_A8SUU-ijEeuLe8v4JEtDDg")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One or several settlement parties are not recognised or are invalid.
    /// Encoded/decoded by serializers as &quot;ISTP&quot;.
    /// </summary>
    [EnumMember(Value = "ISTP")]
    [IsoId("_A8SUW-ijEeuLe8v4JEtDDg")]
    [Description(@"One or several settlement parties are not recognised or are invalid.")]
    SettlementParties = RejectedStatusReasonCode.SettlementParties, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_A8SUXeijEeuLe8v4JEtDDg")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ISA type is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_A8SUX-ijEeuLe8v4JEtDDg")]
    [Description(@"ISA type is not recognised or invalid.")]
    InvalidISAType = RejectedStatusReasonCode.InvalidISAType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_A8SUYeijEeuLe8v4JEtDDg")]
    [Description(@"Another reason for the status rejected.")]
    Other = RejectedStatusReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The two share classes are not part of the same fund.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_A8SUY-ijEeuLe8v4JEtDDg")]
    [Description(@"The two share classes are not part of the same fund.")]
    NotConvertable = RejectedStatusReasonCode.NotConvertable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset instructed for transfer is closed.
    /// Encoded/decoded by serializers as &quot;ACLO&quot;.
    /// </summary>
    [EnumMember(Value = "ACLO")]
    [IsoId("_A8SUZeijEeuLe8v4JEtDDg")]
    [Description(@"Asset instructed for transfer is closed.")]
    AssetClosed = RejectedStatusReasonCode.AssetClosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Asset does not support reregistration.
    /// Encoded/decoded by serializers as &quot;NASS&quot;.
    /// </summary>
    [EnumMember(Value = "NASS")]
    [IsoId("_A8SUZ-ijEeuLe8v4JEtDDg")]
    [Description(@"Asset does not support reregistration.")]
    AssetNotSupported = RejectedStatusReasonCode.AssetNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer quantity is too small.
    /// Encoded/decoded by serializers as &quot;NQTY&quot;.
    /// </summary>
    [EnumMember(Value = "NQTY")]
    [IsoId("_A8SUaeijEeuLe8v4JEtDDg")]
    [Description(@"Transfer quantity is too small.")]
    QuantityBelowMinimum = RejectedStatusReasonCode.QuantityBelowMinimum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a transfer out of investment funds.
    /// Encoded/decoded by serializers as &quot;BLTR&quot;.
    /// </summary>
    [EnumMember(Value = "BLTR")]
    [IsoId("_A8SUa-ijEeuLe8v4JEtDDg")]
    [Description(@"Investment account is blocked due to a transfer out of investment funds.")]
    AccountBlockedForTransfer = RejectedStatusReasonCode.AccountBlockedForTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order or transfer has already been executed and confirmation has been sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_A8SUbeijEeuLe8v4JEtDDg")]
    [Description(@"Order or transfer has already been executed and confirmation has been sent.")]
    AlreadyExecuted = RejectedStatusReasonCode.AlreadyExecuted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assets are illiquid.
    /// Encoded/decoded by serializers as &quot;ILLI&quot;.
    /// </summary>
    [EnumMember(Value = "ILLI")]
    [IsoId("_A8SUb-ijEeuLe8v4JEtDDg")]
    [Description(@"Assets are illiquid.")]
    AssetsIlliquid = RejectedStatusReasonCode.AssetsIlliquid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Holding will be below the minimum retained value.
    /// Encoded/decoded by serializers as &quot;BMRV&quot;.
    /// </summary>
    [EnumMember(Value = "BMRV")]
    [IsoId("_A8SUceijEeuLe8v4JEtDDg")]
    [Description(@"Holding will be below the minimum retained value.")]
    BelowMinimumRetainedAmount = RejectedStatusReasonCode.BelowMinimumRetainedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data in the order or transfer instruction is invalid.
    /// Encoded/decoded by serializers as &quot;DINV&quot;.
    /// </summary>
    [EnumMember(Value = "DINV")]
    [IsoId("_A8SUc-ijEeuLe8v4JEtDDg")]
    [Description(@"Data in the order or transfer instruction is invalid.")]
    DataInvalid = RejectedStatusReasonCode.DataInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICAG&quot;.
    /// </summary>
    [EnumMember(Value = "ICAG")]
    [IsoId("_A8SUdeijEeuLe8v4JEtDDg")]
    [Description(@"Delivering agent is not recognised or is invalid.")]
    DeliveringAgent = RejectedStatusReasonCode.DeliveringAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instructing party is not allowed to instruct for this investment account.
    /// Encoded/decoded by serializers as &quot;IPAC&quot;.
    /// </summary>
    [EnumMember(Value = "IPAC")]
    [IsoId("_A8SUd-ijEeuLe8v4JEtDDg")]
    [Description(@"Instructing party is not allowed to instruct for this investment account.")]
    InstructingPartyNotAllowedForAccount =
        RejectedStatusReasonCode.InstructingPartyNotAllowedForAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediary is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_A8SUeeijEeuLe8v4JEtDDg")]
    [Description(@"Intermediary is not recognised or is invalid.")]
    Intermediary = RejectedStatusReasonCode.Intermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid settlement amount.
    /// Encoded/decoded by serializers as &quot;DMON&quot;.
    /// </summary>
    [EnumMember(Value = "DMON")]
    [IsoId("_A8SUe-ijEeuLe8v4JEtDDg")]
    [Description(@"Unrecognised or invalid settlement amount.")]
    InvalidSettlementAmount = RejectedStatusReasonCode.InvalidSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Percentage holding breach, for example, PPM rules; taxation rules (ERISA).
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_A8SUfeijEeuLe8v4JEtDDg")]
    [Description(@"Percentage holding breach, for example, PPM rules; taxation rules (ERISA).")]
    PercentageHoldingBreach = RejectedStatusReasonCode.PercentageHoldingBreach, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IVAG&quot;.
    /// </summary>
    [EnumMember(Value = "IVAG")]
    [IsoId("_A8SUf-ijEeuLe8v4JEtDDg")]
    [Description(@"Receiving agent is not recognised or is invalid.")]
    ReceivingAgent = RejectedStatusReasonCode.ReceivingAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid Settlement Amount Currency.
    /// Encoded/decoded by serializers as &quot;NCRR&quot;.
    /// </summary>
    [EnumMember(Value = "NCRR")]
    [IsoId("_A8SUgeijEeuLe8v4JEtDDg")]
    [Description(@"Unrecognised or invalid Settlement Amount Currency.")]
    SettlementAmountCurrency = RejectedStatusReasonCode.SettlementAmountCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid trade date or requested trade date or future trade date.
    /// Encoded/decoded by serializers as &quot;DTRD&quot;.
    /// </summary>
    [EnumMember(Value = "DTRD")]
    [IsoId("_A8SUg-ijEeuLe8v4JEtDDg")]
    [Description(
        @"Unrecognised or invalid trade date or requested trade date or future trade date."
    )]
    TradeDate = RejectedStatusReasonCode.TradeDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment method, for example, cheque or payment card, is not accepted.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_A8SUheijEeuLe8v4JEtDDg")]
    [Description(@"Payment method, for example, cheque or payment card, is not accepted.")]
    UnacceptedPaymentMethod = RejectedStatusReasonCode.UnacceptedPaymentMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement currency requested is not supported.
    /// Encoded/decoded by serializers as &quot;URSC&quot;.
    /// </summary>
    [EnumMember(Value = "URSC")]
    [IsoId("_A8SUh-ijEeuLe8v4JEtDDg")]
    [Description(@"Settlement currency requested is not supported.")]
    UnacceptedRequestedSettlementCurrency =
        RejectedStatusReasonCode.UnacceptedRequestedSettlementCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the relevant market practice.
    /// Encoded/decoded by serializers as &quot;NCMP&quot;.
    /// </summary>
    [EnumMember(Value = "NCMP")]
    [IsoId("_LQHUYeijEeuLe8v4JEtDDg")]
    [Description(@"Instruction is not compliant with the relevant market practice.")]
    NotCompliantWithMarketPractice = RejectedStatusReasonCode.NotCompliantWithMarketPractice, // same ordinal as derivation source for type conversions
}
