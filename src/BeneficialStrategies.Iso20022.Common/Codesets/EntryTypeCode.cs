// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the quantity or amount is to be delivered or received.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GwgOMHvEEemW9qhOy0scyg")]
[Description(@"Specifies whether the quantity or amount is to be delivered or received.")]
[Derivations(typeof(CollateralEntryType1Code))]
public enum EntryTypeCode
{
    /// <summary>
    /// Financial Instruments  or amount are to be received in Party A&apos;s account.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_B6l14HvJEemW9qhOy0scyg")]
    [Description(@"Financial Instruments  or amount are to be received in Party A's account.|")]
    Received,
    
    /// <summary>
    /// Financial Instruments or amount are to be delivered out of Party A&apos;s account.
    /// Encoded/decoded by serializers as &quot;DELI&quot;.
    /// </summary>
    [EnumMember(Value = "DELI")]
    [IsoId("_QhB60HvJEemW9qhOy0scyg")]
    [Description(@"Financial Instruments or amount are to be delivered out of Party A's account.|")]
    Delivered,
    
}
