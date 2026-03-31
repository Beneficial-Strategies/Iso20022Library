// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the offeror for the event is the issuing company or a third party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oYawDL3EeKU9IrkkToqcw_1230885883")]
[Description(
    @"Specifies whether the offeror for the event is the issuing company or a third party."
)]
[Derivations(typeof(OfferorType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OfferorTypeCode>))]
#endif
public enum OfferorTypeCode
{
    /// <summary>
    /// Offeror is the issuing company.
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_1oYawTL3EeKU9IrkkToqcw_-1991997331")]
    [Description(@"Offeror is the issuing company.")]
    Self,

    /// <summary>
    /// Offer is made by the third party.
    /// Encoded/decoded by serializers as &quot;THRD&quot;.
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_1oYawjL3EeKU9IrkkToqcw_-246077871")]
    [Description(@"Offer is made by the third party.")]
    ThirdParty,
}
