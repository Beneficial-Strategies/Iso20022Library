// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Communication method used for the transmission of documents.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAkIdNp-Ed-ak6NoX_4Aeg_326561043")]
[Description(@"Communication method used for the transmission of documents.")]
[DerivedFrom(typeof(CommunicationMethodCode))]
public enum CommunicationMethod1Code
{
    /// <summary>
    /// Transmission by Swift (FIN).
    /// Encoded/decoded by serializers as &quot;SWMT&quot;.
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("_bAkIddp-Ed-ak6NoX_4Aeg_591608994")]
    [Description(@"Transmission by Swift (FIN).")]
    SWIFTMT = CommunicationMethodCode.SWIFTMT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transmission by SWIFTNET.
    /// Encoded/decoded by serializers as &quot;SWMX&quot;.
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("_bAkIdtp-Ed-ak6NoX_4Aeg_309468232")]
    [Description(@"Transmission by SWIFTNET.")]
    SWIFTMX = CommunicationMethodCode.SWIFTMX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_bAkId9p-Ed-ak6NoX_4Aeg_603616409")]
    [Description(@"Transmission by fax.")]
    Fax = CommunicationMethodCode.Fax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_bAkIeNp-Ed-ak6NoX_4Aeg_617470095")]
    [Description(@"Transmission by e-mail.")]
    Email = CommunicationMethodCode.Email, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transmission by proprietary method.
    /// Encoded/decoded by serializers as &quot;PROP&quot;.
    /// </summary>
    [EnumMember(Value = "PROP")]
    [IsoId("_bAtSYNp-Ed-ak6NoX_4Aeg_631321016")]
    [Description(@"Transmission by proprietary method.")]
    Proprietary = CommunicationMethodCode.Proprietary, // same ordinal as derivation source for type conversions
}
