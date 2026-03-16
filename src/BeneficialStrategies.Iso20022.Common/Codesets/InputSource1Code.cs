// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the input source for the generation of the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m9EHgMmMEeWAGphE2LvqeA")]
[Description(@"Specifies the input source for the generation of the file.")]
[DerivedFrom(typeof(InputSourceCode))]
public enum InputSource1Code
{
    /// <summary>
    /// File has been encoded.
    /// Encoded/decoded by serializers as &quot;NCOD&quot;.
    /// </summary>
    [EnumMember(Value = "NCOD")]
    [IsoId("_uWkrscmMEeWAGphE2LvqeA")]
    [Description(@"File has been encoded.")]
    Encoded = InputSourceCode.Encoded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File has been uploaded manually.
    /// Encoded/decoded by serializers as &quot;UMNL&quot;.
    /// </summary>
    [EnumMember(Value = "UMNL")]
    [IsoId("_uiBGssmMEeWAGphE2LvqeA")]
    [Description(@"File has been uploaded manually.")]
    UploadedManually = InputSourceCode.UploadedManually, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File has been uploaded through the CIS (Customer Identification System) system.
    /// Encoded/decoded by serializers as &quot;UCIS&quot;.
    /// </summary>
    [EnumMember(Value = "UCIS")]
    [IsoId("_utUXwsmMEeWAGphE2LvqeA")]
    [Description(
        @"File has been uploaded through the CIS (Customer Identification System) system."
    )]
    UploadedViaCIS = InputSourceCode.UploadedViaCIS, // same ordinal as derivation source for type conversions
}
