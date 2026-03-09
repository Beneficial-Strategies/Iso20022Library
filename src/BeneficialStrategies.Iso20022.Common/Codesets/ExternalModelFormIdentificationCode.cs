// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeFW7iEeKo25nLKvGr8w_769706628")]
[Description(@"Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalModelFormIdentification1Code))]
public enum ExternalModelFormIdentificationCode
{
    /// <summary>
    /// ISP98 model form for standby incorporating annexed form of payment demand with statement.
    /// Encoded/decoded by serializers as &quot;ISP1&quot;.
    /// </summary>
    [EnumMember(Value = "ISP1")]
    [IsoId("_uPScM_RYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for standby incorporating annexed form of payment demand with statement.")]
    ISP98ModelForm1,
    
    /// <summary>
    /// ISP98 model form or standby providing for extension and incorporating annexed form of payment demand with alternative non-extension statement.
    /// Encoded/decoded by serializers as &quot;ISP2&quot;.
    /// </summary>
    [EnumMember(Value = "ISP2")]
    [IsoId("_uPScNvRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form or standby providing for extension and incorporating annexed form of payment demand with alternative non-extension statement.")]
    ISP98ModelForm2,
    
    /// <summary>
    /// ISP98 model form or standby providing for reduction and incorporating annexed form of reduction demand. 
    /// Encoded/decoded by serializers as &quot;ISP3&quot;.
    /// </summary>
    [EnumMember(Value = "ISP3")]
    [IsoId("_uPbmIPRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form or standby providing for reduction and incorporating annexed form of reduction demand. ")]
    ISP98ModelForm3,
    
    /// <summary>
    /// ISP98 model form for standby providing for transfer and incorporating annexed form of transfer demand.
    /// Encoded/decoded by serializers as &quot;ISP4&quot;.
    /// </summary>
    [EnumMember(Value = "ISP4")]
    [IsoId("_uPbmI_RYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for standby providing for transfer and incorporating annexed form of transfer demand.")]
    ISP98ModelForm4,
    
    /// <summary>
    /// ISP98 model form for simplified demand only standby.
    /// Encoded/decoded by serializers as &quot;ISP5&quot;.
    /// </summary>
    [EnumMember(Value = "ISP5")]
    [IsoId("_uPbmJvRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for simplified demand only standby.")]
    ISP98ModelForm5,
    
    /// <summary>
    /// ISP98 model form for counter standby with annexed form of local bank undertaking.
    /// Encoded/decoded by serializers as &quot;ISP6&quot;.
    /// </summary>
    [EnumMember(Value = "ISP6")]
    [IsoId("_uPbmKfRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for counter standby with annexed form of local bank undertaking.")]
    ISP98ModelForm6,
    
    /// <summary>
    /// ISP98 model form for standby requiring confirmation.
    /// Encoded/decoded by serializers as &quot;ISP7&quot;.
    /// </summary>
    [EnumMember(Value = "ISP7")]
    [IsoId("_uPlXIPRYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for standby requiring confirmation.")]
    ISP98ModelForm7,
    
    /// <summary>
    /// ISP98 model form for confirmation of standby.
    /// Encoded/decoded by serializers as &quot;ISP8&quot;.
    /// </summary>
    [EnumMember(Value = "ISP8")]
    [IsoId("_uPlXI_RYEeuLhpyIdtJzwg")]
    [Description(@"ISP98 model form for confirmation of standby.")]
    ISP98ModelForm8,
    
    /// <summary>
    /// Model form for demand guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).
    /// Encoded/decoded by serializers as &quot;UDG1&quot;.
    /// </summary>
    [EnumMember(Value = "UDG1")]
    [IsoId("_uPlXJvRYEeuLhpyIdtJzwg")]
    [Description(@"Model form for demand guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).")]
    URDGDemandGuarantee,
    
    /// <summary>
    /// Model form for counter-guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).
    /// Encoded/decoded by serializers as &quot;UDG2&quot;.
    /// </summary>
    [EnumMember(Value = "UDG2")]
    [IsoId("_uPvIIPRYEeuLhpyIdtJzwg")]
    [Description(@"Model form for counter-guarantee defined in the latest version of the ICC Uniform Rules For Demand Guarantees (URDG).")]
    URDGCounterGuarantee,
    
}
