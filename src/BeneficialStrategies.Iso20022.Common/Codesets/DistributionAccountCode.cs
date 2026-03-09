// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of account where the disbursed CUSIP will be allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oiLwDL3EeKU9IrkkToqcw_-1432180896")]
[Description(@"Specifies the type of account where the disbursed CUSIP will be allocated.")]
[Derivations(typeof(DistributionAccount1Code))]
public enum DistributionAccountCode
{
    /// <summary>
    /// General free account. DTC (The Depository Trust Company) allows immediate use of securities.
    /// Encoded/decoded by serializers as &quot;GENF&quot;.
    /// </summary>
    [EnumMember(Value = "GENF")]
    [IsoId("_1oiLwTL3EeKU9IrkkToqcw_1225892924")]
    [Description(@"General free account. DTC (The Depository Trust Company) allows immediate use of securities.")]
    GeneralFree,
    
    /// <summary>
    /// RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities.
    /// Encoded/decoded by serializers as &quot;RRGA&quot;.
    /// </summary>
    [EnumMember(Value = "RRGA")]
    [IsoId("_1oiLwjL3EeKU9IrkkToqcw_1657827283")]
    [Description(@"RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities.")]
    RRGAccount,
    
}
