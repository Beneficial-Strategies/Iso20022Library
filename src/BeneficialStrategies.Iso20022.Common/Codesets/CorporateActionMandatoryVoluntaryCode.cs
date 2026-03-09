// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the event is mandatory, mandatory with options or voluntary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bKsU1dp-Ed-ak6NoX_4Aeg_735779459")]
[Description(@"Specifies whether the event is mandatory, mandatory with options or voluntary.")]
[Derivations(typeof(CorporateActionMandatoryVoluntary1Code))]
public enum CorporateActionMandatoryVoluntaryCode
{
    /// <summary>
    /// Participation in CA event is mandatory. Further instructions from the account owner are not required.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_bKsU1tp-Ed-ak6NoX_4Aeg_823512957")]
    [Description(@"Participation in CA event is mandatory. Further instructions from the account owner are not required.")]
    Mandatory,
    
    /// <summary>
    /// Participation in the corporate action is mandatory and further instructions from the account owner are required, unless a default option has been specified.
    /// Encoded/decoded by serializers as &quot;CHOS&quot;.
    /// </summary>
    [EnumMember(Value = "CHOS")]
    [IsoId("_bKsU19p-Ed-ak6NoX_4Aeg_840137840")]
    [Description(@"Participation in the corporate action is mandatory and further instructions from the account owner are required, unless a default option has been specified.")]
    MandatoryWithOptions,
    
    /// <summary>
    /// Participation in the corporate action is voluntary. If the owner wishes to take part in the event, instructions from the account owner are required.
    /// Encoded/decoded by serializers as &quot;VOLU&quot;.
    /// </summary>
    [EnumMember(Value = "VOLU")]
    [IsoId("_bKsU2Np-Ed-ak6NoX_4Aeg_863226393")]
    [Description(@"Participation in the corporate action is voluntary. If the owner wishes to take part in the event, instructions from the account owner are required.")]
    Voluntary,
    
}
