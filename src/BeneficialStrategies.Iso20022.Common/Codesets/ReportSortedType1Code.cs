// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of criterion used to sort a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VeXEKNp-Ed-ak6NoX_4Aeg_-2144991913")]
[Description(@"Specifies the type of criterion used to sort a report.")]
[DerivedFrom(typeof(ReportSortedTypeCode))]
public enum ReportSortedType1Code
{
    /// <summary>
    /// Type of criterion is a nation.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_VeXEKdp-Ed-ak6NoX_4Aeg_-2144991903")]
    [Description(@"Type of criterion is a nation.")]
    Country = ReportSortedTypeCode.Country, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of criterion is an entity, eg, a financial institution.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_Veg1INp-Ed-ak6NoX_4Aeg_-2144991902")]
    [Description(@"Type of criterion is an entity, eg, a financial institution.")]
    Party = ReportSortedTypeCode.Party, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of criterion is a currency, eg, the euro.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_Veg1Idp-Ed-ak6NoX_4Aeg_-2144991901")]
    [Description(@"Type of criterion is a currency, eg, the euro.")]
    Currency = ReportSortedTypeCode.Currency, // same ordinal as derivation source for type conversions
    
}
