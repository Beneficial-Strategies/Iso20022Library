// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal standing of the organisation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aeIw0Np-Ed-ak6NoX_4Aeg_-705480493")]
[Description(@"Specifies the legal standing of the organisation.")]
[Derivations(typeof(LegalStructure1Code))]
public enum LegalStructureCode
{
    /// <summary>
    /// Legal structure is a corporation.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_aeIw0dp-Ed-ak6NoX_4Aeg_-657457370")]
    [Description(@"Legal structure is a corporation.")]
    Corporation,

    /// <summary>
    /// Legal structure is an individual.
    /// Encoded/decoded by serializers as &quot;INDV&quot;.
    /// </summary>
    [EnumMember(Value = "INDV")]
    [IsoId("_aeIw0tp-Ed-ak6NoX_4Aeg_-649146167")]
    [Description(@"Legal structure is an individual.")]
    Individual,

    /// <summary>
    /// Legal structure is a supranational.
    /// Encoded/decoded by serializers as &quot;SNAT&quot;.
    /// </summary>
    [EnumMember(Value = "SNAT")]
    [IsoId("_aeIw09p-Ed-ak6NoX_4Aeg_-648223047")]
    [Description(@"Legal structure is a supranational.")]
    Supranational,

    /// <summary>
    /// Legal structure is a sovereign.
    /// Encoded/decoded by serializers as &quot;SOVR&quot;.
    /// </summary>
    [EnumMember(Value = "SOVR")]
    [IsoId("_aeIw1Np-Ed-ak6NoX_4Aeg_-647299649")]
    [Description(@"Legal structure is a sovereign.")]
    Sovereign,

    /// <summary>
    /// Legal structure is a municipal.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_aeIw1dp-Ed-ak6NoX_4Aeg_-646375666")]
    [Description(@"Legal structure is a municipal.")]
    Municipal,

    /// <summary>
    /// Legal structure is a province.
    /// Encoded/decoded by serializers as &quot;PVIN&quot;.
    /// </summary>
    [EnumMember(Value = "PVIN")]
    [IsoId("_aeIw1tp-Ed-ak6NoX_4Aeg_-645452423")]
    [Description(@"Legal structure is a province.")]
    Province,

    /// <summary>
    /// Legal structure is a state.
    /// Encoded/decoded by serializers as &quot;STAE&quot;.
    /// </summary>
    [EnumMember(Value = "STAE")]
    [IsoId("_aeIw19p-Ed-ak6NoX_4Aeg_-644528871")]
    [Description(@"Legal structure is a state.")]
    State,

    /// <summary>
    /// Legal structure is a county.
    /// Encoded/decoded by serializers as &quot;CNTY&quot;.
    /// </summary>
    [EnumMember(Value = "CNTY")]
    [IsoId("_aeIw2Np-Ed-ak6NoX_4Aeg_-643605534")]
    [Description(@"Legal structure is a county.")]
    County,

    /// <summary>
    /// Legal structure is a partnership.
    /// Encoded/decoded by serializers as &quot;PNTR&quot;.
    /// </summary>
    [EnumMember(Value = "PNTR")]
    [IsoId("_aeIw2dp-Ed-ak6NoX_4Aeg_-642682066")]
    [Description(@"Legal structure is a partnership.")]
    Partnership,

    /// <summary>
    /// Legal structure is a financial institution.
    /// Encoded/decoded by serializers as &quot;FINI&quot;.
    /// </summary>
    [EnumMember(Value = "FINI")]
    [IsoId("_aeSh0Np-Ed-ak6NoX_4Aeg_-640835487")]
    [Description(@"Legal structure is a financial institution.")]
    FinancialInstitution,

    /// <summary>
    /// Legal structure is a state.
    /// Encoded/decoded by serializers as &quot;NATI&quot;.
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_7HsY8Xx8EemHsOqJOzMVfg")]
    [Description(@"Legal structure is a state.")]
    National,
}
