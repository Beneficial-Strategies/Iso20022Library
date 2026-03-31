// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z8A7M9p-Ed-ak6NoX_4Aeg_-2009106787")]
[Description(@"Specifies the type, or nature, of the payment.")]
[DerivedFrom(typeof(PaymentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentType3Code>))]
#endif
public enum PaymentType3Code
{
    /// <summary>
    /// Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBS&quot;.
    /// </summary>
    [EnumMember(Value = "CBS")]
    [IsoId("_Z8A7NNp-Ed-ak6NoX_4Aeg_-2009106552")]
    [Description(
        @"Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country."
    )]
    CrossBorderPayment = PaymentTypeCode.CrossBorderPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.
    /// Encoded/decoded by serializers as &quot;BCK&quot;.
    /// </summary>
    [EnumMember(Value = "BCK")]
    [IsoId("_Z8A7Ndp-Ed-ak6NoX_4Aeg_-2009106527")]
    [Description(
        @"Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system."
    )]
    BackUp = PaymentTypeCode.BackUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a payment offsetting the net cash balance owed/due in a retail payment system.
    /// Encoded/decoded by serializers as &quot;BAL&quot;.
    /// </summary>
    [EnumMember(Value = "BAL")]
    [IsoId("_Z8A7Ntp-Ed-ak6NoX_4Aeg_-2009106526")]
    [Description(
        @"Transaction is a payment offsetting the net cash balance owed/due in a retail payment system."
    )]
    BalanceRetail = PaymentTypeCode.BalanceRetail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is linked to CLS activities.
    /// Encoded/decoded by serializers as &quot;CLS&quot;.
    /// </summary>
    [EnumMember(Value = "CLS")]
    [IsoId("_Z8A7N9p-Ed-ak6NoX_4Aeg_-2009106510")]
    [Description(@"Payment is linked to CLS activities.")]
    CLSPayment = PaymentTypeCode.CLSPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is made to settle an operation made with the central bank.
    /// Encoded/decoded by serializers as &quot;CTR&quot;.
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_Z8A7ONp-Ed-ak6NoX_4Aeg_-2009106492")]
    [Description(@"Payment is made to settle an operation made with the central bank.")]
    CentralBankOperation = PaymentTypeCode.CentralBankOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBH&quot;.
    /// </summary>
    [EnumMember(Value = "CBH")]
    [IsoId("_Z8A7Odp-Ed-ak6NoX_4Aeg_-2009106467")]
    [Description(
        @"Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country."
    )]
    CrossBorderHighValuePayment = PaymentTypeCode.CrossBorderHighValuePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBP&quot;.
    /// </summary>
    [EnumMember(Value = "CBP")]
    [IsoId("_Z8KsMNp-Ed-ak6NoX_4Aeg_-2009106450")]
    [Description(
        @"Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country."
    )]
    CrossBorderPriorityPayment = PaymentTypeCode.CrossBorderPriorityPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross cash payment offsetting the amount owed/due for a securities transaction settlement.
    /// Encoded/decoded by serializers as &quot;DPG&quot;.
    /// </summary>
    [EnumMember(Value = "DPG")]
    [IsoId("_Z8KsMdp-Ed-ak6NoX_4Aeg_-2009106432")]
    [Description(
        @"Gross cash payment offsetting the amount owed/due for a securities transaction settlement."
    )]
    DVPGross = PaymentTypeCode.DVPGross, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net payment offsetting the cash balance due/owed for a series of securities transactions settlement.
    /// Encoded/decoded by serializers as &quot;DPN&quot;.
    /// </summary>
    [EnumMember(Value = "DPN")]
    [IsoId("_Z8KsMtp-Ed-ak6NoX_4Aeg_-2009106415")]
    [Description(
        @"Net payment offsetting the cash balance due/owed for a series of securities transactions settlement."
    )]
    DVPNet = PaymentTypeCode.DVPNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.
    /// Encoded/decoded by serializers as &quot;EXP&quot;.
    /// </summary>
    [EnumMember(Value = "EXP")]
    [IsoId("_Z8KsM9p-Ed-ak6NoX_4Aeg_-2009106414")]
    [Description(
        @"Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system."
    )]
    ExpressPayment = PaymentTypeCode.ExpressPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_Z8KsNNp-Ed-ak6NoX_4Aeg_-2009106397")]
    [Description(
        @"Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country."
    )]
    ThirdCurrencyHighValuePayment = PaymentTypeCode.ThirdCurrencyHighValuePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system.
    /// Encoded/decoded by serializers as &quot;LMT&quot;.
    /// </summary>
    [EnumMember(Value = "LMT")]
    [IsoId("_Z8KsNdp-Ed-ak6NoX_4Aeg_-2009106124")]
    [Description(
        @"Transaction is a payment that is processed when the pool of liquidity exceeds the minimum value reserved for an express payment in the RTGSPlus system."
    )]
    LimitPayment = PaymentTypeCode.LimitPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.
    /// Encoded/decoded by serializers as &quot;LIQ&quot;.
    /// </summary>
    [EnumMember(Value = "LIQ")]
    [IsoId("_Z8KsNtp-Ed-ak6NoX_4Aeg_-2009106107")]
    [Description(
        @"Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution."
    )]
    LiquidityTransfer = PaymentTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPP&quot;.
    /// </summary>
    [EnumMember(Value = "DPP")]
    [IsoId("_Z8KsN9p-Ed-ak6NoX_4Aeg_-2009106106")]
    [Description(
        @"Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country."
    )]
    DomesticPriorityPayment = PaymentTypeCode.DomesticPriorityPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPH&quot;.
    /// </summary>
    [EnumMember(Value = "DPH")]
    [IsoId("_Z8KsONp-Ed-ak6NoX_4Aeg_-2009106089")]
    [Description(
        @"Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country."
    )]
    DomesticHighValuePayment = PaymentTypeCode.DomesticHighValuePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment has an origin and a destination in the same country, and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPS&quot;.
    /// </summary>
    [EnumMember(Value = "DPS")]
    [IsoId("_Z8KsOdp-Ed-ak6NoX_4Aeg_-2009106012")]
    [Description(
        @"Payment has an origin and a destination in the same country, and is made in the currency of that country."
    )]
    DomesticPayment = PaymentTypeCode.DomesticPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is linked to overnight deposits and the marginal lending facility.
    /// Encoded/decoded by serializers as &quot;STF&quot;.
    /// </summary>
    [EnumMember(Value = "STF")]
    [IsoId("_Z8T2INp-Ed-ak6NoX_4Aeg_-2009105969")]
    [Description(@"Payment is linked to overnight deposits and the marginal lending facility.")]
    StandingFacilities = PaymentTypeCode.StandingFacilities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is linked to the Treasury State.
    /// Encoded/decoded by serializers as &quot;TRP&quot;.
    /// </summary>
    [EnumMember(Value = "TRP")]
    [IsoId("_Z8T2Idp-Ed-ak6NoX_4Aeg_-2009105952")]
    [Description(@"Payment is linked to the Treasury State.")]
    TreasuryStatePayment = PaymentTypeCode.TreasuryStatePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCS&quot;.
    /// </summary>
    [EnumMember(Value = "TCS")]
    [IsoId("_Z8T2Itp-Ed-ak6NoX_4Aeg_-2009105934")]
    [Description(
        @"Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country."
    )]
    ThirdCurrencyPayment = PaymentTypeCode.ThirdCurrencyPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is the payment of a specific amount of money lent by a creditor/lender.
    /// Encoded/decoded by serializers as &quot;LOA&quot;.
    /// </summary>
    [EnumMember(Value = "LOA")]
    [IsoId("_Z8T2I9p-Ed-ak6NoX_4Aeg_-2009105933")]
    [Description(
        @"Transaction is the payment of a specific amount of money lent by a creditor/lender."
    )]
    Loan = PaymentTypeCode.Loan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an amount of money transferred in repayment of loan.
    /// Encoded/decoded by serializers as &quot;LOR&quot;.
    /// </summary>
    [EnumMember(Value = "LOR")]
    [IsoId("_Z8T2JNp-Ed-ak6NoX_4Aeg_-2009105909")]
    [Description(@"Transaction is an amount of money transferred in repayment of loan.")]
    LoanRepayment = PaymentTypeCode.LoanRepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.
    /// Encoded/decoded by serializers as &quot;TCP&quot;.
    /// </summary>
    [EnumMember(Value = "TCP")]
    [IsoId("_Z8T2Jdp-Ed-ak6NoX_4Aeg_-2009105892")]
    [Description(
        @"Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country."
    )]
    ThirdCurrencyPriorityPayment = PaymentTypeCode.ThirdCurrencyPriorityPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is linked to an overnight deposit.
    /// Encoded/decoded by serializers as &quot;OND&quot;.
    /// </summary>
    [EnumMember(Value = "OND")]
    [IsoId("_Z8T2Jtp-Ed-ak6NoX_4Aeg_-1235461266")]
    [Description(@"Transaction is linked to an overnight deposit.")]
    OvernightDeposit = PaymentTypeCode.OvernightDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is linked to the marginal lending facility.
    /// Encoded/decoded by serializers as &quot;MGL&quot;.
    /// </summary>
    [EnumMember(Value = "MGL")]
    [IsoId("_Z8T2J9p-Ed-ak6NoX_4Aeg_-1231765290")]
    [Description(@"Transaction is linked to the marginal lending facility.")]
    MarginalLending = PaymentTypeCode.MarginalLending, // same ordinal as derivation source for type conversions
}
