// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of clearing payment or related transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NFZZYFBBEeedyPuM0kK2EQ")]
[Description(@"Party in charge of clearing payment or related transactions.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType23Code
{
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_TverwVBBEeedyPuM0kK2EQ")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_UI7GglBBEeedyPuM0kK2EQ")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in charge of clearing payment or related transactions.
    /// Encoded/decoded by serializers as &quot;CLRA&quot;.
    /// </summary>
    [EnumMember(Value = "CLRA")]
    [IsoId("_VLk2UlBBEeedyPuM0kK2EQ")]
    [Description(@"Agent in charge of clearing payment or related transactions.")]
    ClearingAgent = PartyTypeCode.ClearingAgent, // same ordinal as derivation source for type conversions
    
}
