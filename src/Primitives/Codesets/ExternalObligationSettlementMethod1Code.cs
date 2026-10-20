// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the settlement method for the obligation.
///
///
/// The list of valid codes is an external code list published separately.
///
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vyt3YIQSEfCu2585jRNU3Q")]
[Description(
    @"Specifies the settlement method for the obligation.|||The list of valid codes is an external code list published separately. ||External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalObligationSettlementMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalObligationSettlementMethod1Code>))]
public enum ExternalObligationSettlementMethod1Code
{
    /// <summary>
    /// Settled bilaterally.
    /// Encoded/decoded by serializers as &quot;BILA&quot;.
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_3aI7wYQSEfCu2585jRNU3Q")]
    [Description(@"Settled bilaterally.")]
    Bilateral = ExternalObligationSettlementMethodCode.Bilateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settled multilaterally.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_bHESQoQTEfCu2585jRNU3Q")]
    [Description(@"Settled multilaterally.")]
    Multilateral = ExternalObligationSettlementMethodCode.Multilateral, // same ordinal as derivation source for type conversions
}
