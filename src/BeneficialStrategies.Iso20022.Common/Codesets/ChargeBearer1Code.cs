// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a78HJtp-Ed-ak6NoX_4Aeg_230427680")]
[Description(@"Specifies which party(ies) will pay charges due for processing of the payment transaction.")]
[DerivedFrom(typeof(ChargeBearerCode))]
public enum ChargeBearer1Code
{
    /// <summary>
    /// All transaction charges are to be borne by the debtor.
    /// Encoded/decoded by serializers as &quot;OUR&quot;.
    /// </summary>
    [EnumMember(Value = "OUR")]
    [IsoId("_a78HJ9p-Ed-ak6NoX_4Aeg_-676764336")]
    [Description(@"All transaction charges are to be borne by the debtor.")]
    BorneByDebtor = ChargeBearerCode.BorneByDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All transaction charges are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;BEN&quot;.
    /// </summary>
    [EnumMember(Value = "BEN")]
    [IsoId("_a8F4INp-Ed-ak6NoX_4Aeg_-674914229")]
    [Description(@"All transaction charges are to be borne by the creditor.")]
    BorneByCreditor = ChargeBearerCode.BorneByCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Under the credit transfer scenario, transaction charges on the sender&apos;s side are to be borne by the debtor; transaction charges on the receiver&apos;s side are to be borne by the creditor.
    /// Encoded/decoded by serializers as &quot;SHA&quot;.
    /// </summary>
    [EnumMember(Value = "SHA")]
    [IsoId("_a8F4Idp-Ed-ak6NoX_4Aeg_-671223087")]
    [Description(@"Under the credit transfer scenario, transaction charges on the sender's side are to be borne by the debtor; transaction charges on the receiver's side are to be borne by the creditor.")]
    Shared = ChargeBearerCode.Shared, // same ordinal as derivation source for type conversions
    
}
