// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YghNlNp-Ed-ak6NoX_4Aeg_-1342567946")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType1Code
{
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_YghNldp-Ed-ak6NoX_4Aeg_-2096385794")]
    [Description(@"Collateral type is cash.")]
    Cash = CollateralTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YghNltp-Ed-ak6NoX_4Aeg_2084742436")]
    [Description(@"Collateral type is securities.")]
    Securities = CollateralTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary&apos;s compliance with the terms and conditions set forth in the undertaking.
    /// Encoded/decoded by serializers as &quot;LCRE&quot;.
    /// </summary>
    [EnumMember(Value = "LCRE")]
    [IsoId("_YghNl9p-Ed-ak6NoX_4Aeg_-473975924")]
    [Description(
        @"Instrument issued by a bank substituting its name and credit standing for that of its customer. A letter of credit is a written undertaking of the bank, issued for the account of a customer (the applicant), to honour a demand for payment, upon the beneficiary's compliance with the terms and conditions set forth in the undertaking."
    )]
    LetterOfCredit = CollateralTypeCode.LetterOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YghNmNp-Ed-ak6NoX_4Aeg_400628295")]
    [Description(@"Other assets that could be used as collateral.")]
    Other = CollateralTypeCode.Other, // same ordinal as derivation source for type conversions
}
