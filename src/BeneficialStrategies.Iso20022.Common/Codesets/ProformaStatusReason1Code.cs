// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for proforma status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h2CSkE_vEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for proforma status.")]
[DerivedFrom(typeof(ProformaStatusReasonCode))]
public enum ProformaStatusReason1Code
{
    /// <summary>
    /// Modification to the account data is in process.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_kDXs0U_vEeaB8-OWTiMVrQ")]
    [Description(@"Modification to the account data is in process.")]
    ModificationInProcess = ProformaStatusReasonCode.ModificationInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account opening is waiting for rights holder information.
    /// Encoded/decoded by serializers as &quot;RIGH&quot;.
    /// </summary>
    [EnumMember(Value = "RIGH")]
    [IsoId("_kWRasU_vEeaB8-OWTiMVrQ")]
    [Description(@"Account opening is waiting for rights holder information.")]
    Rights = ProformaStatusReasonCode.Rights, // same ordinal as derivation source for type conversions
}
