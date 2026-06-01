// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation status, as published in an external investigation status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w8jnQFEVEe2YkcF60skG_A")]
[Description(
    @"Specifies the investigation status, as published in an external investigation status code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationStatus1Code>))]
public enum ExternalInvestigationStatus1Code
{
    /// <summary>
    /// Investigation is closed.
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("___asy9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is closed.")]
    InvestigationClosed = ExternalInvestigationStatusCode.InvestigationClosed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is opened/pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("___aszdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is opened/pending.")]
    InvestigationPending = ExternalInvestigationStatusCode.InvestigationPending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("___asz9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is rejected.")]
    InvestigationRejected = ExternalInvestigationStatusCode.InvestigationRejected, // same ordinal as derivation source for type conversions
}
