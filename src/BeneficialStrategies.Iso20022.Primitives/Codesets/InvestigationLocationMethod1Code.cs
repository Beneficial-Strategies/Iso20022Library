// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to deliver/retrieve the investigation information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qpxYQFT_Ee2at7Z9GFZ2Mw")]
[Description(@"Specifies the method used to deliver/retrieve the investigation information.")]
[DerivedFrom(typeof(InvestigationLocationMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InvestigationLocationMethod1Code>))]
public enum InvestigationLocationMethod1Code
{
    /// <summary>
    /// Investigation related data must be sent through Electronic Data Interchange (EDI).
    /// Encoded/decoded by serializers as &quot;EDIC&quot;.
    /// </summary>
    [EnumMember(Value = "EDIC")]
    [IsoId("_sKNQQVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through Electronic Data Interchange (EDI).")]
    ElectronicDataInterchange = InvestigationLocationMethodCode.ElectronicDataInterchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation related data must be sent through e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_sRSIoVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through e-mail.")]
    EMail = InvestigationLocationMethodCode.EMail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation related data must be faxed.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_sXI5AVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be faxed.")]
    Fax = InvestigationLocationMethodCode.Fax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation related data must be sent through postal services.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_scR3sVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through postal services.")]
    Post = InvestigationLocationMethodCode.Post, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation related data must be sent through by phone as a short message service (SMS).
    /// Encoded/decoded by serializers as &quot;SMSM&quot;.
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_shYaIVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through by phone as a short message service (SMS).")]
    SMS = InvestigationLocationMethodCode.SMS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation related data needs to be sent to a Uniform Resource Identifier (URI).
    /// Encoded/decoded by serializers as &quot;URID&quot;.
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_snTb8VT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI's are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.")]
    UniformResourceIdentifier = InvestigationLocationMethodCode.UniformResourceIdentifier, // same ordinal as derivation source for type conversions
}
