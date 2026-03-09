// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Rule to apply for the presence and the value of a message item.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KS412H1DEeCF8NjrBemJWQ_-2004435660")]
[Description(@"Rule to apply for the presence and the value of a message item.")]
[Derivations(typeof(MessageItemCondition1Code),typeof(MessageItemCondition2Code))]
public enum MessageItemConditionCode
{
    /// <summary>
    /// Message item must be present.
    /// Encoded/decoded by serializers as &quot;MNDT&quot;.
    /// </summary>
    [EnumMember(Value = "MNDT")]
    [IsoId("_KTB_wH1DEeCF8NjrBemJWQ_763935229")]
    [Description(@"Message item must be present.")]
    Mandatory,
    
    /// <summary>
    /// Message item must be present with the configured value.
    /// Encoded/decoded by serializers as &quot;CFVL&quot;.
    /// </summary>
    [EnumMember(Value = "CFVL")]
    [IsoId("_KTB_wX1DEeCF8NjrBemJWQ_-233137124")]
    [Description(@"Message item must be present with the configured value.")]
    ConfiguredValue,
    
    /// <summary>
    /// Message item has the configured value if the item is absent.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_KTB_wn1DEeCF8NjrBemJWQ_650096163")]
    [Description(@"Message item has the configured value if the item is absent.")]
    DefaultValue,
    
    /// <summary>
    /// Message item must have one of the configured values.
    /// Encoded/decoded by serializers as &quot;ALWV&quot;.
    /// </summary>
    [EnumMember(Value = "ALWV")]
    [IsoId("_KTB_w31DEeCF8NjrBemJWQ_828214835")]
    [Description(@"Message item must have one of the configured values.")]
    AllowedValues,
    
    /// <summary>
    /// Message item has to be present if available.
    /// Encoded/decoded by serializers as &quot;IFAV&quot;.
    /// </summary>
    [EnumMember(Value = "IFAV")]
    [IsoId("_KTB_xH1DEeCF8NjrBemJWQ_942053901")]
    [Description(@"Message item has to be present if available.")]
    IfAvailable,
    
    /// <summary>
    /// Message item is present if it was present in a previous related message with the same value.
    /// Encoded/decoded by serializers as &quot;COPY&quot;.
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_KTB_xX1DEeCF8NjrBemJWQ_-346976190")]
    [Description(@"Message item is present if it was present in a previous related message with the same value.")]
    Copy,
    
    /// <summary>
    /// Message item is not supported and has to be absent.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_KTB_xn1DEeCF8NjrBemJWQ_-55018452")]
    [Description(@"Message item is not supported and has to be absent.")]
    NotSupported,
    
    /// <summary>
    /// Minimum set of values to use in messages.
    /// Encoded/decoded by serializers as &quot;LMNV&quot;.
    /// </summary>
    [EnumMember(Value = "LMNV")]
    [IsoId("_w73-sHC6Ee2bmOA3bkVsMg")]
    [Description(@"Minimum set of values to use in messages.")]
    ListMinimumValues,
    
}
