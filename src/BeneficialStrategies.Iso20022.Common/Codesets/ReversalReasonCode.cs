// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason of the payment or loyalty reversal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sK0tANuGEeiB5uLfkg9ZJA")]
[Description(@"Reason of the payment or loyalty reversal.")]
[Derivations(typeof(ReversalReason1Code))]
public enum ReversalReasonCode
{
    /// <summary>
    /// Customer cancels the transaction.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_vzKFoNuGEeiB5uLfkg9ZJA")]
    [Description(@"Customer cancels the transaction.")]
    CustomerCancellation,

    /// <summary>
    /// Merchant or Cashier cancels the transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_zyg3INuGEeiB5uLfkg9ZJA")]
    [Description(@"Merchant or Cashier cancels the transaction.")]
    MerchantCancellation,

    /// <summary>
    /// Reversal after a suspection of malfunction of the POI system.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_4ypwMNuGEeiB5uLfkg9ZJA")]
    [Description(@"Reversal after a suspection of malfunction of the POI system.")]
    Malfuntion,

    /// <summary>
    /// POI System unable to complete transaction.
    /// Encoded/decoded by serializers as &quot;UNAB&quot;.
    /// </summary>
    [EnumMember(Value = "UNAB")]
    [IsoId("_-J-aMNuGEeiB5uLfkg9ZJA")]
    [Description(@"POI System unable to complete transaction.")]
    UnableToComplete,
}
