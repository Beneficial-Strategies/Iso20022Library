// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Communication method used for the transmission of documents.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gcdCsA1fEeKGXqvMN6jpiw")]
[Description(@"Communication method used for the transmission of documents.")]
[DerivedFrom(typeof(CommunicationMethodCode))]
public enum CommunicationMethod2Code
{
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_mPNrgQ1fEeKGXqvMN6jpiw")]
    [Description(@"Transmission by e-mail.")]
    Email = CommunicationMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_mk0vIQ1fEeKGXqvMN6jpiw")]
    [Description(@"Transmission by fax.")]
    Fax = CommunicationMethodCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by file transfer.
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_myYqAQ1fEeKGXqvMN6jpiw")]
    [Description(@"Transmission by file transfer.")]
    File = CommunicationMethodCode.File, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission on line, for example, in a web portal.
    /// Encoded/decoded by serializers as &quot;ONLI&quot;.
    /// </summary>
    [EnumMember(Value = "ONLI")]
    [IsoId("_nNM9wQ1fEeKGXqvMN6jpiw")]
    [Description(@"Transmission on line, for example, in a web portal.")]
    Online = CommunicationMethodCode.Online, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by postal service.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_jEZ6YUp-EeKw5sECfP82rg")]
    [Description(@"Transmission by postal service.")]
    PostalService = CommunicationMethodCode.PostalService, // same ordinal as derivation source for type conversions
    
}
