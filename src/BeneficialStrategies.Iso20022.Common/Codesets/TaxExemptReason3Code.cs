// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DljS4SDAEeWPMvNwVtiMsA")]
[Description(
    @"Specifies the reason a specific tax has not been levied/deducted on a given transaction."
)]
[DerivedFrom(typeof(TaxExemptReasonCode))]
public enum TaxExemptReason3Code
{
    /// <summary>
    /// Account is not tax exempt.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_ECIhMSDAEeWPMvNwVtiMsA")]
    [Description(@"Account is not tax exempt.")]
    None = TaxExemptReasonCode.None, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account.
    /// Encoded/decoded by serializers as &quot;MASA&quot;.
    /// </summary>
    [EnumMember(Value = "MASA")]
    [IsoId("_ECIhMyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Maxi Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). The Maxi ISA allows an investor to save all three of the different elements of ISA investments that are allowed, with one savings institution in a single account."
    )]
    MaxiISA = TaxExemptReasonCode.MaxiISA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account.
    /// Encoded/decoded by serializers as &quot;MISA&quot;.
    /// </summary>
    [EnumMember(Value = "MISA")]
    [IsoId("_ECIhNSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Mini Cash Individual Savings Account (ISA). Account is an ISA with a single ISA manager that may contain cash, stocks and shares, investment funds and life assurance up to the prescribed annual subscription limit (required for UK). An investor can hold more than one Mini ISA to utilise the overall Mini ISA investment limit, and can invest with more than one savings institution, however only one of the three elements of ISA investment is allowed in a single account."
    )]
    MiniCashISA = TaxExemptReasonCode.MiniCashISA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as &quot;SISA&quot;.
    /// </summary>
    [EnumMember(Value = "SISA")]
    [IsoId("_ECIhNyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Mini Stocks and Shares Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain stocks, shares and collective investments up to the prescribed annual subscription limit (required for UK)."
    )]
    MiniStocksAndSharesISA = TaxExemptReasonCode.MiniStocksAndSharesISA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK).
    /// Encoded/decoded by serializers as &quot;IISA&quot;.
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_ECIhOSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Mini Insurance Individual Savings Account (ISA). Account is an ISA with an ISA manager that may only contain life insurance investments up to the prescribed annual subscription limit (required for UK)."
    )]
    MiniInsuranceISA = TaxExemptReasonCode.MiniInsuranceISA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for current year payments into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;CUYP&quot;.
    /// </summary>
    [EnumMember(Value = "CUYP")]
    [IsoId("_ECIhOyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for current year payments into an investment retirement account (required for US)."
    )]
    CurrentYearPayment = TaxExemptReasonCode.CurrentYearPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a prior year payment into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;PRYP&quot;.
    /// </summary>
    [EnumMember(Value = "PRYP")]
    [IsoId("_ECIhPSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for a prior year payment into an investment retirement account (required for US)."
    )]
    PriorYearPayment = TaxExemptReasonCode.PriorYearPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for an asset transfer into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;ASTR&quot;.
    /// </summary>
    [EnumMember(Value = "ASTR")]
    [IsoId("_ECIhPyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for an asset transfer into an investment retirement account (required for US)."
    )]
    AssetTransfer = TaxExemptReasonCode.AssetTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for employee - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EMPY&quot;.
    /// </summary>
    [EnumMember(Value = "EMPY")]
    [IsoId("_ECIhQSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for employee - prior year contributions into an investment retirement account (required for US)."
    )]
    EmployeePriorYear = TaxExemptReasonCode.EmployeePriorYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for employee - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EMCY&quot;.
    /// </summary>
    [EnumMember(Value = "EMCY")]
    [IsoId("_ECIhQyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for employee - current year contributions into an investment retirement account (required for US)."
    )]
    EmployeeCurrentYear = TaxExemptReasonCode.EmployeeCurrentYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for employer - prior year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;EPRY&quot;.
    /// </summary>
    [EnumMember(Value = "EPRY")]
    [IsoId("_ECIhRSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for employer - prior year contributions into an investment retirement account (required for US)."
    )]
    EmployerPriorYear = TaxExemptReasonCode.EmployerPriorYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for employer - current year contributions into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;ECYE&quot;.
    /// </summary>
    [EnumMember(Value = "ECYE")]
    [IsoId("_ECIhRyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for employer - current year contributions into an investment retirement account (required for US)."
    )]
    EmployerCurrentYear = TaxExemptReasonCode.EmployerCurrentYear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;NFPI&quot;.
    /// </summary>
    [EnumMember(Value = "NFPI")]
    [IsoId("_ECIhSSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for non-fund prototype Individual Retirement Account (IRA) into an investment retirement account (required for US)."
    )]
    NonFundPrototypeIRA = TaxExemptReasonCode.NonFundPrototypeIRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for non-fund qualified plan into an investment retirement account (required for US).
    /// Encoded/decoded by serializers as &quot;NFQP&quot;.
    /// </summary>
    [EnumMember(Value = "NFQP")]
    [IsoId("_ECIhSyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for non-fund qualified plan into an investment retirement account (required for US)."
    )]
    NonFundQualifiedPlan = TaxExemptReasonCode.NonFundQualifiedPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a defined contribution plan (required for US).
    /// Encoded/decoded by serializers as &quot;DECP&quot;.
    /// </summary>
    [EnumMember(Value = "DECP")]
    [IsoId("_ECIhTSDAEeWPMvNwVtiMsA")]
    [Description(@"Account is for a defined contribution plan (required for US).")]
    DefinedContributionPlan = TaxExemptReasonCode.DefinedContributionPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is an Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as &quot;IRAC&quot;.
    /// </summary>
    [EnumMember(Value = "IRAC")]
    [IsoId("_ECIhTyDAEeWPMvNwVtiMsA")]
    [Description(@"Account is an Individual Retirement Account (IRA) (required for US).")]
    IndividualRetirementAccount = TaxExemptReasonCode.IndividualRetirementAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for an Individual Retirement Account (IRA) - Rollover (required for US).
    /// Encoded/decoded by serializers as &quot;IRAR&quot;.
    /// </summary>
    [EnumMember(Value = "IRAR")]
    [IsoId("_ECIhUSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Account is for an Individual Retirement Account (IRA) - Rollover (required for US)."
    )]
    IndividualRetirementAccountRollover = TaxExemptReasonCode.IndividualRetirementAccountRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US).
    /// Encoded/decoded by serializers as &quot;KEOG&quot;.
    /// </summary>
    [EnumMember(Value = "KEOG")]
    [IsoId("_ECIhUyDAEeWPMvNwVtiMsA")]
    [Description(
        @"KEOGH. Account is a tax-deferred retirement plan designed to help self-employed workers or individuals who earn self-employed income establish a retirement savings program (required for US)."
    )]
    KEOGH = TaxExemptReasonCode.KEOGH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is a Profit Sharing Plan (required for US).
    /// Encoded/decoded by serializers as &quot;PFSP&quot;.
    /// </summary>
    [EnumMember(Value = "PFSP")]
    [IsoId("_ECIhVSDAEeWPMvNwVtiMsA")]
    [Description(@"Account is a Profit Sharing Plan (required for US).")]
    ProfitSharingPlan = TaxExemptReasonCode.ProfitSharingPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US).
    /// Encoded/decoded by serializers as &quot;401K&quot;.
    /// </summary>
    [EnumMember(Value = "401K")]
    [IsoId("_ECIhVyDAEeWPMvNwVtiMsA")]
    [Description(
        @"401k. Account is an optional retirement plan supported by many companies, in which income is invested before it is taxed (required for US)."
    )]
    FourHundredAndOneK = TaxExemptReasonCode.FourHundredAndOneK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Self-Directed Individual Retirement Account (IRA) (required for US).
    /// Encoded/decoded by serializers as &quot;SIRA&quot;.
    /// </summary>
    [EnumMember(Value = "SIRA")]
    [IsoId("_ECIhWSDAEeWPMvNwVtiMsA")]
    [Description(@"Self-Directed Individual Retirement Account (IRA) (required for US).")]
    SelfDirectedIRA = TaxExemptReasonCode.SelfDirectedIRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US).
    /// Encoded/decoded by serializers as &quot;403B&quot;.
    /// </summary>
    [EnumMember(Value = "403B")]
    [IsoId("_ECIhWyDAEeWPMvNwVtiMsA")]
    [Description(
        @"403(b). Account is a tax-deferred investment and savings program for employees of hospitals, educational institutions and other non-profit organisations, to save and invest in their own retirement. The name refers to the relevant section in the US Internal Revenue Code (required for US)."
    )]
    FourHundredAndThreeB = TaxExemptReasonCode.FourHundredAndThreeB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// 457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US).
    /// Encoded/decoded by serializers as &quot;457X&quot;.
    /// </summary>
    [EnumMember(Value = "457X")]
    [IsoId("_ECIhXSDAEeWPMvNwVtiMsA")]
    [Description(
        @"457. Account is a non-qualified deferred compensation program that is available to state and local governments and not-for-profit employers (required for US)."
    )]
    FourHundredFiftySeven = TaxExemptReasonCode.FourHundredFiftySeven, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as &quot;RIRA&quot;.
    /// </summary>
    [EnumMember(Value = "RIRA")]
    [IsoId("_ECIhXyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Roth Individual Retirement Account (IRA) Fund Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US)."
    )]
    RothIRAFundPrototype = TaxExemptReasonCode.RothIRAFundPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US).
    /// Encoded/decoded by serializers as &quot;RIAN&quot;.
    /// </summary>
    [EnumMember(Value = "RIAN")]
    [IsoId("_ECIhYSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Roth Individual Retirement Account (IRA) Non-Prototype. Account is a tax-deferred retirement account based on the reverse principle of a traditional IRA. Retirement contributions are taxed upfront, but withdrawals may be made tax-free when a certain age is reached, provided the Roth IRA has been set up for a certain period of time (required for US)."
    )]
    RothIRANonPrototype = TaxExemptReasonCode.RothIRANonPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US).
    /// Encoded/decoded by serializers as &quot;RCRF&quot;.
    /// </summary>
    [EnumMember(Value = "RCRF")]
    [IsoId("_ECIhYyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Roth Conversion Individual Retirement Account (IRA) Fund Prototype. Account is a retirement account established when a party switches from a regular IRA ( required for US)."
    )]
    RothConversionIRAFundPrototype = TaxExemptReasonCode.RothConversionIRAFundPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US).
    /// Encoded/decoded by serializers as &quot;RCIP&quot;.
    /// </summary>
    [EnumMember(Value = "RCIP")]
    [IsoId("_ECIhZSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Roth Conversion Individual Retirement Account (IRA) Non-Prototype. Account is a retirement account established when a party switches from a Regular IRA (required for US)."
    )]
    RothConversionIRANonPrototype = TaxExemptReasonCode.RothConversionIRANonPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US).
    /// Encoded/decoded by serializers as &quot;EIFP&quot;.
    /// </summary>
    [EnumMember(Value = "EIFP")]
    [IsoId("_ECIhZyDAEeWPMvNwVtiMsA")]
    [Description(
        @"Education Individual Retirement Account Fund Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required for US)."
    )]
    EducationIRAFundPrototype = TaxExemptReasonCode.EducationIRAFundPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US).
    /// Encoded/decoded by serializers as &quot;EIOP&quot;.
    /// </summary>
    [EnumMember(Value = "EIOP")]
    [IsoId("_ECIhaSDAEeWPMvNwVtiMsA")]
    [Description(
        @"Education Individual Retirement Account Non-Prototype (also known as an Education Savings Account). Account is a savings plan open to anyone under the age of 18. When the account owner withdraws money to pay for qualified higher education expenses, the withdrawals are generally tax-free (required in the US)."
    )]
    EducationIRANonPrototype = TaxExemptReasonCode.EducationIRANonPrototype, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a foreigner for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;FORE&quot;.
    /// </summary>
    [EnumMember(Value = "FORE")]
    [IsoId("_JPxqwSDAEeWPMvNwVtiMsA")]
    [Description(@"Account is for a foreigner for which a tax exemption is permitted.")]
    Foreigner = TaxExemptReasonCode.Foreigner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exemption due to incapacitation.
    /// Encoded/decoded by serializers as &quot;INCA&quot;.
    /// </summary>
    [EnumMember(Value = "INCA")]
    [IsoId("_Jep0QSDAEeWPMvNwVtiMsA")]
    [Description(@"Exemption due to incapacitation.")]
    Incapacity = TaxExemptReasonCode.Incapacity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a minor for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_KChWUSDAEeWPMvNwVtiMsA")]
    [Description(@"Account is for a minor for which a tax exemption is permitted.")]
    Minor = TaxExemptReasonCode.Minor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for an association, for example, a sports club, for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;ASSO&quot;.
    /// </summary>
    [EnumMember(Value = "ASSO")]
    [IsoId("_YSu38TaKEeWxoIK_IhudJg")]
    [Description(
        @"Account is for an association, for example, a sports club, for which a tax exemption is permitted."
    )]
    Association = TaxExemptReasonCode.Association, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a diplomat for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;DIPL&quot;.
    /// </summary>
    [EnumMember(Value = "DIPL")]
    [IsoId("_cHBo8TaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a diplomat for which a tax exemption is permitted.")]
    Diplomat = TaxExemptReasonCode.Diplomat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for two account owners that are both domestic.
    /// Encoded/decoded by serializers as &quot;DOME&quot;.
    /// </summary>
    [EnumMember(Value = "DOME")]
    [IsoId("_cNRa4TaKEeWxoIK_IhudJg")]
    [Description(@"Account is for two account owners that are both domestic.")]
    Domestic = TaxExemptReasonCode.Domestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for two account owners where one or both are foreign.
    /// Encoded/decoded by serializers as &quot;FORP&quot;.
    /// </summary>
    [EnumMember(Value = "FORP")]
    [IsoId("_chf-cTaKEeWxoIK_IhudJg")]
    [Description(@"Account is for two account owners where one or both are foreign.")]
    OneOrBothForeign = TaxExemptReasonCode.OneOrBothForeign, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ordinary reporting.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_cnmmcTaKEeWxoIK_IhudJg")]
    [Description(@"Ordinary reporting.")]
    Ordinary = TaxExemptReasonCode.Ordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a pension fund for which a tax exemption is permitted.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_dbFR0TaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a pension fund for which a tax exemption is permitted.|")]
    PensionFund = TaxExemptReasonCode.PensionFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a refugee or person without a number assigned by a government organisation, for example, without a Danish Central Securities Number.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_dnR6wTaKEeWxoIK_IhudJg")]
    [Description(
        @"Account is for a refugee or person without a number assigned by a government organisation, for example, without a Danish Central Securities Number."
    )]
    Refugee = TaxExemptReasonCode.Refugee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for a rights holder.
    /// Encoded/decoded by serializers as &quot;RIHO&quot;.
    /// </summary>
    [EnumMember(Value = "RIHO")]
    [IsoId("_dut_gTaKEeWxoIK_IhudJg")]
    [Description(@"Account is for a rights holder.")]
    RightsHolder = TaxExemptReasonCode.RightsHolder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Administrator of the account is not the owner.
    /// Encoded/decoded by serializers as &quot;ADMI&quot;.
    /// </summary>
    [EnumMember(Value = "ADMI")]
    [IsoId("_vRAkMb-HEeWfsa741pI6WA")]
    [Description(@"Administrator of the account is not the owner.")]
    Administrator = TaxExemptReasonCode.Administrator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Two or more of the account owners are foreign residents.
    /// Encoded/decoded by serializers as &quot;TANR&quot;.
    /// </summary>
    [EnumMember(Value = "TANR")]
    [IsoId("_vaug4b-HEeWfsa741pI6WA")]
    [Description(@"Two or more of the account owners are foreign residents.")]
    TwoNonResident = TaxExemptReasonCode.TwoNonResident, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One of the account owners is a foreign resident.
    /// Encoded/decoded by serializers as &quot;OANR&quot;.
    /// </summary>
    [EnumMember(Value = "OANR")]
    [IsoId("_vk_3Mb-HEeWfsa741pI6WA")]
    [Description(@"One of the account owners is a foreign resident.")]
    OneNonResident = TaxExemptReasonCode.OneNonResident, // same ordinal as derivation source for type conversions
}
