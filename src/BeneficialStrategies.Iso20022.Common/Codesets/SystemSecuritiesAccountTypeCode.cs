// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lists the type of the securities account specific for a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hjeiUmliEeGaMcKyqKNRfQ_-1442503299")]
[Description(@"Lists the type of the securities account specific for a system.")]
[Derivations(typeof(SystemSecuritiesAccountType1Code))]
public enum SystemSecuritiesAccountTypeCode
{
    /// <summary>
    /// Account owned by a CSD Participant|.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_hjeiU2liEeGaMcKyqKNRfQ_1872191376")]
    [Description(@"Account owned by a CSD Participant|.")]
    CSDParticipantAccount,
    
    /// <summary>
    /// Account operated by CSD for mirroring positions|.
    /// Encoded/decoded by serializers as &quot;CSDM&quot;.
    /// </summary>
    [EnumMember(Value = "CSDM")]
    [IsoId("_hjeiVGliEeGaMcKyqKNRfQ_1890782340")]
    [Description(@"Account operated by CSD for mirroring positions|.")]
    CSDMirrorAccount,
    
    /// <summary>
    /// Account operated by CSD for settlement of securities legs for instructions involving internal CSD s.
    /// Encoded/decoded by serializers as &quot;ICSA&quot;.
    /// </summary>
    [EnumMember(Value = "ICSA")]
    [IsoId("_hjeiVWliEeGaMcKyqKNRfQ_1290945656")]
    [Description(@"Account operated by CSD for settlement of securities legs for instructions involving internal CSD s.")]
    InterCSDAccount,
    
    /// <summary>
    /// Account operated by CSDs in a direct holding market context.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_hjeiVmliEeGaMcKyqKNRfQ_1254906660")]
    [Description(@"Account operated by CSDs in a direct holding market context.")]
    TechnicalOffsetAccount,
    
    /// <summary>
    /// Account operated by CSD in cross-CSD settlement context.
    /// Encoded/decoded by serializers as &quot;CSDO&quot;.
    /// </summary>
    [EnumMember(Value = "CSDO")]
    [IsoId("_hjeiV2liEeGaMcKyqKNRfQ_1755887588")]
    [Description(@"Account operated by CSD in cross-CSD settlement context.")]
    CSDOmnibusAccount,
    
    /// <summary>
    /// Account reflecting the holdings of the participants of the issuer CSD for a given financial instrument.
    /// Encoded/decoded by serializers as &quot;ISSA&quot;.
    /// </summary>
    [EnumMember(Value = "ISSA")]
    [IsoId("_hjeiWGliEeGaMcKyqKNRfQ_2050946548")]
    [Description(@"Account reflecting the holdings of the participants of the issuer CSD for a given financial instrument.")]
    IssuanceAccount,
    
}
