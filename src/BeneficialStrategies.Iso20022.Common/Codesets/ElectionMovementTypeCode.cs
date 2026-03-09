// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the effect on the holdings of electing a Corporate Action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag-CY9p-Ed-ak6NoX_4Aeg_855319504")]
[Description(@"Specifies the effect on the holdings of electing a Corporate Action option.")]
[Derivations(typeof(ElectionMovementType2Code),typeof(ElectionMovementType1Code))]
public enum ElectionMovementTypeCode
{
    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ag-CZNp-Ed-ak6NoX_4Aeg_872869307")]
    [Description(@"Election results in a change of balance type that transfers control of the securities rather than the securities themselves.")]
    Restricted,
    
    /// <summary>
    /// Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.
    /// Encoded/decoded by serializers as &quot;DRCT&quot;.
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_ag-CZdp-Ed-ak6NoX_4Aeg_872869308")]
    [Description(@"Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.")]
    Direct,
    
    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_ag-CZtp-Ed-ak6NoX_4Aeg_-1056877029")]
    [Description(@"Election results in a change of balance type that transfers control of the securities rather than the securities themselves.")]
    Sequestered,
    
}
