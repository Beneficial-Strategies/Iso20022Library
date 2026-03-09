// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a physical form is required.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VsEwAdp-Ed-ak6NoX_4Aeg_-1720487337")]
[Description(@"Specifies whether a physical form is required.")]
[Derivations(typeof(Form1Code))]
public enum FormCode
{
    /// <summary>
    /// A phsyical form is required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;REQU&quot;.
    /// </summary>
    [EnumMember(Value = "REQU")]
    [IsoId("_VsEwAtp-Ed-ak6NoX_4Aeg_-1436042438")]
    [Description(@"A phsyical form is required through the main fund order desk.")]
    Required,
    
    /// <summary>
    /// A phsyical form is not required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;NREQ&quot;.
    /// </summary>
    [EnumMember(Value = "NREQ")]
    [IsoId("_VsEwA9p-Ed-ak6NoX_4Aeg_-1431426395")]
    [Description(@"A phsyical form is not required through the main fund order desk.")]
    NotRequired,
    
    /// <summary>
    /// A phsyical form with the investor&apos;s written signature is required through the main fund order desk.
    /// Encoded/decoded by serializers as &quot;SREQ&quot;.
    /// </summary>
    [EnumMember(Value = "SREQ")]
    [IsoId("_VsEwBNp-Ed-ak6NoX_4Aeg_-1416648096")]
    [Description(@"A phsyical form with the investor's written signature is required through the main fund order desk.")]
    SignatureRequired,
    
}
