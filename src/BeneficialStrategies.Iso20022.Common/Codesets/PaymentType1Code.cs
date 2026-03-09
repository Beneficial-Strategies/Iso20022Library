// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vl9g99p-Ed-ak6NoX_4Aeg_-345535565")]
[Description(@"Specifies the type, or nature, of the payment.")]
[DerivedFrom(typeof(PaymentTypeCode))]
public enum PaymentType1Code
{
    /// <summary>
    /// Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBS&quot;.
    /// </summary>
    [EnumMember(Value = "CBS")]
    [IsoId("_Vl9g-Np-Ed-ak6NoX_4Aeg_193012472")]
    [Description(@"Payment has an origin in one country, a destination in another, and is made in the currency of either the origin or destination country.")]
    CrossBorderPayment = PaymentTypeCode.CrossBorderPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.
    /// Encoded/decoded by serializers as &quot;BCK&quot;.
    /// </summary>
    [EnumMember(Value = "BCK")]
    [IsoId("_Vl9g-dp-Ed-ak6NoX_4Aeg_193012515")]
    [Description(@"Payment is made under the recovery procedure to move liquidity to/from the settlement account of a member according to the specifications of the system.")]
    BackUp = PaymentTypeCode.BackUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is linked to CLS activities.
    /// Encoded/decoded by serializers as &quot;CLS&quot;.
    /// </summary>
    [EnumMember(Value = "CLS")]
    [IsoId("_VmHR8Np-Ed-ak6NoX_4Aeg_193012532")]
    [Description(@"Payment is linked to CLS activities.")]
    CLSPayment = PaymentTypeCode.CLSPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is made to settle an operation made with the central bank.
    /// Encoded/decoded by serializers as &quot;CTR&quot;.
    /// </summary>
    [EnumMember(Value = "CTR")]
    [IsoId("_VmHR8dp-Ed-ak6NoX_4Aeg_193012575")]
    [Description(@"Payment is made to settle an operation made with the central bank.")]
    CentralBankOperation = PaymentTypeCode.CentralBankOperation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBH&quot;.
    /// </summary>
    [EnumMember(Value = "CBH")]
    [IsoId("_VmHR8tp-Ed-ak6NoX_4Aeg_193012592")]
    [Description(@"Transaction is a high value payment that has an origin in one country and a destination in another country and is made in the currency of either the origin or destination country.")]
    CrossBorderHighValuePayment = PaymentTypeCode.CrossBorderHighValuePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.
    /// Encoded/decoded by serializers as &quot;CBP&quot;.
    /// </summary>
    [EnumMember(Value = "CBP")]
    [IsoId("_VmHR89p-Ed-ak6NoX_4Aeg_193012627")]
    [Description(@"Transaction is a priority payment that has an origin in one country and a destination in another and is made in the currency of either the origin or destination country.")]
    CrossBorderPriorityPayment = PaymentTypeCode.CrossBorderPriorityPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.
    /// Encoded/decoded by serializers as &quot;EXP&quot;.
    /// </summary>
    [EnumMember(Value = "EXP")]
    [IsoId("_VmHR9Np-Ed-ak6NoX_4Aeg_193012887")]
    [Description(@"Transaction is a payment that is processed whenever liquidity is available on the settlement account of a member of the RTGSPlus system.")]
    ExpressPayment = PaymentTypeCode.ExpressPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_VmHR9dp-Ed-ak6NoX_4Aeg_193012922")]
    [Description(@"Transaction is a high value payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyHighValuePayment = PaymentTypeCode.ThirdCurrencyHighValuePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.
    /// Encoded/decoded by serializers as &quot;LIQ&quot;.
    /// </summary>
    [EnumMember(Value = "LIQ")]
    [IsoId("_VmHR9tp-Ed-ak6NoX_4Aeg_193012947")]
    [Description(@"Payment is made to transfer liquidity to/from the settlement account of a member, to/from the current account held at the central institution or any other institution.")]
    LiquidityTransfer = PaymentTypeCode.LiquidityTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPP&quot;.
    /// </summary>
    [EnumMember(Value = "DPP")]
    [IsoId("_VmHR99p-Ed-ak6NoX_4Aeg_193012982")]
    [Description(@"Transaction is a priority payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticPriorityPayment = PaymentTypeCode.DomesticPriorityPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPH&quot;.
    /// </summary>
    [EnumMember(Value = "DPH")]
    [IsoId("_VmHR-Np-Ed-ak6NoX_4Aeg_193013017")]
    [Description(@"Transaction is a high value payment that has an origin and a destination in the same country and is made in the currency of that country.")]
    DomesticHighValuePayment = PaymentTypeCode.DomesticHighValuePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has an origin and a destination in the same country, and is made in the currency of that country.
    /// Encoded/decoded by serializers as &quot;DPS&quot;.
    /// </summary>
    [EnumMember(Value = "DPS")]
    [IsoId("_VmHR-dp-Ed-ak6NoX_4Aeg_193013325")]
    [Description(@"Payment has an origin and a destination in the same country, and is made in the currency of that country.")]
    DomesticPayment = PaymentTypeCode.DomesticPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.
    /// Encoded/decoded by serializers as &quot;TCS&quot;.
    /// </summary>
    [EnumMember(Value = "TCS")]
    [IsoId("_VmQb4Np-Ed-ak6NoX_4Aeg_193013367")]
    [Description(@"Transaction is a payment that is made in a third currency to the origin and destination countries. The origin and destination countries may be one and the same country.")]
    ThirdCurrencyPayment = PaymentTypeCode.ThirdCurrencyPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.
    /// Encoded/decoded by serializers as &quot;TCP&quot;.
    /// </summary>
    [EnumMember(Value = "TCP")]
    [IsoId("_VmQb4dp-Ed-ak6NoX_4Aeg_193013402")]
    [Description(@"Payment is made in a third currency to the origin and destination countries. The origin and destination countries may be the same country.")]
    ThirdCurrencyPriorityPayment = PaymentTypeCode.ThirdCurrencyPriorityPayment, // same ordinal as derivation source for type conversions
    
}
