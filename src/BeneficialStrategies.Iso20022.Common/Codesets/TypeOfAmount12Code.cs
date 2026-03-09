// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xy4xoFT6EeetiruPyDPo0Q")]
[Description(@"Type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount12Code
{
    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_z_oWAVT6EeetiruPyDPo0Q")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount = TypeOfAmountCode.AuthorisedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_4CMzkVT6EeetiruPyDPo0Q")]
    [Description(@"Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.")]
    Discount = TypeOfAmountCode.Discount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee applied by the card issuer to the cardholder.
    /// Encoded/decoded by serializers as &quot;ISCF&quot;.
    /// </summary>
    [EnumMember(Value = "ISCF")]
    [IsoId("_5p5KIVT6EeetiruPyDPo0Q")]
    [Description(@"Fee applied by the card issuer to the cardholder.")]
    IssuerCardholderFee = TypeOfAmountCode.IssuerCardholderFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains the total amount of all authorisations related to the same cardholder purchase activities. Example: total of all incremental or splitted shipment authorisations for the same purchase.
    /// Encoded/decoded by serializers as &quot;CUAT&quot;.
    /// </summary>
    [EnumMember(Value = "CUAT")]
    [IsoId("_IFzkoVT8EeetiruPyDPo0Q")]
    [Description(@"Contains the total amount of all authorisations related to the same cardholder purchase activities. Example: total of all incremental or splitted shipment authorisations for the same purchase.")]
    Cumulative = TypeOfAmountCode.Cumulative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum amount (the final amount must be less or equal).
    /// Encoded/decoded by serializers as &quot;MAXI&quot;.
    /// </summary>
    [EnumMember(Value = "MAXI")]
    [IsoId("_NlW9kVT8EeetiruPyDPo0Q")]
    [Description(@"Maximum amount (the final amount must be less or equal).")]
    Maximum = TypeOfAmountCode.Maximum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTX&quot;.
    /// </summary>
    [EnumMember(Value = "AMTX")]
    [IsoId("_OU91kVT8EeetiruPyDPo0Q")]
    [Description(@"Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined.")]
    MaximumAllowedAmount = TypeOfAmountCode.MaximumAllowedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTN&quot;.
    /// </summary>
    [EnumMember(Value = "AMTN")]
    [IsoId("_OdmNIVT8EeetiruPyDPo0Q")]
    [Description(@"Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined.")]
    MinimumAllowedAmount = TypeOfAmountCode.MinimumAllowedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount that has been requested to be authorised.
    /// Encoded/decoded by serializers as &quot;AMTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AMTQ")]
    [IsoId("_PRg9YVT8EeetiruPyDPo0Q")]
    [Description(@"Transaction amount that has been requested to be authorised.")]
    RequestedAmount = TypeOfAmountCode.RequestedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_PxWUAVT8EeetiruPyDPo0Q")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_P_e2oVT8EeetiruPyDPo0Q")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested cashback amount
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("_2t9sYRcJEeit0dtP9bTmEg")]
    [Description(@"Requested cashback amount")]
    RequestedCashback = TypeOfAmountCode.RequestedCashback, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount anticipated for the transaction
    /// Encoded/decoded by serializers as &quot;ANTA&quot;.
    /// </summary>
    [EnumMember(Value = "ANTA")]
    [IsoId("_27WoIRcJEeit0dtP9bTmEg")]
    [Description(@"Amount anticipated for the transaction")]
    Anticipated = TypeOfAmountCode.Anticipated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local amount before DCC (Dynamic Currency Conversion) was applied.
    /// Encoded/decoded by serializers as &quot;PDCC&quot;.
    /// </summary>
    [EnumMember(Value = "PDCC")]
    [IsoId("_qD6MgekUEemeDPHh-U9b6w")]
    [Description(@"Local amount before DCC (Dynamic Currency Conversion) was applied.")]
    PreDCC = TypeOfAmountCode.PreDCC, // same ordinal as derivation source for type conversions
    
}
