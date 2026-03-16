// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the corporate action proceeds are taxable at issuer level.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iSnDE_ouEeCfbIXrKCjG0g")]
[Description(@"Specifies whether the corporate action proceeds are taxable at issuer level.")]
[Derivations(typeof(IssuerTaxability1Code))]
public enum IssuerTaxabilityCode
{
    /// <summary>
    /// The cash proceeds are taxable.
    /// Encoded/decoded by serializers as &quot;TXBL&quot;.
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_lj-tN_ouEeCfbIXrKCjG0g")]
    [Description(@"The cash proceeds are taxable.")]
    Taxable,
}
