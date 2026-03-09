// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-51rIGBlEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for an accepted status.")]
[Derivations(typeof(AcceptedStatusReason1Code))]
public enum AcceptedStatusReasonCode
{
    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_2GWm0GBmEeaR1OOiVxm3Gg")]
    [Description(@"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code.")]
    SectorNotAllowed,
    
    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_DsPNsGBnEeaR1OOiVxm3Gg")]
    [Description(@"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place.")]
    PlaceNotAllowed,
    
}
