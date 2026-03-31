// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YhkWcNp-Ed-ak6NoX_4Aeg_-1906851692")]
[Description(
    @"Specifies the reason a specific tax has not been levied/deducted on a given transaction."
)]
[Derivations(
    typeof(TaxExemptReason1Code),
    typeof(TaxExemptReason2Code),
    typeof(TaxExemptReason3Code)
)]
public enum TaxExemptReasonCode
{
    /// <summary>
    /// Account is not tax exempt.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_YhkWcdp-Ed-ak6NoX_4Aeg_1468189283")]
    [Description(@"Account is not tax exempt.")]
    None,

    /// <summary>
    /// Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account.
    /// Encoded/decoded by serializers as &quot;MASA&quot;.
    /// </summary>
    [EnumMember(Value = "MASA")]
    [IsoId("_YhkWctp-Ed-ak6NoX_4Aeg_1468189284")]
    [Description(
        @"Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account."
    )]
    MaxiISA,

    /// <summary>
    /// Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account.
    /// Encoded/decoded by serializers as &quot;MISA&quot;.
    /// </summary>
    [EnumMember(Value = "MISA")]
    [IsoId("_YhkWc9p-Ed-ak6NoX_4Aeg_1468189285")]
    [Description(
        @"Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account."
    )]
    MiniCashISA,

    /// <summary>
    /// Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as &quot;SISA&quot;.
    /// </summary>
    [EnumMember(Value = "SISA")]
    [IsoId("_YhkWdNp-Ed-ak6NoX_4Aeg_1468189286")]
    [Description(
        @"Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK)."
    )]
    MiniStocksAndSharesISA,

    /// <summary>
    /// Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as &quot;IISA&quot;.
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_YhkWddp-Ed-ak6NoX_4Aeg_1468189287")]
    [Description(
        @"Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK)."
    )]
    MiniInsuranceISA,

    /// <summary>
    /// Account is for current year payments into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;CUYP&quot;.
    /// </summary>
    [EnumMember(Value = "CUYP")]
    [IsoId("_YhkWdtp-Ed-ak6NoX_4Aeg_1468189288")]
    [Description(
        @"Account is for current year payments into an investment retirement account (required for US)."
    )]
    CurrentYearPayment,

    /// <summary>
    /// Account is for a prior year payment into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;PRYP&quot;.
    /// </summary>
    [EnumMember(Value = "PRYP")]
    [IsoId("_YhkWd9p-Ed-ak6NoX_4Aeg_1468189289")]
    [Description(
        @"Account is for a prior year payment into an investment retirement account (required for US)."
    )]
    PriorYearPayment,

    /// <summary>
    /// Account is for an asset transfer into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;ASTR&quot;.
    /// </summary>
    [EnumMember(Value = "ASTR")]
    [IsoId("_YhkWeNp-Ed-ak6NoX_4Aeg_1468189290")]
    [Description(
        @"Account is for an asset transfer into an investment retirement account (required for US)."
    )]
    AssetTransfer,

    /// <summary>
    /// Account is for employee - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EMPY&quot;.
    /// </summary>
    [EnumMember(Value = "EMPY")]
    [IsoId("_YhkWedp-Ed-ak6NoX_4Aeg_1468189291")]
    [Description(
        @"Account is for employee - prior year contributions into an investment retirement account (required for US)."
    )]
    EmployeePriorYear,

    /// <summary>
    /// Account is for employee - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EMCY&quot;.
    /// </summary>
    [EnumMember(Value = "EMCY")]
    [IsoId("_YhtgYNp-Ed-ak6NoX_4Aeg_1468189292")]
    [Description(
        @"Account is for employee - current year contributions into an investment retirement account (required for US)."
    )]
    EmployeeCurrentYear,

    /// <summary>
    /// Account is for employer - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EPRY&quot;.
    /// </summary>
    [EnumMember(Value = "EPRY")]
    [IsoId("_YhtgYdp-Ed-ak6NoX_4Aeg_1468189300")]
    [Description(
        @"Account is for employer - prior year contributions into an investment retirement account (required for US)."
    )]
    EmployerPriorYear,

    /// <summary>
    /// Account is for employer - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;ECYE&quot;.
    /// </summary>
    [EnumMember(Value = "ECYE")]
    [IsoId("_YhtgYtp-Ed-ak6NoX_4Aeg_1468189301")]
    [Description(
        @"Account is for employer - current year contributions into an investment retirement account (required for US)."
    )]
    EmployerCurrentYear,

    /// <summary>
    /// Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;NFPI&quot;.
    /// </summary>
    [EnumMember(Value = "NFPI")]
    [IsoId("_YhtgY9p-Ed-ak6NoX_4Aeg_1468189302")]
    [Description(
        @"Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US)."
    )]
    NonFundPrototypeIRA,

    /// <summary>
    /// Account is for non-fund qualified plan into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;NFQP&quot;.
    /// </summary>
    [EnumMember(Value = "NFQP")]
    [IsoId("_YhtgZNp-Ed-ak6NoX_4Aeg_1468189303")]
    [Description(
        @"Account is for non-fund qualified plan into an investment retirement account (required for US)."
    )]
    NonFundQualifiedPlan,

    /// <summary>
    /// Account is for a defined contribution plan (required for US).
    /// Encoded/decoded by serializers as &quot;DECP&quot;.
    /// </summary>
    [EnumMember(Value = "DECP")]
    [IsoId("_YhtgZdp-Ed-ak6NoX_4Aeg_1468189304")]
    [Description(@"Account is for a defined contribution plan (required for US).")]
    DefinedContributionPlan,

    /// <summary>
    /// Account is an Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as &quot;IRAC&quot;.
    /// </summary>
    [EnumMember(Value = "IRAC")]
    [IsoId("_YhtgZtp-Ed-ak6NoX_4Aeg_1468189305")]
    [Description(@"Account is an Individual Retirement Account (IRA) (required for US).")]
    IndividualRetirementAccount,

    /// <summary>
    /// Account is for an Individual Retirement Account (IRA) - Rollover (required for US).
    /// Encoded/decoded by serializers as &quot;IRAR&quot;.
    /// </summary>
    [EnumMember(Value = "IRAR")]
    [IsoId("_YhtgZ9p-Ed-ak6NoX_4Aeg_1468189314")]
    [Description(
        @"Account is for an Individual Retirement Account (IRA) - Rollover (required for US)."
    )]
    IndividualRetirementAccountRollover,

    /// <summary>
    /// KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US).
    /// Encoded/decoded by serializers as &quot;KEOG&quot;.
    /// </summary>
    [EnumMember(Value = "KEOG")]
    [IsoId("_YhtgaNp-Ed-ak6NoX_4Aeg_1468189315")]
    [Description(
        @"KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US)."
    )]
    KEOGH,

    /// <summary>
    /// Account is a Profit Sharing Plan (required for US).
    /// Encoded/decoded by serializers as &quot;PFSP&quot;.
    /// </summary>
    [EnumMember(Value = "PFSP")]
    [IsoId("_Yhtgadp-Ed-ak6NoX_4Aeg_1468189316")]
    [Description(@"Account is a Profit Sharing Plan (required for US).")]
    ProfitSharingPlan,

    /// <summary>
    /// 401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US).
    /// Encoded/decoded by serializers as &quot;401K&quot;.
    /// </summary>
    [EnumMember(Value = "401K")]
    [IsoId("_Yh3RYNp-Ed-ak6NoX_4Aeg_1468189317")]
    [Description(
        @"401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US)."
    )]
    FourHundredAndOneK,

    /// <summary>
    /// Self-Directed Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as &quot;SIRA&quot;.
    /// </summary>
    [EnumMember(Value = "SIRA")]
    [IsoId("_Yh3RYdp-Ed-ak6NoX_4Aeg_1468189318")]
    [Description(@"Self-Directed Individual Retirement Account (IRA) (required for US).")]
    SelfDirectedIRA,

    /// <summary>
    /// 403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US).
    /// Encoded/decoded by serializers as &quot;403B&quot;.
    /// </summary>
    [EnumMember(Value = "403B")]
    [IsoId("_Yh3RYtp-Ed-ak6NoX_4Aeg_1468189319")]
    [Description(
        @"403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US)."
    )]
    FourHundredAndThreeB,

    /// <summary>
    /// 457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US).
    /// Encoded/decoded by serializers as &quot;457X&quot;.
    /// </summary>
    [EnumMember(Value = "457X")]
    [IsoId("_Yh3RY9p-Ed-ak6NoX_4Aeg_1468189320")]
    [Description(
        @"457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US)."
    )]
    FourHundredFiftySeven,

    /// <summary>
    /// Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as &quot;RIRA&quot;.
    /// </summary>
    [EnumMember(Value = "RIRA")]
    [IsoId("_Yh3RZNp-Ed-ak6NoX_4Aeg_1468189321")]
    [Description(
        @"Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US)."
    )]
    RothIRAFundPrototype,

    /// <summary>
    /// Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as &quot;RIAN&quot;.
    /// </summary>
    [EnumMember(Value = "RIAN")]
    [IsoId("_Yh3RZdp-Ed-ak6NoX_4Aeg_1468189322")]
    [Description(
        @"Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US)."
    )]
    RothIRANonPrototype,

    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US).
    /// Encoded/decoded by serializers as &quot;RCRF&quot;.
    /// </summary>
    [EnumMember(Value = "RCRF")]
    [IsoId("_Yh3RZtp-Ed-ak6NoX_4Aeg_1468189323")]
    [Description(
        @"Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US)."
    )]
    RothConversionIRAFundPrototype,

    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US).
    /// Encoded/decoded by serializers as &quot;RCIP&quot;.
    /// </summary>
    [EnumMember(Value = "RCIP")]
    [IsoId("_Yh3RZ9p-Ed-ak6NoX_4Aeg_1468189331")]
    [Description(
        @"Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US)."
    )]
    RothConversionIRANonPrototype,

    /// <summary>
    /// Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US).
    /// Encoded/decoded by serializers as &quot;EIFP&quot;.
    /// </summary>
    [EnumMember(Value = "EIFP")]
    [IsoId("_Yh3RaNp-Ed-ak6NoX_4Aeg_1468189332")]
    [Description(
        @"Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US)."
    )]
    EducationIRAFundPrototype,

    /// <summary>
    /// Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US).
    /// Encoded/decoded by serializers as &quot;EIOP&quot;.
    /// </summary>
    [EnumMember(Value = "EIOP")]
    [IsoId("_Yh3Radp-Ed-ak6NoX_4Aeg_1468189333")]
    [Description(
        @"Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US)."
    )]
    EducationIRANonPrototype,

    /// <summary>
    /// Another type of tax exemption.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YiBCYNp-Ed-ak6NoX_4Aeg_-1521742840")]
    [Description(@"Another type of tax exemption.")]
    Other,

    /// <summary>
    /// Account is for a minor for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_wn9AcCC_EeWPMvNwVtiMsA")]
    [Description(@"Account is for a minor for which a tax exemption is permitted.")]
    Minor,

    /// <summary>
    /// Exemption due to incapacitation.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_zrfp8CC_EeWPMvNwVtiMsA")]
    [Description(@"Exemption due to incapacitation.")]
    Incapacity,

    /// <summary>
    /// Account is for a foreigner for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;FORE&quot;.
    /// </summary>
    [EnumMember(Value = "FORE")]
    [IsoId("_25Kf0CC_EeWPMvNwVtiMsA")]
    [Description(@"Account is for a foreigner for which a tax exemption is permitted.")]
    Foreigner,

    /// <summary>
    /// Ordinary reporting.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_fukM0DaJEeWxoIK_IhudJg")]
    [Description(@"Ordinary reporting.")]
    Ordinary,

    /// <summary>
    /// Account is for an association, for example, a sports club, for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;ASSO&quot;.
    /// </summary>
    [EnumMember(Value = "ASSO")]
    [IsoId("_mK-PkDaJEeWxoIK_IhudJg")]
    [Description(
        @"Account is for an association, for example, a sports club, for which a tax exemption is permitted."
    )]
    Association,

    /// <summary>
    /// Account is for two account owners that are both domestic.
    /// Encoded/decoded by serializers as &quot;DOME&quot;.
    /// </summary>
    [EnumMember(Value = "DOME")]
    [IsoId("_wLJ7EDaJEeWxoIK_IhudJg")]
    [Description(@"Account is for two account owners that are both domestic.")]
    Domestic,

    /// <summary>
    /// Account is for two account owners where one or both are foreign.
    /// Encoded/decoded by serializers as &quot;FORP&quot;.
    /// </summary>
    [EnumMember(Value = "FORP")]
    [IsoId("_yXmkgDaJEeWxoIK_IhudJg")]
    [Description(@"Account is for two account owners where one or both are foreign.")]
    OneOrBothForeign,

    /// <summary>
    /// Account is for a rights holder.
    /// Encoded/decoded by serializers as &quot;RIHO&quot;.
    /// </summary>
    [EnumMember(Value = "RIHO")]
    [IsoId("_DnhNIDaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a rights holder.")]
    RightsHolder,

    /// <summary>
    /// Account is for a pension fund for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_HaUJUDaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a pension fund for which a tax exemption is permitted.|")]
    PensionFund,

    /// <summary>
    /// Account is for a diplomat for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;DIPL&quot;.
    /// </summary>
    [EnumMember(Value = "DIPL")]
    [IsoId("_Ks_bADaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a diplomat for which a tax exemption is permitted.")]
    Diplomat,

    /// <summary>
    /// Account is for a refugee or person without a number assigned by a government organisation, for example, without a Danish Central Securities Number.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_NYYDMDaKEeWxoIK_IhudJg")]
    [Description(
        @"Account is for a refugee or person without a number assigned by a government organisation, for example, without a Danish Central Securities Number."
    )]
    Refugee,

    /// <summary>
    /// One of the account owners is a foreign resident.
    /// Encoded/decoded by serializers as &quot;OANR&quot;.
    /// </summary>
    [EnumMember(Value = "OANR")]
    [IsoId("_deb6cL-HEeWfsa741pI6WA")]
    [Description(@"One of the account owners is a foreign resident.")]
    OneNonResident,

    /// <summary>
    /// Two or more of the account owners are foreign residents.
    /// Encoded/decoded by serializers as &quot;TANR&quot;.
    /// </summary>
    [EnumMember(Value = "TANR")]
    [IsoId("_dkSq0L-HEeWfsa741pI6WA")]
    [Description(@"Two or more of the account owners are foreign residents.")]
    TwoNonResident,

    /// <summary>
    /// Administrator of the account is not the owner.
    /// Encoded/decoded by serializers as &quot;ADMI&quot;.
    /// </summary>
    [EnumMember(Value = "ADMI")]
    [IsoId("_drDaIL-HEeWfsa741pI6WA")]
    [Description(@"Administrator of the account is not the owner.")]
    Administrator,
}
