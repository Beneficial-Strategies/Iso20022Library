// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for proforma status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3uoL8E_uEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for proforma status.")]
[Derivations(typeof(ProformaStatusReason1Code))]
public enum ProformaStatusReasonCode
{
    /// <summary>
    /// Account opening is waiting for rights holder information.
    /// Encoded/decoded by serializers as &quot;RIGH&quot;.
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_XJWtcE_vEeaB8-OWTiMVrQ")]
    [Description(@"Account opening is waiting for rights holder information.")]
    Rights,

    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_aKBpIE_vEeaB8-OWTiMVrQ")]
    [Description(@"Modification to the account data is in process.")]
    ModificationInProcess,
}
