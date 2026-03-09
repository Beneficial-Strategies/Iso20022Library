// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of payment instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vDyvUF8xEeicg40_9gK9vQ")]
[Description(@"Specifies a type of payment instrument.")]
[DerivedFrom(typeof(FundPaymentTypeCode))]
public enum FundPaymentType1Code
{
    /// <summary>
    /// Payment instrument is a bankers draft.
    /// Encoded/decoded by serializers as &quot;DRAF&quot;.
    /// </summary>
    [EnumMember(Value = "DRAF")]
    [IsoId("_wli18V8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a bankers draft.")]
    BankersDraft = FundPaymentTypeCode.BankersDraft, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a cash account.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_wqTaIV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cash account.")]
    CashAccount = FundPaymentTypeCode.CashAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a cheque.
    /// Encoded/decoded by serializers as &quot;CHEQ&quot;.
    /// </summary>
    [EnumMember(Value = "CHEQ")]
    [IsoId("_w1dhQV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a cheque.")]
    Cheque = FundPaymentTypeCode.Cheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a credit transfer.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_w9Cv8V8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a credit transfer.")]
    CreditTransfer = FundPaymentTypeCode.CreditTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a direct debit.
    /// Encoded/decoded by serializers as &quot;DDEB&quot;.
    /// </summary>
    [EnumMember(Value = "DDEB")]
    [IsoId("_xC2dAV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a direct debit.")]
    DirectDebit = FundPaymentTypeCode.DirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instrument is a payment card.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_xIzUAV8xEeicg40_9gK9vQ")]
    [Description(@"Payment instrument is a payment card.")]
    PaymentCard = FundPaymentTypeCode.PaymentCard, // same ordinal as derivation source for type conversions
    
}
