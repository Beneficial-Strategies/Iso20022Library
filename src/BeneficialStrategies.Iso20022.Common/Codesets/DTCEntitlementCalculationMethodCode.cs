// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the calculation of entitlements.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1qKjcDL3EeKU9IrkkToqcw_-1097096548")]
[Description(@"Specifies the type of the calculation of entitlements.")]
[Derivations(typeof(DTCEntitlementCalculationMethod1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DTCEntitlementCalculationMethodCode>))]
#endif
public enum DTCEntitlementCalculationMethodCode
{
    /// <summary>
    /// Per individual account X share holding per account X Cash Rate divided by the Stock Rate = Whole Shares + CIL of Fractions Example: 100 shares X.50 (Cash Rate) divided by $20.00 (Stock Rate)=2 whole shares and.500000 fractions Fractional Entitlement: If the price is $15.00 per share, you would calculate.500000 X $15.00 = $7.50 for CIL.
    /// Encoded/decoded by serializers as &quot;SR15&quot;.
    /// </summary>
    [EnumMember(Value = "SR15")]
    [IsoId("_1qKjcTL3EeKU9IrkkToqcw_176771106")]
    [Description(
        @"Per individual account X share holding per account X Cash Rate divided by the Stock Rate = Whole Shares + CIL of Fractions Example: 100 shares X.50 (Cash Rate) divided by $20.00 (Stock Rate)=2 whole shares and.500000 fractions Fractional Entitlement: If the price is $15.00 per share, you would calculate.500000 X $15.00 = $7.50 for CIL."
    )]
    StockRateFC15,

    /// <summary>
    /// Per individual account X share holding per account X Cash Rate = entitlement Example: 100 shares X.50 (Cash Rate) = $50.00 in cash.
    /// Encoded/decoded by serializers as &quot;CR17&quot;.
    /// </summary>
    [EnumMember(Value = "CR17")]
    [IsoId("_1qKjcjL3EeKU9IrkkToqcw_-658040957")]
    [Description(
        @"Per individual account X share holding per account X Cash Rate = entitlement Example: 100 shares X.50 (Cash Rate) = $50.00 in cash."
    )]
    CashRateFC17,

    /// <summary>
    /// Per individual account X share holding per account X Stock Rate = whole shares + CIL of Fractions Example: 150 shares X 5% (Stock Rate) = 7 whole shares and.500000 fractions Fractional Entitlement: If the CIL price is $10.00 per share, you would calculate.500000 X $10.00 = $5.00 for CIL.
    /// Encoded/decoded by serializers as &quot;SR18&quot;.
    /// </summary>
    [EnumMember(Value = "SR18")]
    [IsoId("_1qKjczL3EeKU9IrkkToqcw_-373665995")]
    [Description(
        @"Per individual account X share holding per account X Stock Rate = whole shares + CIL of Fractions Example: 150 shares X 5% (Stock Rate) = 7 whole shares and.500000 fractions Fractional Entitlement: If the CIL price is $10.00 per share, you would calculate.500000 X $10.00 = $5.00 for CIL."
    )]
    StockRateFC18,

    /// <summary>
    /// Per individual account X share holding per account X Stock Rate = whole shares + Fractions Example: 150 shares X 5% (Stock Rate) = 7 whole shares and.500000 fractions. Cash Entitlement: If the CIL price is $10.00 per share, you would calculate 7.500000 shares X $10.00 = $75.00 in cash.
    /// Encoded/decoded by serializers as &quot;SC19&quot;.
    /// </summary>
    [EnumMember(Value = "SC19")]
    [IsoId("_1qKjdDL3EeKU9IrkkToqcw_-291014286")]
    [Description(
        @"Per individual account X share holding per account X Stock Rate = whole shares + Fractions Example: 150 shares X 5% (Stock Rate) = 7 whole shares and.500000 fractions. Cash Entitlement: If the CIL price is $10.00 per share, you would calculate 7.500000 shares X $10.00 = $75.00 in cash."
    )]
    StockRateXCashRateFC19,

    /// <summary>
    /// A) Per individual account X share holding per account X Stock Rate = Whole shares + CIL of Fractions (Note 1)Note 1- Then option is to buy fraction so as to round up to one (1) whole share B) Per individual account X (1 whole share-fractional issuable) = fractions to be bought X CIL Fraction Price= Cash to be charged to each individual account (Note 1) + 1 whole share to be added to the individual account (Note 2)Note 1- Appropriate cash adjustment decreasing a participants cash position will be transacted Note 2- Appropriate share adjustment increasing a participants share position will be transacted Special Note: The following two formulas relate to those situations whereby the option allows you to buy an additional fraction so as to round up to one (1) whole share. F/C 20-can be used for most fractions buy round ups. F/C 21-was once a mandatory fraction buy round up formula used by a agent. (The end result is the same if you use either F/C).
    /// Encoded/decoded by serializers as &quot;SB20&quot;.
    /// </summary>
    [EnumMember(Value = "SB20")]
    [IsoId("_1qKjdTL3EeKU9IrkkToqcw_-488310351")]
    [Description(
        @"A) Per individual account X share holding per account X Stock Rate = Whole shares + CIL of Fractions (Note 1)Note 1- Then option is to buy fraction so as to round up to one (1) whole share B) Per individual account X (1 whole share-fractional issuable) = fractions to be bought X CIL Fraction Price= Cash to be charged to each individual account (Note 1) + 1 whole share to be added to the individual account (Note 2)Note 1- Appropriate cash adjustment decreasing a participants cash position will be transacted Note 2- Appropriate share adjustment increasing a participants share position will be transacted Special Note: The following two formulas relate to those situations whereby the option allows you to buy an additional fraction so as to round up to one (1) whole share. F/C 20-can be used for most fractions buy round ups. F/C 21-was once a mandatory fraction buy round up formula used by a agent. (The end result is the same if you use either F/C)."
    )]
    StockRateEnableBuyUpToNextWholeShareFC20,

    /// <summary>
    /// A) Per individual account X share holding per account X Stock Rate = Whole shares + Fractional Issuable Note: This is a Mandatory Agent calculation for fractional round-up B) Per individual account X (1 whole share X round out price (announce in Cash Rate)-(Fractional Issuable X Stock Rate) = Cash to be charged to each individual account + 1 whole share to be added to each individual account.
    /// Encoded/decoded by serializers as &quot;SHST&quot;.
    /// </summary>
    [EnumMember(Value = "SHST")]
    [IsoId("_1qKjdjL3EeKU9IrkkToqcw_-1098523438")]
    [Description(
        @"A) Per individual account X share holding per account X Stock Rate = Whole shares + Fractional Issuable Note: This is a Mandatory Agent calculation for fractional round-up B) Per individual account X (1 whole share X round out price (announce in Cash Rate)-(Fractional Issuable X Stock Rate) = Cash to be charged to each individual account + 1 whole share to be added to each individual account."
    )]
    SharesXStock,
}
