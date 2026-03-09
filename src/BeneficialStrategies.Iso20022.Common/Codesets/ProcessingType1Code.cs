// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of processing restrictions the central system must apply.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8JT2IaMgEeCJ6YNENx4h-w_-880711812")]
[Description(@"Specifies the type of processing restrictions the central system must apply.")]
[DerivedFrom(typeof(ProcessingTypeCode))]
public enum ProcessingType1Code
{
    /// <summary>
    /// Restriction is the rejection during the settlement instruction validation.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_8JT2IqMgEeCJ6YNENx4h-w_-393464774")]
    [Description(@"Restriction is the rejection during the settlement instruction validation.")]
    Rejection = ProcessingTypeCode.Rejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.
    /// Encoded/decoded by serializers as &quot;CVHD&quot;.
    /// </summary>
    [EnumMember(Value = "CVHD")]
    [IsoId("_8JdAAKMgEeCJ6YNENx4h-w_-1779488563")]
    [Description(@"Restriction is setting the CSD validation automatically to hold when accepting a settlement instruction.")]
    CSDValidationHold = ProcessingTypeCode.CSDValidationHold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.
    /// Encoded/decoded by serializers as &quot;RSVT&quot;.
    /// </summary>
    [EnumMember(Value = "RSVT")]
    [IsoId("_8JdAAaMgEeCJ6YNENx4h-w_-739454268")]
    [Description(@"Restriction is the creation of a reservation of a cash balance or a securities position for a specific purpose.")]
    Reservation = ProcessingTypeCode.Reservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.
    /// Encoded/decoded by serializers as &quot;BLCK&quot;.
    /// </summary>
    [EnumMember(Value = "BLCK")]
    [IsoId("_8JdAAqMgEeCJ6YNENx4h-w_-1357372058")]
    [Description(@"Restriction is the blocking of a party, securities account, security or cash account from settlement, blocking of securities position or cash balance for a specific purpose.")]
    Blocking = ProcessingTypeCode.Blocking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions.
    /// Encoded/decoded by serializers as &quot;EARM&quot;.
    /// </summary>
    [EnumMember(Value = "EARM")]
    [IsoId("_8JdAA6MgEeCJ6YNENx4h-w_927638380")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions.")]
    Earmarking = ProcessingTypeCode.Earmarking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.
    /// Encoded/decoded by serializers as &quot;EFAC&quot;.
    /// </summary>
    [EnumMember(Value = "EFAC")]
    [IsoId("_8JdABKMgEeCJ6YNENx4h-w_-1964191071")]
    [Description(@"Restriction of linked to the balance type that defines and manages position types for securities positions for auto-collateralisation.")]
    EarmarkingForAutoCollateralisation = ProcessingTypeCode.EarmarkingForAutoCollateralisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No restriction has been defined.
    /// Encoded/decoded by serializers as &quot;DLVR&quot;.
    /// </summary>
    [EnumMember(Value = "DLVR")]
    [IsoId("_8JdABaMgEeCJ6YNENx4h-w_1538040308")]
    [Description(@"No restriction has been defined.")]
    Deliverable = ProcessingTypeCode.Deliverable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction is linked to a sub-pledged collateral transaction.
    /// Encoded/decoded by serializers as &quot;COLD&quot;.
    /// </summary>
    [EnumMember(Value = "COLD")]
    [IsoId("_8JdABqMgEeCJ6YNENx4h-w_-779072156")]
    [Description(@"Restriction is linked to a sub-pledged collateral transaction.")]
    Collateralised = ProcessingTypeCode.Collateralised, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Restriction does not support any partial execution.
    /// Encoded/decoded by serializers as &quot;CSDB&quot;.
    /// </summary>
    [EnumMember(Value = "CSDB")]
    [IsoId("_8JdAB6MgEeCJ6YNENx4h-w_1505938282")]
    [Description(@"Restriction does not support any partial execution.")]
    CoSDBlocking = ProcessingTypeCode.CoSDBlocking, // same ordinal as derivation source for type conversions
    
}
