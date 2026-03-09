// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of changes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCy9ENp-Ed-ak6NoX_4Aeg_1029236450")]
[Description(@"Specifies the type of changes.")]
[DerivedFrom(typeof(CorporateActionChangeTypeCode))]
public enum CorporateActionChangeType1Code
{
    /// <summary>
    /// Change from bearer into registered form.
    /// Encoded/decoded by serializers as &quot;BERE&quot;.
    /// </summary>
    [EnumMember(Value = "BERE")]
    [IsoId("_bCy9Edp-Ed-ak6NoX_4Aeg_1029236452")]
    [Description(@"Change from bearer into registered form.")]
    BearToRegistered = CorporateActionChangeTypeCode.BearToRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change of all instruments into certificates.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_bCy9Etp-Ed-ak6NoX_4Aeg_1029236481")]
    [Description(@"Change of all instruments into certificates.")]
    Certificates = CorporateActionChangeTypeCode.Certificates, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from dematerialised into physical form.
    /// Encoded/decoded by serializers as &quot;DEPH&quot;.
    /// </summary>
    [EnumMember(Value = "DEPH")]
    [IsoId("_bCy9E9p-Ed-ak6NoX_4Aeg_1029236482")]
    [Description(@"Change from dematerialised into physical form.")]
    DematerialisedToPhysical = CorporateActionChangeTypeCode.DematerialisedToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global permanent to physical form.
    /// Encoded/decoded by serializers as &quot;GPPH&quot;.
    /// </summary>
    [EnumMember(Value = "GPPH")]
    [IsoId("_bCy9FNp-Ed-ak6NoX_4Aeg_1029236483")]
    [Description(@"Change from global permanent to physical form.")]
    GlobalPermanentToPhysical = CorporateActionChangeTypeCode.GlobalPermanentToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global temporary to global permanent form.
    /// Encoded/decoded by serializers as &quot;GTGP&quot;.
    /// </summary>
    [EnumMember(Value = "GTGP")]
    [IsoId("_bCy9Fdp-Ed-ak6NoX_4Aeg_1029236504")]
    [Description(@"Change from global temporary to global permanent form.")]
    GlobalTemporaryToGlobalPermanent = CorporateActionChangeTypeCode.GlobalTemporaryToGlobalPermanent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from global temporary to physical form.
    /// Encoded/decoded by serializers as &quot;GTPH&quot;.
    /// </summary>
    [EnumMember(Value = "GTPH")]
    [IsoId("_bCy9Ftp-Ed-ak6NoX_4Aeg_1029236512")]
    [Description(@"Change from global temporary to physical form.")]
    GlobalTemporaryToPhysical = CorporateActionChangeTypeCode.GlobalTemporaryToPhysical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.
    /// Encoded/decoded by serializers as &quot;NAME&quot;.
    /// </summary>
    [EnumMember(Value = "NAME")]
    [IsoId("_bCy9F9p-Ed-ak6NoX_4Aeg_1029236752")]
    [Description(@"The issuing company changes its name. CA event shows the change from old name to new name and may involve surrendering physical shares with the old name to the registrar.")]
    Name = CorporateActionChangeTypeCode.Name, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from physical into dematerialised form.
    /// Encoded/decoded by serializers as &quot;PHDE&quot;.
    /// </summary>
    [EnumMember(Value = "PHDE")]
    [IsoId("_bC8uENp-Ed-ak6NoX_4Aeg_1029236760")]
    [Description(@"Change from physical into dematerialised form.")]
    PhysicalToDematerialised = CorporateActionChangeTypeCode.PhysicalToDematerialised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change from registered into bearer form.
    /// Encoded/decoded by serializers as &quot;REBE&quot;.
    /// </summary>
    [EnumMember(Value = "REBE")]
    [IsoId("_bC8uEdp-Ed-ak6NoX_4Aeg_1029236761")]
    [Description(@"Change from registered into bearer form.")]
    RegisteredToBearer = CorporateActionChangeTypeCode.RegisteredToBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Change in the terms of the security.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_bC8uEtp-Ed-ak6NoX_4Aeg_1029236783")]
    [Description(@"Change in the terms of the security.")]
    Terms = CorporateActionChangeTypeCode.Terms, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Process of changing the accounting method of a security, for example, mutual fund, from units to a quantity with decimals.
    /// Encoded/decoded by serializers as &quot;DECI&quot;.
    /// </summary>
    [EnumMember(Value = "DECI")]
    [IsoId("_bC8uE9p-Ed-ak6NoX_4Aeg_1029236791")]
    [Description(@"Process of changing the accounting method of a security, for example, mutual fund, from units to a quantity with decimals.")]
    Decimalisation = CorporateActionChangeTypeCode.Decimalisation, // same ordinal as derivation source for type conversions
    
}
