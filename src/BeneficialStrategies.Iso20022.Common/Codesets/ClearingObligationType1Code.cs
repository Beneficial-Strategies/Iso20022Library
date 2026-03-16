// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation under Regulation (EU) No 648/2012, as of the time of execution of the contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sCzjYA29EeWmAKKPnqYEVQ")]
[Description(
    @"Specifies whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation under Regulation (EU) No 648/2012, as of the time of execution of the contract."
)]
[DerivedFrom(typeof(ClearingObligationTypeCode))]
public enum ClearingObligationType1Code
{
    /// <summary>
    /// Reported contract does not belong to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as &quot;FLSE&quot;.
    /// </summary>
    [EnumMember(Value = "FLSE")]
    [IsoId("_wq36sQ29EeWmAKKPnqYEVQ")]
    [Description(
        @"Reported contract does not belong to a class of OTC derivatives that has been declared subject to the clearing obligation."
    )]
    No = ClearingObligationTypeCode.No, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unknown whether reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_wwOUwQ29EeWmAKKPnqYEVQ")]
    [Description(
        @"Unknown whether reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation."
    )]
    Unknown = ClearingObligationTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as &quot;TRUE&quot;.
    /// </summary>
    [EnumMember(Value = "TRUE")]
    [IsoId("_w0r-AQ29EeWmAKKPnqYEVQ")]
    [Description(
        @"Reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation."
    )]
    Yes = ClearingObligationTypeCode.Yes, // same ordinal as derivation source for type conversions
}
