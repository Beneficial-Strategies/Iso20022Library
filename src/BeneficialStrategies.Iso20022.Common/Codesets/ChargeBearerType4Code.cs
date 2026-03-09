// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XaGi3_WfEemtd4wHZYvFUQ")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
[DerivedFrom(typeof(ChargeBearerTypeCode))]
public enum ChargeBearerType4Code
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_XaGi4fWfEemtd4wHZYvFUQ")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor = ChargeBearerTypeCode.BorneByDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_XaGi4_WfEemtd4wHZYvFUQ")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor = ChargeBearerTypeCode.BorneByCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_XaGi5fWfEemtd4wHZYvFUQ")]
    [Description(@"In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.")]
    Shared = ChargeBearerTypeCode.Shared, // same ordinal as derivation source for type conversions
    
}
