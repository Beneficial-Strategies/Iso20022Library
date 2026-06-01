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
[IsoId("_Yx4wtlT_Ee2at7Z9GFZ2Mw")]
[Description(@"Specifies the method used to deliver/retrieve the investigation information.")]
[Derivations(typeof(InvestigationLocationMethod1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<InvestigationLocationMethodCode>))]
public enum InvestigationLocationMethodCode
{
    /// <summary>
    /// Investigation related data must be sent through Electronic Data Interchange (EDI).
    /// Encoded/decoded by serializers as &quot;EDIC&quot;.
    /// </summary>
    [EnumMember(Value = "EDIC")]
    [IsoId("_Yx5Xw1T_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through Electronic Data Interchange (EDI).")]
    ElectronicDataInterchange,

    /// <summary>
    /// Investigation related data must be sent through e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_Yx5XwlT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through e-mail.")]
    EMail,

    /// <summary>
    /// Investigation related data must be faxed.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_Yx5XwFT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be faxed.")]
    Fax,

    /// <summary>
    /// Investigation related data must be sent through postal services.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_Yx5XwVT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through postal services.")]
    Post,

    /// <summary>
    /// Investigation related data must be sent through by phone as a short message service (SMS).
    /// Encoded/decoded by serializers as &quot;SMSM&quot;.
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_Yx5XxFT_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data must be sent through by phone as a short message service (SMS).")]
    SMS,

    /// <summary>
    /// Investigation related data needs to be sent to a Uniform Resource Identifier (URI).
    /// Encoded/decoded by serializers as &quot;URID&quot;.
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_Yx4wt1T_Ee2at7Z9GFZ2Mw")]
    [Description(@"Investigation related data needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI's are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.")]
    UniformResourceIdentifier,
}
