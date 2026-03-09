// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card writing capabilities of the terminal performing the transaction. 
/// It correspond to the ISO 8583, field number 22-10 for the version 93, and 27-8_9 for the version 2003.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GvpZEHr4EeSZrs_hiwNOWA")]
[Description(@"Card writing capabilities of the terminal performing the transaction. |It correspond to the ISO 8583, field number 22-10 for the version 93, and 27-8_9 for the version 2003.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading3Code
{
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as &quot;CDFL&quot;.
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_Sd-ocXr4EeSZrs_hiwNOWA")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as &quot;ECTL&quot;.
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_Slb7UXr4EeSZrs_hiwNOWA")]
    [Description(@"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).")]
    EMVProximityReader = CardDataReadingCode.EMVProximityReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as &quot;CICC&quot;.
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_SxD8gXr4EeSZrs_hiwNOWA")]
    [Description(@"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.")]
    ICC = CardDataReadingCode.ICC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as &quot;MGST&quot;.
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_Thq6EXr4EeSZrs_hiwNOWA")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as &quot;CTLS&quot;.
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_T1l7oXr4EeSZrs_hiwNOWA")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader = CardDataReadingCode.ProximityReader, // same ordinal as derivation source for type conversions
    
}
