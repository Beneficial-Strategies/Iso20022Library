// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason of the payment or loyalty reversal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DBKyoNuHEeiB5uLfkg9ZJA")]
[Description(@"Reason of the payment or loyalty reversal.")]
[DerivedFrom(typeof(ReversalReasonCode))]
public enum ReversalReason1Code
{
    /// <summary>
    /// Customer cancels the transaction.
    /// Encoded/decoded by serializers as &quot;CUSC&quot;.
    /// </summary>
    [EnumMember(Value = "CUSC")]
    [IsoId("_FHV08duHEeiB5uLfkg9ZJA")]
    [Description(@"Customer cancels the transaction.")]
    CustomerCancellation = ReversalReasonCode.CustomerCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal after a suspection of malfunction of the POI system.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_FMy8sduHEeiB5uLfkg9ZJA")]
    [Description(@"Reversal after a suspection of malfunction of the POI system.")]
    Malfuntion = ReversalReasonCode.Malfuntion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant or Cashier cancels the transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_FQaRYduHEeiB5uLfkg9ZJA")]
    [Description(@"Merchant or Cashier cancels the transaction.")]
    MerchantCancellation = ReversalReasonCode.MerchantCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// POI System unable to complete transaction.
    /// Encoded/decoded by serializers as &quot;UNAB&quot;.
    /// </summary>
    [EnumMember(Value = "UNAB")]
    [IsoId("_FWSP4duHEeiB5uLfkg9ZJA")]
    [Description(@"POI System unable to complete transaction.")]
    UnableToComplete = ReversalReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions
}
