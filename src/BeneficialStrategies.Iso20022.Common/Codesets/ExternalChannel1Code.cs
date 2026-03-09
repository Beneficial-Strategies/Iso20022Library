// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeEG7iEeKo25nLKvGr8w_689018111")]
[Description(@"Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalChannelCode))]
public enum ExternalChannel1Code
{
    /// <summary>
    /// Delivery by courier.
    /// Encoded/decoded by serializers as &quot;COUR&quot;.
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uOZEXvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by courier.")]
    Courier = ExternalChannelCode.Courier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_uOi1UvRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by e-mail.")]
    Email = ExternalChannelCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_uOi1VfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by fax.")]
    Fax = ExternalChannelCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery by messenger.
    /// Encoded/decoded by serializers as &quot;MESS&quot;.
    /// </summary>
    [EnumMember(Value = "MESS")]
    [IsoId("_uOi1WPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by messenger.")]
    Messenger = ExternalChannelCode.Messenger, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery by postal service.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uOi1W_RYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by postal service.")]
    Post = ExternalChannelCode.Post, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delivery by registered mail services.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_uOi1XvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by registered mail services.")]
    RegisteredMail = ExternalChannelCode.RegisteredMail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer via secure e-mail.
    /// Encoded/decoded by serializers as &quot;SEMA&quot;.
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_uOsmUvRYEeuLhpyIdtJzwg")]
    [Description(@"Transfer via secure e-mail.")]
    SecureEmail = ExternalChannelCode.SecureEmail, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by SWIFTNet FileAct.
    /// Encoded/decoded by serializers as &quot;SWFA&quot;.
    /// </summary>
    [EnumMember(Value = "SWFA")]
    [IsoId("_uOsmVfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet FileAct.")]
    SWIFTNetFileAct = ExternalChannelCode.SWIFTNetFileAct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by SWIFTNet InterAct. 
    /// Encoded/decoded by serializers as &quot;SWIA&quot;.
    /// </summary>
    [EnumMember(Value = "SWIA")]
    [IsoId("_uOsmWPRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet InterAct. ")]
    SWIFTNetInterAct = ExternalChannelCode.SWIFTNetInterAct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by SWIFT (FIN).
    /// Encoded/decoded by serializers as &quot;SWMT&quot;.
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("_uOsmW_RYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFT (FIN).")]
    SWIFTMT = ExternalChannelCode.SWIFTMT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by SWIFTNet.
    /// Encoded/decoded by serializers as &quot;SWMX&quot;.
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("_uO1wQvRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet.")]
    SWIFTMX = ExternalChannelCode.SWIFTMX, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by telecommunications service.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uO1wRfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by telecommunications service.")]
    Telecommunication = ExternalChannelCode.Telecommunication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Available via Web upload/download
    /// Encoded/decoded by serializers as &quot;WEBM&quot;.
    /// </summary>
    [EnumMember(Value = "WEBM")]
    [IsoId("_uO_hQvRYEeuLhpyIdtJzwg")]
    [Description(@"Available via Web upload/download")]
    WebUploadDownload = ExternalChannelCode.WebUploadDownload, // same ordinal as derivation source for type conversions
    
}
