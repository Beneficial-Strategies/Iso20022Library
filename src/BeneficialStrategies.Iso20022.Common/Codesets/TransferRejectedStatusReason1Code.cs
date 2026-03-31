// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjusUtp-Ed-ak6NoX_4Aeg_395065089")]
[Description(@"Specifies the reason for a transfer or settlement instruction rejected status.")]
[DerivedFrom(typeof(RejectedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferRejectedStatusReason1Code>))]
#endif
public enum TransferRejectedStatusReason1Code
{
    /// <summary>
    /// Cash settlement date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_VjusU9p-Ed-ak6NoX_4Aeg_456943894")]
    [Description(@"Cash settlement date is not recognised or is invalid.")]
    SettlementDate = RejectedStatusReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_VjusVNp-Ed-ak6NoX_4Aeg_456944361")]
    [Description(@"Place of settlement is not recognised or is invalid.")]
    SettlementPlace = RejectedStatusReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_VjusVdp-Ed-ak6NoX_4Aeg_464330688")]
    [Description(@"Identification of the security is not recognised or is invalid.")]
    FinancialInstrumentIdentification = RejectedStatusReasonCode.FinancialInstrumentIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There are not enough securities in the account to process the instruction.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_VjusVtp-Ed-ak6NoX_4Aeg_465253262")]
    [Description(@"There are not enough securities in the account to process the instruction.")]
    NotEnoughFinancialInstrument = RejectedStatusReasonCode.NotEnoughFinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One or several settlement parties are not recognised or are invalid.
    /// Encoded/decoded by serializers as &quot;ISTP&quot;.
    /// </summary>
    [EnumMember(Value = "ISTP")]
    [IsoId("_VjusV9p-Ed-ak6NoX_4Aeg_464331073")]
    [Description(@"One or several settlement parties are not recognised or are invalid.")]
    SettlementParties = RejectedStatusReasonCode.SettlementParties, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;ICTN&quot;.
    /// </summary>
    [EnumMember(Value = "ICTN")]
    [IsoId("_VjusWNp-Ed-ak6NoX_4Aeg_464331540")]
    [Description(@"Certificate number is not recognised or is invalid.")]
    CertificateNumber = RejectedStatusReasonCode.CertificateNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account identification is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_VjusWdp-Ed-ak6NoX_4Aeg_464331952")]
    [Description(@"Investment account identification is not recognised or is invalid.")]
    InvestmentAccount = RejectedStatusReasonCode.InvestmentAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquisition date is not recognised or is invalid.
    /// Encoded/decoded by serializers as &quot;IAQD&quot;.
    /// </summary>
    [EnumMember(Value = "IAQD")]
    [IsoId("_Vj32QNp-Ed-ak6NoX_4Aeg_464332479")]
    [Description(@"Acquisition date is not recognised or is invalid.")]
    AcquisitionDate = RejectedStatusReasonCode.AcquisitionDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked due to a corporate action.
    /// Encoded/decoded by serializers as &quot;BLCA&quot;.
    /// </summary>
    [EnumMember(Value = "BLCA")]
    [IsoId("_Vj32Qdp-Ed-ak6NoX_4Aeg_465252718")]
    [Description(@"Investment account is blocked due to a corporate action.")]
    AccountBlockedForCorporateAction = RejectedStatusReasonCode.AccountBlockedForCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_Vj32Qtp-Ed-ak6NoX_4Aeg_465253150")]
    [Description(
        @"Investment account is blocked until certain legal proceedings are completed, for example, legal documents from the successor, legal proceedings due to bankruptcy."
    )]
    AccountBlockedMissingDocuments = RejectedStatusReasonCode.AccountBlockedMissingDocuments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the security and the security name are not the same.
    /// Encoded/decoded by serializers as &quot;IDNA&quot;.
    /// </summary>
    [EnumMember(Value = "IDNA")]
    [IsoId("_Vj32Q9p-Ed-ak6NoX_4Aeg_465253768")]
    [Description(@"Identification of the security and the security name are not the same.")]
    FinancialInstrumentIdentificationAndName =
        RejectedStatusReasonCode.FinancialInstrumentIdentificationAndName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order contains physical delivery details but the fund can not be physically delivered.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_Vj32RNp-Ed-ak6NoX_4Aeg_465253803")]
    [Description(
        @"Order contains physical delivery details but the fund can not be physically delivered."
    )]
    PhysicalDeliveryImpossible = RejectedStatusReasonCode.PhysicalDeliveryImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legally impossible to cancel.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_Vj32Rdp-Ed-ak6NoX_4Aeg_466176266")]
    [Description(@"Legally impossible to cancel.")]
    LegallyImpossible = RejectedStatusReasonCode.LegallyImpossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is not compliant with the service level agreement.
    /// Encoded/decoded by serializers as &quot;NSLA&quot;.
    /// </summary>
    [EnumMember(Value = "NSLA")]
    [IsoId("_Vj32Rtp-Ed-ak6NoX_4Aeg_1361236867")]
    [Description(@"Instruction is not compliant with the service level agreement.")]
    NotCompliantWithSLA = RejectedStatusReasonCode.NotCompliantWithSLA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another reason for the status rejected.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Vj32R9p-Ed-ak6NoX_4Aeg_4303597")]
    [Description(@"Another reason for the status rejected.")]
    Other = RejectedStatusReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity is invalid.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Vj32SNp-Ed-ak6NoX_4Aeg_-902559429")]
    [Description(@"Financial instrument quantity is invalid.")]
    FinancialInstrumentQuantity = RejectedStatusReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
}
