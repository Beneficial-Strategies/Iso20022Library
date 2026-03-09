// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the price of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HqDnMezYEeSBf_ghFpb9rQ")]
[Description(@"Status of the price of a financial instrument.")]
[Derivations(typeof(PriceStatus1Code),typeof(PriceStatus2Code))]
public enum PriceStatusCode
{
    /// <summary>
    /// Price is pending.
    /// Encoded/decoded by serializers as &quot;PNDG&quot;.
    /// </summary>
    [EnumMember(Value = "PNDG")]
    [IsoId("_KRC3kOzYEeSBf_ghFpb9rQ")]
    [Description(@"Price is pending.")]
    Pending,
    
    /// <summary>
    /// No price for transaction (e.g. transfer between accounts).
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_ybLl0I-SEeWtN7rsKJRs8Q")]
    [Description(@"No price for transaction (e.g. transfer between accounts).")]
    NotApplicable,
    
}
