// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VirjeNp-Ed-ak6NoX_4Aeg_1065163158")]
[Description(@"Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.")]
[DerivedFrom(typeof(ConfirmationTypeCode))]
public enum ConfirmationType1Code
{
    /// <summary>
    /// Specifies that the message is an actual confirmation of the execution of a transfer request.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_Vi1UcNp-Ed-ak6NoX_4Aeg_1120574018")]
    [Description(@"Specifies that the message is an actual confirmation of the execution of a transfer request.")]
    Actual = ConfirmationTypeCode.Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_Vi1Ucdp-Ed-ak6NoX_4Aeg_1120574036")]
    [Description(@"Specifies that the confirmation is an intention to execute a transfer instruction for the listed assets.")]
    Intent = ConfirmationTypeCode.Intent, // same ordinal as derivation source for type conversions
    
}
