// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zs12wALwEeutW5-TpeYJhA")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralType8Code>))]
#endif
public enum CollateralType8Code
{
    /// <summary>
    /// Total collateral affected to open market operations.
    /// Encoded/decoded by serializers as &quot;COMO&quot;.
    /// </summary>
    [EnumMember(Value = "COMO")]
    [IsoId("_bzLRIQLwEeutW5-TpeYJhA")]
    [Description(@"Total collateral affected to open market operations.")]
    TotalCollateralAffectedToOpenMarketOperations =
        CollateralTypeCode.TotalCollateralAffectedToOpenMarketOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total credit claims.
    /// Encoded/decoded by serializers as &quot;CCCL&quot;.
    /// </summary>
    [EnumMember(Value = "CCCL")]
    [IsoId("_b6Ua8gLwEeutW5-TpeYJhA")]
    [Description(@"Total credit claims.")]
    TotalCreditClaims = CollateralTypeCode.TotalCreditClaims, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total externally managed collateral apart from credit claims.
    /// Encoded/decoded by serializers as &quot;CEMC&quot;.
    /// </summary>
    [EnumMember(Value = "CEMC")]
    [IsoId("_cD_UUgLwEeutW5-TpeYJhA")]
    [Description(@"Total externally managed collateral apart from credit claims.|")]
    TotalExternallyManagedCollateralApartFromCreditClaims =
        CollateralTypeCode.TotalExternallyManagedCollateralApartFromCreditClaims, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total externally managed collateral for credit claims.
    /// Encoded/decoded by serializers as &quot;CXCC&quot;.
    /// </summary>
    [EnumMember(Value = "CXCC")]
    [IsoId("_cMUw8gLwEeutW5-TpeYJhA")]
    [Description(@"Total externally managed collateral for credit claims.")]
    TotalExternallyManagedCollateralForCreditClaim =
        CollateralTypeCode.TotalExternallyManagedCollateralForCreditClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total fixed term deposit used as collateral.
    /// Encoded/decoded by serializers as &quot;CFTD&quot;.
    /// </summary>
    [EnumMember(Value = "CFTD")]
    [IsoId("_cjO1EgLwEeutW5-TpeYJhA")]
    [Description(@"Total fixed term deposit used as collateral.")]
    TotalFixedTermDeposit = CollateralTypeCode.TotalFixedTermDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total interest for fixed term Deposit used as collateral.
    /// Encoded/decoded by serializers as &quot;CFTI&quot;.
    /// </summary>
    [EnumMember(Value = "CFTI")]
    [IsoId("_csdCggLwEeutW5-TpeYJhA")]
    [Description(@"Total interest for fixed term Deposit used as collateral.")]
    TotalInterestForFixedTermDeposit = CollateralTypeCode.TotalInterestForFixedTermDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total triparty collateral.
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_czAWcgLwEeutW5-TpeYJhA")]
    [Description(@"Total triparty collateral.")]
    TotalTripartyCollateral = CollateralTypeCode.TotalTripartyCollateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_qeiSUQLwEeutW5-TpeYJhA")]
    [Description(@"Collateral type is cash.")]
    Cash = CollateralTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary&apos;s compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as &quot;LCRE&quot;.
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_q7sIYgLwEeutW5-TpeYJhA")]
    [Description(
        @"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking."
    )]
    LetterOfCredit = CollateralTypeCode.LetterOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_rZcbYgLwEeutW5-TpeYJhA")]
    [Description(@"Other assets that could be used as collateral.")]
    Other = CollateralTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_r0h04gLwEeutW5-TpeYJhA")]
    [Description(@"Collateral type is securities.")]
    Securities = CollateralTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total collateral operations.
    /// Encoded/decoded by serializers as &quot;CTCO&quot;.
    /// </summary>
    [EnumMember(Value = "CTCO")]
    [IsoId("_XI6sAQLxEeutW5-TpeYJhA")]
    [Description(@"Total collateral operations.||")]
    TotalCollateralOperations = CollateralTypeCode.TotalCollateralOperations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total collateral value after relative credit limit.
    /// Encoded/decoded by serializers as &quot;CCVR&quot;.
    /// </summary>
    [EnumMember(Value = "CCVR")]
    [IsoId("_XR_IcgLxEeutW5-TpeYJhA")]
    [Description(@"Total collateral value after relative credit limit.")]
    TotalCollateralValueAfterRelativeCreditLimit =
        CollateralTypeCode.TotalCollateralValueAfterRelativeCreditLimit, // same ordinal as derivation source for type conversions
}
