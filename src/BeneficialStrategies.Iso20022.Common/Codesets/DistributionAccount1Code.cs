// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code specifying the type of account where the disbursed CUSIP will be allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tcg8TL3EeKU9IrkkToqcw_-1446554882")]
[Description(@"Code specifying the type of account where the disbursed CUSIP will be allocated.")]
[DerivedFrom(typeof(DistributionAccountCode))]
public enum DistributionAccount1Code
{
    /// <summary>
    /// General free account. DTC (The Depository Trust Company) allows immediate use of securities.
    /// Encoded/decoded by serializers as &quot;GENF&quot;.
    /// </summary>
    [EnumMember(Value = "GENF")]
    [IsoId("_1tcg8jL3EeKU9IrkkToqcw_1027673005")]
    [Description(
        @"General free account. DTC (The Depository Trust Company) allows immediate use of securities."
    )]
    GeneralFree = DistributionAccountCode.GeneralFree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities.
    /// Encoded/decoded by serializers as &quot;RRGA&quot;.
    /// </summary>
    [EnumMember(Value = "RRGA")]
    [IsoId("_1tcg8zL3EeKU9IrkkToqcw_1352790512")]
    [Description(
        @"RRG account. Sub account. DTC (The Depository Trust Company) does not allow immediate use of securities."
    )]
    RRGAccount = DistributionAccountCode.RRGAccount, // same ordinal as derivation source for type conversions
}
