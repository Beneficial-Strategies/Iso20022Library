// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p0PnYPJUEei775R97f5g5A")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType6Code
{
    /// <summary>
    /// Collateral type is a bank guarantee.
    /// Encoded/decoded by serializers as &quot;GBBK&quot;.
    /// </summary>
    [EnumMember(Value = "GBBK")]
    [IsoId("_tMy3kfJUEei775R97f5g5A")]
    [Description(@"Collateral type is a bank guarantee.")]
    BankGuarantee = CollateralTypeCode.BankGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_tRaR0PJUEei775R97f5g5A")]
    [Description(@"Collateral type is bonds.")]
    Bond = CollateralTypeCode.Bond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_tWUnAfJUEei775R97f5g5A")]
    [Description(@"Collateral type is cash.")]
    Cash = CollateralTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_tbOVIfJUEei775R97f5g5A")]
    [Description(@"Collateral type is commodities.")]
    Commodity = CollateralTypeCode.Commodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is an insurance contract.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_th0FUfJUEei775R97f5g5A")]
    [Description(@"Collateral type is an insurance contract.")]
    Insurance = CollateralTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary&apos;s compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as &quot;LCRE&quot;.
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_tnt5AfJUEei775R97f5g5A")]
    [Description(
        @"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking."
    )]
    LetterOfCredit = CollateralTypeCode.LetterOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tuSbEfJUEei775R97f5g5A")]
    [Description(@"Other assets that could be used as collateral.")]
    Other = CollateralTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_t0UKkfJUEei775R97f5g5A")]
    [Description(
        @"Collateral type are physical entities, for example, airplanes for debt issued by the airline industry."
    )]
    PhysicalEntities = CollateralTypeCode.PhysicalEntities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_t551MfJUEei775R97f5g5A")]
    [Description(@"Collateral type is securities.")]
    Securities = CollateralTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is stock certificates.
    /// Encoded/decoded by serializers as &quot;STCF&quot;.
    /// </summary>
    [EnumMember(Value = "STCF")]
    [IsoId("_t-GYsfJUEei775R97f5g5A")]
    [Description(@"Collateral type is stock certificates.")]
    StockCertificate = CollateralTypeCode.StockCertificate, // same ordinal as derivation source for type conversions
}
