// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a8PpJ9p-Ed-ak6NoX_4Aeg_-779465922")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the instruction.")]
[Derivations(typeof(ChargeBearerType1Code),typeof(ChargeBearerType2Code),typeof(ChargeBearerType3Code),typeof(ChargeBearerType4Code))]
public enum ChargeBearerTypeCode
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_a8YzENp-Ed-ak6NoX_4Aeg_-779465905")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor,
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_a8YzEdp-Ed-ak6NoX_4Aeg_-779465887")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor,
    
    /// <summary>
    /// In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_a8YzEtp-Ed-ak6NoX_4Aeg_-779465862")]
    [Description(@"In a credit transfer context, means that transaction charges on the sender side are to be borne by the debtor, transaction charges on the receiver side are to be borne by the creditor. In a direct debit context, means that transaction charges on the sender side are to be borne by the creditor, transaction charges on the receiver side are to be borne by the debtor.")]
    Shared,
    
    /// <summary>
    /// Charges are to be applied following the rules agreed in the service level and/or scheme.
    /// Encoded/decoded by serializers as &quot;SLEV&quot;.
    /// </summary>
    [EnumMember(Value = "SLEV")]
    [IsoId("_a8YzE9p-Ed-ak6NoX_4Aeg_-725902015")]
    [Description(@"Charges are to be applied following the rules agreed in the service level and/or scheme.")]
    FollowingServiceLevel,
    
}
