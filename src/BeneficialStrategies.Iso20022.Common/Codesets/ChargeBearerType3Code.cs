// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_he7u0KXeEeaBtJ1HvhzRtg")]
[Description(@"Specifies which party/parties will bear the charges associated with the processing of the payment transaction.")]
[DerivedFrom(typeof(ChargeBearerTypeCode))]
public enum ChargeBearerType3Code
{
    /// <summary>
    /// In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_jY5hIaXeEeaBtJ1HvhzRtg")]
    [Description(@"In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.")]
    Shared = ChargeBearerTypeCode.Shared, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_jree4KXeEeaBtJ1HvhzRtg")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor = ChargeBearerTypeCode.BorneByDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_j4Ia0qXeEeaBtJ1HvhzRtg")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor = ChargeBearerTypeCode.BorneByCreditor, // same ordinal as derivation source for type conversions
    
}
