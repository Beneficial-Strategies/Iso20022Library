// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YurlZ9p-Ed-ak6NoX_4Aeg_-1737790311")]
[Description(@"Specifies the reason for a transfer or settlement instruction rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
public enum TransferRejectedStatusReason2Code
{
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_YurlaNp-Ed-ak6NoX_4Aeg_-1404400474")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_Yu0vUNp-Ed-ak6NoX_4Aeg_-1404400439")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_Yu0vUdp-Ed-ak6NoX_4Aeg_-1404400421")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_Yu0vUtp-Ed-ak6NoX_4Aeg_-1404400396")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One or several settlement parties are not recognised or are invalid.
    /// Encoded/decoded by serializers as &quot;ISTP&quot;.
    /// </summary>
    [EnumMember(Value = "ISTP")]
    [IsoId("_Yu0vU9p-Ed-ak6NoX_4Aeg_-1404400379")]
    [Description(@"One or several settlement parties are not recognised or are invalid.")]
    SettlementParties = RejectedStatusReasonCode.SettlementParties, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate number is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICTN&quot;.
    /// </summary>
    [EnumMember(Value = "ICTN")]
    [IsoId("_Yu0vVNp-Ed-ak6NoX_4Aeg_-1404400361")]
    [Description(@"Certificate number is not recognised or is invalid.")]
    CertificateNumber = RejectedStatusReasonCode.CertificateNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_Yu0vVdp-Ed-ak6NoX_4Aeg_-1404400319")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acquisition date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IAQD&quot;.
    /// </summary>
    [EnumMember(Value = "IAQD")]
    [IsoId("_Yu0vVtp-Ed-ak6NoX_4Aeg_-1404400301")]
    [Description(@"Acquisition date is not recognised or is invalid.")]
    AcquisitionDate = RejectedStatusReasonCode.AcquisitionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_Yu0vV9p-Ed-ak6NoX_4Aeg_-1404400241")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_Yu0vWNp-Ed-ak6NoX_4Aeg_-1404400224")]
    [Description(@"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.")]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_Yu0vWdp-Ed-ak6NoX_4Aeg_-1404400206")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName = RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_Yu-gUNp-Ed-ak6NoX_4Aeg_-1404399964")]
    [Description(@"Order contains physical delivery details but the fund can not be physically delivered.")]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_Yu-gUdp-Ed-ak6NoX_4Aeg_-1404399947")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Yu-gUtp-Ed-ak6NoX_4Aeg_-1404399912")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Yu-gU9p-Ed-ak6NoX_4Aeg_-1404399834")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor name and address is not recognised.
    /// Encoded/decoded by serializers as &quot;INUK&quot;.
    /// </summary>
    [EnumMember(Value = "INUK")]
    [IsoId("_Yu-gVNp-Ed-ak6NoX_4Aeg_-940729188")]
    [Description(@"Investor name and address is not recognised.")]
    InvestorNameAddressUnknown = RejectedStatusReasonCode.InvestorNameAddressUnknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investor data is insufficient. Applicable when the mandated market practice is not followed.
    /// Encoded/decoded by serializers as &quot;INID&quot;.
    /// </summary>
    [EnumMember(Value = "INID")]
    [IsoId("_Yu-gVdp-Ed-ak6NoX_4Aeg_-940729163")]
    [Description(@"Investor data is insufficient. Applicable when the mandated market practice is not followed.")]
    InsufficientInvestorData = RejectedStatusReasonCode.InsufficientInvestorData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account servicer is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_Yu-gVtp-Ed-ak6NoX_4Aeg_-940729146")]
    [Description(@"Account servicer is not recognised or is invalid.")]
    InvalidAccountServicer = RejectedStatusReasonCode.InvalidAccountServicer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Nominee account is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INNA&quot;.
    /// </summary>
    [EnumMember(Value = "INNA")]
    [IsoId("_Yu-gV9p-Ed-ak6NoX_4Aeg_-940728863")]
    [Description(@"Nominee account is not recognised or is invalid.")]
    InvalidNomineeAccount = RejectedStatusReasonCode.InvalidNomineeAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New plan manager is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;INPM&quot;.
    /// </summary>
    [EnumMember(Value = "INPM")]
    [IsoId("_Yu-gWNp-Ed-ak6NoX_4Aeg_-940728845")]
    [Description(@"New plan manager is not recognised or is invalid.")]
    InvalidNewPlanManager = RejectedStatusReasonCode.InvalidNewPlanManager, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year.
    /// Encoded/decoded by serializers as &quot;CYPA&quot;.
    /// </summary>
    [EnumMember(Value = "CYPA")]
    [IsoId("_YvIRUNp-Ed-ak6NoX_4Aeg_-940728760")]
    [Description(@"Partial transfer of current year is not allowed, that is, it is not possible to transfer one asset for the current year as other assets are held for the current year.")]
    CurrentYearPartial = RejectedStatusReasonCode.CurrentYearPartial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well.
    /// Encoded/decoded by serializers as &quot;PTNS&quot;.
    /// </summary>
    [EnumMember(Value = "PTNS")]
    [IsoId("_YvIRUdp-Ed-ak6NoX_4Aeg_-940728743")]
    [Description(@"Partial transfer is not supported. Applicable when tax years are rolled up and because, for example, a transfer request for tax year 2000 only is received, it is not possible to process the transfer as the investor holds other tax years as well.")]
    PartialNotSupported = RejectedStatusReasonCode.PartialNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument is not valid for the requested tax year.
    /// Encoded/decoded by serializers as &quot;FTAX&quot;.
    /// </summary>
    [EnumMember(Value = "FTAX")]
    [IsoId("_YvIRUtp-Ed-ak6NoX_4Aeg_-940728665")]
    [Description(@"Financial instrument is not valid for the requested tax year.")]
    FinancialInstrumentTaxYear = RejectedStatusReasonCode.FinancialInstrumentTaxYear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ISA type is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;ISAT&quot;.
    /// </summary>
    [EnumMember(Value = "ISAT")]
    [IsoId("_YvIRU9p-Ed-ak6NoX_4Aeg_-940728353")]
    [Description(@"ISA type is not recognised or invalid.")]
    InvalidISAType = RejectedStatusReasonCode.InvalidISAType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash account is not recognised or invalid.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_YvIRVNp-Ed-ak6NoX_4Aeg_-940728336")]
    [Description(@"Cash account is not recognised or invalid.")]
    InvalidCashAccount = RejectedStatusReasonCode.InvalidCashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer reference is a duplicate of a previously received transfer.
    /// Encoded/decoded by serializers as &quot;TREF&quot;.
    /// </summary>
    [EnumMember(Value = "TREF")]
    [IsoId("_YvIRVdp-Ed-ak6NoX_4Aeg_-659603425")]
    [Description(@"Transfer reference is a duplicate of a previously received transfer.")]
    DuplicateTransferReference = RejectedStatusReasonCode.DuplicateTransferReference, // same ordinal as derivation source for type conversions
    
}
