// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains list of plan owners
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NrX48RUUEfC_aaedwHHlmw")]
[Description(@"Contains list of plan owners")]
[DerivedFrom(typeof(PlanOwnerCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PlanOwner2Code>))]
public enum PlanOwner2Code
{
    /// <summary>
    /// Plan owner is an acceptor.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_NycxURUUEfC_aaedwHHlmw")]
    [Description(@"Plan owner is an acceptor.")]
    Acceptor = PlanOwnerCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan owner is an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_NycxUxUUEfC_aaedwHHlmw")]
    [Description(@"Plan owner is an acquirer.")]
    Acquirer = PlanOwnerCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan owner is an issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_NycxVRUUEfC_aaedwHHlmw")]
    [Description(@"Plan owner is an issuer.")]
    Issuer = PlanOwnerCode.Issuer, // same ordinal as derivation source for type conversions
}
