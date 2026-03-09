// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a communication method used for the transmission of documents.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0sTXUNL6EeSDLevdaFPXHw")]
[Description(@"Specifies a communication method used for the transmission of documents.")]
[DerivedFrom(typeof(CommunicationMethodCode))]
public enum CommunicationMethod4Code
{
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_-_hTkdL6EeSDLevdaFPXHw")]
    [Description(@"Transmission by e-mail.")]
    Email = CommunicationMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("__HQTQ9L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by fax.")]
    Fax = CommunicationMethodCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by file transfer.
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("__QCb09L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by file transfer.")]
    File = CommunicationMethodCode.File, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission on line, for example, in a web portal.
    /// Encoded/decoded by serializers as &quot;ONLI&quot;.
    /// </summary>
    [EnumMember(Value = "ONLI")]
    [IsoId("__XK-k9L6EeSDLevdaFPXHw")]
    [Description(@"Transmission on line, for example, in a web portal.")]
    Online = CommunicationMethodCode.Online, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by telephone.
    /// Encoded/decoded by serializers as &quot;PHON&quot;.
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("__ed5Y9L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by telephone.")]
    Phone = CommunicationMethodCode.Phone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by postal service.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("__lAmQ9L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by postal service.")]
    PostalService = CommunicationMethodCode.PostalService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by proprietary method.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("__r__E9L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by proprietary method.")]
    Proprietary = CommunicationMethodCode.Proprietary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by Swift (FIN).
    /// Encoded/decoded by serializers as &quot;SWMT&quot;.
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("__y2N89L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by Swift (FIN).")]
    SWIFTMT = CommunicationMethodCode.SWIFTMT, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by SWIFTNET.
    /// Encoded/decoded by serializers as &quot;SWMX&quot;.
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("__5ir09L6EeSDLevdaFPXHw")]
    [Description(@"Transmission by SWIFTNET.")]
    SWIFTMX = CommunicationMethodCode.SWIFTMX, // same ordinal as derivation source for type conversions
    
}
