// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the grouping options of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_au04M9p-Ed-ak6NoX_4Aeg_-1706891243")]
[Description(@"Specifies the grouping options of the payment transaction.")]
[Derivations(typeof(Grouping1Code))]
public enum GroupingCode
{
    /// <summary>
    /// Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present.
    /// Encoded/decoded by serializers as &quot;SNGL&quot;.
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_au04NNp-Ed-ak6NoX_4Aeg_-1661638294")]
    [Description(@"Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present.")]
    Single,
    
    /// <summary>
    /// Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as &quot;GRPD&quot;.
    /// </summary>
    [EnumMember(Value = "GRPD")]
    [IsoId("_au04Ndp-Ed-ak6NoX_4Aeg_-1575752625")]
    [Description(@"Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block.")]
    Grouped,
    
    /// <summary>
    /// Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_au04Ntp-Ed-ak6NoX_4Aeg_-1530498717")]
    [Description(@"Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block.")]
    Mixed,
    
}
