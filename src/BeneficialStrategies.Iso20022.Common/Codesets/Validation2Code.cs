// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the validation of a signature used to sign the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G7wjoMmLEeWAGphE2LvqeA")]
[Description(@"Specifies the validation of a signature used to sign the file.")]
[DerivedFrom(typeof(ValidationCode))]
public enum Validation2Code
{
    /// <summary>
    /// Validation of the signature is successful.
    /// Encoded/decoded by serializers as &quot;OKAY&quot;.
    /// </summary>
    [EnumMember(Value = "OKAY")]
    [IsoId("_H_9LkcmLEeWAGphE2LvqeA")]
    [Description(@"Validation of the signature is successful.")]
    ValidationSuccessful = ValidationCode.ValidationSuccessful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Validation of the signature has failed.
    /// Encoded/decoded by serializers as &quot;NTOK&quot;.
    /// </summary>
    [EnumMember(Value = "NTOK")]
    [IsoId("_WPzBscnIEeWI4cSIO9foRA")]
    [Description(@"Validation of the signature has failed.")]
    ValidationFailed = ValidationCode.ValidationFailed, // same ordinal as derivation source for type conversions
    
}
