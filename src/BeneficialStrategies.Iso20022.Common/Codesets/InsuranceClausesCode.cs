// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of standards insurance clauses. (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZEqotp-Ed-ak6NoX_4Aeg_976637789")]
[Description(@"List of standards insurance clauses. (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
[Derivations(typeof(InsuranceClauses1Code))]
public enum InsuranceClausesCode
{
    /// <summary>
    /// Institute Cargo Clause A (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_aZEqo9p-Ed-ak6NoX_4Aeg_-2041099809")]
    [Description(@"Institute Cargo Clause A (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseA,
    
    /// <summary>
    /// Institute Cargo Clause B (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCB&quot;.
    /// </summary>
    [EnumMember(Value = "ICCB")]
    [IsoId("_aZEqpNp-Ed-ak6NoX_4Aeg_-2041099808")]
    [Description(@"Institute Cargo Clause B (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseB,
    
    /// <summary>
    /// Institute Cargo Clause C (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICCC&quot;.
    /// </summary>
    [EnumMember(Value = "ICCC")]
    [IsoId("_aZEqpdp-Ed-ak6NoX_4Aeg_-2041099807")]
    [Description(@"Institute Cargo Clause C (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseC,
    
    /// <summary>
    /// Institute Cargo Clause for Air (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICAI&quot;.
    /// </summary>
    [EnumMember(Value = "ICAI")]
    [IsoId("_aZEqptp-Ed-ak6NoX_4Aeg_-2041099543")]
    [Description(@"Institute Cargo Clause for Air (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteCargoClauseAir,
    
    /// <summary>
    /// Institute War Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IWCC&quot;.
    /// </summary>
    [EnumMember(Value = "IWCC")]
    [IsoId("_aZEqp9p-Ed-ak6NoX_4Aeg_-2041099542")]
    [Description(@"Institute War Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteWarClauseCargo,
    
    /// <summary>
    /// Institute Strikes Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ISCC&quot;.
    /// </summary>
    [EnumMember(Value = "ISCC")]
    [IsoId("_aZEqqNp-Ed-ak6NoX_4Aeg_-2041099526")]
    [Description(@"Institute Strikes Clause for Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteStrikesClauseCargo,
    
    /// <summary>
    /// Institute Replacement Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IREC&quot;.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_aZOboNp-Ed-ak6NoX_4Aeg_-2041099517")]
    [Description(@"Institute Replacement Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteReplacementClause,
    
    /// <summary>
    /// Institute Classification Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ICLC&quot;.
    /// </summary>
    [EnumMember(Value = "ICLC")]
    [IsoId("_aZObodp-Ed-ak6NoX_4Aeg_-2041099508")]
    [Description(@"Institute Classification Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteClassificationClause,
    
    /// <summary>
    /// ISM Code Endorsement (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;ISMC&quot;.
    /// </summary>
    [EnumMember(Value = "ISMC")]
    [IsoId("_aZObotp-Ed-ak6NoX_4Aeg_-2041099500")]
    [Description(@"ISM Code Endorsement (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    ISMCodeEndorsement,
    
    /// <summary>
    /// Computer Millenium Clause Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;CMCC&quot;.
    /// </summary>
    [EnumMember(Value = "CMCC")]
    [IsoId("_aZObo9p-Ed-ak6NoX_4Aeg_-2041099483")]
    [Description(@"Computer Millenium Clause Cargo (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    ComputerMilleniumClauseCargo,
    
    /// <summary>
    /// Institute Radioactive Contamination Exclusion Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).
    /// Encoded/decoded by serializers as &quot;IRCE&quot;.
    /// </summary>
    [EnumMember(Value = "IRCE")]
    [IsoId("_aZObpNp-Ed-ak6NoX_4Aeg_-2041099482")]
    [Description(@"Institute Radioactive Contamination Exclusion Clause (standard policy wordings issued by the Institute of London Underwriters or the American Institute of Marine Underwriters).")]
    InstituteRadioactiveContaminationExclusionClause,
    
}
