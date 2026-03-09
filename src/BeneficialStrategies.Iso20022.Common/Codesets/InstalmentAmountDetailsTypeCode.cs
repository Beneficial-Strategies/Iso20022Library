// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the details of the grace period applicable to the instalment
/// </summary>
[DataContract]
[Serializable]
[IsoId("_J00oB9uYEei2qvU6FBLZYA")]
[Description(@"Contains the details of the grace period applicable to the instalment")]
[Derivations(typeof(InstalmentAmountDetailsType1Code),typeof(InstalmentAmountDetailsType2Code))]
public enum InstalmentAmountDetailsTypeCode
{
    /// <summary>
    /// Insurance amount
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("_J01PFNuYEei2qvU6FBLZYA")]
    [Description(@"Insurance amount")]
    Insurance,
    
    /// <summary>
    /// Requested amount
    /// Encoded/decoded by serializers as &quot;RQST&quot;.
    /// </summary>
    [EnumMember(Value = "RQST")]
    [IsoId("_J01PFduYEei2qvU6FBLZYA")]
    [Description(@"Requested amount")]
    Requested,
    
    /// <summary>
    /// Instalment amount tax
    /// Encoded/decoded by serializers as &quot;TAXX&quot;.
    /// </summary>
    [EnumMember(Value = "TAXX")]
    [IsoId("_J01PENuYEei2qvU6FBLZYA")]
    [Description(@"Instalment amount tax")]
    Tax,
    
    /// <summary>
    /// Expense Amount
    /// Encoded/decoded by serializers as &quot;EXPN&quot;.
    /// </summary>
    [EnumMember(Value = "EXPN")]
    [IsoId("_J01PEtuYEei2qvU6FBLZYA")]
    [Description(@"Expense Amount")]
    Expense,
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_J01PE9uYEei2qvU6FBLZYA")]
    [Description(@"Grace period unit type")]
    OtherNational,
    
    /// <summary>
    /// Grace period unit type
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_J01PEduYEei2qvU6FBLZYA")]
    [Description(@"Grace period unit type")]
    OtherPrivate,
    
    /// <summary>
    /// Other amounts
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_qeGAQNuYEei2qvU6FBLZYA")]
    [Description(@"Other amounts")]
    OtherCharges,
    
    /// <summary>
    /// Funded amount
    /// Encoded/decoded by serializers as &quot;FUNA&quot;.
    /// </summary>
    [EnumMember(Value = "FUNA")]
    [IsoId("_u_P3QNuYEei2qvU6FBLZYA")]
    [Description(@"Funded amount")]
    Funded,
    
    /// <summary>
    /// Fees amount
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_LHhCINucEei2qvU6FBLZYA")]
    [Description(@"Fees amount")]
    Fees,
    
    /// <summary>
    /// Total financing cost per annum.
    /// Encoded/decoded by serializers as &quot;AFCO&quot;.
    /// </summary>
    [EnumMember(Value = "AFCO")]
    [IsoId("_8MWRMOkXEemeDPHh-U9b6w")]
    [Description(@"Total financing cost per annum.")]
    AnnualFinancingCost,
    
    /// <summary>
    /// Interest amount.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_sMJBsJJNEeuuktRxxQZoNQ")]
    [Description(@"Interest amount.")]
    Interest,
    
    /// <summary>
    /// Principal amount.
    /// Encoded/decoded by serializers as &quot;PRNC&quot;.
    /// </summary>
    [EnumMember(Value = "PRNC")]
    [IsoId("_0qtJcJJNEeuuktRxxQZoNQ")]
    [Description(@"Principal amount.")]
    Principal,
    
}
