// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the offeror for the event is the issuing company or a third party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pa8lTL3EeKU9IrkkToqcw_1480504854")]
[Description(@"Specifies whether the offeror for the event is the issuing company or a third party.")]
[DerivedFrom(typeof(OfferorTypeCode))]
public enum OfferorType1Code
{
    /// <summary>
    /// Offeror is the issuing company.
    /// Encoded/decoded by serializers as &quot;SELF&quot;.
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_1pa8ljL3EeKU9IrkkToqcw_2101612018")]
    [Description(@"Offeror is the issuing company.")]
    Self = OfferorTypeCode.Self, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offer is made by the third party.
    /// Encoded/decoded by serializers as &quot;THRD&quot;.
    /// </summary>
    [EnumMember(Value = "THRD")]
    [IsoId("_1pktkDL3EeKU9IrkkToqcw_1987772952")]
    [Description(@"Offer is made by the third party.")]
    ThirdParty = OfferorTypeCode.ThirdParty, // same ordinal as derivation source for type conversions
    
}
