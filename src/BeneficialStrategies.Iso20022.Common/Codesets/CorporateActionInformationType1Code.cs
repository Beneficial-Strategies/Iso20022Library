// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of information event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ioVuQCXcEeOFIcNWlDEvdQ")]
[Description(@"Specifies the type of information event.")]
[DerivedFrom(typeof(CorporateActionInformationTypeCode))]
public enum CorporateActionInformationType1Code
{
    /// <summary>
    /// Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_qcrNQSXcEeOFIcNWlDEvdQ")]
    [Description(
        @"Information is about an informal call when an issuer, trustee, agent wishes to talk to note holders to discuss a certain issue or potential change to the notes; nothing said being binding."
    )]
    ConferenceCall = CorporateActionInformationTypeCode.ConferenceCall, // same ordinal as derivation source for type conversions
}
