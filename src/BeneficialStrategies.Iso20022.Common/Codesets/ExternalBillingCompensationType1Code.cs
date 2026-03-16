// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6WzSl5qlEeGSON8vddiWzQ_882310239")]
[Description(
    @"Defines the type of billing compensation to be applied, as published in an external billing compensation type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalBillingCompensationTypeCode))]
public enum ExternalBillingCompensationType1Code
{
    /// <summary>
    /// Total amount of service charges that can be offset by an earnings allowance credit. Such services carry a Payment Method code of ”Balance Compensable”.  This amount is included in SettleChargeTtl-Current Period (AFP code 00 03 00). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 03 31
    /// Encoded/decoded by serializers as &quot;BACS&quot;.
    /// </summary>
    [EnumMember(Value = "BACS")]
    [IsoId("_uNDAgvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total amount of service charges that can be offset by an earnings allowance credit. Such services carry a Payment Method code of ”Balance Compensable”.  This amount is included in SettleChargeTtl-Current Period (AFP code 00 03 00). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 03 31"
    )]
    BalanceCompensableServices = ExternalBillingCompensationTypeCode.BalanceCompensableServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount due to the bank for the settlement period, after all adjustments and deductions. Includes both service and tax charges. If nothing is due this value must be sent as zero. AFP code=00 03 14
    /// Encoded/decoded by serializers as &quot;CTND&quot;.
    /// </summary>
    [EnumMember(Value = "CTND")]
    [IsoId("_uNDAhfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount due to the bank for the settlement period, after all adjustments and deductions. Includes both service and tax charges. If nothing is due this value must be sent as zero. AFP code=00 03 14"
    )]
    ChargesAndTaxesNetDueThisStmt =
        ExternalBillingCompensationTypeCode.ChargesAndTaxesNetDueThisStmt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount due to the bank for balance compensable service charges which exceed the earnings allowance for the settlement period. This amount should be equal to the absolute value of the ExcessDeficitEarningsAllowance-Adjusted (AFP code 00 02 44). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 47
    /// Encoded/decoded by serializers as &quot;DEAD&quot;.
    /// </summary>
    [EnumMember(Value = "DEAD")]
    [IsoId("_uNDAiPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount due to the bank for balance compensable service charges which exceed the earnings allowance for the settlement period. This amount should be equal to the absolute value of the ExcessDeficitEarningsAllowance-Adjusted (AFP code 00 02 44). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 47"
    )]
    DeficitEarningsAllowanceDueThisStmt =
        ExternalBillingCompensationTypeCode.DeficitEarningsAllowanceDueThisStmt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value of balances maintained during the statement period which can be used to offset balance compensable service charges. This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 40
    /// Encoded/decoded by serializers as &quot;EALL&quot;.
    /// </summary>
    [EnumMember(Value = "EALL")]
    [IsoId("_uNDAi_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Value of balances maintained during the statement period which can be used to offset balance compensable service charges. This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 40"
    )]
    EarningsAllowance = ExternalBillingCompensationTypeCode.EarningsAllowance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net value of balance and/or rate adjustments for prior periods to be applied to the current excess/(deficit) allowance. AFP code=00 02 43
    /// Encoded/decoded by serializers as &quot;EANA&quot;.
    /// </summary>
    [EnumMember(Value = "EANA")]
    [IsoId("_uNDAjvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Net value of balance and/or rate adjustments for prior periods to be applied to the current excess/(deficit) allowance. AFP code=00 02 43"
    )]
    EarningsAllowanceNetAdjustment =
        ExternalBillingCompensationTypeCode.EarningsAllowanceNetAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Excess/(deficit) earnings allowance for the analysis period plus or minus any net earnings allowance and/or balance compensable service charge adjustments. Note that in the absence of any EarningsAllowance-NetAdjust (AFP code 00 02 43) this balance is preferred instead of the ExcessDeficitEarningsAllowance (AFP code 00 02 41). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 44
    /// Encoded/decoded by serializers as &quot;EDAA&quot;.
    /// </summary>
    [EnumMember(Value = "EDAA")]
    [IsoId("_uNMxgvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Excess/(deficit) earnings allowance for the analysis period plus or minus any net earnings allowance and/or balance compensable service charge adjustments. Note that in the absence of any EarningsAllowance-NetAdjust (AFP code 00 02 43) this balance is preferred instead of the ExcessDeficitEarningsAllowance (AFP code 00 02 41). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 44"
    )]
    ExcessDeficitEarningsAllowanceAdjusted =
        ExternalBillingCompensationTypeCode.ExcessDeficitEarningsAllowanceAdjusted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The difference between the earnings allowance and the balance compensable service charges.  Excess allowance occurs when the earnings allowance exceeds the total balance compensable service charges.  A Deficit allowance occurs when the total balance compensable service charges exceed the earnings allowance. Excess allowances may be carried forward into future statement periods at the bank’s discretion. Deficit allowances are typically reflected as charges due to the bank in the form of DeficitEarningsAllowanceDueThisStmt (AFP code 00 02 47). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 41
    /// Encoded/decoded by serializers as &quot;EDAL&quot;.
    /// </summary>
    [EnumMember(Value = "EDAL")]
    [IsoId("_uNMxhfRYEeuLhpyIdtJzwg")]
    [Description(
        @"The difference between the earnings allowance and the balance compensable service charges.  Excess allowance occurs when the earnings allowance exceeds the total balance compensable service charges.  A Deficit allowance occurs when the total balance compensable service charges exceed the earnings allowance. Excess allowances may be carried forward into future statement periods at the bank’s discretion. Deficit allowances are typically reflected as charges due to the bank in the form of DeficitEarningsAllowanceDueThisStmt (AFP code 00 02 47). This value must be sent if the bank is providing an earnings credit based on deposit balances. AFP code=00 02 41"
    )]
    ExcessDeficitEarningsAllowance =
        ExternalBillingCompensationTypeCode.ExcessDeficitEarningsAllowance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges from a prior billing period which have been paid. AFP code=00 03 22
    /// Encoded/decoded by serializers as &quot;FESS&quot;.
    /// </summary>
    [EnumMember(Value = "FESS")]
    [IsoId("_uNMxiPRYEeuLhpyIdtJzwg")]
    [Description(@"Charges from a prior billing period which have been paid. AFP code=00 03 22")]
    FeesPaid = ExternalBillingCompensationTypeCode.FeesPaid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of service charges as listed in the Service Sections that are provided free of charge. Such services carry a Payment Method code of &quot;FREE&quot; (Free). This amount is included in SettleChargetTL-Current Period (AFP code 00 03 00). Should be sent if there are any “Free” service charges in the Service Sections. It is assumed that “waived” and “free” services are not taxed. AFP code=00 03 36
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_uNMxi_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Total amount of service charges as listed in the Service Sections that are provided free of charge. Such services carry a Payment Method code of ""FREE"" (Free). This amount is included in SettleChargetTL-Current Period (AFP code 00 03 00). Should be sent if there are any “Free” service charges in the Service Sections. It is assumed that “waived” and “free” services are not taxed. AFP code=00 03 36"
    )]
    FreeServices = ExternalBillingCompensationTypeCode.FreeServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of service charges due as of this statement that are not eligible to be offset by an earnings allowance credit. Such services carry a Payment Method code of “FLAT&quot; (HardCharge).  This amount is included in SettleChargeTtl-CurrentPeriod (AFP code 00 03 00 ). AFP code=00 03 00
    /// Encoded/decoded by serializers as &quot;NBCS&quot;.
    /// </summary>
    [EnumMember(Value = "NBCS")]
    [IsoId("_uNWigvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total amount of service charges due as of this statement that are not eligible to be offset by an earnings allowance credit. Such services carry a Payment Method code of “FLAT"" (HardCharge).  This amount is included in SettleChargeTtl-CurrentPeriod (AFP code 00 03 00 ). AFP code=00 03 00"
    )]
    NonBalCompensableServices = ExternalBillingCompensationTypeCode.NonBalCompensableServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of service charges as listed in the Service Sections but assessed previously and which, therefore, are not due.  Such services carry a Payment Method code of &quot;PVCH&quot; (PreviouslyCharged). This amount is included in SettleChargetTL-CurrentPeriod (AFP code 00 03 00). Should be sent if there are any &quot;Previously Charged&quot;  services in the Service Sections. AFP code=00 03 35
    /// Encoded/decoded by serializers as &quot;PVCS&quot;.
    /// </summary>
    [EnumMember(Value = "PVCS")]
    [IsoId("_uNWihfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total amount of service charges as listed in the Service Sections but assessed previously and which, therefore, are not due.  Such services carry a Payment Method code of ""PVCH"" (PreviouslyCharged). This amount is included in SettleChargetTL-CurrentPeriod (AFP code 00 03 00). Should be sent if there are any ""Previously Charged""  services in the Service Sections. AFP code=00 03 35"
    )]
    PreviouslyChargedServices = ExternalBillingCompensationTypeCode.PreviouslyChargedServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net value of adjustments to balance compensable service charges for a prior period(s) to be applied to the current excess/(deficit) allowance. AFP cod=00 03 32
    /// Encoded/decoded by serializers as &quot;SCAB&quot;.
    /// </summary>
    [EnumMember(Value = "SCAB")]
    [IsoId("_uNWiiPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Net value of adjustments to balance compensable service charges for a prior period(s) to be applied to the current excess/(deficit) allowance. AFP cod=00 03 32"
    )]
    ServChargesNetAdjustBalCompensable =
        ExternalBillingCompensationTypeCode.ServChargesNetAdjustBalCompensable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total of all service charge adjustments that are not eligible to be offset by an earnings allowance credit.  This can be a positive-signed or negative-signed number. AFP code=00 03 33
    /// Encoded/decoded by serializers as &quot;SCAN&quot;.
    /// </summary>
    [EnumMember(Value = "SCAN")]
    [IsoId("_uNWii_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Total of all service charge adjustments that are not eligible to be offset by an earnings allowance credit.  This can be a positive-signed or negative-signed number. AFP code=00 03 33"
    )]
    ServChargesNetAdjustNonBalCompensable =
        ExternalBillingCompensationTypeCode.ServChargesNetAdjustNonBalCompensable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The total amount of service charges due exclusive of taxes due. AFP code=00 03 11
    /// Encoded/decoded by serializers as &quot;SCBT&quot;.
    /// </summary>
    [EnumMember(Value = "SCBT")]
    [IsoId("_uNWijvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The total amount of service charges due exclusive of taxes due. AFP code=00 03 11"
    )]
    ServiceChargesDueBeforeTax = ExternalBillingCompensationTypeCode.ServiceChargesDueBeforeTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total charges before credit for services provided during the current statement period. This total is the arithmetic sum of all charges listed in the Settlement Amount element of the Service Sections in the statement regardless of the Payment Method code . It includes all Balance Compensable charges, Hard charges, Previously Charged charges, Waived charges and Free charges. It does not include any tax charges related to the services. AFP code=00 03 00
    /// Encoded/decoded by serializers as &quot;SCCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCCP")]
    [IsoId("_uNfscvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total charges before credit for services provided during the current statement period. This total is the arithmetic sum of all charges listed in the Settlement Amount element of the Service Sections in the statement regardless of the Payment Method code . It includes all Balance Compensable charges, Hard charges, Previously Charged charges, Waived charges and Free charges. It does not include any tax charges related to the services. AFP code=00 03 00"
    )]
    SettleChargeTtlCurrentPeriod = ExternalBillingCompensationTypeCode.SettleChargeTtlCurrentPeriod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of ChargesAndTaxes-NetDueThisStmt (AFP code 00 03 14 ) that are directly debited from the customer’s account. AFP code=00 03 50
    /// Encoded/decoded by serializers as &quot;SCDB&quot;.
    /// </summary>
    [EnumMember(Value = "SCDB")]
    [IsoId("_uNfsdfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount of ChargesAndTaxes-NetDueThisStmt (AFP code 00 03 14 ) that are directly debited from the customer’s account. AFP code=00 03 50"
    )]
    ServiceChargesDebited = ExternalBillingCompensationTypeCode.ServiceChargesDebited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The total amount of any service charge discount. AFP code=00 03 41
    /// Encoded/decoded by serializers as &quot;SCDI&quot;.
    /// </summary>
    [EnumMember(Value = "SCDI")]
    [IsoId("_uNfsePRYEeuLhpyIdtJzwg")]
    [Description(@"The total amount of any service charge discount. AFP code=00 03 41")]
    ServiceChargesDiscount = ExternalBillingCompensationTypeCode.ServiceChargesDiscount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of ChargesAndTaxes-NetDueThisStmt (AFP code 00 03 14 ) that are invoiced. AFP code=00 03 A0
    /// Encoded/decoded by serializers as &quot;SCIN&quot;.
    /// </summary>
    [EnumMember(Value = "SCIN")]
    [IsoId("_uNfse_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount of ChargesAndTaxes-NetDueThisStmt (AFP code 00 03 14 ) that are invoiced. AFP code=00 03 A0"
    )]
    ServiceChargesInvoiced = ExternalBillingCompensationTypeCode.ServiceChargesInvoiced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Total amount of hard interest credited to a designated account. The amount of hard interest credited, if any, is calculated by applying the Interest Credited rate against a negative balance as reported in the Balance Section with a Balance Identifier of  ExcessDeficitCollectedBal (AFP code 00 04 12). AFP code=00 00 76
    /// Encoded/decoded by serializers as &quot;TICD&quot;.
    /// </summary>
    [EnumMember(Value = "TICD")]
    [IsoId("_uNfsfvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Total amount of hard interest credited to a designated account. The amount of hard interest credited, if any, is calculated by applying the Interest Credited rate against a negative balance as reported in the Balance Section with a Balance Identifier of  ExcessDeficitCollectedBal (AFP code 00 04 12). AFP code=00 00 76"
    )]
    TtlInterestCredited = ExternalBillingCompensationTypeCode.TtlInterestCredited, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The total amount of service charges that were subject to taxes. AFP code=00 03 13
    /// Encoded/decoded by serializers as &quot;TXSC&quot;.
    /// </summary>
    [EnumMember(Value = "TXSC")]
    [IsoId("_uNpdcvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The total amount of service charges that were subject to taxes. AFP code=00 03 13"
    )]
    TaxableServiceCharges = ExternalBillingCompensationTypeCode.TaxableServiceCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sum of all the individual tax values as contained in either the individual Service Sections or Tax Sections. AFP code=00 03 60
    /// Encoded/decoded by serializers as &quot;TXTS&quot;.
    /// </summary>
    [EnumMember(Value = "TXTS")]
    [IsoId("_uNpddfRYEeuLhpyIdtJzwg")]
    [Description(
        @"The Sum of all the individual tax values as contained in either the individual Service Sections or Tax Sections. AFP code=00 03 60"
    )]
    TaxTotalSum = ExternalBillingCompensationTypeCode.TaxTotalSum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of service charges otherwise due that are waived on this statement. Such services carry a Payment Method code of “WVED&quot; (Waived). Note that this amount does not include line item free services (AFP code 00 03 36). This amount is included in SettleChargetTL-Current Period (AFP code 00 03 00). Any such line item waivers or free services are not brought forward into the Compensation calculations. It is assumed that “waived” and “free” services are not taxed. afp CODE=00 03 40
    /// Encoded/decoded by serializers as &quot;WAIV&quot;.
    /// </summary>
    [EnumMember(Value = "WAIV")]
    [IsoId("_uNpdePRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount of service charges otherwise due that are waived on this statement. Such services carry a Payment Method code of “WVED"" (Waived). Note that this amount does not include line item free services (AFP code 00 03 36). This amount is included in SettleChargetTL-Current Period (AFP code 00 03 00). Any such line item waivers or free services are not brought forward into the Compensation calculations. It is assumed that “waived” and “free” services are not taxed. afp CODE=00 03 40"
    )]
    WaivedServices = ExternalBillingCompensationTypeCode.WaivedServices, // same ordinal as derivation source for type conversions
}
