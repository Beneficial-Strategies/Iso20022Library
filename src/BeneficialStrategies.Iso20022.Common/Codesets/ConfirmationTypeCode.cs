// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqbxQdp-Ed-ak6NoX_4Aeg_-1345554396")]
[Description(@"Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.")]
[Derivations(typeof(ConfirmationType1Code))]
public enum ConfirmationTypeCode
{
    /// <summary>
    /// Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_VqbxQtp-Ed-ak6NoX_4Aeg_-1318772467")]
    [Description(@"Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.")]
    Intent,
    
    /// <summary>
    /// Specifies that the message is an actual confirmation of the execution of a transfer request.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_VqbxQ9p-Ed-ak6NoX_4Aeg_887847604")]
    [Description(@"Specifies that the message is an actual confirmation of the execution of a transfer request.")]
    Actual,
    
}
