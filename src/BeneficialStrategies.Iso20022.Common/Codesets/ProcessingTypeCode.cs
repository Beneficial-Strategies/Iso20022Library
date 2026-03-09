// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of processing restrictions the central system must apply.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8JmxAKMgEeCJ6YNENx4h-w_1084364172")]
[Description(@"Specifies the type of processing restrictions the central system must apply.")]
[Derivations(typeof(ProcessingType1Code))]
public enum ProcessingTypeCode
{
    /// <summary>
    /// Restriction is the rejection during the settlement instruction validation.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_8JmxAaMgEeCJ6YNENx4h-w_-1077443998")]
    [Description(@"Restriction is the rejection during the settlement instruction validation.")]
    Rejection,
    
    /// <summary>
    /// Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.
    /// Encoded/decoded by serializers as &quot;CVHD&quot;.
    /// </summary>
    [EnumMember(Value = "CVHD")]
    [IsoId("_8JmxAqMgEeCJ6YNENx4h-w_-1557912151")]
    [Description(@"Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.")]
    CSDValidationHold,
    
    /// <summary>
    /// Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.
    /// Encoded/decoded by serializers as &quot;RSVT&quot;.
    /// </summary>
    [EnumMember(Value = "RSVT")]
    [IsoId("_8JmxA6MgEeCJ6YNENx4h-w_-38467749")]
    [Description(@"Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.")]
    Reservation,
    
    /// <summary>
    /// Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_8JmxBKMgEeCJ6YNENx4h-w_-271474649")]
    [Description(@"Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.")]
    Blocking,
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions.
    /// Encoded/decoded by serializers as &quot;EARM&quot;.
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_8JmxBaMgEeCJ6YNENx4h-w_1785763740")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions.")]
    Earmarking,
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.
    /// Encoded/decoded by serializers as &quot;EFAC&quot;.
    /// </summary>
    [EnumMember(Value = "EFAC")]
    [IsoId("_8JmxBqMgEeCJ6YNENx4h-w_-1927677915")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.")]
    EarmarkingForAutoCollateralisation,
    
    /// <summary>
    /// No restriction has been defined.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_8JmxB6MgEeCJ6YNENx4h-w_332029776")]
    [Description(@"No restriction has been defined.")]
    Deliverable,
    
    /// <summary>
    /// Restriction is linked to a sub-pledged collateral transaction.
    /// Encoded/decoded by serializers as &quot;COLD&quot;.
    /// </summary>
    [EnumMember(Value = "COLD")]
    [IsoId("_8JmxCKMgEeCJ6YNENx4h-w_-1706446193")]
    [Description(@"Restriction is linked to a sub-pledged collateral transaction.")]
    Collateralised,
    
    /// <summary>
    /// Restriction does not support any partial execution.
    /// Encoded/decoded by serializers as &quot;CSDB&quot;.
    /// </summary>
    [EnumMember(Value = "CSDB")]
    [IsoId("_8Jv68KMgEeCJ6YNENx4h-w_-177097319")]
    [Description(@"Restriction does not support any partial execution.")]
    CoSDBlocking,
    
}
