// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether there is cash in the account that is awaiting investment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9onxIPpeEeCLMa5EIHtDrg")]
[Description(@"Specifies whether there is cash in the account that is awaiting investment.")]
[DerivedFrom(typeof(ResidualCashCode))]
public enum ResidualCash1Code
{
    /// <summary>
    /// Residual Cash not to be transferred.
    /// Encoded/decoded by serializers as &quot;NRCT&quot;.
    /// </summary>
    [EnumMember(Value = "NRCT")]
    [IsoId("_WcfODv8uEeC87tbx-VXRVA")]
    [Description(@"Residual Cash not to be transferred.")]
    NotResidualCashTransfer = ResidualCashCode.NotResidualCashTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Residual cash to be transferred.
    /// Encoded/decoded by serializers as &quot;RCTR&quot;.
    /// </summary>
    [EnumMember(Value = "RCTR")]
    [IsoId("_WgN3fv8uEeC87tbx-VXRVA")]
    [Description(@"Residual cash to be transferred.")]
    ResidualCashTransfer = ResidualCashCode.ResidualCashTransfer, // same ordinal as derivation source for type conversions
}
