// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of official document used for identification or authentication.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4YsNAHhREee6_vnrijrKgg")]
[Description(@"Type of official document used for identification or authentication.")]
[DerivedFrom(typeof(OfficialDocumentTypeCode))]
public enum OfficialDocumentType1Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_AFCNoXhSEee6_vnrijrKgg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistration = OfficialDocumentTypeCode.AlienRegistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Travel authorisation assigned by a government agency (e.g. ESTA, etc.)
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_AQG1MXhSEee6_vnrijrKgg")]
    [Description(@"Travel authorisation assigned by a government agency (e.g. ESTA, etc.)")]
    Authorisation = OfficialDocumentTypeCode.Authorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Diplomatic passport or travel document.
    /// Encoded/decoded by serializers as &quot;DIPL&quot;.
    /// </summary>
    [EnumMember(Value = "DIPL")]
    [IsoId("_Ac2QsXhSEee6_vnrijrKgg")]
    [Description(@"Diplomatic passport or travel document.")]
    Diplomatic = OfficialDocumentTypeCode.Diplomatic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Driving license.
    /// Encoded/decoded by serializers as &quot;DVLC&quot;.
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_AoA-4XhSEee6_vnrijrKgg")]
    [Description(@"Driving license.")]
    DrivingLicense = OfficialDocumentTypeCode.DrivingLicense, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Europol-issued travel or related document.
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_A2ZZIXhSEee6_vnrijrKgg")]
    [Description(@"Europol-issued travel or related document.")]
    Europol = OfficialDocumentTypeCode.Europol, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identity card.
    /// Encoded/decoded by serializers as &quot;IDEN&quot;.
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_BC7ZQXhSEee6_vnrijrKgg")]
    [Description(@"Identity card.")]
    IdentityCard = OfficialDocumentTypeCode.IdentityCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Internal travel document.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_BOUJ4XhSEee6_vnrijrKgg")]
    [Description(@"Internal travel document.")]
    Internal = OfficialDocumentTypeCode.Internal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interpol-issued travel or related document 
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_BZ3SkXhSEee6_vnrijrKgg")]
    [Description(@"Interpol-issued travel or related document ")]
    Interpol = OfficialDocumentTypeCode.Interpol, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Emergency travel or related document.
    /// Encoded/decoded by serializers as &quot;LZPR&quot;.
    /// </summary>
    [EnumMember(Value = "LZPR")]
    [IsoId("_Bmbu8XhSEee6_vnrijrKgg")]
    [Description(@"Emergency travel or related document.")]
    Laissezpasser = OfficialDocumentTypeCode.Laissezpasser, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of official document defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_CPItsXhSEee6_vnrijrKgg")]
    [Description(@"Other type of official document defined at national level.")]
    OtherNational = OfficialDocumentTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of official document defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_CdkyUXhSEee6_vnrijrKgg")]
    [Description(@"Other type of official document defined at private level.")]
    OtherPrivate = OfficialDocumentTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_Cvr2AXhSEee6_vnrijrKgg")]
    [Description(@"Passport.")]
    Passport = OfficialDocumentTypeCode.Passport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Visa issued by a government or related authority.
    /// Encoded/decoded by serializers as &quot;VISA&quot;.
    /// </summary>
    [EnumMember(Value = "VISA")]
    [IsoId("_C96fQXhSEee6_vnrijrKgg")]
    [Description(@"Visa issued by a government or related authority.")]
    PassportVisa = OfficialDocumentTypeCode.PassportVisa, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Permit.
    /// Encoded/decoded by serializers as &quot;PERM&quot;.
    /// </summary>
    [EnumMember(Value = "PERM")]
    [IsoId("_DNYeoXhSEee6_vnrijrKgg")]
    [Description(@"Permit.")]
    Permit = OfficialDocumentTypeCode.Permit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Travel or related document issued to refugees.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_D9yn4XhSEee6_vnrijrKgg")]
    [Description(@"Travel or related document issued to refugees.")]
    Refugee = OfficialDocumentTypeCode.Refugee, // same ordinal as derivation source for type conversions
    
}
