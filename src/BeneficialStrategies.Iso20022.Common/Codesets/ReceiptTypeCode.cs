// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Channel to transmit receipt information to the recipient.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_idBPwErGEeenp6hmNprBHg")]
[Description(@"Channel to transmit receipt information to the recipient.")]
[Derivations(typeof(ReceiptType1Code))]
public enum ReceiptTypeCode
{
    /// <summary>
    /// Receipt in a paper form.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_sr7TwErGEeenp6hmNprBHg")]
    [Description(@"Receipt in a paper form.")]
    Paper,
    
    /// <summary>
    /// Receipt transmitted by SMS message.
    /// Encoded/decoded by serializers as &quot;SMSM&quot;.
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_wbQsQErGEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by SMS message.")]
    SMS,
    
    /// <summary>
    /// Receipt transmitted by Email.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_37duUErGEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted by Email.")]
    EMail,
    
    /// <summary>
    /// Receipt transmitted to a Uniform Resource Identifier (URI) address.
    /// Encoded/decoded by serializers as &quot;URID&quot;.
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_9_lz8ErGEeenp6hmNprBHg")]
    [Description(@"Receipt transmitted to a Uniform Resource Identifier (URI) address.")]
    UniformResourceIdentifier,
    
    /// <summary>
    /// Other type of channel to transmit receipt information to the recipient.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_FPkosErHEeenp6hmNprBHg")]
    [Description(@"Other type of channel to transmit receipt information to the recipient.")]
    Other,
    
}
