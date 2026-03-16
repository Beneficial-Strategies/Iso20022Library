// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of information event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AqQfMCXcEeOFIcNWlDEvdQ")]
[Description(@"Specifies the type of information event.")]
[Derivations(typeof(CorporateActionInformationType1Code))]
public enum CorporateActionInformationTypeCode
{
    /// <summary>
    /// Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_axnpoCXcEeOFIcNWlDEvdQ")]
    [Description(
        @"Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding."
    )]
    ConferenceCall,
}
