// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of criterion is a country.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VqbxRNp-Ed-ak6NoX_4Aeg_-2144991898")]
[Description(@"Type of criterion is a country.")]
[Derivations(typeof(ReportSortedType1Code))]
public enum ReportSortedTypeCode
{
    /// <summary>
    /// Type of criterion is a nation.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_VqbxRdp-Ed-ak6NoX_4Aeg_-2144991897")]
    [Description(@"Type of criterion is a nation.")]
    Country,
    
    /// <summary>
    /// Type of criterion is an entity, eg, a financial institution.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_VqbxRtp-Ed-ak6NoX_4Aeg_-2144991896")]
    [Description(@"Type of criterion is an entity, eg, a financial institution.")]
    Party,
    
    /// <summary>
    /// Type of criterion is a currency, eg, the euro.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_VqbxR9p-Ed-ak6NoX_4Aeg_-2144991895")]
    [Description(@"Type of criterion is a currency, eg, the euro.")]
    Currency,
    
}
