// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of standards insurance clauses. (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aY65oNp-Ed-ak6NoX_4Aeg_1001570968")]
[Description(@"List of standards insurance clauses. (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
[DerivedFrom(typeof(InsuranceClausesCode))]
public enum InsuranceClauses1Code
{
    /// <summary>
    /// Institute Cargo Clause A (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_aY65odp-Ed-ak6NoX_4Aeg_1349737815")]
    [Description(@"Institute Cargo Clause A (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseA = InsuranceClausesCode.InstituteCargoClauseA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Cargo Clause B (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCB&quot;.
    /// </summary>
    [EnumMember(Value = "ICCB")]
    [IsoId("_aY65otp-Ed-ak6NoX_4Aeg_1389450404")]
    [Description(@"Institute Cargo Clause B (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseB = InsuranceClausesCode.InstituteCargoClauseB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Cargo Clause C (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCC&quot;.
    /// </summary>
    [EnumMember(Value = "ICCC")]
    [IsoId("_aY65o9p-Ed-ak6NoX_4Aeg_1402380527")]
    [Description(@"Institute Cargo Clause C (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseC = InsuranceClausesCode.InstituteCargoClauseC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Cargo Clause for Air (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICAI&quot;.
    /// </summary>
    [EnumMember(Value = "ICAI")]
    [IsoId("_aY65pNp-Ed-ak6NoX_4Aeg_1459640342")]
    [Description(@"Institute Cargo Clause for Air (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseAir = InsuranceClausesCode.InstituteCargoClauseAir, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute War Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IWCC&quot;.
    /// </summary>
    [EnumMember(Value = "IWCC")]
    [IsoId("_aY65pdp-Ed-ak6NoX_4Aeg_1479957389")]
    [Description(@"Institute War Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteWarClauseCargo = InsuranceClausesCode.InstituteWarClauseCargo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Strikes Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ISCC&quot;.
    /// </summary>
    [EnumMember(Value = "ISCC")]
    [IsoId("_aY65ptp-Ed-ak6NoX_4Aeg_1533520042")]
    [Description(@"Institute Strikes Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteStrikesClauseCargo = InsuranceClausesCode.InstituteStrikesClauseCargo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Replacement Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_aY65p9p-Ed-ak6NoX_4Aeg_1566767278")]
    [Description(@"Institute Replacement Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteReplacementClause = InsuranceClausesCode.InstituteReplacementClause, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Classification Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICLC&quot;.
    /// </summary>
    [EnumMember(Value = "ICLC")]
    [IsoId("_aY65qNp-Ed-ak6NoX_4Aeg_1821658964")]
    [Description(@"Institute Classification Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteClassificationClause = InsuranceClausesCode.InstituteClassificationClause, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ISM Code Endorsement (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ISMC&quot;.
    /// </summary>
    [EnumMember(Value = "ISMC")]
    [IsoId("_aY65qdp-Ed-ak6NoX_4Aeg_1909391695")]
    [Description(@"ISM Code Endorsement (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    ISMCodeEndorsement = InsuranceClausesCode.ISMCodeEndorsement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Computer Millenium Clause Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;CMCC&quot;.
    /// </summary>
    [EnumMember(Value = "CMCC")]
    [IsoId("_aZEqoNp-Ed-ak6NoX_4Aeg_1938946317")]
    [Description(@"Computer Millenium Clause Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    ComputerMilleniumClauseCargo = InsuranceClausesCode.ComputerMilleniumClauseCargo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institute Radioactive Contamination Exclusion Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IRCE&quot;.
    /// </summary>
    [EnumMember(Value = "IRCE")]
    [IsoId("_aZEqodp-Ed-ak6NoX_4Aeg_1862295502")]
    [Description(@"Institute Radioactive Contamination Exclusion Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteRadioactiveContaminationExclusionClause = InsuranceClausesCode.InstituteRadioactiveContaminationExclusionClause, // same ordinal as derivation source for type conversions
    
}
